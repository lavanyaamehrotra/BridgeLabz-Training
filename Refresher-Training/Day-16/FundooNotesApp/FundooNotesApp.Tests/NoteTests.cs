using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Services;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Services;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class NoteTests
    {
        private FundooContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<FundooContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new FundooContext(options);
        }

        private NoteBL GetNoteBL(FundooContext context)
        {
            var noteRL = new NoteRL(context);
            return new NoteBL(noteRL);
        }

        // ---------- Create ----------

        [TestMethod]
        public void CreateNote_ShouldSucceed_AndSaveCorrectly()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());

            var result = noteBL.CreateNote(new CreateNoteDTO { Title = "Test Note", Description = "Test Desc" }, userId: 1);

            Assert.AreEqual("Test Note", result.Title);
            Assert.IsTrue(result.NoteId > 0);
        }

        // ---------- Get ----------

        [TestMethod]
        public void GetAllNotes_ShouldReturnOnlyThatUsersNotes()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());

            noteBL.CreateNote(new CreateNoteDTO { Title = "User1 Note" }, userId: 1);
            noteBL.CreateNote(new CreateNoteDTO { Title = "User2 Note" }, userId: 2);

            var user1Notes = noteBL.GetAllNotes(userId: 1);

            Assert.AreEqual(1, user1Notes.Count);
            Assert.AreEqual("User1 Note", user1Notes[0].Title);
        }

        [TestMethod]
        public void GetNoteById_ShouldThrowException_WhenNoteBelongsToDifferentUser()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Private Note" }, userId: 1);

            try
            {
                noteBL.GetNoteById(created.NoteId, userId: 2);
                Assert.Fail("Expected NoteNotFoundException was not thrown");
            }
            catch (NoteNotFoundException) { }
        }

        // ---------- Delete ----------

        [TestMethod]
        public void DeleteNote_ShouldThrowException_WhenNoteIsNotInTrash()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Active Note" }, userId: 1);

            try
            {
                noteBL.DeleteNote(created.NoteId, userId: 1);
                Assert.Fail("Expected NoteNotFoundException was not thrown");
            }
            catch (NoteNotFoundException) { }
        }

        [TestMethod]
        public void DeleteNote_ShouldSucceed_WhenNoteIsInTrash()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "To Be Trashed" }, userId: 1);
            noteBL.TrashNote(created.NoteId, userId: 1);

            noteBL.DeleteNote(created.NoteId, userId: 1);

            try
            {
                noteBL.GetNoteById(created.NoteId, userId: 1);
                Assert.Fail("Note should no longer exist after delete");
            }
            catch (NoteNotFoundException) { }
        }

        // ---------- Pin / Archive / Trash rules ----------

        [TestMethod]
        public void TogglePin_ShouldAutoUnarchive_WhenNoteIsCurrentlyArchived()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Archived Note" }, userId: 1);
            noteBL.ToggleArchive(created.NoteId, userId: 1);

            var pinned = noteBL.TogglePin(created.NoteId, userId: 1);

            Assert.IsTrue(pinned.Pin);
            Assert.IsFalse(pinned.Archive);
        }

        [TestMethod]
        public void ToggleArchive_ShouldAutoUnpin_WhenNoteIsCurrentlyPinned()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Pinned Note" }, userId: 1);
            noteBL.TogglePin(created.NoteId, userId: 1);

            var archived = noteBL.ToggleArchive(created.NoteId, userId: 1);

            Assert.IsTrue(archived.Archive);
            Assert.IsFalse(archived.Pin);
        }

        [TestMethod]
        public void TrashNote_ShouldClearBothPinAndArchive()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Pinned Note" }, userId: 1);
            noteBL.TogglePin(created.NoteId, userId: 1);

            var trashed = noteBL.TrashNote(created.NoteId, userId: 1);

            Assert.IsTrue(trashed.Trash);
            Assert.IsFalse(trashed.Pin);
            Assert.IsFalse(trashed.Archive);
        }

        [TestMethod]
        public void RestoreNote_ShouldSetTrashToFalse()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            var created = noteBL.CreateNote(new CreateNoteDTO { Title = "Note" }, userId: 1);
            noteBL.TrashNote(created.NoteId, userId: 1);

            var restored = noteBL.RestoreNote(created.NoteId, userId: 1);

            Assert.IsFalse(restored.Trash);
        }

        // ---------- Search / Filter ----------

        [TestMethod]
        public void SearchNotes_ShouldReturnOnlyMatchingTitles()
        {
            var noteBL = GetNoteBL(GetInMemoryContext());
            noteBL.CreateNote(new CreateNoteDTO { Title = "Grocery List" }, userId: 1);
            noteBL.CreateNote(new CreateNoteDTO { Title = "Work Notes" }, userId: 1);

            var results = noteBL.SearchNotes(userId: 1, keyword: "Grocery");

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Grocery List", results[0].Title);
        }
    }
}
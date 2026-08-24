using Microsoft.EntityFrameworkCore;
using FundooNotesApp.BusinessLayer.Services;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Services;

namespace FundooNotesApp.Tests
{
    [TestClass]
    public class LabelTests
    {
        private FundooContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<FundooContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new FundooContext(options);
        }

        [TestMethod]
        public void CreateLabel_ShouldSucceed_AndLinkToCorrectNote()
        {
            var context = GetInMemoryContext();
            var noteBL = new NoteBL(new NoteRL(context));
            var labelBL = new LabelBL(new LabelRL(context));

            var note = noteBL.CreateNote(new CreateNoteDTO { Title = "Note for Label" }, userId: 1);
            var label = labelBL.CreateLabel(new CreateLabelDTO { LabelName = "Work", NoteId = note.NoteId }, userId: 1);

            Assert.AreEqual("Work", label.LabelName);
            Assert.AreEqual(note.NoteId, label.NoteId);
        }

        [TestMethod]
        public void GetAllLabels_ShouldReturnOnlyThatUsersLabels()
        {
            var context = GetInMemoryContext();
            var noteBL = new NoteBL(new NoteRL(context));
            var labelBL = new LabelBL(new LabelRL(context));

            var note1 = noteBL.CreateNote(new CreateNoteDTO { Title = "Note A" }, userId: 1);
            var note2 = noteBL.CreateNote(new CreateNoteDTO { Title = "Note B" }, userId: 2);
            labelBL.CreateLabel(new CreateLabelDTO { LabelName = "User1 Label", NoteId = note1.NoteId }, userId: 1);
            labelBL.CreateLabel(new CreateLabelDTO { LabelName = "User2 Label", NoteId = note2.NoteId }, userId: 2);

            var user1Labels = labelBL.GetAllLabels(userId: 1);

            Assert.AreEqual(1, user1Labels.Count);
            Assert.AreEqual("User1 Label", user1Labels[0].LabelName);
        }

        [TestMethod]
        public void EditLabel_ShouldUpdateLabelName()
        {
            var context = GetInMemoryContext();
            var noteBL = new NoteBL(new NoteRL(context));
            var labelBL = new LabelBL(new LabelRL(context));

            var note = noteBL.CreateNote(new CreateNoteDTO { Title = "Note" }, userId: 1);
            var label = labelBL.CreateLabel(new CreateLabelDTO { LabelName = "Old Name", NoteId = note.NoteId }, userId: 1);

            var updated = labelBL.EditLabel(label.LabelId, userId: 1, new EditLabelDTO { LabelName = "New Name" });

            Assert.AreEqual("New Name", updated.LabelName);
        }

        [TestMethod]
        public void DeleteLabel_ShouldSucceed_WhenLabelBelongsToUser()
        {
            var context = GetInMemoryContext();
            var noteBL = new NoteBL(new NoteRL(context));
            var labelBL = new LabelBL(new LabelRL(context));

            var note = noteBL.CreateNote(new CreateNoteDTO { Title = "Note" }, userId: 1);
            var label = labelBL.CreateLabel(new CreateLabelDTO { LabelName = "ToDelete", NoteId = note.NoteId }, userId: 1);

            labelBL.DeleteLabel(label.LabelId, userId: 1);

            try
            {
                labelBL.GetLabelById(label.LabelId, userId: 1);
                Assert.Fail("Label should no longer exist after delete");
            }
            catch (LabelNotFoundException) { }
        }

        [TestMethod]
        public void DeleteLabel_ShouldThrowException_WhenLabelDoesNotBelongToUser()
        {
            var context = GetInMemoryContext();
            var noteBL = new NoteBL(new NoteRL(context));
            var labelBL = new LabelBL(new LabelRL(context));

            var note = noteBL.CreateNote(new CreateNoteDTO { Title = "Note" }, userId: 1);
            var label = labelBL.CreateLabel(new CreateLabelDTO { LabelName = "Personal", NoteId = note.NoteId }, userId: 1);

            try
            {
                labelBL.DeleteLabel(label.LabelId, userId: 2);
                Assert.Fail("Expected LabelNotFoundException was not thrown");
            }
            catch (LabelNotFoundException) { }
        }
    }
}
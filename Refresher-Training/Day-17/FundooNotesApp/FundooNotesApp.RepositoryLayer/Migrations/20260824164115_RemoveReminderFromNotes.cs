using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundooNotesApp.RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReminderFromNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reminder",
                table: "Notes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Reminder",
                table: "Notes",
                type: "datetime2",
                nullable: true);
        }
    }
}

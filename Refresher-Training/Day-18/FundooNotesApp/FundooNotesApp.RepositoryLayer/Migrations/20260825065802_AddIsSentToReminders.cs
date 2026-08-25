using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundooNotesApp.RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSentToReminders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSent",
                table: "Reminders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSent",
                table: "Reminders");
        }
    }
}

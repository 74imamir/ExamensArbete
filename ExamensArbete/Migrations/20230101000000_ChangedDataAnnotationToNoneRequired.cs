using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamensArbete.Migrations
{
    public partial class ChangedDataAnnotationToNoneRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Authors",
                maxLength: 80,
                nullable: true,
                oldMaxLength: 80,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Authors",
                maxLength: 100,
                nullable: true,
                oldMaxLength: 100,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Authors",
                maxLength: 20,
                nullable: true,
                oldMaxLength: 20,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Authors",
                maxLength: 300,
                nullable: true,
                oldMaxLength: 300,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Authors",
                maxLength: 800,
                nullable: true,
                oldMaxLength: 800,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Twitter",
                table: "Authors",
                maxLength: 250,
                nullable: true,
                oldMaxLength: 250,
                oldNullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // If needed, provide code to revert the changes in the Down method
        }
    }
}

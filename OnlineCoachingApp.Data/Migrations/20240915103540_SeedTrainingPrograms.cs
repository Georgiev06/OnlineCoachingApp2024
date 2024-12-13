using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class SeedTrainingPrograms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TrainingPrograms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 10, 35, 39, 891, DateTimeKind.Utc).AddTicks(2153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 15, 10, 16, 37, 204, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("2469c9d3-0591-4267-864f-262189e24b09"), 2, "Training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("5cb44179-4766-4516-aa03-59cece552317"), 2, "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("81416a84-d909-4860-961e-de1cddc125fd"), 2, "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("2469c9d3-0591-4267-864f-262189e24b09"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("5cb44179-4766-4516-aa03-59cece552317"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("81416a84-d909-4860-961e-de1cddc125fd"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TrainingPrograms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 15, 10, 16, 37, 204, DateTimeKind.Utc).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 15, 10, 35, 39, 891, DateTimeKind.Utc).AddTicks(2153));
        }
    }
}

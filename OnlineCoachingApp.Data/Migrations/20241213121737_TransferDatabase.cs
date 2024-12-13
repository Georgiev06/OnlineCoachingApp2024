using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class TransferDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("410b9111-7b0a-42f0-afd7-34e3c45f3d40"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("4ceaf901-b4c9-4ee5-aa75-d3bc40e97ba1"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("c76ecebe-c09c-40e0-9567-9b7aa04dbe02"));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("0d5e02eb-c092-4dd1-9b73-28f10fe1dfd1"), 2, "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("2a722e65-b7c4-412e-a66e-4454894d71c0"), 2, "Training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("4d35946d-267f-44c7-afda-82a62159e795"), 2, "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("0d5e02eb-c092-4dd1-9b73-28f10fe1dfd1"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("2a722e65-b7c4-412e-a66e-4454894d71c0"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("4d35946d-267f-44c7-afda-82a62159e795"));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { new Guid("410b9111-7b0a-42f0-afd7-34e3c45f3d40"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", false, "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { new Guid("4ceaf901-b4c9-4ee5-aa75-d3bc40e97ba1"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", false, "Fitness Program", 39.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { new Guid("c76ecebe-c09c-40e0-9567-9b7aa04dbe02"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", false, "Fitness Program", 49.99m, null });
        }
    }
}

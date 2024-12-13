using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class AddedIsActiveColumnForSoftDeleting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("26020087-d92e-4fd8-a8f8-59344f8dc3ee"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("7c65f650-3bd8-43da-b3db-e39214586e67"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("94d518c3-1a9f-4184-8f60-db778bd861d7"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TrainingPrograms",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("410b9111-7b0a-42f0-afd7-34e3c45f3d40"), 2, "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("4ceaf901-b4c9-4ee5-aa75-d3bc40e97ba1"), 2, "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("c76ecebe-c09c-40e0-9567-9b7aa04dbe02"), 2, "Training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TrainingPrograms");

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("26020087-d92e-4fd8-a8f8-59344f8dc3ee"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("7c65f650-3bd8-43da-b3db-e39214586e67"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("94d518c3-1a9f-4184-8f60-db778bd861d7"), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelableProject.Server.Migrations
{
    public partial class newdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Durations_DurationId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Payments_PaymentId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Rooms_RoomId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_DurationId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_PaymentId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_RoomId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "DateIn",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DateOut",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "489e4d75-e0dc-4ac8-ab15-72834102fc89",
                column: "ConcurrencyStamp",
                value: "71139350-96e3-4530-b218-198986c31add");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd4389e0-5019-466c-930e-8f60f453bc91",
                column: "ConcurrencyStamp",
                value: "b3854ffa-2b9c-4bd6-ae60-4bd682699b7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18a0ae93-da75-43fd-ba01-7b4f95456194",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822c4b19-e248-4924-ae87-ee66b2a047fa", "AQAAAAEAACcQAAAAEJjFDZ8J+I9c21aXoV7typkRelBv6aGZUkHSHDdbVXItVCX3hVGyoGY4ZrcrLfg5dg==", "d5969ce2-ec1d-4d24-b758-35024de4f441" });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3022), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3025), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3028), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3033), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 2, 9, 7, 35, 3, 585, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6906), new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6929), new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6934), new DateTime(2022, 2, 9, 7, 35, 3, 584, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 581, DateTimeKind.Local).AddTicks(6614), new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9018), new DateTime(2022, 2, 9, 7, 35, 3, 582, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DurationId",
                table: "Bookings",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PaymentId",
                table: "Bookings",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Durations_DurationId",
                table: "Bookings",
                column: "DurationId",
                principalTable: "Durations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Payments_PaymentId",
                table: "Bookings",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Durations_DurationId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Payments_PaymentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DurationId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PaymentId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "489e4d75-e0dc-4ac8-ab15-72834102fc89",
                column: "ConcurrencyStamp",
                value: "e0fb48bd-cec2-417c-83bb-622ff6f6af25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd4389e0-5019-466c-930e-8f60f453bc91",
                column: "ConcurrencyStamp",
                value: "a50d9de8-714c-406f-9aad-a5166d86b9b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18a0ae93-da75-43fd-ba01-7b4f95456194",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "976d1a49-0d72-4820-b758-27fc033f4c4b", "AQAAAAEAACcQAAAAEI7DoM/A0KX+z69m29ybHa8mN7hHuhQJaeYfPb0Om3aw6oiIz1G1yDsnQw3HiZggng==", "2feeb5b0-78ac-4143-89d1-4114a7d4c1f4" });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3027), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3043), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Durations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3067), new DateTime(2022, 2, 8, 22, 4, 42, 376, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8222), new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8271), new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8277), new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8288), new DateTime(2022, 2, 8, 22, 4, 42, 374, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 367, DateTimeKind.Local).AddTicks(7238), new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9636), new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9643), new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 2, 8, 22, 4, 42, 369, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_DurationId",
                table: "Hotels",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_PaymentId",
                table: "Hotels",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_RoomId",
                table: "Hotels",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Durations_DurationId",
                table: "Hotels",
                column: "DurationId",
                principalTable: "Durations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Payments_PaymentId",
                table: "Hotels",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Rooms_RoomId",
                table: "Hotels",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

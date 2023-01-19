using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T07.BoardGame.Core.Migrations
{
    public partial class InitProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e01b5da-60a1-426e-b306-edbecd1aa228", "a179e953-41dd-4ef9-adb2-37292f591890", "UserV1", "USERV1" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "752a7c8c-d839-4ab8-a88a-1645f48319f8", "UserV0", "USERV0" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "966f6aff-c653-4553-bfcc-b6d63d6461d1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29a1edd8-8a04-4ad4-9cc3-a0402f533017", 0, "174c00d1-6d7a-4cbc-ae21-5df1ce436cc6", "thanhu2@user.com", true, false, null, "THANHU2@USER.COM", "THANHU2@USER.COM", "AQAAAAEAACcQAAAAECaMJrK/BAG1HB00SLkhe4tFAJj5faLFv653q/0zT5dxiiHq0b03dqD7nGqvQPVH8Q==", null, false, "e3196431-f7dc-42bc-aaf4-578967667842", false, "thanhu2@user.com" },
                    { "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed", 0, "211cfcbc-58d7-4d2d-8e95-89e10df5d620", "thanhu1@user.com", true, false, null, "THANHU1@USER.COM", "THANHU1@USER.COM", "AQAAAAEAACcQAAAAEJmJdA/mku3KdyDtsaNDOUwhvW2dSUnnZ0jWe11s4+irquPvoX/3F/QIvo3JnDQk3w==", null, false, "aa7415cb-594d-4d70-85b4-4a0518e72f19", false, "thanhu1@user.com" },
                    { "7d1cb70a-6c6f-4920-b353-30f5a97e9767", 0, "b5a3d329-cc6a-48e7-be24-5261f50b276a", "thanhu3@user.com", true, false, null, "THANHU3@USER.COM", "THANHU3@USER.COM", "AQAAAAEAACcQAAAAEPsx9WSq4Jz7J6bQ4wqEPie07C05DFoXmXSUvhAr3YDEbexiFcpLocuVjdJU80Q14Q==", null, false, "bde754d8-f324-4745-9898-3a81b6cfa6d5", false, "thanhu3@user.com" },
                    { "a2d6f7a5-7249-407c-8518-effb9df83f4d", 0, "9bf20483-4bdf-4aa6-8fc5-05eeb69cbde3", "thanhu5@user.com", true, false, null, "THANHU5@USER.COM", "THANHU5@USER.COM", "AQAAAAEAACcQAAAAEDDJW1vQ3c4I/6ELfxboPIZZRbp9GDaq9W+dVecSE6w4btx4qyDtzMSoYZU36lsX1g==", null, false, "5f2113d8-cf07-4f53-a2fd-41a3bc3f2a83", false, "thanhu5@user.com" },
                    { "dd10f17b-6c30-43c8-b326-c69a807ba2c5", 0, "02c640e5-9ea2-4aae-9790-3a449e784dbb", "thanha1@admin.com", true, false, null, "THANHA1@ADMIN.COM", "THANHA1@ADMIN.COM", "AQAAAAEAACcQAAAAEGpZ4YQeQAwk/oMdz1S/syzHxUWBw8+BLQjKFMP0I8NrScH5hXXgspRLAEzVHlKQwA==", null, false, "2fe3573d-e5d9-4a54-8dab-cfa0031f0c42", false, "thanha1@admin.com" },
                    { "e6e01470-3dcd-41b3-9eac-b11cdc461330", 0, "8de0133b-6b63-4312-afcd-6dcf1747b02b", "thanhu4@user.com", true, false, null, "THANHU4@USER.COM", "THANHU4@USER.COM", "AQAAAAEAACcQAAAAELwlMfqtpNnJ2Kt6zKuE48cZiDTtV3Rs3Ckw1BmpxjpOxrV7XMHp0kPtZfi1rm7iqQ==", null, false, "d264bb70-59f7-439f-b748-a4859fee3cce", false, "thanhu4@user.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "29a1edd8-8a04-4ad4-9cc3-a0402f533017" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "7d1cb70a-6c6f-4920-b353-30f5a97e9767" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "a2d6f7a5-7249-407c-8518-effb9df83f4d" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "dd10f17b-6c30-43c8-b326-c69a807ba2c5" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "e6e01470-3dcd-41b3-9eac-b11cdc461330" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

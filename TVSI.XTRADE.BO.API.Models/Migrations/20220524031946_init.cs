using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVSI.XTRADE.BO.API.Models.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorCodes",
                columns: table => new
                {
                    ErrCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ErrMsgVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrMsgEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorCodes", x => x.ErrCode);
                });

            migrationBuilder.CreateTable(
                name: "LogLogins",
                columns: table => new
                {
                    LogLoginId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Device = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogLogins", x => x.LogLoginId);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevokeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "ErrorCodes",
                columns: new[] { "ErrCode", "Active", "Channel", "CreatedBy", "CreatedDate", "Descriptions", "ErrMsgEn", "ErrMsgVi", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8402), "", "Success.", "Thành công.", null, null },
                    { "69901", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8421), "", "Account has been locked.", "Tài khoản đã bị khóa.", null, null },
                    { "69902", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8439), "", "Login information is incorrect.", "Thông tin đăng nhập không đúng.", null, null },
                    { "69903", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8456), "", "Not allowed to access application.", "Người dùng không có quyền truy cập ứng dụng.", null, null },
                    { "69904", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8473), "", "Not allowed to access action.", "Người dùng không có quyền truy cập hành đông.", null, null },
                    { "69905", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8490), "", "Token is required.", "Thông tin Token là bắt buộc.", null, null },
                    { "69906", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8508), "", "Token not found.", "Không tìm thấy thông tin Token.", null, null },
                    { "69907", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8525), "", "Token invalid.", "Thông tin Token không đúng.", null, null },
                    { "-99999", true, "ALL", "System", new DateTime(2022, 5, 24, 10, 19, 46, 298, DateTimeKind.Local).AddTicks(8364), "", "Transactions failed. Please contact customer service.", "Giao dịch thất bại. Vui lòng liên hệ bộ phận chăm sóc khách hàng.", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "Password", "Phone", "Pin", "Username" },
                values: new object[] { 1L, "Vietnam", "demo@netcore.com", "FE-01-CE-2A-7F-BA-C8-FA-FA-ED-7C-98-2A-04-E2-29", "0123456789", "1234", "demo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorCodes");

            migrationBuilder.DropTable(
                name: "LogLogins");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

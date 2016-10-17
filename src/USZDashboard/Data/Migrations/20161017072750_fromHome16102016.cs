using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace USZDashboard.Data.Migrations
{
    public partial class fromHome16102016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminRight",
                columns: table => new
                {
                    AdminRightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ext = table.Column<string>(nullable: true),
                    Right = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRight", x => x.AdminRightId);
                });

            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    ClinicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClinicLongName = table.Column<string>(nullable: true),
                    ClinicName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinic", x => x.ClinicId);
                });

            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    LayoutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LayoutName = table.Column<string>(nullable: true),
                    Structure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout", x => x.LayoutId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                name: "UserGroup",
                columns: table => new
                {
                    UserGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminRightId = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.UserGroupId);
                    table.ForeignKey(
                        name: "FK_UserGroup_AdminRight_AdminRightId",
                        column: x => x.AdminRightId,
                        principalTable: "AdminRight",
                        principalColumn: "AdminRightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dashboard",
                columns: table => new
                {
                    DashboardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DashboardName = table.Column<string>(nullable: true),
                    LayoutId = table.Column<int>(nullable: false),
                    Structure = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    categories = table.Column<bool>(nullable: false),
                    collapsible = table.Column<bool>(nullable: false),
                    editable = table.Column<bool>(nullable: false),
                    maximizable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboard", x => x.DashboardId);
                    table.ForeignKey(
                        name: "FK_Dashboard_Layout_LayoutId",
                        column: x => x.LayoutId,
                        principalTable: "Layout",
                        principalColumn: "LayoutId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    UserGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_UserGroup_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "UserGroup",
                        principalColumn: "UserGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Widget",
                columns: table => new
                {
                    WidgetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DashboardId = table.Column<int>(nullable: true),
                    WidgetName = table.Column<string>(nullable: true),
                    config = table.Column<string>(nullable: true),
                    fullScreen = table.Column<string>(nullable: true),
                    modalSize = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widget", x => x.WidgetId);
                    table.ForeignKey(
                        name: "FK_Widget_Dashboard_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboard",
                        principalColumn: "DashboardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDashboard",
                columns: table => new
                {
                    UserDashboardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DashboardId = table.Column<int>(nullable: false),
                    Ext = table.Column<string>(nullable: true),
                    UserGroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDashboard", x => x.UserDashboardId);
                    table.ForeignKey(
                        name: "FK_UserDashboard_Dashboard_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboard",
                        principalColumn: "DashboardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDashboard_UserGroup_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "UserGroup",
                        principalColumn: "UserGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDashboard_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StructureTable",
                columns: table => new
                {
                    StructureTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Column = table.Column<int>(nullable: false),
                    ColumnStyle = table.Column<string>(nullable: true),
                    LayoutId = table.Column<int>(nullable: false),
                    RowNumber = table.Column<int>(nullable: false),
                    WidgetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureTable", x => x.StructureTableId);
                    table.ForeignKey(
                        name: "FK_StructureTable_Layout_LayoutId",
                        column: x => x.LayoutId,
                        principalTable: "Layout",
                        principalColumn: "LayoutId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StructureTable_Widget_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widget",
                        principalColumn: "WidgetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

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
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dashboard_LayoutId",
                table: "Dashboard",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_StructureTable_LayoutId",
                table: "StructureTable",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_StructureTable_WidgetId",
                table: "StructureTable",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserGroupId",
                table: "User",
                column: "UserGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDashboard_DashboardId",
                table: "UserDashboard",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDashboard_UserGroupId",
                table: "UserDashboard",
                column: "UserGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDashboard_UserId",
                table: "UserDashboard",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_AdminRightId",
                table: "UserGroup",
                column: "AdminRightId");

            migrationBuilder.CreateIndex(
                name: "IX_Widget_DashboardId",
                table: "Widget",
                column: "DashboardId");
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
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "StructureTable");

            migrationBuilder.DropTable(
                name: "UserDashboard");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Widget");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Dashboard");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "Layout");

            migrationBuilder.DropTable(
                name: "AdminRight");
        }
    }
}

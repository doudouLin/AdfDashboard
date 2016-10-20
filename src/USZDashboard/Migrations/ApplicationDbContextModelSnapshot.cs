using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using USZDashboard.Data;

namespace USZDashboard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("USZDashboard.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.AdminRight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Ext");

                    b.Property<string>("Right");

                    b.HasKey("Id");

                    b.ToTable("AdminRight");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Clinic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<string>("ClinicLongName");

                    b.Property<string>("ClinicName");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.HasKey("Id");

                    b.ToTable("Clinic");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Dashboard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Categories");

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<bool>("Collapsible");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("DashboardName");

                    b.Property<bool>("Editable");

                    b.Property<bool>("Maximizable");

                    b.Property<Guid>("StructureId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("StructureId");

                    b.ToTable("Dashboard");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Structure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Structure");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.TableColumn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<int>("ColumnNumber");

                    b.Property<string>("ColumnStyle");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<Guid>("TableRowId");

                    b.HasKey("Id");

                    b.HasIndex("TableRowId");

                    b.ToTable("TableColumn");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.TableRow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<Guid?>("DashboardId");

                    b.Property<int>("RowNumber");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.ToTable("TableRow");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Photo");

                    b.Property<Guid?>("UserGroupId");

                    b.HasKey("Id");

                    b.HasIndex("UserGroupId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserDashboard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<Guid>("DashboardId");

                    b.Property<string>("Ext");

                    b.Property<Guid>("UserGroupId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.HasIndex("UserGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDashboard");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AdminRightId");

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("GroupName");

                    b.HasKey("Id");

                    b.HasIndex("AdminRightId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Widget", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<bool>("FullScreen");

                    b.Property<int>("Index");

                    b.Property<string>("ModalSize");

                    b.Property<Guid>("TableColumnId");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<string>("WidgetName");

                    b.HasKey("Id");

                    b.HasIndex("TableColumnId");

                    b.ToTable("Widget");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.WidgetConfigration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ChangeDate");

                    b.Property<string>("ChangeUser");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUser");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.Property<Guid>("WidgetId");

                    b.HasKey("Id");

                    b.HasIndex("WidgetId");

                    b.ToTable("WidgetConfigration");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("USZDashboard.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("USZDashboard.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("USZDashboard.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Dashboard", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Structure", "Structure")
                        .WithMany()
                        .HasForeignKey("StructureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.TableColumn", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.TableRow")
                        .WithMany("TableColumns")
                        .HasForeignKey("TableRowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.TableRow", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Dashboard")
                        .WithMany("TableRows")
                        .HasForeignKey("DashboardId");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.User", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.UserGroup")
                        .WithMany("Users")
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserDashboard", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Dashboard", "Dashboard")
                        .WithMany()
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("USZDashboard.Models.DashboardViewModels.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("USZDashboard.Models.DashboardViewModels.User", "User")
                        .WithMany("UserDashboards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserGroup", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.AdminRight", "AdminRight")
                        .WithMany()
                        .HasForeignKey("AdminRightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Widget", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.TableColumn")
                        .WithMany("Widgets")
                        .HasForeignKey("TableColumnId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.WidgetConfigration", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Widget")
                        .WithMany("WidgetConfigrations")
                        .HasForeignKey("WidgetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

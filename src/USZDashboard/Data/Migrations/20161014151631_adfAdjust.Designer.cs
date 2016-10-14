using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using USZDashboard.Data;

namespace USZDashboard.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161014151631_adfAdjust")]
    partial class adfAdjust
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                    b.Property<int>("AdminRightId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Right");

                    b.HasKey("AdminRightId");

                    b.ToTable("AdminRight");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClinicName");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinic");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Dashboard", b =>
                {
                    b.Property<int>("DashboardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LayoutId");

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.Property<bool>("categories");

                    b.Property<bool>("collapsible");

                    b.Property<bool>("editable");

                    b.Property<bool>("maximizable");

                    b.HasKey("DashboardId");

                    b.HasIndex("LayoutId");

                    b.ToTable("Dashboard");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Layout", b =>
                {
                    b.Property<int>("LayoutId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Structure");

                    b.HasKey("LayoutId");

                    b.ToTable("Layout");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.LayoutDetail", b =>
                {
                    b.Property<int>("LayoutDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Column");

                    b.Property<string>("ColumnStyle");

                    b.Property<int>("LayoutId");

                    b.Property<int>("RowNumber");

                    b.HasKey("LayoutDetailId");

                    b.HasIndex("LayoutId");

                    b.ToTable("LayoutDetail");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int?>("UserGroupId");

                    b.HasKey("UserId");

                    b.HasIndex("UserGroupId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserDashboard", b =>
                {
                    b.Property<int>("UserDashboardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DashboardId");

                    b.Property<int>("UserGroupId");

                    b.Property<int>("UserId");

                    b.HasKey("UserDashboardId");

                    b.HasIndex("DashboardId");

                    b.HasIndex("UserGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDashboard");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminRightId");

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("UserGroupId");

                    b.HasIndex("AdminRightId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.Widget", b =>
                {
                    b.Property<int>("WidgetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DashboardId");

                    b.Property<string>("config");

                    b.Property<string>("fullScreen");

                    b.Property<string>("modalSize");

                    b.Property<string>("title");

                    b.Property<string>("type");

                    b.HasKey("WidgetId");

                    b.HasIndex("DashboardId");

                    b.ToTable("Widget");
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
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.LayoutDetail", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.User", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.UserGroup")
                        .WithMany("User")
                        .HasForeignKey("UserGroupId");
                });

            modelBuilder.Entity("USZDashboard.Models.DashboardViewModels.UserDashboard", b =>
                {
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Dashboard", "Dashboard")
                        .WithMany("UserDashboards")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("USZDashboard.Models.DashboardViewModels.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("USZDashboard.Models.DashboardViewModels.User", "User")
                        .WithMany("UserDashboard")
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
                    b.HasOne("USZDashboard.Models.DashboardViewModels.Dashboard")
                        .WithMany("Widgets")
                        .HasForeignKey("DashboardId");
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_NewSolutions.Migrations
{
    public partial class NewSolutions_v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "about");

            migrationBuilder.EnsureSchema(
                name: "clients");

            migrationBuilder.EnsureSchema(
                name: "contacts");

            migrationBuilder.EnsureSchema(
                name: "home");

            migrationBuilder.EnsureSchema(
                name: "projects");

            migrationBuilder.CreateTable(
                name: "about_section1",
                schema: "about",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details_regular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    details_bold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    video_link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about_section1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "about_section2",
                schema: "about",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    small_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about_section2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "about_section3",
                schema: "about",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about_section3", x => x.id);
                });

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
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "Client_Img_Url",
                schema: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNavigation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Img_Url", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                schema: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    job_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    twitter_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    linked_in_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    facebook_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    instegram_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clients_section1",
                schema: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients_section1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts_section1",
                schema: "contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts_section1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts_social_media",
                schema: "contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    twitter_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    facebook_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    linked_in_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    instegram_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts_social_media", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Img_Url",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNavigation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Img_Url", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    job_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    twitter_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    linked_in_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    facebook_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    instegram_url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section1",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section2",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section3",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    active_clients = table.Column<short>(type: "smallint", nullable: true),
                    projects_done = table.Column<short>(type: "smallint", nullable: true),
                    team_advisors = table.Column<short>(type: "smallint", nullable: true),
                    glorious_years = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section4",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section4", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section4_card1",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    card_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_footer1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section4_card1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section4_card2",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    card_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_footer1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section4_card2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section4_card3",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    card_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_footer1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    card_footer3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section4_card3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section5",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section6",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section6", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section7",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section7", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section7_slider1",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section7_slider1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "home_section7_slider2",
                schema: "home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home_section7_slider2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Project_Img_Url",
                schema: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNavigation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Img_Url", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "projects_section1",
                schema: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_title2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects_section1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "upload_project",
                schema: "projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    big_Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_upload_project", x => x.id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "about_section1",
                schema: "about");

            migrationBuilder.DropTable(
                name: "about_section2",
                schema: "about");

            migrationBuilder.DropTable(
                name: "about_section3",
                schema: "about");

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
                name: "Client_Img_Url",
                schema: "clients");

            migrationBuilder.DropTable(
                name: "clients",
                schema: "clients");

            migrationBuilder.DropTable(
                name: "clients_section1",
                schema: "clients");

            migrationBuilder.DropTable(
                name: "contacts_section1",
                schema: "contacts");

            migrationBuilder.DropTable(
                name: "contacts_social_media",
                schema: "contacts");

            migrationBuilder.DropTable(
                name: "Employee_Img_Url");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "home_section1",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section2",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section3",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section4",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section4_card1",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section4_card2",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section4_card3",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section5",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section6",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section7",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section7_slider1",
                schema: "home");

            migrationBuilder.DropTable(
                name: "home_section7_slider2",
                schema: "home");

            migrationBuilder.DropTable(
                name: "Project_Img_Url",
                schema: "projects");

            migrationBuilder.DropTable(
                name: "projects_section1",
                schema: "projects");

            migrationBuilder.DropTable(
                name: "upload_project",
                schema: "projects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

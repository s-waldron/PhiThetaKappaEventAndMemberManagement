using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhiThetaKappaEventAndMemberManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EVENTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompletedEventDate = table.Column<DateTime>(nullable: false),
                    CompletedEventNumberOfMembers = table.Column<int>(nullable: false),
                    EventAddress = table.Column<string>(nullable: false),
                    EventCity = table.Column<string>(nullable: false),
                    EventCompletedEvent = table.Column<bool>(nullable: false),
                    EventDescription = table.Column<string>(nullable: false),
                    EventEndDateAndTime = table.Column<DateTime>(nullable: false),
                    EventLocationName = table.Column<string>(nullable: false),
                    EventName = table.Column<string>(nullable: false),
                    EventStartDateAndTime = table.Column<DateTime>(nullable: false),
                    EventState = table.Column<string>(nullable: false),
                    EventZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EVENTID);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MEMBERID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberAlumnus = table.Column<bool>(nullable: false),
                    MemberEmailAddress = table.Column<string>(nullable: false),
                    MemberFirstName = table.Column<string>(nullable: false),
                    MemberJoinDate = table.Column<DateTime>(nullable: false),
                    MemberLastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MEMBERID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NEWSID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NewsArticle = table.Column<string>(nullable: false),
                    NewsArticleTitle = table.Column<string>(nullable: false),
                    NewsCreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NEWSID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}

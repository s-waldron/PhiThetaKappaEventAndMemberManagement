using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PhiThetaKappaEventAndMemberManagement.Models;

namespace PhiThetaKappaEventAndMemberManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180925172224_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhiThetaKappaEventAndMemberManagement.Models.Events", b =>
                {
                    b.Property<int>("EVENTID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CompletedEventDate");

                    b.Property<int>("CompletedEventNumberOfMembers");

                    b.Property<string>("EventAddress")
                        .IsRequired();

                    b.Property<string>("EventCity")
                        .IsRequired();

                    b.Property<bool>("EventCompletedEvent");

                    b.Property<string>("EventDescription")
                        .IsRequired();

                    b.Property<DateTime>("EventEndDateAndTime");

                    b.Property<string>("EventLocationName")
                        .IsRequired();

                    b.Property<string>("EventName")
                        .IsRequired();

                    b.Property<DateTime>("EventStartDateAndTime");

                    b.Property<string>("EventState")
                        .IsRequired();

                    b.Property<int>("EventZipCode");

                    b.HasKey("EVENTID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("PhiThetaKappaEventAndMemberManagement.Models.Member", b =>
                {
                    b.Property<int>("MEMBERID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("MemberAlumnus");

                    b.Property<string>("MemberEmailAddress")
                        .IsRequired();

                    b.Property<string>("MemberFirstName")
                        .IsRequired();

                    b.Property<DateTime>("MemberJoinDate");

                    b.Property<string>("MemberLastName")
                        .IsRequired();

                    b.HasKey("MEMBERID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("PhiThetaKappaEventAndMemberManagement.Models.News", b =>
                {
                    b.Property<int>("NEWSID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NewsArticle")
                        .IsRequired();

                    b.Property<string>("NewsArticleTitle")
                        .IsRequired();

                    b.Property<DateTime>("NewsCreatedDate");

                    b.HasKey("NEWSID");

                    b.ToTable("News");
                });
        }
    }
}

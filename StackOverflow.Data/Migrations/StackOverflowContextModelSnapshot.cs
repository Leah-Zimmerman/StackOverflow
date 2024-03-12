﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackOverflow.Data;

#nullable disable

namespace StackOverflow.Data.Migrations
{
    [DbContext(typeof(StackOverflowContext))]
    partial class StackOverflowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StackOverflow.Data.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("StackOverflow.Data.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("StackOverflow.Data.QuestionAnswer", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId", "AnswerId");

                    b.HasIndex("AnswerId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("StackOverflow.Data.QuestionTag", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("QuestionTags");
                });

            modelBuilder.Entity("StackOverflow.Data.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("StackOverflow.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StackOverflow.Data.QuestionAnswer", b =>
                {
                    b.HasOne("StackOverflow.Data.Answer", null)
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StackOverflow.Data.Question", null)
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("StackOverflow.Data.QuestionTag", b =>
                {
                    b.HasOne("StackOverflow.Data.Question", null)
                        .WithMany("QuestionTags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StackOverflow.Data.Tag", null)
                        .WithMany("QuestionTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("StackOverflow.Data.Answer", b =>
                {
                    b.Navigation("QuestionAnswers");
                });

            modelBuilder.Entity("StackOverflow.Data.Question", b =>
                {
                    b.Navigation("QuestionAnswers");

                    b.Navigation("QuestionTags");
                });

            modelBuilder.Entity("StackOverflow.Data.Tag", b =>
                {
                    b.Navigation("QuestionTags");
                });
#pragma warning restore 612, 618
        }
    }
}
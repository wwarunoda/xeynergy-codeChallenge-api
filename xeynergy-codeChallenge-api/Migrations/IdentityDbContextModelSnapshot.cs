﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xeynergy_codeChallenge_api.Contexts;

namespace xeynergy_codeChallenge_api.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.AccessRule", b =>
                {
                    b.Property<Guid>("AccessRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Permission")
                        .HasColumnType("bit");

                    b.Property<string>("RuleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccessRuleId");

                    b.ToTable("AccessRules");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.UserGroup", b =>
                {
                    b.Property<Guid>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccessRuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserGroupId");

                    b.HasIndex("AccessRuleId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.Admin", b =>
                {
                    b.HasBaseType("xeynergy_codeChallenge_api.Entities.Person");

                    b.Property<string>("Privilege")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.User", b =>
                {
                    b.HasBaseType("xeynergy_codeChallenge_api.Entities.Person");

                    b.Property<Guid>("AttachedCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("UserGroupId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.UserGroup", b =>
                {
                    b.HasOne("xeynergy_codeChallenge_api.Entities.AccessRule", "AccessRule")
                        .WithMany("UserGroups")
                        .HasForeignKey("AccessRuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessRule");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.User", b =>
                {
                    b.HasOne("xeynergy_codeChallenge_api.Entities.UserGroup", "UserGroup")
                        .WithMany("Users")
                        .HasForeignKey("UserGroupId");

                    b.Navigation("UserGroup");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.AccessRule", b =>
                {
                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("xeynergy_codeChallenge_api.Entities.UserGroup", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
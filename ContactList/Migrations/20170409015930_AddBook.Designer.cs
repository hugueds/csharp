using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ContactList.Models;

namespace ContactList.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    [Migration("20170409015930_AddBook")]
    partial class AddBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("ContactList.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorContactId");

                    b.Property<string>("Title");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorContactId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("ContactList.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Telephone");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactList.Models.Book", b =>
                {
                    b.HasOne("ContactList.Models.Contact", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorContactId");
                });
        }
    }
}

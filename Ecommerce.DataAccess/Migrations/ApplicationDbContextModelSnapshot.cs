﻿// <auto-generated />
using Ecommerce.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J. R. R. Tolkien",
                            CategoryId = 5,
                            Description = "The Lord of the Rings is an epic high-fantasy novel written by English author and scholar J. R. R. Tolkien.",
                            ISBN = "978-0-395-19395-7",
                            ImageUrl = "",
                            ListPrice = 19.989999999999998,
                            Price = 14.99,
                            Price100 = 12.99,
                            Price50 = 13.99,
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 2,
                            Author = "J. K. Rowling",
                            CategoryId = 5,
                            Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling.",
                            ISBN = "978-0-7475-3269-6",
                            ImageUrl = "",
                            ListPrice = 14.99,
                            Price = 9.9900000000000002,
                            Price100 = 7.9900000000000002,
                            Price50 = 8.9900000000000002,
                            Title = "Harry Potter and the Philosopher's Stone"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Dan Brown",
                            CategoryId = 7,
                            Description = "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown.",
                            ISBN = "978-0-385-50420-5",
                            ImageUrl = "",
                            ListPrice = 12.99,
                            Price = 7.9900000000000002,
                            Price100 = 5.9900000000000002,
                            Price50 = 6.9900000000000002,
                            Title = "The Da Vinci Code"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stephen King",
                            CategoryId = 7,
                            Description = "The Shining is a horror novel by American author Stephen King.",
                            ISBN = "978-0-385-12167-5",
                            ImageUrl = "",
                            ListPrice = 9.9900000000000002,
                            Price = 4.9900000000000002,
                            Price100 = 2.9900000000000002,
                            Price50 = 3.9900000000000002,
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Nicholas Sparks",
                            CategoryId = 8,
                            Description = "The Notebook is a 1996 romantic novel by American novelist Nicholas Sparks.",
                            ISBN = "978-0-446-52080-5",
                            ImageUrl = "",
                            ListPrice = 7.9900000000000002,
                            Price = 2.9900000000000002,
                            Price100 = 0.98999999999999999,
                            Price50 = 1.99,
                            Title = "The Notebook"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Suzanne Collins",
                            CategoryId = 1,
                            Description = "The Hunger Games is a 2008 dystopian novel by the American writer Suzanne Collins.",
                            ISBN = "978-0-439-02348-1",
                            ImageUrl = "",
                            ListPrice = 11.99,
                            Price = 6.9900000000000002,
                            Price100 = 4.9900000000000002,
                            Price50 = 5.9900000000000002,
                            Title = "The Hunger Games"
                        },
                        new
                        {
                            Id = 7,
                            Author = "George R. R. Martin",
                            CategoryId = 5,
                            Description = "Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by the American author George R. R. Martin.",
                            ISBN = "978-0-553-57340-4",
                            ImageUrl = "",
                            ListPrice = 15.99,
                            Price = 10.99,
                            Price100 = 8.9900000000000002,
                            Price50 = 9.9900000000000002,
                            Title = "Game of Thrones"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.HasOne("Ecommerce.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

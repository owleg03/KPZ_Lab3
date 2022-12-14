// <auto-generated />
using CodeFirstApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221106113201_AddLazyLoading")]
    partial class AddLazyLoading
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirstApp.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "100",
                            Key = "A",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "75",
                            Key = "B",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "125",
                            Key = "C",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Indian",
                            Key = "A",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Arctic",
                            Key = "B",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "Atlantic",
                            Key = "C",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "Pacific",
                            Key = "D",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "Rodent",
                            Key = "A",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Content = "Fish",
                            Key = "B",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Content = "Mammal",
                            Key = "C",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Content = "Bird",
                            Key = "D",
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMarkedDebatable")
                        .HasColumnType("bit");

                    b.Property<double>("SuccessRate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Calculate 25*3:",
                            Description = "Math problem",
                            IsMarkedDebatable = false,
                            SuccessRate = 90.019999999999996
                        },
                        new
                        {
                            Id = 2,
                            Content = "Which is the biggest ocean on Earth?",
                            Description = "Geography problem",
                            IsMarkedDebatable = false,
                            SuccessRate = 29.309999999999999
                        },
                        new
                        {
                            Id = 3,
                            Content = "Which animal type is a dolphin?",
                            Description = "Science problem",
                            IsMarkedDebatable = true,
                            SuccessRate = 77.909999999999997
                        });
                });

            modelBuilder.Entity("CodeFirstApp.Models.Answer", b =>
                {
                    b.HasOne("CodeFirstApp.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirstApp.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}

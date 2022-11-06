using Microsoft.EntityFrameworkCore;

using DesktopApp.Models;

namespace DesktopApp;

public sealed class ApplicationDbContext: DbContext
{
    private const string DefaultConnection = "Server=(localdb)\\MSSQLLocalDB;Database=KPZ_Lab3_CodeFirst";
    private const string A = "A";
    private const string B = "B";
    private const string C = "C";
    private const string D = "D";
    
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<Answer> Answers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DefaultConnection);
        optionsBuilder.UseLazyLoadingProxies();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Questions data
        modelBuilder.Entity<Question>().HasData(
            new Question
            {
                Id = 1,
                Content = "Calculate 25*3:",
                Description = "Math problem",
                SuccessRate = 90.02,
                IsMarkedDebatable = false
            },
            new Question
            {
                Id = 2,
                Content = "Which is the biggest ocean on Earth?",
                Description = "Geography problem",
                SuccessRate = 29.31,
                IsMarkedDebatable = false
            },
            new Question
            {
                Id = 3,
                Content = "Which animal type is a dolphin?",
                Description = "Science problem",
                SuccessRate = 77.91,
                IsMarkedDebatable = true
            }
        );
        
        // Answers data
        modelBuilder.Entity<Answer>().HasData(
            new Answer
            {
                Id = 1,
                Key = A,
                Content = "100",
                QuestionId = 1
            },
            new Answer
            {
                Id = 2,
                Key = B,
                Content = "75",
                QuestionId = 1
            },
            new Answer
            {
                Id = 3,
                Key = C,
                Content = "125",
                QuestionId = 1
            },
            new Answer
            {
                Id = 4,
                Key = A,
                Content = "Indian",
                QuestionId = 2
            },
            new Answer
            {
                Id = 5,
                Key = B,
                Content = "Arctic",
                QuestionId = 2,
            },
            new Answer
            {
                Id = 6,
                Key = C,
                Content = "Atlantic",
                QuestionId = 2,
            },
            new Answer
            {
                Id = 7,
                Key = D,
                Content = "Pacific",
                QuestionId = 2,
            },
            new Answer
            {
                Id = 8,
                Key = A,
                Content = "Rodent",
                QuestionId = 3
            },
            new Answer
            {
                Id = 9,
                Key = B,
                Content = "Fish",
                QuestionId = 3
            },
            new Answer
            {
                Id = 10,
                Key = C,
                Content = "Mammal",
                QuestionId = 3
            },
            new Answer
            {
                Id = 11,
                Key = D,
                Content = "Bird",
                QuestionId = 3
            }
        );
    }
}
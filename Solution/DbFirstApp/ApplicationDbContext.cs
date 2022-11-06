using DbFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApp
{
    public partial class ApplicationDbContext : DbContext
    {
        private const string A = "A";
        private const string B = "B";
        private const string C = "C";
        private const string D = "D";
        
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KPZ_Lab3_DbFirst");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(50)
                    .HasColumnName("content");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .HasColumnName("key");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_Questions");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(50)
                    .HasColumnName("content");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.IsMarkedDebatable).HasColumnName("is_marked_debatable");

                entity.Property(e => e.SuccessRate).HasColumnName("success_rate");
            });

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
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using HK_Registration.Models;

namespace HK_Registration.Data
{
    public class CourseRegistrationContext : DbContext
    {
        public CourseRegistrationContext(
            DbContextOptions<CourseRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<HKClass> Classes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HKClass>().HasData(

                new HKClass
                {
                    CourseID = 1,
                    Name = "Internet Programming",
                    Number = "CPSC-8720-02",
                    Department = "Health Informatics",
                    Credit = 3,
                    Capacity = 25
                },

                new HKClass
                {
                    CourseID = 2,
                    Name = "Java Programming",
                    Number = "CPSC-8720-03",
                    Department = "Computer Science",
                    Credit = 4,
                    Capacity = 20
                }
            );
        }
    }
}
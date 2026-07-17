using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Student> Students{get;set;}
        public DbSet<Classs> Classes{get;set;}
        public DbSet<Attendence> Attendences{get;set;}
        public DbSet<ClassStudent> ClassStudents{get;set;}
        public DbSet<Faculity> Faculities{get;set;}
        public DbSet<EducationLevel> EducationLevels{get;set;}
         public DbSet<StudentAttendence> StudentAttendences{get;set;}



        
    }
}
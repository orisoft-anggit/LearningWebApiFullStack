using Microsoft.EntityFrameworkCore;
using Web.Api.Entities.Employee;
using Web.Api.Entities.Faculty;
using Web.Api.Entities.Lecturer;
using Web.Api.Entities.ProgramStudy;
using Web.Api.Entities.Student;
using Web.Api.Infrastucture.Configuration.FacultyConfiguration;
using Web.Api.Infrastucture.Configuration.ProgramStudyConfiguration;

namespace Web.Api.Infrastucture.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FacultyEntityConfiguration());            
            builder.ApplyConfiguration(new ProgramStudyEntityConfiguration());              
            base.OnModelCreating(builder);
        }

        public virtual DbSet<FacultyEntity> Facultys { get; set; }

        public virtual DbSet<ProgramStudyEntity> ProgramStudys { get; set; }

        public virtual DbSet<LecturerEntity> Lectures { get; set; }

        public virtual DbSet<StudentEntity> Students { get; set; }

        public virtual DbSet<EmployeeEntity> Employees { get; set; }
    }
}
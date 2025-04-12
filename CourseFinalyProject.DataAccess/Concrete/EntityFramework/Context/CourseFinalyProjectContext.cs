using Core.Entities.Concrete;
using CourseFinalyProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.DataAccess.Concrete.EntityFramework.Context
{
    public class CourseFinalyProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CAHID;Database=CBEDFinalProjectApi;User Id=sa;Password=2016;TrustServerCertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<Attestation> Attestations { get; set; }
        public DbSet<DodtGoAbroad> DodtGoAbroads { get; set; }
        public DbSet<ExtenstionOFServiceLife> ExtenstionOFServiceLives { get; set; }
        public DbSet<MilitaryService> MilitaryServices { get; set; }
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<CombatOperations> CombatOperations { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationType> EducationTypes { get; set; }
        public DbSet<FrutherEducation> FrutherEducations { get; set; }
        public DbSet<Conscriptio> Conscriptio { get; set; }
        public DbSet<DiscountedService> DiscountedServices { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Give> Gives { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOpertaionClaim> UserOpertaionClaims { get; set; }
        public DbSet<RankType> RankTypes { get; set; }
        public DbSet<RankStatus> RankStatuses { get; set; }
        public DbSet<MilitaryRank> MilitaryRanks { get; set; }
    }
}

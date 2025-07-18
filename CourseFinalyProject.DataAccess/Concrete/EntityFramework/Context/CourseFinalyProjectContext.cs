﻿using Core.Entities.Concrete;
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
            //  optionsBuilder.UseSqlServer("Server=DESKTOP-1UHH25N\\MYDB;Database=CBEDFinalProjectApi;User Id=sa;Password=2016;TrustServerCertificate=true");            
          //  optionsBuilder.UseSqlServer("Server=DESKTOP-K6T1BDK;Database=CBEDFinalProjectApi;User Id=sa;Password=2016;TrustServerCertificate=true");
            optionsBuilder.UseSqlServer("Server = DESKTOP-K6T1BDK; Database = CBEDFinalProjectApi; TrustServerCertificate= True; MultipleActiveResultSets = true;User ID=sa;Password=2016");
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
        public DbSet<Branch> Branches { get; set; }
        public DbSet<RelativeType> RelativeTypes { get; set; }
        public DbSet<EmployeeFamilyMember> EmployeeFamilyMembers { get; set; }
        public DbSet<MedalType> MedalTypes { get; set; }
        public DbSet<ForignLanguage> ForignLanguages { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MHHK> MHHKs { get; set; }
        public DbSet<MHHKType> MHHKTypes { get; set; }
        public DbSet<AwardsType> AwardsTypes { get; set; }
        public DbSet<Awards> Awards { get; set; }
        public DbSet<HonoraryTitle> HonoraryTitles { get; set; }

    }
}

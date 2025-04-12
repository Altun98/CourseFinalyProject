using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Employee:BaseEntity,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? OldLastName { get; set; }
        public string? Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public ICollection<MilitaryService> MilitaryServices { get; set; } = new List<MilitaryService>();
        public ICollection<ExtenstionOFServiceLife> ExtenstionOFServiceLives { get; set; } = new List<ExtenstionOFServiceLife>();
        public ICollection<Attestation> Attestations { get; set; } = new List<Attestation>();
        public ICollection<DodtGoAbroad> DodtGoAbroads { get; set; } = new List<DodtGoAbroad>();
        public ICollection<AcademicDegree> AcademicDegrees { get; set; } = new List<AcademicDegree>();
        public ICollection<CombatOperations> CombatOperations { get; set; } = new List<CombatOperations>();
        public Conscriptio Conscriptio { get; set; }
        public ICollection<Education> Educations { get; set; } = new List<Education>();
        public ICollection<FrutherEducation> FrutherEducations { get; set; } = new List<FrutherEducation>();
        public ICollection<LaborActivity> laborActivities { get; set; } = new List<LaborActivity>();
    }
}

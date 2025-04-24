using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class EmployeeDocument : BaseEntity, IEntity
    {
        public DateTime? DocDade { get; set; }
        public string? DocNumber { get; set; }
        [ForeignKey(nameof(DocumentType))] public int DocumentTypeID { get; set; }
        [ForeignKey(nameof(Give))] public int GiveID { get; set; }
        public ICollection<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();

    }
}

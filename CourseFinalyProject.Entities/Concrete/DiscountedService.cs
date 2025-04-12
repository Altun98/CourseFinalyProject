using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class DiscountedService : BaseEntity, IEntity
    {
        [ForeignKey(nameof(MilitaryService))] public int MilitaryServisID { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? DocumentNumber { get; set; }
        public decimal? Coefficent { get; set; }
        public MilitaryService MilitaryService { get; set; }
    }
}

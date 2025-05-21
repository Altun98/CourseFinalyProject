using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class Language : BaseEntity, IEntity
    {
        public string LanguageName { get; set; }
        public string Description { get; set; } = string.Empty;
        ICollection<ForignLanguage> ForignLanguages = new List<ForignLanguage>();
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Entities.Concrete
{
    public class DocumentType : BaseEntity, IEntity
    {
        public string DocumentTypeName { get; set; }
    }
}

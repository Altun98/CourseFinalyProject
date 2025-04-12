using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFinalyProject.Business.Concrete
{
    public class DocumentTypeManager : IDocumentTypeService
    {
        private readonly IDocumentTypeDal _documentType;
        public DocumentTypeManager(IDocumentTypeDal documentType)
        {
            _documentType = documentType;
        }
    }
}

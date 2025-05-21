using Core.Entities;

namespace CourseFinalyProject.Entities.Concrete
{
    public class HonoraryTitle : BaseEntity, IEntity
    {
        //Fexri ad
        public string HonoraryTitleName { get; set; }
        public bool IsActive { get; set; }

    }
}

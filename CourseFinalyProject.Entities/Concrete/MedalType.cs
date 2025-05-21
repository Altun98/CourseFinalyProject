using Core.Entities;

namespace CourseFinalyProject.Entities.Concrete
{
    public class MedalType : BaseEntity, IEntity
    {
        //Medal tipleri
        public string MedalName { get; set; }
        public string Description { get; set; }
        public bool IsAll { get; set; } = true;
    }
}

namespace AutomapperTest.DTO
{
    public partial class UpsertCourse
    {
        public string Name { get; set; }
    }

    public partial class UpsertCourse
    {
        public class Mapping : AutoMapper.Profile
        {
            public Mapping()
            {
                CreateMap<UpsertCourse, Entities.Course>()
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Sections, opt => opt.Ignore());
            }
        }
    }
}

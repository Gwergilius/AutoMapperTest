namespace AutomapperTest.DTO
{
    public partial class UpsertSection
    {
        public string Name { get; set; }
    }

    public partial class UpsertSection
    {
        public class Mapping : AutoMapper.Profile
        {
            public Mapping()
            {
                CreateMap<UpsertSection, Entities.Section>()
                    .ForMember(x => x.Id, opt => opt.Ignore());
            }
        }
    }
}

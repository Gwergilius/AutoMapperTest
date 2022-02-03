using System.Collections.Generic;

namespace AutomapperTest.Entities
{
    public partial class Course : Entity
    {
        public string Name { get; set; }
        public ICollection<Section> Sections { get; } = new List<Section>();
    }

    public partial class Course
    {
        public class Mapping : AutoMapper.Profile
        {

        }
    }
}

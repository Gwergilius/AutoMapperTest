using AutoMapper;
using NUnit.Framework;

namespace AutomapperTest
{
    public class Tests
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Entities.Entity)));
            config.AssertConfigurationIsValid();
            _mapper = config.CreateMapper();
        }

        [Test]
        public void Test1()
        {
            const int initialId = 42;
            const string oldName = "Abraham Lincoln";
            const string newName = "Benjamin Franklin";

            var section = new Entities.Section { Id = initialId, Name = oldName };
            var dto = new DTO.UpsertSection { Name = newName };

            _mapper.Map(dto, section);

            Assert.AreEqual(newName, section.Name, "No mapping was happened");
            Assert.AreEqual(initialId, section.Id,  "Entity.Id was changed by the mapping");
        }
    }
}
using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Port : ITrackableEntity
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual Country Country { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Port(int id, string name, Country country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

        public void IsCreated()
        {
            Created = DateTime.UtcNow;
        }

        public void IsModified()
        {
            Modified = DateTime.UtcNow;
        }

    }
}

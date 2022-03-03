using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Country : ITrackableEntity
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Country(int id, string name, string abbreviaton)
        {
            Id = id;
            Name = name;
            Abbreviation = abbreviaton;
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

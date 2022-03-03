using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Terminal : ITrackableEntity
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual Port Port { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Terminal(int id, string name, Port port)
        {
            Id = id;
            Name = name;
            Port = port;
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

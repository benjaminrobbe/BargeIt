using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Quay : ITrackableEntity
    {

        public int Id { get; private set; }
        public int Number { get; private set; }
        public virtual Terminal Terminal { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Quay(int id, int number, Terminal terminal)
        {
            Id = id;
            Number = number;
            Terminal = terminal;
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

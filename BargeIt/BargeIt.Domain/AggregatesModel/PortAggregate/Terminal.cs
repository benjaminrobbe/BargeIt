using System.Collections.Generic;
using BargeIt.Domain.SeedWork;

namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Terminal : Entity
    {
        public string Name { get; private set; }

        public int PortId { get; private set; }
        public Port Port { get; private set; }

        private readonly List<Quay> _Quays;
        public virtual IReadOnlyCollection<Quay> Quays { get; private set; }

        public Terminal(
            string name,
            Port port)
        {
            Name = name;
            Port = port;
        }
    }
}

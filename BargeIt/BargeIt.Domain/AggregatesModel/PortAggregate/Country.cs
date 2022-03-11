using BargeIt.Domain.SeedWork;
using System.Collections.Generic;

namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Country : Entity
    {
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }

        private readonly List<Port> _Ports;
        public virtual IReadOnlyCollection<Port> Ports { get; private set; }

        public Country(
            string name,
            string abbreviaton)
        {
            Name = name;
            Abbreviation = abbreviaton;
        }
    }
}

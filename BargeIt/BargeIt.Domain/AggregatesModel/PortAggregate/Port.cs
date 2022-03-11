using BargeIt.Domain.SeedWork;
using System.Collections.Generic;

namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Port : Entity
    {
        public string Name { get; private set; }

        public int CountryId { get; private set; }
        public Country Country { get; private set; }

        private readonly List<Terminal> _Terminals;
        public virtual IReadOnlyCollection<Terminal> Terminals { get; private set; }

        public Port(
            string name,
            Country country)
        {
            Name = name;
            Country = country;
        }
    }
}

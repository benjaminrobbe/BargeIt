using BargeIt.Domain.SeedWork;

namespace BargeIt.Domain.AggregatesModel.PortAggregate
{
    public class Quay : Entity
    {
        public int Number { get; private set; }

        public int TerminalId { get; private set; }
        public Terminal Terminal { get; private set; }

        public Quay(
            int number,
            Terminal terminal)
        {
            Number = number;
            Terminal = terminal;
        }
    }
}

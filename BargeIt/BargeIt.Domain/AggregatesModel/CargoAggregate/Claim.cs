using System;
using System.Collections.Generic;
using BargeIt.Domain.SeedWork;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Claim : Entity
    {
        public int OfferedPrice { get; private set; }
        public string Comment { get; private set; }
        public DateTime AcceptDate { get; private set; }
        public DateTime DeclineDate { get; private set; }

        public int CargoId { get; private set; }
        public Cargo Cargo { get; private set; }

        private readonly List<Message> _messages;
        public virtual IReadOnlyCollection<Message> Messages { get; private set; }

        public Claim(
            int offeredPrice,
            Cargo cargo,
            DateTime acceptDate = new DateTime(),
            DateTime declineDate = new DateTime(),
            string comment = null)
        {
            OfferedPrice = offeredPrice;
            Comment = comment;
            AcceptDate = acceptDate;
            DeclineDate = declineDate;
            Cargo = cargo;
            CargoId = Cargo.Id;
        }
    }
}

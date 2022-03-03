using System;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Claim : ITrackableEntity
    {

        public int Id { get; private set; }
        public int OfferedPrice { get; private set; }
        public string Comment { get; private set; }
        public DateTime AcceptDate { get; private set; }
        public DateTime DeclineDate { get; private set; }
        public Cargo Cargo { get; private set; }
        public Barge Barge { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Claim(int id, int offeredPrice, Cargo cargo, Barge barge, DateTime acceptDate = new DateTime(), DateTime declineDate = new DateTime(), string comment = null)
        {
            Id = id;
            OfferedPrice = offeredPrice;
            Comment = comment;
            AcceptDate = acceptDate;
            DeclineDate = declineDate;
            Cargo = cargo;
            Barge = barge;
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

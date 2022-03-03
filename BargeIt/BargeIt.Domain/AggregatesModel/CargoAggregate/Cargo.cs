using System;
using System.Collections.Generic;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using BargeIt.Domain.AggregatesModel.PortAggregate;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Cargo : ITrackableEntity
    {

        public int Id { get; private set; }
        public string CargoIdNumber { get; private set; }
        public virtual Company CargoOwner { get; set; }
        public virtual Terminal TerminalOrigin { get; set; }
        public virtual Terminal TerminalDestination { get; set; }
        public virtual Quay QuayOrigin { get; set; }
        public virtual Quay QuayDestination { get; set; }
        public int CreditsCost { get; set; }
        public decimal RequestedPrice { get; set; }
        // bool / Boolean?
        public bool IsFixedPrice { get; set; }
        public DateTime PickUpDateStart { get; set; }
        public DateTime PickUpDateEnd { get; set; }
        public bool PickUpIsFullDay { get; set; }
        public DateTime DropOffDateStart { get; set; }
        public DateTime DropOffDateEnd { get; set; }
        public bool DropOffIsFullDay { get; set; }
        public bool HasDangerousGoods { get; set; }
        // enum
        public string Status { get; set; }
        public virtual List<Claim> Claims { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        // date and time / full day?
        // constructor chaining?
        public Cargo(int id,
            string cargoIdNumber,
            Company cargoOwner,
            Terminal terminalOrigin,
            Terminal terminalDestination,
            decimal requestedPrice,
            DateTime pickUpDateStart,
            DateTime dropOffDateStart,
            DateTime pickUpDateEnd,
            DateTime dropOffDateEnd,
            string status,
            Quay quayOrigin = null,
            Quay quayDestination = null,
            bool pickUpIsFullDay = false,
            bool dropOffIsFullDay = false,
            bool hasDangerousGoods = false,
            bool isFixedPrice = true)
        {
            Id = id;
            CargoIdNumber = cargoIdNumber;
            CargoOwner = cargoOwner;
            TerminalOrigin = terminalOrigin;
            TerminalDestination = terminalDestination;
            QuayOrigin = quayOrigin;
            QuayDestination = quayDestination;
            // calculated value
            CreditsCost = 1;
            RequestedPrice = requestedPrice;
            IsFixedPrice = isFixedPrice;
            PickUpDateStart = pickUpDateStart;
            PickUpDateEnd = pickUpDateEnd;
            PickUpIsFullDay = pickUpIsFullDay;
            DropOffDateStart = dropOffDateStart;
            DropOffDateEnd = dropOffDateEnd;
            DropOffIsFullDay = dropOffIsFullDay;
            HasDangerousGoods = hasDangerousGoods;
            Status = status;
            Claims = new List<Claim>();
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

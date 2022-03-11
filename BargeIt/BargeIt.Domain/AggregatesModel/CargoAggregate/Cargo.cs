using System;
using System.Collections.Generic;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.Enums;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;
using BargeIt.Domain.AggregatesModel.PortAggregate;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Cargo : Entity
    {

        public string CargoIdNumber { get; private set; }

        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        public Terminal TerminalOrigin { get; private set; }
        public Terminal TerminalDestination { get; private set; }

        public Quay QuayOrigin { get; private set; }
        public Quay QuayDestination { get; private set; }

        public int CreditsCost { get; private set; }
        public decimal RequestedPrice { get; private set; }
        public bool IsFixedPrice { get; private set; }
        public DateTime PickUpDateStart { get; private set; }
        public DateTime PickUpDateEnd { get; private set; }
        public bool PickUpIsFullDay { get; private set; }
        public DateTime DropOffDateStart { get; private set; }
        public DateTime DropOffDateEnd { get; private set; }
        public bool DropOffIsFullDay { get; private set; }
        public bool HasDangerousGoods { get; private set; }
        public CargoStatus Status { get; private set; }

        private readonly List<Claim> _Claims;
        public virtual IReadOnlyCollection<Claim> Claims { get; private set; }


        //CONSTRUCTOR
        public Cargo(
            string cargoIdNumber,
            Company company,
            Terminal terminalOrigin,
            Terminal terminalDestination,
            decimal requestedPrice,
            DateTime pickUpDateStart,
            DateTime pickUpDateEnd,
            bool pickUpIsFullDay,
            DateTime dropOffDateStart,
            DateTime dropOffDateEnd,
            bool dropOffIsFullDay,
            CargoStatus status,
            Quay quayOrigin = null,
            Quay quayDestination = null,
            bool hasDangerousGoods = false,
            bool isFixedPrice = true)
        {
            CargoIdNumber = cargoIdNumber;
            Company = company;
            CompanyId = Company.Id;
            TerminalOrigin = terminalOrigin;
            TerminalDestination = terminalDestination;
            QuayOrigin = quayOrigin;
            QuayDestination = quayDestination;
            CreditsCost = 1; // CALCULATED VALUE
            RequestedPrice = requestedPrice;
            IsFixedPrice = isFixedPrice;
            SetPickUpTimes(pickUpDateStart, pickUpDateEnd, pickUpIsFullDay);
            SetDropOffTimes(dropOffDateStart, dropOffDateEnd, dropOffIsFullDay);
            HasDangerousGoods = hasDangerousGoods;
            Status = status;
            Claims = new List<Claim>();
        }

        //PRIVATE HELPER METHODS
        private void SetPickUpTimes(DateTime pickUpDateStart, DateTime pickUpDateEnd, bool pickUpIsFullDay) {
            if (pickUpIsFullDay || (pickUpDateStart == pickUpDateStart.Date && pickUpDateEnd == pickUpDateEnd.Date.AddSeconds(-1)))
            {
                PickUpIsFullDay = true;
                SetFullDay(pickUpDateStart);
            }
            else
            {
                PickUpDateStart = pickUpDateStart;
                PickUpDateEnd = pickUpDateEnd;
            }
        }

        private void SetDropOffTimes(DateTime dropOffDateStart, DateTime dropOffDateEnd, bool dropOffIsFullDay) {
            if (dropOffIsFullDay || (dropOffDateStart == dropOffDateStart.Date && dropOffDateEnd == dropOffDateEnd.Date.AddSeconds(-1)))
            {
                DropOffIsFullDay = true;
                SetFullDay(dropOffDateStart);
            }
            else
            {
                DropOffDateStart = dropOffDateStart;
                DropOffDateEnd = dropOffDateEnd;
            }
        }

        private void SetFullDay(DateTime dateTime)
        {
            PickUpDateStart = dateTime.Date;
            PickUpDateEnd = dateTime.Date.AddSeconds(-1);
        }
    }
}

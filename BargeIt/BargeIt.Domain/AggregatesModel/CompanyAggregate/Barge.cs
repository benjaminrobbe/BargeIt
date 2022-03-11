using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class Barge : Entity
    {
        public string IdNumber { get; private set; }
        public string Captain { get; private set; }
        public int MaxTEU { get; private set; }
        public string PhoneNumber { get; private set; }

        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        public Barge
        (
            string idNumber,
            string captain,
            int maxTeu,
            string phoneNumber,
            Company company
        )
        {
            IdNumber = idNumber;
            Captain = captain;
            MaxTEU = maxTeu;
            PhoneNumber = phoneNumber;
            Company = company;
        }

    }
}

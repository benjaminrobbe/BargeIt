using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class Barge : ITrackableEntity
    {

        public int Id { get; private set; }
        public string IdNumber { get; private set; }
        public string Captain { get; private set; }
        public int MaxTeu { get; private set; }
        public string Phone { get; private set; }
        public virtual Company Company { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Barge(int id, string idNumber, string captain, int maxTeu, string phone, Company company)
        {
            Id = id;
            IdNumber = idNumber;
            Captain = captain;
            MaxTeu = maxTeu;
            Phone = phone;
            Company = company;
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

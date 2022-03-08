using System;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.Enums;
namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class Company : ITrackableEntity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public CompanyType Type { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string Postal { get; private set; }
        public string VAT { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Company(int id, string name, string email, CompanyType type, string street, int number, string city, string postal, string vat)
        {
            Id = id;
            Name = name;
            Email = email;
            Type = type;
            Street = street;
            Number = number;
            City = city;
            Postal = postal;
            VAT = vat;
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

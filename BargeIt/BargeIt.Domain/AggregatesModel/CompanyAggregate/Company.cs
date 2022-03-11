using System;
using System.Collections.Generic;
using BargeIt.Domain.AggregatesModel.CargoAggregate;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.Enums;

namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class Company : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public CompanyType Type { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string Postal { get; private set; }
        public string VAT { get; private set; }

        private readonly List<User> _users;
        public virtual IReadOnlyCollection<User> Users { get; private set; }

        private readonly List<Barge> _barges;
        public virtual IReadOnlyCollection<Barge> Barges { get; private set; }

        public Company
        (
            string name,
            string email,
            CompanyType type,
            string street,
            int number,
            string city,
            string postal,
            string vat
        )
        {
            Name = name;
            Email = email;
            Type = type;
            Street = street;
            Number = number;
            City = city;
            Postal = postal;
            VAT = vat;
            
        }
    }
}

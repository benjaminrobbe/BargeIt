using System;
using BargeIt.Domain.SeedWork;
using Microsoft.AspNetCore.Identity;

namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class User : IdentityUser<int>, ITrackableEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        //public string Email { get; private set; }
        public bool Enabled { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public int CompanyId { get; private set; }
        public Company Company { get; private set; }

        public string SetPasswordToken { get; private set; }

        public User
        (
            string firstname,
            string lastname
            //string email
        )
        {
            FirstName = firstname;
            LastName = lastname;
            //Email = email;
            Enabled = true;
        }

        public User SetEnabled(bool enabled)
        {
            Enabled = enabled;
            return this;
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

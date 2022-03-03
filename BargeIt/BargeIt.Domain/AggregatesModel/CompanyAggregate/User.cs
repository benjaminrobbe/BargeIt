using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.CompanyAggregate
{
    public class User : ITrackableEntity
    {

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public bool Enabled { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public string SetPasswordToken { get; private set; }

        public User(int id, string firstname, string lastname, string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Enabled = true;
        }

        public void setPasswordHash (string password)
        {
            string encryptedPassword = EncryptPassword(password);
            SetPasswordToken = password;
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

        private string EncryptPassword(string password)
        {
            return password + "1234";
        }

    }
}

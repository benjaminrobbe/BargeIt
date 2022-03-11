using System;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Message : Entity
    {
        public string Content { get; private set; }
        public DateTime Date { get; private set; }
        public bool IsSystemMessage { get; private set; }

        public int SenderId { get; private set; }
        public User Sender { get; private set; }

        public int ClaimId { get; private set; }
        public Claim Claim { get; private set; }

        public Message(
            string content,
            DateTime date,
            User sender,
            Claim claim,
            bool isSystemMessage = false)
        {
            Content = content;
            Date = date;
            IsSystemMessage = isSystemMessage;
            Sender = sender;
            SenderId = Sender.Id;
            Claim = claim;
            ClaimId = Claim.Id;
        }
    }
}

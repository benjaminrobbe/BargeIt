using System;
using BargeIt.Domain.AggregatesModel.CompanyAggregate;

namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Message
    {

        public int Id { get; private set; }
        public string Content { get; private set; }
        public DateTime Date { get; private set; }
        public bool IsSystemMessage { get; private set; }
        public virtual User Sender { get; private set; }
        public virtual Claim Claim { get; private set; }

        public Message(int id, string content, DateTime date, User sender, Claim claim, bool isSystemMessage = false)
        {
            Id = id;
            Content = content;
            Date = date;
            IsSystemMessage = isSystemMessage;
            Sender = sender;
            Claim = claim;
        }
    }
}

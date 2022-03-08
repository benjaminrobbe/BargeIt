using System;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.Enums;
namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Container : ITrackableEntity
    {
        //FIELDS
        public int Id { get; private set; }
        public ContainerType Type { get; private set; }
        public int Amount { get; private set; }
        public int TotalWeight { get; private set; }
        public int Teu { get; private set; }
        public virtual Cargo Cargo { get; private set; }

        //INTERFACE PROPERTIES ITrackableEntity
        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        //CONSTRUCTOR
        public Container(int id, ContainerType type, int amount, int totalWeight, int teu, Cargo cargo)
        {
            Id = id;
            Type = type;
            Amount = amount;
            TotalWeight = totalWeight;
            Teu = teu;
            Cargo = cargo;
        }

        //INTERFACE METHODS
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

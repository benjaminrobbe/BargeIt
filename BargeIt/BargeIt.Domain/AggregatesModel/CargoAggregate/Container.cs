using System;
using BargeIt.Domain.SeedWork;
namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{

    public enum ContainerType
    {
        _20_feet,
        _40_feet,
        _40_feet_high_cube,
    }

    public class Container : ITrackableEntity
    {

        public int Id { get; private set; }
        public ContainerType Type { get; private set; }
        public int Amount { get; private set; }
        public int TotalWeight { get; private set; }
        public int Teu { get; private set; }
        public virtual Cargo Cargo { get; private set; }

        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

        public Container(int id, ContainerType type, int amount, int totalWeight, int teu, Cargo cargo)
        {
            Id = id;
            Type = type;
            Amount = amount;
            TotalWeight = totalWeight;
            Teu = teu;
            Cargo = cargo;
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

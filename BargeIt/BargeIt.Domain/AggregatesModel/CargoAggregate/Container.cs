using System;
using BargeIt.Domain.SeedWork;
using BargeIt.Domain.Enums;
namespace BargeIt.Domain.AggregatesModel.CargoAggregate
{
    public class Container : Entity
    {
        public ContainerType Type { get; private set; }
        public int Amount { get; private set; }
        public int TotalWeight { get; private set; }
        public int TEU { get; private set; }

        public int CargoId { get; private set; }
        public Cargo Cargo { get; private set; }

        public Container(
            ContainerType type,
            int amount,
            int totalWeight,
            int teu,
            Cargo cargo)
        {
            Type = type;
            Amount = amount;
            TotalWeight = totalWeight;
            TEU = teu;
            Cargo = cargo;
            CargoId = Cargo.Id;
        }
    }
}

using System;
namespace BargeIt.Domain.SeedWork
{
    public interface ITrackableEntity
    {
        DateTime Created { get; }
        DateTime? Modified { get; }
        void IsCreated();
        void IsModified();
    }
}

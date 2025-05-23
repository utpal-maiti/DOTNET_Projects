﻿namespace APIConcepts.Services.TransientScopedSingleton
{
    public interface ITransientService
    {
        Guid GetOperationID();
    }
    public interface IScopedService
    {
        Guid GetOperationID();
    }
    public interface ISingletonService
    {
        Guid GetOperationID();
    }

    public class OperationService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}

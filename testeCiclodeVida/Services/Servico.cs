using System;
namespace testeCiclodeVida.Services
{
   
        public class Servico : ITransientService, IScopedService, ISingletonService
        {
            Guid id;
            public Servico()
            {
                id = Guid.NewGuid();
            }

            public Guid GetID()
            {
                return id;
            }
        }

        public interface ITransientService
        {
            Guid GetID();
        }

        public interface IScopedService
        {
            Guid GetID();
        }

        public interface ISingletonService
        {
            Guid GetID();
        }
    
}


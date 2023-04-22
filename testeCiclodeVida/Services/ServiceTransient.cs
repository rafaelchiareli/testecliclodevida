using System;
using testeCiclodeVida.Interfaces;

namespace testeCiclodeVida.Services
{
    public class ServiceTransient : IServiceTransient

    {
        public ServiceTransient()
        {
        }

        public Guid gerarGuid()
        {
            return Guid.NewGuid();
        }
    }
}


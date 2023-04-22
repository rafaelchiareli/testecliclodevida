using System;
using testeCiclodeVida.Interfaces;

namespace testeCiclodeVida.Services
{
    public class ServiceSingleton : IServiceSingleton
    {
        public ServiceSingleton()
        {
        }

        public Guid gerarGuid()
        {
            return Guid.NewGuid();
        }
    }
}


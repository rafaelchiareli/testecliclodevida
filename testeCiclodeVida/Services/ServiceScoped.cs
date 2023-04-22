using System;
using testeCiclodeVida.Interfaces;

namespace testeCiclodeVida.Services
{
    public class ServiceScoped : IServiceScoped
    {
        public ServiceScoped()
        {
        }

        public Guid gerarGuid()
        {
            return Guid.NewGuid();
        }
    }
}


using MD.Application.Interfaces;
using MD.Application.Service;
using MD.Domain.Interfaces.Repository;
using MD.Domain.Interfaces.Services;
using MD.Domain.Services;
using MD.Infra.Data.Repository;
using SimpleInjector;

namespace MD.Infra.CrossCutting.IOC
{
    public class BootStraper
    {

        /*
         * Lifestyle.Transient = Uma instância para cada solicitação.
         * Lifestyle.Singleton = Uma instância única para a classe.
         * Lifestyle.Scoped = Uma instância única para o request.
         */
        public static void Register(Container pobContainer)
        {
            // Camada de Aplicação
            pobContainer.Register<ITipoHistoriaAppService, TipoHistoriaAppService>(Lifestyle.Scoped);

            // Domínio
            pobContainer.Register<ITipoHistoriaService, TipoHistoriaService>(Lifestyle.Scoped);

            // Data
            pobContainer.Register<ITipoHistoriaRepository, TipoHistoriaRepository>(Lifestyle.Scoped);

        }

    }
}

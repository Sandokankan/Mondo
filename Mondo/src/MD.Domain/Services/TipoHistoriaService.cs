using MD.Domain.Entities;
using MD.Domain.Interfaces.Services;
using MD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Services
{
    public class TipoHistoriaService : ITipoHistoriaService
    {
        private readonly ITipoHistoriaRepository _TipoHistoriaRepository;

        public TipoHistoriaService(ITipoHistoriaRepository pobTipoHistoriaRepository)
        {
            _TipoHistoriaRepository = pobTipoHistoriaRepository;
        }

        public TipoHistoria Adicionar(TipoHistoria pObjeto)
        {
            return _TipoHistoriaRepository.Adicionar(pObjeto);
        }

        public TipoHistoria Atualizar(TipoHistoria pObjeto)
        {
            return _TipoHistoriaRepository.Atualizar(pObjeto);
        }

        public void Desativar(Guid pIdTipoHistoria)
        {
            _TipoHistoriaRepository.Desativar(pIdTipoHistoria);
        }

        public void Dispose()
        {
            _TipoHistoriaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TipoHistoria> ObterAtivos()
        {
            return _TipoHistoriaRepository.ObterAtivos();
        }

        public TipoHistoria ObterPorID(Guid pID)
        {
            return _TipoHistoriaRepository.ObterPorID(pID);
        }

        public TipoHistoria ObterPorTitulo(string pstTitulo)
        {
            return _TipoHistoriaRepository.ObterPorTitulo(pstTitulo);
        }

        public IEnumerable<TipoHistoria> ObterTodos()
        {
            return _TipoHistoriaRepository.ObterTodos();
        }
    }
}

using MD.Application.Interfaces;
using MD.Application.ViewModels;
using MD.Domain.Interfaces.Repository;
using MD.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MD.Domain.Entities;

namespace MD.Application.Service
{
    public class HistoriaAppService : IHistoriaAppService
    {
        private readonly IHistoriaRepository _historiaRepository;

        public HistoriaAppService()
        {
            _historiaRepository = new HistoriaRepository();
        }

        public HistoriaViewModel Adicionar(HistoriaViewModel pHistoria)
        {
            var obHistoriaD = Mapper.Map<Historia>(pHistoria);
            return Mapper.Map<HistoriaViewModel>(_historiaRepository.Adicionar(obHistoriaD));
        }

        public HistoriaViewModel Atualizar(HistoriaViewModel pHistoria)
        {
            var obHistoriaD = Mapper.Map<Historia>(pHistoria);
            return Mapper.Map<HistoriaViewModel>(_historiaRepository.Atualizar(obHistoriaD));
        }

        public void Desativar(Guid pIdHistoria)
        {
            _historiaRepository.Desativar(pIdHistoria);
        }

        public void Dispose()
        {
            _historiaRepository.Dispose();
            GC.SuppressFinalize(_historiaRepository);
        }

        public HistoriaViewModel ObterPorId(Guid pIdHistoria)
        {
            return Mapper.Map<HistoriaViewModel>(_historiaRepository.ObterPorID(pIdHistoria));
        }

        public IEnumerable<HistoriaViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<HistoriaViewModel>>(_historiaRepository.ObterTodos());
        }
    }
}

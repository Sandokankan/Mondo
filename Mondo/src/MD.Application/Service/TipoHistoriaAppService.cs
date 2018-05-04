using AutoMapper;
using MD.Application.Interfaces;
using MD.Application.ViewModels;
using MD.Domain.Entities;
using MD.Domain.Interfaces.Repository;
using MD.Domain.Interfaces.Services;
using MD.Infra.Data.Repository;
using System;
using System.Collections.Generic;

namespace MD.Application.Service
{
    public class TipoHistoriaAppService : ITipoHistoriaAppService
    {

        private readonly ITipoHistoriaService _TipoHistoriaService;

        public TipoHistoriaAppService(ITipoHistoriaService pobTipoHistoriaService)
        {
            _TipoHistoriaService = pobTipoHistoriaService;
        }

        public TipoHistoriaViewModel Adicionar(TipoHistoriaViewModel pTipoHistoria)
        {
            var obTipoHistoriaDomain = Mapper.Map<TipoHistoria>(pTipoHistoria);
            return Mapper.Map<TipoHistoriaViewModel>(_TipoHistoriaService.Adicionar(obTipoHistoriaDomain));
        }

        public TipoHistoriaViewModel Atualizar(TipoHistoriaViewModel pTipoHistoria)
        {
            var obTipoHistoriaDomain = Mapper.Map<TipoHistoria>(pTipoHistoria);
            return Mapper.Map<TipoHistoriaViewModel>(_TipoHistoriaService.Atualizar(obTipoHistoriaDomain));
        }

        public void Desativar(Guid pIdTipoHistoria)
        {
            _TipoHistoriaService.Desativar(pIdTipoHistoria);
        }

        public void Dispose()
        {
            _TipoHistoriaService.Dispose();
            GC.SuppressFinalize(_TipoHistoriaService);
        }

        public TipoHistoriaViewModel ObterPorId(Guid pIdTipoHistoria)
        {
            return Mapper.Map<TipoHistoriaViewModel>(_TipoHistoriaService.ObterPorID(pIdTipoHistoria));
        }

        public IEnumerable<TipoHistoriaViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<TipoHistoriaViewModel>>(_TipoHistoriaService.ObterTodos());
        }
    }
}

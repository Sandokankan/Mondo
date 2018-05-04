using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MD.Application.ViewModels;
using MD.Domain.Entities;

namespace MD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<TipoHistoria, TipoHistoriaViewModel>();
            CreateMap<Historia, HistoriaViewModel>();
        }

    }
}

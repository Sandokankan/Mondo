using AutoMapper;
using MD.Application.ViewModels;
using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<TipoHistoriaViewModel, TipoHistoria>();
            CreateMap<HistoriaViewModel, Historia>();
        }
    }
}

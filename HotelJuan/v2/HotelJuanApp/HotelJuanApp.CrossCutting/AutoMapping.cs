using System;
using AutoMapper;
using HotelJuanApp.Application.ViewModels;
using HotelJuanApp.Domain.Entity;

namespace HotelJuanApp.CrossCutting
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Quarto, QuartoViewModel>();
            CreateMap<QuartoViewModel, Quarto>();     
        }        
    }
}

using AutoMapper;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Entities;

namespace ViacaoCalango.CrossCutting
{
    public class SourceMappingProfile : Profile
    {
        public SourceMappingProfile()
        {
            CreateMap<ReservaViewModel, Reserva>()
                .ForMember(dest => dest.RotaID, o => o.MapFrom(src => src.RotaID))
                .ForMember(dest => dest.TrechoOrigem, o => o.MapFrom(src => src.TrechoOrigem))
                .ForMember(dest => dest.TrechoDestino, o => o.MapFrom(src => src.TrechoDestino))
                .ForMember(dest => dest.Ida, o => o.MapFrom(src => src.Ida))
                .ForMember(dest => dest.Volta, o => o.MapFrom(src => src.Volta))
                .ForMember(dest => dest.Classe, o => o.MapFrom(src => src.Classe))
                .ForMember(dest => dest.DataIda, o => o.MapFrom(src => src.DataIda))
                .ForMember(dest => dest.DataVolta, o => o.MapFrom(src => src.DataVolta))
                .ForMember(dest => dest.HoraEmbarque, o => o.MapFrom(src => src.HoraEmbarque))
                .ForMember(dest => dest.Valor, o => o.MapFrom(src => src.Valor));

            CreateMap<Reserva, ReservaViewModel>()
                .ForMember(dest => dest.RotaID, o => o.MapFrom(src => src.RotaID))
                .ForMember(dest => dest.TrechoOrigem, o => o.MapFrom(src => src.TrechoOrigem))
                .ForMember(dest => dest.TrechoDestino, o => o.MapFrom(src => src.TrechoDestino))
                .ForMember(dest => dest.Ida, o => o.MapFrom(src => src.Ida))
                .ForMember(dest => dest.Volta, o => o.MapFrom(src => src.Volta))
                .ForMember(dest => dest.Classe, o => o.MapFrom(src => src.Classe))
                .ForMember(dest => dest.DataIda, o => o.MapFrom(src => src.DataIda))
                .ForMember(dest => dest.DataVolta, o => o.MapFrom(src => src.DataVolta))
                .ForMember(dest => dest.HoraEmbarque, o => o.MapFrom(src => src.HoraEmbarque))
                .ForMember(dest => dest.Valor, o => o.MapFrom(src => src.Valor));
        }
    }
}
using AutoMapper;
using JogoDaVelha.Negocios.Dto;
using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace JogoDaVelha.WebApi.Mappers
{
    public class AutomapperConfig: Profile
    {
        public AutomapperConfig()
        {
            CreateMap<JogadorDto, JogadorViewModel>().ReverseMap();
            CreateMap<PartidaDto, PartidaViewModel>().ReverseMap();
            CreateMap<SituacaoDto, SituacaoViewModel>().ReverseMap();
            CreateMap<TabuleiroDto, TabuleiroViewModel>().ReverseMap();
        }
    }
}

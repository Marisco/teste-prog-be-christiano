using AutoMapper;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.WebApi.ViewModels;

namespace JogoDaVelha.WebApi.Mappers
{
    public class AutomapperConfig: Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Jogador, JogadorViewModel>().ReverseMap();
            CreateMap<Partida, PartidaViewModel>().ReverseMap();
            CreateMap<Situacao, SituacaoViewModel>().ReverseMap();
            CreateMap<Tabuleiro, TabuleiroViewModel>().ReverseMap();
        }
    }
}

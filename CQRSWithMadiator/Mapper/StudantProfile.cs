using AutoMapper;
using CQRSWithMadiator.Models;
using CQRSWithMadiator.queries;

namespace CQRSWithMadiator.Mapper
{
    public class StudantProfile : Profile
    {
        public StudantProfile()
        {
            CreateMap<Studant, StudantQueryResult>().ReverseMap();
        }
    }
}

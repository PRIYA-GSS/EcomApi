using AutoMapper;
using Entity = EcomApi.DataAccess.Entities;
using Dto = EcomApi.Models.DTOs ;
namespace EcomApi.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Entity.Product, Dto.Product>().ReverseMap();
            CreateMap<Entity.User, Dto.User>().ReverseMap();
            CreateMap<Entity.Order, Dto.Order>().ReverseMap();
        }
    }
}

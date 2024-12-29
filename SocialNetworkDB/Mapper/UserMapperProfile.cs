using SocialNetworkDB.Models;
using AutoMapper;

namespace SocialNetworkDB.Mapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<RegisterViewModel, User>(); // Пример маппинга
        }
    }
}

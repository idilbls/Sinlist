using AutoMapper;
using Sinlist.Core.Entities.Lists;
using Sinlist.Shared.Lists;

namespace Sinlist.Api.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<List, ListDto>();
            CreateMap<ListDto, List>();

            CreateMap<ListItem, ListItemDto>();
            CreateMap<ListItemDto, ListItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace ApiForRestaurentDashboard.Utils
{
    public class AdminMapperConfiguration : Profile
    {
        public AdminMapperConfiguration()
        {
            //CreateMap<WrPickupListModel, WRPickupList>()
            //     .ForMember(dest => dest.WRPickupListProducts, mo => mo.Ignore())
            //     .ForMember(dest => dest.Customer, mo => mo.Ignore());

        }
    }
}

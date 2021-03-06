using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekseatWitch.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Villager, VillagerModel>();
            CreateMap<VillagerModel, Villager>();
        }
    }
}

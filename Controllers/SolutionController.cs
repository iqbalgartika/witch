using AutoMapper;
using GeekseatWitch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekseatWitch.Controllers
{
    [Route("api")]
    [ApiController]
    public class SolutionController : ControllerBase
    {
        private readonly IMapper _mapper;

        // Assign the object in the constructor for dependency injection
        public SolutionController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        [Route("banishTheWitch")]
        public decimal banishTheWitch(List<VillagerModel> models)
        {
            try
            {
                List<Villager> villagers = _mapper.Map<List<Villager>>(models);
                return WitchAlgorithm.AvgKills(villagers);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}

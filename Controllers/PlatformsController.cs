using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;

namespace PlatformService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo repo;
        private readonly IMapper mapper;

        public PlatformsController(IPlatformRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPlatforms()
        {
            Console.WriteLine("--> Getting platforms...");
            var platformItem = repo.GetAllPlatform();
            return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(platformItem));
        }
    }
}

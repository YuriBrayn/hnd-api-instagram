using hnd.api.instagram.Models;
using hnd.api.instagram.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Linq;
using System;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Filters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hnd.api.instagram.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [Produces("application/json")] 
    public class TargetController : ControllerBase
    {
        private readonly ITargetRepository _targetRepository;
        public TargetController(ITargetRepository targetRepository)
        {
            _targetRepository = targetRepository;
        }

        [HttpGet]
        [Produces(typeof(Target))]
        private IActionResult Get()
        {
            var targets = _targetRepository.Get();
            if (targets.Count() == 0)
                return NoContent();
            return Ok(targets);
        }

    }
}
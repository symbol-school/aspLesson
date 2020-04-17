using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspLesson.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspLesson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FarmController : ControllerBase
    {

        private readonly ILogger<FarmController> _logger;
        private readonly FarmStorageService _farmStorage;

        public FarmController(ILogger<FarmController> logger, FarmStorageService farmStorage)
        {
            _logger = logger;
            _farmStorage = farmStorage;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Services;
using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private ICardsService _service;

        public CardsController(ICardsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Card> GetAll()
        {
            return _service.FetchCards();
        }
    }
}

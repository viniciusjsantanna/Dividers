using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dividers.Application.CQRS.Dividers.Commands.Calculate;
using Dividers.Application.DTO;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dividers.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DividerController : ControllerBase
    {
        public readonly IMediator mediator;
        public DividerController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public Task<Response> CalculateDividers([FromBody] CalculateDividersCommand command)
        {
            return mediator.Send(command);
        }

    }
}

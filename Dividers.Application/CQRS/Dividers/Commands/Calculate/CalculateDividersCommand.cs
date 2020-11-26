using Dividers.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dividers.Application.CQRS.Dividers.Commands.Calculate
{
    public class CalculateDividersCommand : IRequest<Response>
    {
        public int Number { get; set; }
    }
}

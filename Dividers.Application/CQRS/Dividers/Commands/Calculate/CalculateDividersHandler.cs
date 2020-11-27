using Dividers.Application.DTO;
using Dividers.Application.DTO.Dividers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dividers.Application.CQRS.Dividers.Commands.Calculate
{
    public class CalculateDividersHandler : IRequestHandler<CalculateDividersCommand, Response>
    {
        public CalculateDividersHandler(Response response)
        {
            this.response = response;
        }
        public Response response { get; set; }
        public Task<Response> Handle(CalculateDividersCommand request, CancellationToken cancellationToken)
        {
            if(request.Number == 0)
            {
                return response.Generate(message: Constants.ErrorMessage, hasError: true);
            }
            var numbers = new NumbersDTO();
            var dividirs = new List<string>();
            var listNumber = new List<int>();
            var counter = request.Number - 1;
            for (int i = counter; i > 0; i--)
            {
                if (request.Number % i == 0)
                {
                    listNumber.Add(i);
                }
            }

            numbers.Dividers = listNumber;
            numbers.Primes = listNumber.Where(e => IsPrime(e)).ToList();
            return response.Generate(result: numbers);
        }

        private bool IsPrime(int number)
        {
            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if ((number % i) == 0)
                    isPrime = false;
            }
            return isPrime;
        }
    }
}

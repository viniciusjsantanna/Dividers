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
        const int MAX_SIZE = 15000;
        public Task<Response> Handle(CalculateDividersCommand request, CancellationToken cancellationToken)
        {
            var numbers = new NumbersDTO();
            var divisores = new List<string>();
            var numeros = new List<int>();
            var contador = request.Number - 1;
            for (int i = contador; i > 0; i--)
            {
                if (request.Number % i == 0)
                {
                    numeros.Add(i);
                }
            }

            var primos = numeros.Where(e => IsNumeroPrimo(e)).ToList();
            numbers.Dividers = numeros;
            numbers.Primes = primos;
            return response.Generate(result: numbers);
        }

        private bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }
    }
}

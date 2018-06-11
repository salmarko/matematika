using Matematika.Models;
using System.Collections.Generic;

namespace Matematika.Services
{
    public class CalculationService : ICalculationService
    {
        public List<Calculation> GenerateNumberPairs()
        {
            var list = new List<Calculation>();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var calculation = new Calculation(i, j);
                    list.Add(calculation);
                }
            }

            return list;
        }
    }
}

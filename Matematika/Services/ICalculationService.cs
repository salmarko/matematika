using Matematika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matematika.Services
{
    public interface ICalculationService
    {
        List<Calculation> GenerateNumberPairs();
    }
}

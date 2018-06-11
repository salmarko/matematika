using Matematika.Models;
using System.Collections.Generic;

namespace Matematika.Services
{
    public interface ISessionService
    {
        List<Calculation> Numbers { get; set; }
        int Score { get; set; }
    }
}

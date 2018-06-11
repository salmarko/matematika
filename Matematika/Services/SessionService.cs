using Matematika.Extensions;
using Matematika.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matematika.Services
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        private ISession Session
        {
            get
            {
                return httpContextAccessor.HttpContext.Session;
            }
        }

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public List<Calculation> Numbers
        {
            get
            {
                return Session.GetObjectFromJson<List<Calculation>>(nameof(Numbers));
            }
            set
            {
                Session.SetObjectAsJson(nameof(Numbers), value);
            }
        }

        public int Score
        {
            get
            {
                return Session.GetInt32(nameof(Score)).GetValueOrDefault();
            }
            set
            {
                Session.SetInt32(nameof(Score), value);
            }
        }
    }
}

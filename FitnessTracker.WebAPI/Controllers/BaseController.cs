using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.EFDataAccess.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.WebAPI.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private protected FitnessTrackerContext ctx;

        public BaseController(FitnessTrackerContext ctx)
        {
            this.ctx = ctx;
        }
    }
}

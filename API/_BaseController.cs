using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football4.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Football4
{
    public class BaseController : Controller
    {
        protected MyDbContext DB;

        public BaseController(MyDbContext _db)
        {
            DB = _db;
        }

    }
}

using DAL3;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : Controller
    {
        [HttpGet("getWorkers")]
        public List<Worker> GetAllWorkers() 
        {
            return new List<Worker>()
           {
               new Worker()
               {
                   Id = new Random().Next(100),
                   Name = "Руслан",
                   SecondName = "Садыков"
               },
               new Worker()
               {
                   Id = new Random().Next(100),
                   Name = "Илья",
                   SecondName = "Медведев"
               },
               new Worker()
               {
                   Id = new Random().Next(100),
                   Name = "Алексей",
                   SecondName = "Дмитриев"
               }
           };
        }
    }
}

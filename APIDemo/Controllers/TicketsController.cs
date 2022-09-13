using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDemo.Services;
using APIDemo.Models;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
            public List<Ticket> Get()
        {
            return TicketService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Ticket GetTicket(int id)
        {
            Ticket t = TicketService.Get(id);
            return t;
        }
    }
}

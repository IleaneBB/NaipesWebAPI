using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NaipesWebAPI.Data;
using NaipesWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaipesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarajaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BarajaController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Naipe>>GetNaipe()
        {
            var list = await _context.Naipe.ToListAsync();
            var max = list.Count;
            int index = new Random().Next(0, max);
            var Naipe = list[index];
            if( Naipe  == null)
            {
                return NoContent();
            }
            return Naipe;

        }
    }
}

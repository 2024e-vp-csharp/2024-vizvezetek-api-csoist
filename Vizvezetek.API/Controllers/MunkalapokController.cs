using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Vizvezetek.API.DTOs;
using Vizvezetek.API.Models;
using Vizvezetek.API.Conversion;
using System.Security.Cryptography.X509Certificates;

namespace Vizvezetek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunkalapokController : ControllerBase
    {
        private readonly vizvezetekContext _context;

        public MunkalapokController(vizvezetekContext context)
        {
            _context = context;
        }

        // GET api/Munkalapok
        [HttpGet]
        public async Task<ActionResult<IEnumerable<munkalapDTO>>> GetMunkalap()
        {
            var munkalapok = await _context.munkalap.Include(x => x.hely).Include(x => x.szerelo).ToListAsync();
            return munkalapok.ToDTO();
        }

        // GET api/Munkalapok/id
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<munkalapDTO>>> GetMunkalapById(int id)
        {
            var munkalapok = await _context.munkalap.Include(x => x.hely).Include(x => x.szerelo).Where(x => x.id == id).ToListAsync();
            return munkalapok.ToDTO();
        }

    }
}

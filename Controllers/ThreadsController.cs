using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BotApi.Models;

namespace BotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThreadsController : ControllerBase
    {
        private readonly DbChatBotContext _context;
        public ThreadsController(DbChatBotContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Thread>>> GetThreads()
        {
            return await _context.Threads.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Thread>> PostThread(ThreadDto thread)
        {
            var model = new Thread()
            {
                Id = thread.Id
            };
            await _context.Threads.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

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
    public class MessagesController : ControllerBase
    {
        private readonly DbChatBotContext _context;
        public MessagesController(DbChatBotContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        {
            return await _context.Messages.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(MessageDto message)
        {
            message.MessageDate = DateTime.Now;
            var model = new Message()
            {
                Id =  message.Id,
                ThreadId = message.ThreadId,
                Text = message.Text,
                UserId = message.UserId,
                ChannelName = message.ChannelName,
                MessageDate = message.MessageDate,
                UserName = message.UserName
            };
            await _context.Messages.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<Message>> PutMessage(MessageUpdateDto message)
        {
            var model = await _context.Messages.FirstOrDefaultAsync(x=> x.Id == message.Id);
            model.Text = message.Text;
            _context.Messages.Update(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

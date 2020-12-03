using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BotApi.Models
{
    public class DbChatBotContext: DbContext
    {
        public DbChatBotContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotApi.Models
{
    public class MessageDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public string ChannelName { get; set; }
        public DateTime MessageDate { get; set; }
        public string ThreadId { get; set; }
    }
}

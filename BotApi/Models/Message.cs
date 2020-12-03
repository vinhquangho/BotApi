using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BotApi.Models
{
    public class Message
    {
        [Key]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string ChannelName { get; set; }
        public DateTime MessageDate { get; set; }
        public string Text { get; set; }
        public string ThreadId { get; set; }
        public Thread Thread { get; set; }
    }
}

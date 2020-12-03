using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BotApi.Models
{
    public class Thread
    {
        [Key]
        public string Id { get; set; }
        public List<Message> Message { get; set; }
    }
}

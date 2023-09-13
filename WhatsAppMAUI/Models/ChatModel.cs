using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppMAUI.Models
{
    //public class ChatModel
    //{
    //    public string Avatar { get; set; }
    //    public string Name { get; set; }
    //    public DateTime LastMessageAt { get; set; }
    //    public int UnreadCount { get; set; }
    //}
    public record ChatModel(string Avatar, string Name, string LastMessage, DateTime LastMessageAt, int UnreadCount)
    {
        public string LastMessageAtDisplay => $"{LastMessageAt:HH:mm}";
    }
}

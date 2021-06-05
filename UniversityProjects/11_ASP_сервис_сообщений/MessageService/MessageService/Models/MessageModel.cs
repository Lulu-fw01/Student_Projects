using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MessageService.Models
{
    [Serializable]
    public class MessageModel
    {
        /// <summary>
        /// Тема сообщения.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Текст сообщения.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Id отправителя.
        /// </summary>
        public int SenderId { get; }

        /// <summary>
        /// Id получателя.
        /// </summary>
        public int ReceiverId { get; }

        public MessageModel(string theme, string text, int senderId, int recipientId)
        {
            Subject = theme;
            Text = text;
            SenderId = senderId;
            ReceiverId = recipientId;
        }

    }
}

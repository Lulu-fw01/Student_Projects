using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace MessageService.Models
{
    /// <summary>
    /// Модель для описания сообщения.
    /// </summary>
    [Serializable]
    public class MessageModel: IDataworker<MessageModel>
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
        [Required()]
        public string SenderEmail { get; }

        /// <summary>
        /// Id получателя.
        /// </summary>
        [Required()]
        public string ReceiverEmail { get; }

        /// <summary>
        /// Конструктор для создания сообщения.
        /// </summary>
        /// <param name="subject">
        /// Тема сообщения.
        /// </param>
        /// <param name="text">
        /// Текст сообщения.
        /// </param>
        /// <param name="senderEmail">
        /// Email отправителя.
        /// </param>
        /// <param name="receiverEmail">
        /// Email получателя.
        /// </param>
        public MessageModel(string subject, string text, string senderEmail, string receiverEmail)
        {
            Subject = subject;
            Text = text;
            SenderEmail = senderEmail;
            ReceiverEmail = receiverEmail;
        }

        static MessageModel()
        {
            messagesPath = @$"./data{Path.DirectorySeparatorChar}messages.json";
        }

        static string messagesPath;

        /// <summary>
        /// Загрузка сообщений.
        /// </summary>
        /// <returns></returns>
        public static List<MessageModel> GetMessages() => IDataworker<MessageModel>.LoadData(messagesPath);

        /// <summary>
        /// Сохранение сообщений.
        /// </summary>
        /// <param name="messages"></param>
        public static void SaveMessages(List<MessageModel> messages) => IDataworker<MessageModel>.SaveData(messagesPath, messages);
    }
}

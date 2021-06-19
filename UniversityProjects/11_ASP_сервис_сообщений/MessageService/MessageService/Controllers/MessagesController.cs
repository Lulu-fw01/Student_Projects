using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using MessageService.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MessageService.Controllers
{
    /// <summary>
    /// Контроллер для работы с сообщениями.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly ILogger<MessagesController> _logger;

        public MessagesController(ILogger<MessagesController> logger)
        {
            _logger = logger;
        }


        static Random rand;
        static MessagesController()
        {
            rand = new Random();
        }

        /// <summary>
        /// Создание рандомных сообщений.
        /// </summary>
        /// <returns></returns>
        [HttpPost("CreateMessages")]
        public IActionResult PostMessages()
        {
            try
            {
                var users = UserModel.GetUsers();
                if (users.Count < 2)
                    return NotFound("Not enought users((");

                var rnd = new Random();
                var messages = MessageModel.GetMessages();
                for(int i = 0; i < 10; i++)
                {
                    int u1 = rnd.Next(0, users.Count);
                    int u2 = rnd.Next(0, users.Count);
                    while(u1 == u2)
                    {
                        u1 = rnd.Next(0, users.Count);
                        u2 = rnd.Next(0, users.Count);
                    }
                    messages.Add(RandomStringBuilder.CreateRandomMessage(users[u1].Email, users[u2].Email));
                }

                MessageModel.SaveMessages(messages);
                return Ok("OK: 10 random messages were created");
            }
            catch 
            {
                return NotFound();
                    
            }
        }

        /// <summary>
        /// Получение сообщений по Email отправителя и получателя.
        /// </summary>
        /// <param name="senderEmail">
        /// Email отправителя.
        /// </param>
        /// <param name="receiverEmail">
        /// Email получателя. 
        /// </param>
        /// <returns></returns>
        [HttpGet("GetMessagesByEmails/{senderEmail}/{receiverEmail}", Name = "GetMessagesByEmails")]
        public IActionResult GetMessages([FromRoute]string senderEmail, [FromRoute]string receiverEmail)
        {
            try
            {
                var messages = MessageModel.GetMessages();
                var ans = from m in messages
                          where m.ReceiverEmail == receiverEmail && m.SenderEmail == senderEmail
                          select m;
                if (ans.Count() == 0)
                    return NotFound();

                return Ok(ans);
            }
            catch 
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Получить сообщения по Email отправителя.
        /// </summary>
        /// <param name="senderEmail">
        /// Email отправителя.
        /// </param>
        /// <returns></returns>
        [HttpGet("GetMessagesBySenderEmail/{senderEmail}")]
        public IActionResult GetMessagesBySenderId([FromRoute] string senderEmail)
        {
            try
            {
                var messages = MessageModel.GetMessages();
                var ans = from m in messages
                          where m.SenderEmail == senderEmail
                          select m;
                if (ans.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"Messages with sender with email {senderEmail} not found" });

                return Ok(ans);
            }
            catch 
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Получить сообщения по Email получателя.
        /// </summary>
        /// <param name="receiverEmail">
        /// Email получателя.
        /// </param>
        /// <returns></returns>
        [HttpGet("GetMessagesByReceiverEmail/{receiverEmail}")]
        public IActionResult GetMessagesByReceiverEmail([FromRoute] string receiverEmail)
        {
            try
            {
                var messages = MessageModel.GetMessages();
                var ans = from m in messages
                          where m.ReceiverEmail == receiverEmail
                          select m;
                if (ans.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"Messages with receiver with email {receiverEmail} not found" });

                return Ok(ans);
            }
            catch
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Создание сообщения.
        /// </summary>
        /// <param name="senderEmail">
        /// Email отправителя.
        /// </param>
        /// <param name="receiverEmail">
        /// Email получателя.
        /// </param>
        /// <param name="subject">
        /// Тема сообщения.
        /// </param>
        /// <param name="text">
        /// Текст сообщения.
        /// </param>
        /// <returns></returns>
        [HttpPost("CreateMessage")]
        public IActionResult CreateMessage([FromForm][Required]string senderEmail, [FromForm][Required]string receiverEmail, [FromForm]string subject, [FromForm]string text)
        {
            try 
            {
                senderEmail = senderEmail.ToLower();
                var users = UserModel.GetUsers();
                var u1 = from u in users
                         where u.Email == senderEmail
                         select u;

                if (u1.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"User with email {senderEmail} not found" });
                var sender = u1.First();

                receiverEmail = receiverEmail.ToLower();
                var u2 = from u in users
                         where u.Email == receiverEmail
                         select u;

                if (u2.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"User with email {receiverEmail} not found" });
                var receiver = u2.First();

                subject ??= "";
                text ??= "";

                var messages = MessageModel.GetMessages();
                messages.Add(new MessageModel(subject, text, sender.Email, receiver.Email));
                MessageModel.SaveMessages(messages);
                return Ok("Message was created");
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}

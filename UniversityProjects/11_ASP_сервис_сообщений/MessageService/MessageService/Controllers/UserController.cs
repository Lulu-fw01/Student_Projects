using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MessageService.Models;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace MessageService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        static UserController()
        {
            usersPath = @$"./data{Path.DirectorySeparatorChar}users.json";
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
        static string usersPath;

        /// <summary>
        /// Считывание пользователей из файла.
        /// </summary>
        /// <returns></returns>
        private static List<UserModel> GetUsers()
        {
            var ds = Directory.GetFiles(@"./");
            List<UserModel> users;
            if (System.IO.File.Exists(usersPath))
            {

                var str = System.IO.File.ReadAllText(usersPath);
                users = JsonConvert.DeserializeObject<List<UserModel>>(str);
                var k = 7;
            }
            else
                users = new List<UserModel>();
            
            return users;
        }


        /// <summary>
        /// Создание рандомных пользователей и сообщений.
        /// </summary>
        [HttpPost("CreateBase")]
        public void PostUsersAndMessages()
        {
            var users = GetUsers();

            users.Add(new UserModel("Luka", "lulu@gmail.com"));

            var jsonString = JsonConvert.SerializeObject(users);
            System.IO.File.WriteAllText(usersPath, jsonString);
        }

        /// <summary>
        /// Получение информации о пользователе по Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("{email}", Name = "GetUserByEmail")]
        public IActionResult GetUser([FromRoute] string email)
        {
            try
            {
                var users = GetUsers();

                var user = from u in users
                           where u.Email == email
                           select u;

                if (user.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"User with email:{email} not found" });

                return Ok(user.First());
            }
            catch
            {
                // можно добавть строку.
                return NotFound();
            }
        }


    }

    
}

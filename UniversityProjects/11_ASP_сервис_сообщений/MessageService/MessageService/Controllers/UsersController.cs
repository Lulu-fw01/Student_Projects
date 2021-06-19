using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using MessageService.Models;


namespace MessageService.Controllers
{
    /// <summary>
    /// Контроллер для работы с пользователями.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Создание рандомных пользователей.
        /// </summary>
        [HttpPost("CreateBase")]
        public void CreateUsers()
        {
            var users = UserModel.GetUsers();

            for (int i = 0; i < 10; i++)
            {
                var nu = RandomStringBuilder.CreateRandomUser();
                if (users.Contains(nu))
                    i--;
                else
                    users.Add(nu);
            }

            UserModel.SaveUsers(users);
        }

        /// <summary>
        /// Получение информации о пользователе по Email.
        /// </summary>
        /// <param name="email">
        /// Email пользователя.
        /// </param>
        /// <returns></returns>
        [HttpGet("GetUserByEmail/{email}", Name = "GetUserByEmail")]
        public IActionResult GetUser([FromRoute] string email)
        {
            try
            {
                email = email.ToLower();
                var users = UserModel.GetUsers();

                var user = from u in users
                           where u.Email == email
                           select u;

                if (user.Count() == 0)
                    return NotFound(new NotFoundResponse { Message = $"User with email {email} not found" });

                return Ok(user.First());
            }
            catch
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Запрос на получение всех пользователей.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = UserModel.GetUsers();
                return Ok(users);
            }
            catch
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Вернуть несколько пользоваелей, начиная с некоторого.
        /// </summary>
        /// <param name="offset">
        /// Первый индекс диапазона.
        /// </param>
        /// <param name="limit">
        /// Максимальное количество пользователей, которых нужно вернуть.
        /// </param>
        /// <returns></returns>
        [HttpGet("GetAllUsers/{offset}/{limit}")]
        public IActionResult GetAllUsers([FromRoute]int offset, [FromRoute]int limit)
        {
            try
            {
                if (offset < 0)
                    return BadRequest("Offset is less than 0.");

                if (limit <= 0)
                    return BadRequest("Limit is less than or equal to 0");

                var users = UserModel.GetUsers();

                if (offset > users.Count - 1)
                    return BadRequest("Wrong offset");

                if (limit > users.Count - offset)
                    limit = users.Count - offset;
                var ans = users.GetRange(offset, limit);
                return Ok(ans);
            }
            catch 
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Добавление нового пользователя.
        /// </summary>
        /// <param name="name">
        /// Имя пользователя.
        /// </param>
        /// <param name="email">
        /// Email пользователя.
        /// </param>
        /// <returns></returns>
        [HttpPost("AddNewUser/{name}/{email}")]
        public IActionResult AddUser([FromRoute]string name, [FromRoute]string email)
        {
            try
            {
                if (name == "" || email == "")
                    return BadRequest("Required fields are empty.");

                if (!email.Contains('@'))
                    return BadRequest("Wrong email format.");

                email = email.ToLower();

                var users = UserModel.GetUsers();
               
                var e = (from u in users
                        where u.Email == email
                        select u).Count();

                if (e != 0)
                    return BadRequest($"User with email {email} already exists");

                users.Add(new UserModel(name, email));
                UserModel.SaveUsers(users);
                return Ok($"User with email {email} was created.");;
            }
            catch
            {
                return NotFound();
            }
        }

    }

    
}

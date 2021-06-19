using System;


namespace MessageService.Models
{
    /// <summary>
    /// Класс для создания рандомных строковых полей.
    /// </summary>
    public static class RandomStringBuilder
    {
        static Random rand;
        static RandomStringBuilder()
        {
            rand = new Random();
        }

        /// <summary>
        /// Создание рандомного сообщения.
        /// </summary>
        /// <param name="senderEmail"></param>
        /// <param name="receiverEmail"></param>
        /// <returns></returns>
        public static MessageModel CreateRandomMessage(string senderEmail, string receiverEmail)
        {
            string subject = CreateRandomSubject();
            string text = CreateRandomText();

            return new MessageModel(subject, text, senderEmail, receiverEmail);
        }

        /// <summary>
        /// Создание рандомной темы сообщения.
        /// </summary>
        /// <returns></returns>
        private static string CreateRandomSubject() => CreateRandomString(rand.Next(15, 30));

        /// <summary>
        /// Создание рандомного текста сообщения.
        /// </summary>
        /// <returns></returns>
        private static string CreateRandomText() => CreateRandomString(rand.Next(50, 200));

        /// <summary>
        /// Создание рандомной строки.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static string CreateRandomString(int length)
        {
            string str = "";
            for (int i = 0; i < length; i++)
            {
                str += ((char)rand.Next('a', 'z' + 1)).ToString();
            }
            return str;

        }

        /// <summary>
        /// Метод для создания рандомного пользователя.
        /// </summary>
        /// <returns></returns>
        public static UserModel CreateRandomUser()
        {
            string name = CreateRandomString(10);

            string email = name + '@' + "messageservice.com";

            return new UserModel(name, email);
        }

       
    }
}

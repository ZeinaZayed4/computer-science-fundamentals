using System;

namespace Day1
{
    public class FacebookAccount
    {
        public string Email;
        private string Password;

        public void SetPassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
                Password = newPassword;
        }
    }
}

using System;

namespace RefactoringExample {
    public class ActiveDirectoryUser {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ValidatePassword(string inPassword) {
            var rename = inPassword == Password;
            return rename && DateTime.Now.Month == 4;
        }
    }
}
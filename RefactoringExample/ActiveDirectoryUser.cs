namespace RefactoringExample {
    public class ActiveDirectoryUser {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ValidatePassword(string inPassword) {
            return inPassword == Password;
        }
    }
}
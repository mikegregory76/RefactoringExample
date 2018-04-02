namespace RefactoringExample {
    public class TraditionalUser {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ValidatePassword(string inPassword) {
            return inPassword == Password;
        }
    }
}
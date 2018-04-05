namespace RefactoringExample {
    public abstract class BaseUser {
        public string Username { get; set; }
        public string Password { get; set; }
        public abstract bool ValidatePassword(string inPassword);
    }
}
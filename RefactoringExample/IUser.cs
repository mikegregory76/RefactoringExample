namespace RefactoringExample {
    public interface IUser {
        string Username { get; set; }
        string Password { get; set; }
        bool ValidatePassword(string inPassword);
    }
}
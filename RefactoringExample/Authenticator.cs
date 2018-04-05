namespace RefactoringExample {
    public class Authenticator {
        public bool Login(BaseUser user, string password) {
            return user.ValidatePassword(password);
        }
    }
}
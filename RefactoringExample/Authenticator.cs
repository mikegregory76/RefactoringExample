namespace RefactoringExample {
    public class Authenticator {
        public bool Login(TraditionalUser user, string password) {
            return user.ValidatePassword(password);
        }

        public bool Login(ActiveDirectoryUser user, string password) {
            return user.ValidatePassword(password);
        }
    }
}
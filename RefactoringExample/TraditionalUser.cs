namespace RefactoringExample {
    public class TraditionalUser : BaseUser, IUser {
        public override bool ValidatePassword(string inPassword) {
            return inPassword == Password;
        }
    }
}
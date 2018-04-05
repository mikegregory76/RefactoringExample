using System;

namespace RefactoringExample {
    public class ActiveDirectoryUser : BaseUser, IUser {
        public override bool ValidatePassword(string inPassword) {
            var rename = inPassword == Password;
            return rename && DateTime.Now.Month == 4;
        }
    }
}
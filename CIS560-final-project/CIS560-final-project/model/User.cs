using System;

namespace CIS560_final_project.model
{
    public class User
    {
		public int UserID { get; }
		public string Name { get; }
		public string Email { get; }
		public string PasswordHash { get; }
		
		public User(int UserID, string Name, string Email, string PasswordHash){
			this.UserID = UserID;
			this.Name = Name;
			this.Email = Email;
			this.PasswordHash = PasswordHash;
		}

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                return UserID == ((User)obj).UserID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 31 * UserID;
        }
    }
}
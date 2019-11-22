using System;

namespace CIS560_final_project.model
{
    class User
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
	}
}
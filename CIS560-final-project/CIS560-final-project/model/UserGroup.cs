using System;

namespace CIS560_final_project.model
{
    public class UserGroup
    {
		public int UserGroupID { get; }
		public User Owner { get; }
		public string Name { get; }
		public string Description { get; }
		
		public UserGroup(int UserGroupID, User Owner, string Name, string Description){
			this.UserGroupID = UserGroupID;
			this.Owner = Owner;
			this.Name = Name;
			this.Description = Description;
		}

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                return UserGroupID == ((UserGroup)obj).UserGroupID;
            }
            return false;
        }
    }
}
using System;

namespace CIS560_final_project.model
{
    public class UserGroup
    {
		public int UserGroupID { get; }
		public int GroupOwnerID { get; }
		public string Name { get; }
		public string Description { get; }
		
		public UserGroup(int UserGroupID, int GroupOwnerID, string Name, string Description){
			this.UserGroupID = UserGroupID;
			this.GroupOwnerID = GroupOwnerID;
			this.Name = Name;
			this.Description = Description;
		}
	}
}
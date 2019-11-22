using System;

namespace CIS560_final_project.model
{
    class Roles
    {
		public int RoleID { get; }
		public string Name { get; }
		public bool CanCreateTasks { get; }
		public bool CanAssignTasks { get; }
		public bool CanDeleteTasks { get; }
		public bool CanModifyTasks { get; }
		
		public Role(int RoleID, string Name, bool CCT, bool CAT, bool CDT, bool CMT){
			this.RoleID = RoleID;
			this.Name = Name;
			CanCreateTasks = CCT;
			CanAssignTasks = CAT;
			CanDeleteTasks = CDT;
			CanModifyTasks = CMT;
		}
    }
}

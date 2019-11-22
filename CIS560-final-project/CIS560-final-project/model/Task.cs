using System;

namespace CIS560_final_project.model
{
    class Task
    {
		public int TaskID { get; }
		public string Name { get; }
		public string Description { get; }
		public int UserGroupID { get; }
		public int OwnerUserID { get; }
		public int TaskStateID { get; }
		public string DueDate  { get; }
		public string StartDate  { get; }
		public string CompletionDate { get; }
		
		public Task(int TaskID, string Name, string Description, int UserGroupID, int OwnerUserID, int TaskStateID, string DueDate, string StartDate, string CompletionDate){
			this.TaskID = TaskID;
			this.Name = Name;
			this.Description = Description;
			this.UserGroupID = UserGroupID;
			this.OwnerUserID = OwnerUserID;
			this.TaskStateID = TaskStateID;
			this.DueDate = DueDate;
			this.StartDate = StartDate;
			this.CompletionDate = CompletionDate;
		}
	}
}
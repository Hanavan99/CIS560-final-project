using System;

namespace CIS560_final_project.model
{
    public class Task
    {
		public int TaskID { get; }
		public string Name { get; }
		public string Description { get; }
		public UserGroup UserGroup { get; }
		public User Owner { get; }
		public TaskState TaskState { get; }
		public DateTime DueDate  { get; }
		public DateTime StartDate  { get; }
		public DateTime CompletionDate { get; }
		
		public Task(int TaskID, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, DateTime DueDate, DateTime StartDate, DateTime CompletionDate){
			this.TaskID = TaskID;
			this.Name = Name;
			this.Description = Description;
			this.UserGroup = UserGroup;
			this.Owner = Owner;
			this.TaskState = TaskState;
			this.DueDate = DueDate;
			this.StartDate = StartDate;
			this.CompletionDate = CompletionDate;
		}
	}
}
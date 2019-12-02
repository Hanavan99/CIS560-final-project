using System;

namespace CIS560_final_project.model
{
    public class TaskCategory
    {
		public int TaskCategoryID { get; }
		public User Owner { get; }
		public string Name { get; }
		public string Description { get; }
		public string Color { get; }
		
		public TaskCategory(int TaskCategoryID, User Owner, string Name, string Description, string Color){
			this.TaskCategoryID = TaskCategoryID;
			this.Owner = Owner;
			this.Name = Name;
			this.Description = Description;
			this.Color = Color;
		}
	}
}	
using System;

namespace CIS560_final_project.model
{
    class TaskCategory
    {
		public int TaskCategoryID { get; }
		public int OwnerID { get; }
		public string Name { get; }
		public string Description { get; }
		public string Color { get; }
		
		public TaskCategory(int TaskCategoryID, int OwnerID, string Name, string Description, string Color){
			this.TaskCategoryID = TaskCategory;
			this.OwnerID = OwnerID;
			this.Name = Name;
			this.Description = Description;
			this.Color = Color;
		}
	}
}	
using System;

namespace CIS560_final_project.model
{
    public class TaskState
    {
		public int TaskStateID { get; }
		public string Name { get; }
		public string Description { get; }
		public string Color { get; }
		
		public TaskState(int TaskStateID, string Name, string Description, string Color){
			this.TaskStateID = TaskStateID;
			this.Name = Name;
			this.Description = Description;
			this.Color = Color;
		}

        public override string ToString()
        {
            return Name;
        }
    }
}
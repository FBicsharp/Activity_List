using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity_List.Pages.Todo
{
    public class TodoBase : ComponentBase
    {

        protected IList<TodoItem> todos = new List<TodoItem>();

        protected void AddItemToList()
        {
            if (string.IsNullOrWhiteSpace(this.newTodo.Group) || string.IsNullOrWhiteSpace(this.newTodo.Description) )
            {
                return;
            }            
            this.todos.Add(this.newTodo);
            //display advertise
        }

        protected TodoItem newTodo = new TodoItem();
        protected override void OnInitialized()
        {
            todos.Add(new TodoItem() { Group = "PRova", Description = "Prova", State = TaskState.Incomplete });

            base.OnInitialized();
        }

        cache

    }


    public class TodoItem
    {
        public string Group { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; } = TaskState.Incomplete;
    }

    public enum TaskState
    {
        Complete,
        Incomplete,
        Paused
    }

}

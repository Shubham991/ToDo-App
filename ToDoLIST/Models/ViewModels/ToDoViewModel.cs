using System;
using System.Collections.Generic;

namespace ToDoLIST.Models.ViewModels
{
    public class ToDoViewModel
    {
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}

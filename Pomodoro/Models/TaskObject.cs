using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.Models
{
    public enum Category { Персональное, Работа, Семья, Отдых, Развлечения }
    public class TaskObject
    {
        public TaskObject(int id, string name, Category category, TimeSpan time)
        {
            Id = id;
            Name = name;
            Category = category;
            Time = time;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public TimeSpan Time { get; set; }
    }
}

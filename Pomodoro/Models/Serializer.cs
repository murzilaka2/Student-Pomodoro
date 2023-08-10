using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Pomodoro.Models
{
    public class Serializer
    {
        public static void Serialize(Models.TaskObject task)
        {
            List<Models.TaskObject> tasks = DeSerialize();
            tasks.Add(task);
            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Models.TaskObject>>(fs, tasks);
            }
        }
        public static void Serialize(List<Models.TaskObject> tasks)
        {
            if (File.Exists("tasks.json"))
            {
                File.Delete("tasks.json");
            }
            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Models.TaskObject>>(fs, tasks);
            }
        }
        public static List<Models.TaskObject> DeSerialize()
        {
            List<Models.TaskObject>? tasks = new List<Models.TaskObject>();
            if (File.Exists("tasks.json"))
            {
                using (FileStream fs = new FileStream("tasks.json", FileMode.Open))
                {
                    tasks = JsonSerializer.Deserialize<List<Models.TaskObject>>(fs);
                }
            }
            return tasks;
        }
    }
}

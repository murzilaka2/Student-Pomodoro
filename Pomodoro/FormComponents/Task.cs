using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.FormComponents
{
    public partial class Task : UserControl
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public delegate void AccountHandler();
        public event AccountHandler Notify;
        public delegate void TaskChanhedHandler(Models.TaskObject t);
        public event TaskChanhedHandler NotifyTaskChanged;
        Models.TaskObject taskObject;
        public Task(Models.TaskObject taskObject)
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Models.Category));
            this.taskObject = taskObject;
            this.DescriptionTextBox.Text = taskObject.Name;
            this.CategoryComboBox.SelectedIndex = (int)taskObject.Category;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(DescriptionTextBox, $"Время выполнения: {taskObject.Time}");
        }
        void States()
        {
            EditButton.Enabled = !EditButton.Enabled;
            SaveButton.Enabled = !SaveButton.Enabled;
            DescriptionTextBox.ReadOnly = !DescriptionTextBox.ReadOnly;
            CategoryComboBox.Enabled = !CategoryComboBox.Enabled;
        }
        public void Animate()
        {
            SaveButton.Visible = false;
            EditButton.Visible = false;
            DeleteButton.Visible = false;
            timer.Interval = 1000;
            timer.Start();
            bool flag = true;
            timer.Tick += (sender, e) =>
            {
                if (flag)
                {
                    DescriptionTextBox.BackColor = Color.FromArgb(239, 51, 51);
                    CategoryComboBox.BackColor = Color.FromArgb(239, 51, 51);
                    this.BackColor = Color.FromArgb(239, 51, 51);
                }
                else
                {
                    DescriptionTextBox.BackColor = Color.FromArgb(248, 170, 175);
                    CategoryComboBox.BackColor = Color.FromArgb(248, 170, 175);
                    this.BackColor = Color.FromArgb(248, 170, 175);
                }
                flag = !flag;
            };
            }
        public void StopAnimate()
        {
            timer.Stop();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            States();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            States();
            int id = (int)this.Tag;
            var tasks = Models.Serializer.DeSerialize();
            var task = tasks.Where(e => e.Id == id).FirstOrDefault();
            if (!string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                task.Name = DescriptionTextBox.Text;
                task.Category = (Models.Category)CategoryComboBox.SelectedIndex;
            }
            NotifyTaskChanged?.Invoke(task);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = (int)this.Tag;
            var tasks = Models.Serializer.DeSerialize();
            tasks = tasks.Where(e => e.Id != id).ToList();
            Models.Serializer.Serialize(tasks);
            Notify?.Invoke();
        }
    }
}

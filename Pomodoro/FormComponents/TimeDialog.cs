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
    public partial class TimeDialog : Form
    {
        public TimeDialog()
        {
            InitializeComponent();
        }
        decimal time = 1;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            time = TimeNumeric.Value;
            this.DialogResult = DialogResult.OK;
        }
        public decimal GetTime => time;
    }
}

namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.RigthPanel = new System.Windows.Forms.Panel();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.CreateTaskPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddTaskButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitelPanel = new System.Windows.Forms.Panel();
            this.PlannedTextBox = new System.Windows.Forms.TextBox();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.RigthPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.CreateTaskPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TitelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.HeaderPanel.Controls.Add(this.ButtonsPanel);
            this.HeaderPanel.Controls.Add(this.TimePanel);
            this.HeaderPanel.Controls.Add(this.RigthPanel);
            this.HeaderPanel.Controls.Add(this.LeftPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(816, 166);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonsPanel.Controls.Add(this.ButtonStop);
            this.ButtonsPanel.Controls.Add(this.ButtonStart);
            this.ButtonsPanel.Location = new System.Drawing.Point(94, 81);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Padding = new System.Windows.Forms.Padding(120, 25, 120, 25);
            this.ButtonsPanel.Size = new System.Drawing.Size(612, 85);
            this.ButtonsPanel.TabIndex = 8;
            this.ButtonsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStop.ForeColor = System.Drawing.Color.White;
            this.ButtonStop.Location = new System.Drawing.Point(314, 25);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(178, 35);
            this.ButtonStop.TabIndex = 6;
            this.ButtonStop.Text = "СТОП";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.Location = new System.Drawing.Point(120, 25);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(178, 35);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "СТАРТ";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TimePanel
            // 
            this.TimePanel.Controls.Add(this.NumberLabel);
            this.TimePanel.Controls.Add(this.TimeLabel);
            this.TimePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimePanel.Location = new System.Drawing.Point(94, 0);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(612, 84);
            this.TimePanel.TabIndex = 7;
            this.TimePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // NumberLabel
            // 
            this.NumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberLabel.ForeColor = System.Drawing.Color.White;
            this.NumberLabel.Location = new System.Drawing.Point(465, 9);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(107, 18);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "ПОМОДОРО#1";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(139, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(337, 78);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00:25:00";
            // 
            // RigthPanel
            // 
            this.RigthPanel.Controls.Add(this.MaximizeButton);
            this.RigthPanel.Controls.Add(this.CloseButton);
            this.RigthPanel.Controls.Add(this.MinimizeButton);
            this.RigthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RigthPanel.Location = new System.Drawing.Point(706, 0);
            this.RigthPanel.Name = "RigthPanel";
            this.RigthPanel.Size = new System.Drawing.Size(110, 166);
            this.RigthPanel.TabIndex = 6;
            this.RigthPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.White;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 42;
            this.MaximizeButton.Location = new System.Drawing.Point(46, 3);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 42;
            this.CloseButton.Location = new System.Drawing.Point(79, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 42;
            this.MinimizeButton.Location = new System.Drawing.Point(13, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.SettingsButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(94, 166);
            this.LeftPanel.TabIndex = 5;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsButton.IconColor = System.Drawing.Color.White;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.IconSize = 42;
            this.SettingsButton.Location = new System.Drawing.Point(1, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(34, 34);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.AutoScroll = true;
            this.DesktopPanel.Controls.Add(this.ItemsPanel);
            this.DesktopPanel.Controls.Add(this.LinePanel);
            this.DesktopPanel.Controls.Add(this.CreateTaskPanel);
            this.DesktopPanel.Controls.Add(this.TitelPanel);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 166);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(816, 395);
            this.DesktopPanel.TabIndex = 1;
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.AutoScroll = true;
            this.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPanel.Location = new System.Drawing.Point(0, 82);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(816, 313);
            this.ItemsPanel.TabIndex = 4;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.Black;
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinePanel.Location = new System.Drawing.Point(0, 81);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(816, 1);
            this.LinePanel.TabIndex = 3;
            // 
            // CreateTaskPanel
            // 
            this.CreateTaskPanel.Controls.Add(this.panel3);
            this.CreateTaskPanel.Controls.Add(this.panel2);
            this.CreateTaskPanel.Controls.Add(this.panel1);
            this.CreateTaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateTaskPanel.Location = new System.Drawing.Point(0, 28);
            this.CreateTaskPanel.Name = "CreateTaskPanel";
            this.CreateTaskPanel.Padding = new System.Windows.Forms.Padding(7);
            this.CreateTaskPanel.Size = new System.Drawing.Size(816, 53);
            this.CreateTaskPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DescriptionTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 7);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.panel3.Size = new System.Drawing.Size(571, 39);
            this.panel3.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(5, 3);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PlaceholderText = "Короткое описание";
            this.DescriptionTextBox.Size = new System.Drawing.Size(561, 28);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddTaskButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(778, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 39);
            this.panel2.TabIndex = 1;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTaskButton.FlatAppearance.BorderSize = 0;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.AddTaskButton.IconColor = System.Drawing.Color.Black;
            this.AddTaskButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddTaskButton.IconSize = 38;
            this.AddTaskButton.Location = new System.Drawing.Point(0, 0);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(31, 39);
            this.AddTaskButton.TabIndex = 5;
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryComboBox.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(0, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(200, 28);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.Text = "Без категории";
            // 
            // TitelPanel
            // 
            this.TitelPanel.Controls.Add(this.PlannedTextBox);
            this.TitelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitelPanel.Location = new System.Drawing.Point(0, 0);
            this.TitelPanel.Name = "TitelPanel";
            this.TitelPanel.Size = new System.Drawing.Size(816, 28);
            this.TitelPanel.TabIndex = 1;
            // 
            // PlannedTextBox
            // 
            this.PlannedTextBox.BackColor = System.Drawing.Color.White;
            this.PlannedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlannedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlannedTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlannedTextBox.Location = new System.Drawing.Point(0, 0);
            this.PlannedTextBox.Name = "PlannedTextBox";
            this.PlannedTextBox.ReadOnly = true;
            this.PlannedTextBox.Size = new System.Drawing.Size(816, 24);
            this.PlannedTextBox.TabIndex = 0;
            this.PlannedTextBox.Text = "ЗАПЛАНИРОВАНО · 6 / 2ч 30м";
            this.PlannedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.HeaderPanel);
            this.MinimumSize = new System.Drawing.Size(510, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.HeaderPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.RigthPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.CreateTaskPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TitelPanel.ResumeLayout(false);
            this.TitelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeaderPanel;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private Button ButtonStart;
        private Panel LeftPanel;
        private Panel RigthPanel;
        private Panel ButtonsPanel;
        private Button ButtonStop;
        private Panel TimePanel;
        private Label TimeLabel;
        private Label NumberLabel;
        private Panel DesktopPanel;
        private Panel TitelPanel;
        private TextBox PlannedTextBox;
        private Panel CreateTaskPanel;
        private TextBox DescriptionTextBox;
        private ComboBox CategoryComboBox;
        private Panel panel3;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton AddTaskButton;
        private Panel panel1;
        private Panel LinePanel;
        private Panel ItemsPanel;
    }
}
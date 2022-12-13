namespace FinalProject
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.toDoTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UpOne = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.StepCount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toDoListBox
            // 
            this.toDoListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.toDoListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListBox.ForeColor = System.Drawing.Color.White;
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.ItemHeight = 17;
            this.toDoListBox.Location = new System.Drawing.Point(11, 12);
            this.toDoListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(183, 361);
            this.toDoListBox.TabIndex = 2;
            // 
            // toDoTextBox
            // 
            this.toDoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.toDoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoTextBox.ForeColor = System.Drawing.Color.White;
            this.toDoTextBox.Location = new System.Drawing.Point(208, 97);
            this.toDoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toDoTextBox.Name = "toDoTextBox";
            this.toDoTextBox.Size = new System.Drawing.Size(139, 25);
            this.toDoTextBox.TabIndex = 3;
            this.toDoTextBox.TextChanged += new System.EventHandler(this.toDoTextBox_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.progressBar1.Location = new System.Drawing.Point(22, 450);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 31);
            this.progressBar1.TabIndex = 4;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.FinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.Color.White;
            this.FinishBtn.Location = new System.Drawing.Point(120, 379);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(74, 31);
            this.FinishBtn.TabIndex = 5;
            this.FinishBtn.Text = "Remove";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(11, 379);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(74, 31);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Reset List";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // UpOne
            // 
            this.UpOne.Location = new System.Drawing.Point(436, 156);
            this.UpOne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpOne.Name = "UpOne";
            this.UpOne.Size = new System.Drawing.Size(74, 31);
            this.UpOne.TabIndex = 8;
            this.UpOne.Text = "Up";
            this.UpOne.UseVisualStyleBackColor = true;
            this.UpOne.Click += new System.EventHandler(this.UpOne_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(436, 206);
            this.Down.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(74, 31);
            this.Down.TabIndex = 9;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // StepCount
            // 
            this.StepCount.Location = new System.Drawing.Point(410, 245);
            this.StepCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StepCount.Name = "StepCount";
            this.StepCount.Size = new System.Drawing.Size(100, 23);
            this.StepCount.TabIndex = 10;
            this.StepCount.TextChanged += new System.EventHandler(this.StepCount_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(208, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 16);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Enter Habit";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(362, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StepCount);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.UpOne);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toDoTextBox);
            this.Controls.Add(this.toDoListBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ToDoList";
            this.Text = "Habit Tracker";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.TextBox toDoTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button UpOne;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.TextBox StepCount;
        private System.Windows.Forms.TextBox textBox1;
    }
}
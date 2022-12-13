namespace FinalProject
{
    partial class Calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ChooseTimeTxt1 = new System.Windows.Forms.TextBox();
            this.ChooseEventTxt = new System.Windows.Forms.TextBox();
            this.ChooseTimeTxt2 = new System.Windows.Forms.TextBox();
            this.ChooseAmPm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(6, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.White;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Black;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Black;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(264, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 340);
            this.listBox1.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.Location = new System.Drawing.Point(512, 373);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(96, 35);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(512, 414);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(96, 35);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear All";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ChooseTimeTxt1
            // 
            this.ChooseTimeTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ChooseTimeTxt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseTimeTxt1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTimeTxt1.ForeColor = System.Drawing.Color.White;
            this.ChooseTimeTxt1.Location = new System.Drawing.Point(264, 373);
            this.ChooseTimeTxt1.Name = "ChooseTimeTxt1";
            this.ChooseTimeTxt1.Size = new System.Drawing.Size(22, 22);
            this.ChooseTimeTxt1.TabIndex = 5;
            this.ChooseTimeTxt1.Text = "00";
            this.ChooseTimeTxt1.TextChanged += new System.EventHandler(this.ChooseTimeTxt1_TextChanged);
            // 
            // ChooseEventTxt
            // 
            this.ChooseEventTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ChooseEventTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseEventTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseEventTxt.ForeColor = System.Drawing.Color.White;
            this.ChooseEventTxt.Location = new System.Drawing.Point(264, 399);
            this.ChooseEventTxt.Name = "ChooseEventTxt";
            this.ChooseEventTxt.Size = new System.Drawing.Size(100, 22);
            this.ChooseEventTxt.TabIndex = 6;
            this.ChooseEventTxt.Text = "Add Event Here";
            // 
            // ChooseTimeTxt2
            // 
            this.ChooseTimeTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ChooseTimeTxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseTimeTxt2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTimeTxt2.ForeColor = System.Drawing.Color.White;
            this.ChooseTimeTxt2.Location = new System.Drawing.Point(292, 373);
            this.ChooseTimeTxt2.Name = "ChooseTimeTxt2";
            this.ChooseTimeTxt2.Size = new System.Drawing.Size(22, 22);
            this.ChooseTimeTxt2.TabIndex = 7;
            this.ChooseTimeTxt2.Text = "00";
            // 
            // ChooseAmPm
            // 
            this.ChooseAmPm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.ChooseAmPm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseAmPm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAmPm.ForeColor = System.Drawing.Color.White;
            this.ChooseAmPm.Location = new System.Drawing.Point(320, 373);
            this.ChooseAmPm.Name = "ChooseAmPm";
            this.ChooseAmPm.Size = new System.Drawing.Size(22, 22);
            this.ChooseAmPm.TabIndex = 8;
            this.ChooseAmPm.Text = "PM";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(644, 545);
            this.Controls.Add(this.ChooseAmPm);
            this.Controls.Add(this.ChooseTimeTxt2);
            this.Controls.Add(this.ChooseEventTxt);
            this.Controls.Add(this.ChooseTimeTxt1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox ChooseTimeTxt1;
        private System.Windows.Forms.TextBox ChooseEventTxt;
        private System.Windows.Forms.TextBox ChooseTimeTxt2;
        private System.Windows.Forms.TextBox ChooseAmPm;
    }
}
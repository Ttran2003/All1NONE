namespace FinalProject
{
    partial class CalcForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.bClearEntry = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bPower = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.bUnderOne = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNIne = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bOne = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bPlusMinus = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(11, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(235, 97);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.ForeColor = System.Drawing.Color.White;
            this.inputText.Location = new System.Drawing.Point(11, 124);
            this.inputText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputText.Name = "inputText";
            this.inputText.ReadOnly = true;
            this.inputText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inputText.Size = new System.Drawing.Size(235, 29);
            this.inputText.TabIndex = 1;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // bClearEntry
            // 
            this.bClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bClearEntry.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.bClearEntry.ForeColor = System.Drawing.Color.White;
            this.bClearEntry.Location = new System.Drawing.Point(76, 183);
            this.bClearEntry.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bClearEntry.Name = "bClearEntry";
            this.bClearEntry.Size = new System.Drawing.Size(50, 35);
            this.bClearEntry.TabIndex = 3;
            this.bClearEntry.Text = "CE";
            this.bClearEntry.UseVisualStyleBackColor = false;
            this.bClearEntry.Click += new System.EventHandler(this.bClearEntry_Click_1);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bClear.Font = new System.Drawing.Font("Candara", 10.75F, System.Drawing.FontStyle.Bold);
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(136, 183);
            this.bClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(50, 35);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click_1);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bDelete.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(196, 183);
            this.bDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(50, 35);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "<--";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click_1);
            // 
            // bPower
            // 
            this.bPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bPower.Font = new System.Drawing.Font("Candara", 13.75F, System.Drawing.FontStyle.Bold);
            this.bPower.ForeColor = System.Drawing.Color.White;
            this.bPower.Location = new System.Drawing.Point(16, 220);
            this.bPower.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bPower.Name = "bPower";
            this.bPower.Size = new System.Drawing.Size(50, 35);
            this.bPower.TabIndex = 6;
            this.bPower.Text = "x^2";
            this.bPower.UseVisualStyleBackColor = false;
            this.bPower.Click += new System.EventHandler(this.bPower_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bSqrt.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold);
            this.bSqrt.ForeColor = System.Drawing.Color.White;
            this.bSqrt.Location = new System.Drawing.Point(76, 220);
            this.bSqrt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(50, 35);
            this.bSqrt.TabIndex = 7;
            this.bSqrt.Text = "sqrt";
            this.bSqrt.UseVisualStyleBackColor = false;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // bUnderOne
            // 
            this.bUnderOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bUnderOne.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnderOne.ForeColor = System.Drawing.Color.White;
            this.bUnderOne.Location = new System.Drawing.Point(136, 220);
            this.bUnderOne.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bUnderOne.Name = "bUnderOne";
            this.bUnderOne.Size = new System.Drawing.Size(50, 35);
            this.bUnderOne.TabIndex = 8;
            this.bUnderOne.Text = "1/x";
            this.bUnderOne.UseVisualStyleBackColor = false;
            this.bUnderOne.Click += new System.EventHandler(this.bUnderOne_Click);
            // 
            // bDivide
            // 
            this.bDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bDivide.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivide.ForeColor = System.Drawing.Color.White;
            this.bDivide.Location = new System.Drawing.Point(196, 220);
            this.bDivide.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(50, 35);
            this.bDivide.TabIndex = 9;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = false;
            this.bDivide.Click += new System.EventHandler(this.bDivide_Click);
            // 
            // bSeven
            // 
            this.bSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bSeven.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeven.ForeColor = System.Drawing.Color.White;
            this.bSeven.Location = new System.Drawing.Point(16, 258);
            this.bSeven.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(50, 35);
            this.bSeven.TabIndex = 10;
            this.bSeven.Text = "7";
            this.bSeven.UseVisualStyleBackColor = false;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // bEight
            // 
            this.bEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bEight.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEight.ForeColor = System.Drawing.Color.White;
            this.bEight.Location = new System.Drawing.Point(76, 258);
            this.bEight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(50, 35);
            this.bEight.TabIndex = 11;
            this.bEight.Text = "8";
            this.bEight.UseVisualStyleBackColor = false;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bNIne
            // 
            this.bNIne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bNIne.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNIne.ForeColor = System.Drawing.Color.White;
            this.bNIne.Location = new System.Drawing.Point(136, 258);
            this.bNIne.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bNIne.Name = "bNIne";
            this.bNIne.Size = new System.Drawing.Size(50, 35);
            this.bNIne.TabIndex = 12;
            this.bNIne.Text = "9";
            this.bNIne.UseVisualStyleBackColor = false;
            this.bNIne.Click += new System.EventHandler(this.bNIne_Click);
            // 
            // bMultiply
            // 
            this.bMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bMultiply.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMultiply.ForeColor = System.Drawing.Color.White;
            this.bMultiply.Location = new System.Drawing.Point(196, 258);
            this.bMultiply.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(50, 35);
            this.bMultiply.TabIndex = 13;
            this.bMultiply.Text = "X";
            this.bMultiply.UseVisualStyleBackColor = false;
            this.bMultiply.Click += new System.EventHandler(this.bMultiply_Click);
            // 
            // bFour
            // 
            this.bFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bFour.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFour.ForeColor = System.Drawing.Color.White;
            this.bFour.Location = new System.Drawing.Point(16, 296);
            this.bFour.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(50, 35);
            this.bFour.TabIndex = 14;
            this.bFour.Text = "4";
            this.bFour.UseVisualStyleBackColor = false;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bFive
            // 
            this.bFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bFive.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFive.ForeColor = System.Drawing.Color.White;
            this.bFive.Location = new System.Drawing.Point(76, 296);
            this.bFive.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(50, 35);
            this.bFive.TabIndex = 15;
            this.bFive.Text = "5";
            this.bFive.UseVisualStyleBackColor = false;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bSix
            // 
            this.bSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bSix.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSix.ForeColor = System.Drawing.Color.White;
            this.bSix.Location = new System.Drawing.Point(136, 296);
            this.bSix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(50, 35);
            this.bSix.TabIndex = 16;
            this.bSix.Text = "6";
            this.bSix.UseVisualStyleBackColor = false;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bMinus
            // 
            this.bMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bMinus.Font = new System.Drawing.Font("Candara", 18.75F, System.Drawing.FontStyle.Bold);
            this.bMinus.ForeColor = System.Drawing.Color.White;
            this.bMinus.Location = new System.Drawing.Point(196, 296);
            this.bMinus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(50, 35);
            this.bMinus.TabIndex = 17;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = false;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bOne
            // 
            this.bOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bOne.Font = new System.Drawing.Font("Candara", 16.75F, System.Drawing.FontStyle.Bold);
            this.bOne.ForeColor = System.Drawing.Color.White;
            this.bOne.Location = new System.Drawing.Point(16, 333);
            this.bOne.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(50, 35);
            this.bOne.TabIndex = 18;
            this.bOne.Text = "1";
            this.bOne.UseVisualStyleBackColor = false;
            this.bOne.Click += new System.EventHandler(this.bOne_Click);
            // 
            // bTwo
            // 
            this.bTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bTwo.Font = new System.Drawing.Font("Candara", 16.75F, System.Drawing.FontStyle.Bold);
            this.bTwo.ForeColor = System.Drawing.Color.White;
            this.bTwo.Location = new System.Drawing.Point(76, 333);
            this.bTwo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(50, 35);
            this.bTwo.TabIndex = 19;
            this.bTwo.Text = "2";
            this.bTwo.UseVisualStyleBackColor = false;
            this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
            // 
            // bThree
            // 
            this.bThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bThree.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThree.ForeColor = System.Drawing.Color.White;
            this.bThree.Location = new System.Drawing.Point(136, 333);
            this.bThree.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(50, 35);
            this.bThree.TabIndex = 20;
            this.bThree.Text = "3";
            this.bThree.UseVisualStyleBackColor = false;
            this.bThree.Click += new System.EventHandler(this.bThree_Click);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bPlus.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.ForeColor = System.Drawing.Color.White;
            this.bPlus.Location = new System.Drawing.Point(196, 333);
            this.bPlus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(50, 35);
            this.bPlus.TabIndex = 21;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bPlusMinus
            // 
            this.bPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bPlusMinus.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlusMinus.ForeColor = System.Drawing.Color.White;
            this.bPlusMinus.Location = new System.Drawing.Point(16, 371);
            this.bPlusMinus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bPlusMinus.Name = "bPlusMinus";
            this.bPlusMinus.Size = new System.Drawing.Size(50, 35);
            this.bPlusMinus.TabIndex = 22;
            this.bPlusMinus.Text = "+/-";
            this.bPlusMinus.UseVisualStyleBackColor = false;
            this.bPlusMinus.Click += new System.EventHandler(this.bPlusMinus_Click);
            // 
            // bZero
            // 
            this.bZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bZero.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZero.ForeColor = System.Drawing.Color.White;
            this.bZero.Location = new System.Drawing.Point(76, 371);
            this.bZero.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(50, 35);
            this.bZero.TabIndex = 23;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = false;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.bDot.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDot.ForeColor = System.Drawing.Color.White;
            this.bDot.Location = new System.Drawing.Point(136, 371);
            this.bDot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(50, 35);
            this.bDot.TabIndex = 24;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.bEqual.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.ForeColor = System.Drawing.Color.White;
            this.bEqual.Location = new System.Drawing.Point(196, 371);
            this.bEqual.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(50, 35);
            this.bEqual.TabIndex = 25;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(108)))), ((int)(((byte)(93)))));
            this.button25.Font = new System.Drawing.Font("Candara", 13.75F, System.Drawing.FontStyle.Bold);
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(16, 183);
            this.button25.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(50, 35);
            this.button25.TabIndex = 2;
            this.button25.Text = "\'/.";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(260, 417);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bZero);
            this.Controls.Add(this.bPlusMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bThree);
            this.Controls.Add(this.bTwo);
            this.Controls.Add(this.bOne);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bSix);
            this.Controls.Add(this.bFive);
            this.Controls.Add(this.bFour);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.bNIne);
            this.Controls.Add(this.bEight);
            this.Controls.Add(this.bSeven);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bUnderOne);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.bPower);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.bClearEntry);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button bClearEntry;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bPower;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bUnderOne;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bNIne;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bPlusMinus;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.Button button25;
    }
}
namespace DZ01_2
{
    partial class MyCalculator
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
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btBackSpace = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPoint = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHistory
            // 
            this.tbHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHistory.Enabled = false;
            this.tbHistory.Location = new System.Drawing.Point(0, 0);
            this.tbHistory.Margin = new System.Windows.Forms.Padding(5);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.ReadOnly = true;
            this.tbHistory.Size = new System.Drawing.Size(617, 39);
            this.tbHistory.TabIndex = 0;
            this.tbHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMain
            // 
            this.tbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMain.Location = new System.Drawing.Point(0, 45);
            this.tbMain.Margin = new System.Windows.Forms.Padding(5);
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.Size = new System.Drawing.Size(617, 57);
            this.tbMain.TabIndex = 1;
            this.tbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(0, 110);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(150, 46);
            this.btCE.TabIndex = 2;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(156, 110);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(150, 46);
            this.btC.TabIndex = 3;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btBackSpace
            // 
            this.btBackSpace.Location = new System.Drawing.Point(312, 110);
            this.btBackSpace.Name = "btBackSpace";
            this.btBackSpace.Size = new System.Drawing.Size(150, 46);
            this.btBackSpace.TabIndex = 4;
            this.btBackSpace.Text = "<";
            this.btBackSpace.UseVisualStyleBackColor = true;
            this.btBackSpace.Click += new System.EventHandler(this.btBackSpace_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(468, 110);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(150, 46);
            this.btDivision.TabIndex = 5;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(0, 162);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(150, 46);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(156, 162);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(150, 46);
            this.bt8.TabIndex = 8;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(312, 162);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(150, 46);
            this.bt9.TabIndex = 8;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(467, 162);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(150, 46);
            this.btMulti.TabIndex = 9;
            this.btMulti.Text = "*";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(0, 214);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(150, 46);
            this.bt4.TabIndex = 10;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(156, 214);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(150, 46);
            this.bt5.TabIndex = 11;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(312, 214);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(150, 46);
            this.bt6.TabIndex = 12;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(467, 214);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(150, 46);
            this.btMinus.TabIndex = 13;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(0, 266);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(150, 46);
            this.bt1.TabIndex = 14;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(156, 266);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(150, 46);
            this.bt2.TabIndex = 15;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(312, 266);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(150, 46);
            this.bt3.TabIndex = 16;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(468, 266);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(150, 46);
            this.btPlus.TabIndex = 17;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(0, 318);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(150, 46);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btPoint
            // 
            this.btPoint.Location = new System.Drawing.Point(156, 318);
            this.btPoint.Name = "btPoint";
            this.btPoint.Size = new System.Drawing.Size(150, 46);
            this.btPoint.TabIndex = 19;
            this.btPoint.Text = ".";
            this.btPoint.UseVisualStyleBackColor = true;
            this.btPoint.Click += new System.EventHandler(this.btPoint_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(312, 318);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(306, 46);
            this.btEquals.TabIndex = 20;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 370);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btPoint);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btBackSpace);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.tbHistory);
            this.Name = "MyCalculator";
            this.Text = "MyCalculator";
            this.Shown += new System.EventHandler(this.MyCalculator_Shown);
            this.ResizeEnd += new System.EventHandler(this.MyCalculator_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbHistory;
        private TextBox tbMain;
        private Button btCE;
        private Button btC;
        private Button btBackSpace;
        private Button btDivision;
        private Button bt7;
        private Button bt8;
        private Button bt9;
        private Button btMulti;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button btMinus;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btPlus;
        private Button bt0;
        private Button btPoint;
        private Button btEquals;
    }
}
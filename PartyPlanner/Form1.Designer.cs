namespace PartyPlanner
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(211, 198);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.numPeople);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(203, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(203, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(14, 29);
            this.numPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(89, 20);
            this.numPeople.TabIndex = 2;
            this.numPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPeople.ValueChanged += new System.EventHandler(this.numPeople_ValueChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(14, 55);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 3;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(14, 78);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
            this.healthyBox.TabIndex = 4;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(52, 108);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of People";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(15, 24);
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(89, 20);
            this.numberBirthday.TabIndex = 1;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(15, 51);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(90, 75);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(15, 92);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(138, 20);
            this.cakeWriting.TabIndex = 5;
            this.cakeWriting.Text = "Happy Birthday!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 196);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
    }
}


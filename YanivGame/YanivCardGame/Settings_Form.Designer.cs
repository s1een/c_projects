namespace FormUIDemo
{
    partial class Settings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.button1_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown_w_point = new System.Windows.Forms.NumericUpDown();
            this.label4_winPoint = new System.Windows.Forms.Label();
            this.numericUpDown_l_points = new System.Windows.Forms.NumericUpDown();
            this.label3_lose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_w_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_points)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_start
            // 
            this.button1_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_start.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_start.Location = new System.Drawing.Point(119, 217);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(95, 27);
            this.button1_start.TabIndex = 52;
            this.button1_start.Text = "Confirm";
            this.button1_start.UseVisualStyleBackColor = true;
            this.button1_start.Click += new System.EventHandler(this.button1_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Your Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(119, 60);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 26);
            this.nameTextBox.TabIndex = 44;
            this.nameTextBox.Text = "User1";
            // 
            // numericUpDown_w_point
            // 
            this.numericUpDown_w_point.Location = new System.Drawing.Point(119, 172);
            this.numericUpDown_w_point.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_w_point.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_w_point.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_w_point.Name = "numericUpDown_w_point";
            this.numericUpDown_w_point.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_w_point.TabIndex = 51;
            this.numericUpDown_w_point.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label4_winPoint
            // 
            this.label4_winPoint.AutoSize = true;
            this.label4_winPoint.BackColor = System.Drawing.Color.Transparent;
            this.label4_winPoint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4_winPoint.ForeColor = System.Drawing.Color.Transparent;
            this.label4_winPoint.Location = new System.Drawing.Point(118, 151);
            this.label4_winPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4_winPoint.Name = "label4_winPoint";
            this.label4_winPoint.Size = new System.Drawing.Size(77, 19);
            this.label4_winPoint.TabIndex = 50;
            this.label4_winPoint.Text = "Win Points";
            // 
            // numericUpDown_l_points
            // 
            this.numericUpDown_l_points.Location = new System.Drawing.Point(119, 118);
            this.numericUpDown_l_points.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_l_points.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_l_points.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_l_points.Name = "numericUpDown_l_points";
            this.numericUpDown_l_points.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_l_points.TabIndex = 49;
            this.numericUpDown_l_points.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3_lose
            // 
            this.label3_lose.AutoSize = true;
            this.label3_lose.BackColor = System.Drawing.Color.Transparent;
            this.label3_lose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_lose.ForeColor = System.Drawing.Color.Transparent;
            this.label3_lose.Location = new System.Drawing.Point(118, 97);
            this.label3_lose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_lose.Name = "label3_lose";
            this.label3_lose.Size = new System.Drawing.Size(79, 19);
            this.label3_lose.TabIndex = 48;
            this.label3_lose.Text = "Lose Points";
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 266);
            this.Controls.Add(this.button1_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numericUpDown_w_point);
            this.Controls.Add(this.label4_winPoint);
            this.Controls.Add(this.numericUpDown_l_points);
            this.Controls.Add(this.label3_lose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_w_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown_w_point;
        private System.Windows.Forms.Label label4_winPoint;
        private System.Windows.Forms.NumericUpDown numericUpDown_l_points;
        private System.Windows.Forms.Label label3_lose;
    }
}
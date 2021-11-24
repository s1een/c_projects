namespace CardBox
{
    partial class CardBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPictureBox
            // 
            this.pbPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureBox.Image = global::CardBox.Properties.Resources._card_back;
            this.pbPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pbPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPictureBox.Name = "pbPictureBox";
            this.pbPictureBox.Size = new System.Drawing.Size(56, 87);
            this.pbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPictureBox.TabIndex = 0;
            this.pbPictureBox.TabStop = false;
            // 
            // CardBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardBox";
            this.Size = new System.Drawing.Size(56, 87);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictureBox;
    }
}

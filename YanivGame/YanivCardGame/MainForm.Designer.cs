namespace FormUIDemo
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.FormUiDemoTips = new System.Windows.Forms.ToolTip(this.components);
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.lblRiver = new System.Windows.Forms.Label();
            this.lblPlayerTop = new System.Windows.Forms.Label();
            this.lblPlayerBottom = new System.Windows.Forms.Label();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.pnlPlayerTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlPlayerBottom = new System.Windows.Forms.Panel();
            this.label5_score = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.Throw_button = new System.Windows.Forms.Button();
            this.Show_button = new System.Windows.Forms.Button();
            this.FinishTurn = new System.Windows.Forms.Button();
            this.pile_discard = new System.Windows.Forms.Label();
            this.discard_pile_count = new System.Windows.Forms.Label();
            this.button_hint = new System.Windows.Forms.Button();
            this.label1_score = new System.Windows.Forms.Label();
            this.pbTrumpCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrumpCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(20, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.FormUiDemoTips.SetToolTip(this.btnExit, "Exit the application.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDeck
            // 
            this.pbDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.pbDeck.Location = new System.Drawing.Point(19, 250);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(74, 107);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeck.TabIndex = 2;
            this.pbDeck.TabStop = false;
            this.FormUiDemoTips.SetToolTip(this.pbDeck, "Click the deck to draw a card.");
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pnlRiver
            // 
            this.pnlRiver.AllowDrop = true;
            this.pnlRiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.pnlRiver.Location = new System.Drawing.Point(123, 205);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(754, 133);
            this.pnlRiver.TabIndex = 10;
            this.FormUiDemoTips.SetToolTip(this.pnlRiver, "Click cards to move them to the play area.");
            // 
            // lblRiver
            // 
            this.lblRiver.AutoSize = true;
            this.lblRiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.lblRiver.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRiver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRiver.Location = new System.Drawing.Point(122, 188);
            this.lblRiver.Name = "lblRiver";
            this.lblRiver.Size = new System.Drawing.Size(46, 21);
            this.lblRiver.TabIndex = 9;
            this.lblRiver.Text = "River";
            this.FormUiDemoTips.SetToolTip(this.lblRiver, "Home ");
            // 
            // lblPlayerTop
            // 
            this.lblPlayerTop.AutoSize = true;
            this.lblPlayerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.lblPlayerTop.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerTop.Location = new System.Drawing.Point(122, 18);
            this.lblPlayerTop.Name = "lblPlayerTop";
            this.lblPlayerTop.Size = new System.Drawing.Size(29, 21);
            this.lblPlayerTop.TabIndex = 7;
            this.lblPlayerTop.Text = "AI";
            this.FormUiDemoTips.SetToolTip(this.lblPlayerTop, "Home ");
            // 
            // lblPlayerBottom
            // 
            this.lblPlayerBottom.AutoSize = true;
            this.lblPlayerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.lblPlayerBottom.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerBottom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerBottom.Location = new System.Drawing.Point(122, 341);
            this.lblPlayerBottom.Name = "lblPlayerBottom";
            this.lblPlayerBottom.Size = new System.Drawing.Size(53, 21);
            this.lblPlayerBottom.TabIndex = 11;
            this.lblPlayerBottom.Text = "Player";
            this.FormUiDemoTips.SetToolTip(this.lblPlayerBottom, "Home ");
            // 
            // lblCardCount
            // 
            this.lblCardCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.lblCardCount.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCardCount.Location = new System.Drawing.Point(20, 219);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(75, 32);
            this.lblCardCount.TabIndex = 1;
            this.lblCardCount.Text = "88";
            this.lblCardCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayerTop
            // 
            this.pnlPlayerTop.AllowDrop = true;
            this.pnlPlayerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(88)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlPlayerTop.Location = new System.Drawing.Point(123, 42);
            this.pnlPlayerTop.Name = "pnlPlayerTop";
            this.pnlPlayerTop.Size = new System.Drawing.Size(754, 133);
            this.pnlPlayerTop.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deck";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(20, 434);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlPlayerBottom
            // 
            this.pnlPlayerBottom.AllowDrop = true;
            this.pnlPlayerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(88)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pnlPlayerBottom.Location = new System.Drawing.Point(125, 364);
            this.pnlPlayerBottom.Name = "pnlPlayerBottom";
            this.pnlPlayerBottom.Size = new System.Drawing.Size(755, 133);
            this.pnlPlayerBottom.TabIndex = 9;
            // 
            // label5_score
            // 
            this.label5_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.label5_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5_score.Location = new System.Drawing.Point(-5, 155);
            this.label5_score.Name = "label5_score";
            this.label5_score.Size = new System.Drawing.Size(122, 22);
            this.label5_score.TabIndex = 14;
            this.label5_score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            this.StartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(19, 402);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 26);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Enter += new System.EventHandler(this.StartButton_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtMessages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMessages.Location = new System.Drawing.Point(20, 519);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(721, 116);
            this.txtMessages.TabIndex = 17;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.lblDetails.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDetails.Location = new System.Drawing.Point(16, 494);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(112, 23);
            this.lblDetails.TabIndex = 18;
            this.lblDetails.Text = "Game Details";
            // 
            // Throw_button
            // 
            this.Throw_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Throw_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Throw_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Throw_button.Location = new System.Drawing.Point(780, 541);
            this.Throw_button.Name = "Throw_button";
            this.Throw_button.Size = new System.Drawing.Size(75, 26);
            this.Throw_button.TabIndex = 22;
            this.Throw_button.Text = "Throw";
            this.Throw_button.UseVisualStyleBackColor = true;
            this.Throw_button.Click += new System.EventHandler(this.Throw_button_Click);
            // 
            // Show_button
            // 
            this.Show_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Show_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_button.Location = new System.Drawing.Point(780, 607);
            this.Show_button.Name = "Show_button";
            this.Show_button.Size = new System.Drawing.Size(75, 26);
            this.Show_button.TabIndex = 23;
            this.Show_button.Text = "Show";
            this.Show_button.UseVisualStyleBackColor = true;
            this.Show_button.Click += new System.EventHandler(this.Show_button_Click);
            // 
            // FinishTurn
            // 
            this.FinishTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishTurn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishTurn.Location = new System.Drawing.Point(780, 575);
            this.FinishTurn.Name = "FinishTurn";
            this.FinishTurn.Size = new System.Drawing.Size(75, 26);
            this.FinishTurn.TabIndex = 24;
            this.FinishTurn.Text = "Turn";
            this.FinishTurn.UseVisualStyleBackColor = true;
            this.FinishTurn.Click += new System.EventHandler(this.FinishTurn_Click);
            // 
            // pile_discard
            // 
            this.pile_discard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.pile_discard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pile_discard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pile_discard.Location = new System.Drawing.Point(12, 169);
            this.pile_discard.Name = "pile_discard";
            this.pile_discard.Size = new System.Drawing.Size(86, 22);
            this.pile_discard.TabIndex = 25;
            this.pile_discard.Text = "pile_discard";
            this.pile_discard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pile_discard.Visible = false;
            // 
            // discard_pile_count
            // 
            this.discard_pile_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.discard_pile_count.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discard_pile_count.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.discard_pile_count.Location = new System.Drawing.Point(20, 14);
            this.discard_pile_count.Name = "discard_pile_count";
            this.discard_pile_count.Size = new System.Drawing.Size(75, 32);
            this.discard_pile_count.TabIndex = 26;
            this.discard_pile_count.Text = "88";
            this.discard_pile_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discard_pile_count.Visible = false;
            // 
            // button_hint
            // 
            this.button_hint.BackColor = System.Drawing.Color.Transparent;
            this.button_hint.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_hint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hint.ForeColor = System.Drawing.Color.Transparent;
            this.button_hint.Location = new System.Drawing.Point(802, 12);
            this.button_hint.Name = "button_hint";
            this.button_hint.Size = new System.Drawing.Size(75, 26);
            this.button_hint.TabIndex = 27;
            this.button_hint.Text = "Hint";
            this.FormUiDemoTips.SetToolTip(this.button_hint, "Only one hint");
            this.button_hint.UseVisualStyleBackColor = false;
            this.button_hint.Click += new System.EventHandler(this.button_hint_Click);
            // 
            // label1_score
            // 
            this.label1_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.label1_score.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_score.Location = new System.Drawing.Point(11, 377);
            this.label1_score.Name = "label1_score";
            this.label1_score.Size = new System.Drawing.Size(108, 22);
            this.label1_score.TabIndex = 28;
            this.label1_score.Text = "Main Score: 0";
            // 
            // pbTrumpCard
            // 
            this.pbTrumpCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.pbTrumpCard.Location = new System.Drawing.Point(20, 59);
            this.pbTrumpCard.Name = "pbTrumpCard";
            this.pbTrumpCard.Size = new System.Drawing.Size(74, 107);
            this.pbTrumpCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrumpCard.TabIndex = 29;
            this.pbTrumpCard.TabStop = false;
            this.FormUiDemoTips.SetToolTip(this.pbTrumpCard, "Click the deck to draw a card.");
            this.pbTrumpCard.Click += new System.EventHandler(this.pbTrumpCard_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormUIDemo.Properties.Resources.table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(896, 644);
            this.Controls.Add(this.pbTrumpCard);
            this.Controls.Add(this.label1_score);
            this.Controls.Add(this.button_hint);
            this.Controls.Add(this.discard_pile_count);
            this.Controls.Add(this.pile_discard);
            this.Controls.Add(this.FinishTurn);
            this.Controls.Add(this.Show_button);
            this.Controls.Add(this.Throw_button);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label5_score);
            this.Controls.Add(this.lblPlayerBottom);
            this.Controls.Add(this.pnlPlayerBottom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.lblPlayerTop);
            this.Controls.Add(this.lblRiver);
            this.Controls.Add(this.pnlPlayerTop);
            this.Controls.Add(this.pnlRiver);
            this.Controls.Add(this.lblCardCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yaniv Card Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrumpCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip FormUiDemoTips;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.Label lblCardCount;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.Panel pnlPlayerTop;
        private System.Windows.Forms.Label lblRiver;
        private System.Windows.Forms.Label lblPlayerTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlPlayerBottom;
        private System.Windows.Forms.Label lblPlayerBottom;
        private System.Windows.Forms.Label label5_score;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button Throw_button;
        private System.Windows.Forms.Button Show_button;
        private System.Windows.Forms.Button FinishTurn;
        private System.Windows.Forms.Label pile_discard;
        private System.Windows.Forms.Label discard_pile_count;
        private System.Windows.Forms.Button button_hint;
        private System.Windows.Forms.Label label1_score;
        private System.Windows.Forms.PictureBox pbTrumpCard;
    }
}


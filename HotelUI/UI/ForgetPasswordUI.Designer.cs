namespace HotelUI.UI
{
    partial class ForgetPasswordUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordUI));
            this.LabelExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.LabelBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelExit.ForeColor = System.Drawing.Color.Black;
            this.LabelExit.Location = new System.Drawing.Point(373, 9);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(37, 38);
            this.LabelExit.TabIndex = 71;
            this.LabelExit.Text = "X";
            this.LabelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelExit_MouseClick);
            this.LabelExit.MouseEnter += new System.EventHandler(this.LabelExit_MouseEnter);
            this.LabelExit.MouseLeave += new System.EventHandler(this.LabelExit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "EMail  :";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Window;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(108, 291);
            this.Email.MaxLength = 255;
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(237, 35);
            this.Email.TabIndex = 73;
            this.Email.WordWrap = false;
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.SystemColors.Window;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Accept.Location = new System.Drawing.Point(217, 358);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(128, 33);
            this.Accept.TabIndex = 75;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // LabelBack
            // 
            this.LabelBack.AutoSize = true;
            this.LabelBack.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelBack.ForeColor = System.Drawing.Color.Black;
            this.LabelBack.Location = new System.Drawing.Point(330, 9);
            this.LabelBack.Name = "LabelBack";
            this.LabelBack.Size = new System.Drawing.Size(37, 38);
            this.LabelBack.TabIndex = 208;
            this.LabelBack.Text = "<<";
            this.LabelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelBack_MouseClick);
            this.LabelBack.MouseEnter += new System.EventHandler(this.LabelBack_MouseEnter);
            this.LabelBack.MouseLeave += new System.EventHandler(this.LabelBack_MouseLeave);
            // 
            // ForgetPasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(422, 513);
            this.Controls.Add(this.LabelBack);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPasswordUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordUI";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgetPasswordUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForgetPasswordUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ForgetPasswordUI_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label LabelBack;
    }
}

namespace HotelUI.UI
{
    partial class SaleUI
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
            this.LabelBack = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelBack
            // 
            this.LabelBack.AutoSize = true;
            this.LabelBack.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelBack.ForeColor = System.Drawing.Color.Black;
            this.LabelBack.Location = new System.Drawing.Point(712, 9);
            this.LabelBack.Name = "LabelBack";
            this.LabelBack.Size = new System.Drawing.Size(37, 38);
            this.LabelBack.TabIndex = 211;
            this.LabelBack.Text = "<<";
            this.LabelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelBack_MouseClick);
            this.LabelBack.MouseEnter += new System.EventHandler(this.LabelBack_MouseEnter);
            this.LabelBack.MouseLeave += new System.EventHandler(this.LabelBack_MouseLeave);
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelExit.ForeColor = System.Drawing.Color.Black;
            this.LabelExit.Location = new System.Drawing.Point(755, 9);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(33, 38);
            this.LabelExit.TabIndex = 210;
            this.LabelExit.Text = "x";
            // 
            // SaleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelBack);
            this.Controls.Add(this.LabelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleUI";
            this.Text = "SaleUI";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaleUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaleUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SaleUI_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBack;
        private System.Windows.Forms.Label LabelExit;
    }
}
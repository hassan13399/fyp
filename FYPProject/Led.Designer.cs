
namespace FYPProject
{
    partial class Led
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
            this.pin = new System.Windows.Forms.TextBox();
            this.getText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(126, 16);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(100, 23);
            this.pin.TabIndex = 3;
            this.pin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getText
            // 
            this.getText.Location = new System.Drawing.Point(261, 16);
            this.getText.Name = "getText";
            this.getText.Size = new System.Drawing.Size(75, 23);
            this.getText.TabIndex = 4;
            this.getText.Text = "Ok";
            this.getText.UseVisualStyleBackColor = true;
            this.getText.Click += new System.EventHandler(this.getText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Led
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(363, 53);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getText);
            this.Controls.Add(this.pin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Led";
            this.Text = "Led";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Button getText;
        private System.Windows.Forms.Label label1;
    }
}
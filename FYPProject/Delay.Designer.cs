
namespace FYPProject
{
    partial class Delay
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
            this.label1 = new System.Windows.Forms.Label();
            this.delayValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay  every";
            // 
            // delayValue
            // 
            this.delayValue.FormattingEnabled = true;
            this.delayValue.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            ""});
            this.delayValue.Location = new System.Drawing.Point(114, 16);
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(122, 23);
            this.delayValue.TabIndex = 1;
            // 
            // Delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.delayValue);
            this.Controls.Add(this.label1);
            this.Name = "Delay";
            this.Size = new System.Drawing.Size(265, 52);
            this.Load += new System.EventHandler(this.Delay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox delayValue;
    }
}


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
            this.delayValue = new System.Windows.Forms.ComboBox();
            this.IfLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.delayValue.Location = new System.Drawing.Point(194, 15);
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(165, 23);
            this.delayValue.TabIndex = 1;
            // 
            // IfLabel
            // 
            this.IfLabel.AutoSize = true;
            this.IfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IfLabel.Location = new System.Drawing.Point(75, 17);
            this.IfLabel.Name = "IfLabel";
            this.IfLabel.Size = new System.Drawing.Size(101, 21);
            this.IfLabel.TabIndex = 2;
            this.IfLabel.Text = "Delay every";
            // 
            // Delay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.IfLabel);
            this.Controls.Add(this.delayValue);
            this.Name = "Delay";
            this.Size = new System.Drawing.Size(408, 52);
            this.Load += new System.EventHandler(this.Delay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox delayValue;
        private System.Windows.Forms.Label IfLabel;
    }
}

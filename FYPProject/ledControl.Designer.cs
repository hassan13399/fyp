
namespace FYPProject
{
    partial class ledControl
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
            this.pinValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pin";
            // 
            // pinValue
            // 
            this.pinValue.FormattingEnabled = true;
            this.pinValue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.pinValue.Location = new System.Drawing.Point(73, 17);
            this.pinValue.Name = "pinValue";
            this.pinValue.Size = new System.Drawing.Size(121, 23);
            this.pinValue.TabIndex = 1;
            this.pinValue.SelectedIndexChanged += new System.EventHandler(this.pinValue_SelectedIndexChanged);
            // 
            // ledControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pinValue);
            this.Controls.Add(this.label1);
            this.Name = "ledControl";
            this.Size = new System.Drawing.Size(214, 54);
            this.Load += new System.EventHandler(this.ledControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ledControl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pinValue;
    }
}

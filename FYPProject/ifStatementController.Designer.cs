
namespace FYPProject
{
    partial class ifStatementController
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
            this.IfLabel = new System.Windows.Forms.Label();
            this.ifVariable1 = new System.Windows.Forms.ComboBox();
            this.ifCon = new System.Windows.Forms.ComboBox();
            this.ifVariable2 = new System.Windows.Forms.ComboBox();
            this.ifOpen = new System.Windows.Forms.Label();
            this.ifCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IfLabel
            // 
            this.IfLabel.AutoSize = true;
            this.IfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IfLabel.Location = new System.Drawing.Point(45, 25);
            this.IfLabel.Name = "IfLabel";
            this.IfLabel.Size = new System.Drawing.Size(21, 21);
            this.IfLabel.TabIndex = 0;
            this.IfLabel.Text = "if";
            // 
            // ifVariable1
            // 
            this.ifVariable1.FormattingEnabled = true;
            this.ifVariable1.Location = new System.Drawing.Point(96, 23);
            this.ifVariable1.Name = "ifVariable1";
            this.ifVariable1.Size = new System.Drawing.Size(121, 23);
            this.ifVariable1.TabIndex = 1;
            // 
            // ifCon
            // 
            this.ifCon.FormattingEnabled = true;
            this.ifCon.Items.AddRange(new object[] {
            "=",
            "==",
            "===",
            "!=",
            "<=",
            "<",
            ">",
            ">=",
            "!"});
            this.ifCon.Location = new System.Drawing.Point(237, 23);
            this.ifCon.Name = "ifCon";
            this.ifCon.Size = new System.Drawing.Size(53, 23);
            this.ifCon.TabIndex = 2;
            // 
            // ifVariable2
            // 
            this.ifVariable2.FormattingEnabled = true;
            this.ifVariable2.Location = new System.Drawing.Point(317, 23);
            this.ifVariable2.Name = "ifVariable2";
            this.ifVariable2.Size = new System.Drawing.Size(121, 23);
            this.ifVariable2.TabIndex = 3;
            // 
            // ifOpen
            // 
            this.ifOpen.AutoSize = true;
            this.ifOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ifOpen.Location = new System.Drawing.Point(468, 23);
            this.ifOpen.Name = "ifOpen";
            this.ifOpen.Size = new System.Drawing.Size(16, 21);
            this.ifOpen.TabIndex = 4;
            this.ifOpen.Text = "{";
            // 
            // ifCloseBtn
            // 
            this.ifCloseBtn.Location = new System.Drawing.Point(546, 0);
            this.ifCloseBtn.Name = "ifCloseBtn";
            this.ifCloseBtn.Size = new System.Drawing.Size(28, 23);
            this.ifCloseBtn.TabIndex = 5;
            this.ifCloseBtn.Text = "X";
            this.ifCloseBtn.UseVisualStyleBackColor = true;
            this.ifCloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ifCloseBtn_MouseClick);
            // 
            // ifStatementController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ifCloseBtn);
            this.Controls.Add(this.ifOpen);
            this.Controls.Add(this.ifVariable2);
            this.Controls.Add(this.ifCon);
            this.Controls.Add(this.ifVariable1);
            this.Controls.Add(this.IfLabel);
            this.Name = "ifStatementController";
            this.Size = new System.Drawing.Size(574, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IfLabel;
        private System.Windows.Forms.ComboBox ifVariable1;
        private System.Windows.Forms.ComboBox ifCon;
        private System.Windows.Forms.ComboBox ifVariable2;
        private System.Windows.Forms.Label ifOpen;
        private System.Windows.Forms.Button ifCloseBtn;
    }
}

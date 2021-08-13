
namespace FYPProject
{
    partial class WhileConditionController
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
            this.whileCon = new System.Windows.Forms.ComboBox();
            this.whileVariable1 = new System.Windows.Forms.ComboBox();
            this.whileVariable2 = new System.Windows.Forms.ComboBox();
            this.whileCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IfLabel
            // 
            this.IfLabel.AutoSize = true;
            this.IfLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IfLabel.Location = new System.Drawing.Point(42, 14);
            this.IfLabel.Name = "IfLabel";
            this.IfLabel.Size = new System.Drawing.Size(55, 21);
            this.IfLabel.TabIndex = 1;
            this.IfLabel.Text = "While";
            // 
            // whileCon
            // 
            this.whileCon.FormattingEnabled = true;
            this.whileCon.Items.AddRange(new object[] {
            "=",
            "==",
            "===",
            "!=",
            "<=",
            "<",
            ">",
            ">=",
            "!"});
            this.whileCon.Location = new System.Drawing.Point(263, 12);
            this.whileCon.Name = "whileCon";
            this.whileCon.Size = new System.Drawing.Size(53, 23);
            this.whileCon.TabIndex = 4;
            // 
            // whileVariable1
            // 
            this.whileVariable1.FormattingEnabled = true;
            this.whileVariable1.Location = new System.Drawing.Point(122, 12);
            this.whileVariable1.Name = "whileVariable1";
            this.whileVariable1.Size = new System.Drawing.Size(121, 23);
            this.whileVariable1.TabIndex = 3;
            // 
            // whileVariable2
            // 
            this.whileVariable2.FormattingEnabled = true;
            this.whileVariable2.Items.AddRange(new object[] {
            "=",
            "==",
            "===",
            "!=",
            "<=",
            "<",
            ">",
            ">=",
            "!"});
            this.whileVariable2.Location = new System.Drawing.Point(343, 12);
            this.whileVariable2.Name = "whileVariable2";
            this.whileVariable2.Size = new System.Drawing.Size(118, 23);
            this.whileVariable2.TabIndex = 5;
            // 
            // whileCloseBtn
            // 
            this.whileCloseBtn.Location = new System.Drawing.Point(543, 3);
            this.whileCloseBtn.Name = "whileCloseBtn";
            this.whileCloseBtn.Size = new System.Drawing.Size(28, 23);
            this.whileCloseBtn.TabIndex = 6;
            this.whileCloseBtn.Text = "X";
            this.whileCloseBtn.UseVisualStyleBackColor = true;
            this.whileCloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.whileCloseBtn_MouseClick);
            // 
            // WhileConditionController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.whileCloseBtn);
            this.Controls.Add(this.whileVariable2);
            this.Controls.Add(this.whileCon);
            this.Controls.Add(this.whileVariable1);
            this.Controls.Add(this.IfLabel);
            this.Name = "WhileConditionController";
            this.Size = new System.Drawing.Size(574, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IfLabel;
        private System.Windows.Forms.ComboBox whileCon;
        private System.Windows.Forms.ComboBox whileVariable1;
        private System.Windows.Forms.ComboBox whileVariable2;
        private System.Windows.Forms.Button whileCloseBtn;
    }
}

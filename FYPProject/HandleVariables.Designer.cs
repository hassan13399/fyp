
namespace FYPProject
{
    partial class HandleVariables
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.variableName = new System.Windows.Forms.TextBox();
            this.variableValue = new System.Windows.Forms.TextBox();
            this.variableType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // variableName
            // 
            this.variableName.Location = new System.Drawing.Point(99, 40);
            this.variableName.Name = "variableName";
            this.variableName.Size = new System.Drawing.Size(85, 23);
            this.variableName.TabIndex = 3;
            // 
            // variableValue
            // 
            this.variableValue.Location = new System.Drawing.Point(190, 40);
            this.variableValue.Name = "variableValue";
            this.variableValue.Size = new System.Drawing.Size(85, 23);
            this.variableValue.TabIndex = 4;
            // 
            // variableType
            // 
            this.variableType.FormattingEnabled = true;
            this.variableType.Items.AddRange(new object[] {
            "Int",
            "Double",
            "Boolean",
            "String"});
            this.variableType.Location = new System.Drawing.Point(3, 40);
            this.variableType.Name = "variableType";
            this.variableType.Size = new System.Drawing.Size(88, 23);
            this.variableType.TabIndex = 5;
            // 
            // HandleVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.variableType);
            this.Controls.Add(this.variableValue);
            this.Controls.Add(this.variableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HandleVariables";
            this.Size = new System.Drawing.Size(295, 77);
            this.Load += new System.EventHandler(this.HandleVariables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox variableName;
        private System.Windows.Forms.TextBox variableValue;
        private System.Windows.Forms.ComboBox variableType;
    }
}

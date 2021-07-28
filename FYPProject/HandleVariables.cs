using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FYPProject
{
    public partial class HandleVariables : UserControl
    {

        public HandleVariables()
        {
            InitializeComponent();
        }
        
        public String getvariableType() 
        {
            String VariableType = variableType.Text;
            return VariableType;
        }
        public String getvariableName() 
        {
            String VariableName = variableName.Text;
            return VariableName;
        }
        public String getvariableValue() 
        {
            String VariableValue = variableValue.Text;
            return VariableValue; 
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HandleVariables_Load(object sender, EventArgs e)
        {

        }

        private void variableType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    public partial class uxSizeInput : Form
    {
        private int _globlesize;

        public uxSizeInput()
        {
            InitializeComponent();
        }

        public int GetSize()
        {
            return _globlesize;
        } 

        private void uxConfirmSize_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(uxTextSize.Text);
            if (value>0 && value < 1000)
            {
                _globlesize = value;
                this.Close();

            }
            else
            {
                uxSizeError.Visible = true;
            }
        }
    }
}

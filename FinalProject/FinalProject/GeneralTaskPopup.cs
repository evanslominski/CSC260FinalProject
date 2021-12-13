using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GeneralTaskPopup : Form
    {
        public GeneralTaskPopup()
        {
            InitializeComponent();
        }

        public string nameText { get; set; }
        public string descriptionText { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            nameText = richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            descriptionText = richTextBox2.Text;
        }
    }
}

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
    public partial class ChristmasTaskPopup : Form
    {
        public string nameText { get; set; }
        public string descriptionText { get; set; }
        public string personRecievingText { get; set; }
        public string naughtyOrNiceText { get; set; }
        public ChristmasTaskPopup()
        {
            InitializeComponent();
        }

        private void ChristmasTaskPopup_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            nameText = richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            descriptionText = richTextBox1.Text;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            personRecievingText = richTextBox1.Text;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            naughtyOrNiceText = richTextBox1.Text;
        }
    }
}

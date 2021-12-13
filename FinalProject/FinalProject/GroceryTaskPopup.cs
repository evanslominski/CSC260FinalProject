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
    public partial class GroceryTaskPopup : Form
    {
        public string nameText { get; set; }
        public string descriptionText { get; set; }
        public string storeText { get; set; }
        public string categoryText { get; set; }

        public GroceryTaskPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void GroceryTaskPopup_Load(object sender, EventArgs e)
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
            storeText = richTextBox1.Text;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            categoryText = richTextBox1.Text;
        }
    }
}

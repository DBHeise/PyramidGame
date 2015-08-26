using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyramidGame
{
    public partial class WordForm : Form
    {
        public WordForm(String word)
        {
            InitializeComponent();
            this.label1.Text = word;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyramidGame
{
    public partial class PyramidForm : Form
    {
        Dictionary<int, List<String>> data;
        private Random rnd = new Random();
        public PyramidForm()
        {
            InitializeComponent();
            data = new Dictionary<int, List<string>>();
            data.Add(1, new List<String>(ConfigurationManager.AppSettings["1"].Split('|')));
            data.Add(2, new List<String>(ConfigurationManager.AppSettings["2"].Split('|')));
            data.Add(3, new List<String>(ConfigurationManager.AppSettings["3"].Split('|')));
            data.Add(4, new List<String>(ConfigurationManager.AppSettings["4"].Split('|')));
            data.Add(5, new List<String>(ConfigurationManager.AppSettings["5"].Split('|')));
            data.Add(6, new List<String>(ConfigurationManager.AppSettings["6"].Split('|')));
        }

        private void PyramidForm_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int? blockNum = int.Parse(lbl.Tag as String);
            if (blockNum.HasValue)
            {
                List<String> lst = data[blockNum.Value];
                String word = "empty list!";
                if (lst.Count > 0)
                {
                    int idx = rnd.Next(0, lst.Count);
                    word = lst[idx];
                    lst.Remove(word);
                    data[blockNum.Value] = lst;
                }
                String sentance = word;
                if (lbl.Text.Contains("___"))
                {
                    sentance = lbl.Text.Replace("___", word);
                }
                WordForm child = new WordForm(sentance);
                child.Show();

            }
            
        }
    }
}

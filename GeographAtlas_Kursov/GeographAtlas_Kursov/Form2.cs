using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographAtlas_Kursov
{
    public partial class Form2 : Form
    {
        List<string> Monuments { get; set; }
        List<string> MonumentsInfo { get; set; }
        public Form2(List<string> monuments, List<string> monumentsInfo)
        {
            InitializeComponent();
            Monuments = monuments;
            MonumentsInfo = monumentsInfo;
            foreach (string T in Monuments)
            {
                comboBox1.Items.Add(T);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                richTextBox1.Text = MonumentsInfo[comboBox1.SelectedIndex];
                label2.Text = comboBox1.SelectedItem.ToString();
                return;
            }
            MessageBox.Show("Оберіть монумент");
        }

    
    }
}

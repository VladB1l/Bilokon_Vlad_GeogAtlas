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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetCountries();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Region.RegionAdd();*/

            if (comboBox1.SelectedIndex != -1 && textBox1.Text != "")
            {
                Region R = new Region(textBox1.Text);
                R.Towns = new List<Town>();
                Form1.Countries[comboBox1.SelectedIndex].Regions.Add(R);
                MessageBox.Show("Успішно додано");
                comboBox1.SelectedIndex = -1;
                textBox1.Text = "";
                return;
            }
            MessageBox.Show("Заповніть усі дані!");

        }

        private void SetCountries()
        {
            comboBox1.Items.Clear();
            foreach (Country C in Form1.Countries)
            {
                comboBox1.Items.Add(C.Name);
                comboBox2.Items.Add(C.Name);
                comboBox4.Items.Add(C.Name);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            if (comboBox2.SelectedIndex != -1)
            {
                SetRegions1();
            }
        }

        private void SetRegions1()
        {
            comboBox3.Items.Clear();
            foreach (Region R in Form1.Countries[comboBox2.SelectedIndex].Regions)
            {
                comboBox3.Items.Add(R.Name);
            }
        }

        private void SetRegions2()
        {
            comboBox5.Items.Clear();
            foreach (Region R in Form1.Countries[comboBox4.SelectedIndex].Regions)
            {
                comboBox5.Items.Add(R.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*    Town.TownAdd();*/
            if (comboBox3.SelectedIndex != -1 && textBox2.Text != "")
            {
                Town T = new Town(textBox2.Text);
                T.Areas = new List<Area>();
                Form1.Countries[comboBox2.SelectedIndex].Regions[comboBox3.SelectedIndex].Towns.Add(T);
                MessageBox.Show("Успішно додано");
                comboBox3.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox2.Text = "";
                return;
            }
            MessageBox.Show("Заповніть усі дані!");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = -1;
            if (comboBox4.SelectedIndex != -1)
            {
                SetRegions2();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = -1;
            if (comboBox5.SelectedIndex != -1)
            {
                SetTowns();
            }
        }

        private void SetTowns()
        {
            comboBox6.Items.Clear();
            foreach (Town T in Form1.Countries[comboBox4.SelectedIndex].Regions[comboBox5.SelectedIndex].Towns)
            {
                comboBox6.Items.Add(T.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Area.AreaAdd();*/
            if (comboBox6.SelectedIndex != -1 && textBox3.Text != "")
            {
                Area A = new Area(textBox3.Text);
                Form1.Countries[comboBox4.SelectedIndex].Regions[comboBox5.SelectedIndex].Towns[comboBox6.SelectedIndex].Areas.Add(A);
                MessageBox.Show("Успішно додано");
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                textBox3.Text = "";
                return;
            }
            MessageBox.Show("Заповніть усі дані!");
        }
    }
}

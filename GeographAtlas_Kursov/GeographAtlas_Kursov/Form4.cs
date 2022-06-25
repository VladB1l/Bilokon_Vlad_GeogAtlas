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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SetCountries();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                SetRegions3();
            }
        }

        private void SetRegions3()
        {
            comboBox7.Items.Clear();
            foreach (Region R in Form1.Countries[comboBox1.SelectedIndex].Regions)
            {
                comboBox7.Items.Add(R.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Region.RegionRemove();*/
            if (comboBox7.SelectedIndex != -1)
            {
                Form1.Countries[comboBox1.SelectedIndex].Regions.RemoveAt(comboBox7.SelectedIndex);
                MessageBox.Show("Успішно видалено");
                comboBox1.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
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
            /*   Town.TownRemove();*/
            if (comboBox8.SelectedIndex != -1)
            {
                Form1.Countries[comboBox2.SelectedIndex].Regions[comboBox3.SelectedIndex].Towns.RemoveAt(comboBox8.SelectedIndex);
                MessageBox.Show("Успішно видалено");
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
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
            /* Area.AreaRemover();*/
            if (comboBox9.SelectedIndex != -1)
            {
                Form1.Countries[comboBox4.SelectedIndex].Regions[comboBox5.SelectedIndex].
                    Towns[comboBox6.SelectedIndex].Areas.RemoveAt(comboBox9.SelectedIndex);
                MessageBox.Show("Успішно видалено");
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                return;
            }
            MessageBox.Show("Заповніть усі дані!");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                SetTowns2();
            }
        }

        private void SetTowns2()
        {
            comboBox8.Items.Clear();
            foreach (Town T in Form1.Countries[comboBox2.SelectedIndex].Regions[comboBox3.SelectedIndex].Towns)
            {
                comboBox8.Items.Add(T.Name);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != -1)
            {
                SetAreas();
            }
        }

        private void SetAreas()
        {
            comboBox9.Items.Clear();
            foreach (Area A in Form1.Countries[comboBox4.SelectedIndex].Regions[comboBox5.SelectedIndex].Towns[comboBox6.SelectedIndex].Areas)
            {
                comboBox9.Items.Add(A.Name);
            }
        }
    }
}

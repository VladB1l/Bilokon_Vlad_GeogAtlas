using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographAtlas_Kursov
{
    public class Region 
    {
        public string Name { get; set; }
        public List<Town> Towns { get; set; }

        public Region() { }
        public Region(string Name)
        {
            this.Name = Name;

            Towns = new List<Town>();
        }
       /* public static void RegionAdd()
        {
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
        }*/
       /* public static void RegionRemove()
        {
            if (comboBox7.SelectedIndex != -1)
            {
                Form1.Countries[comboBox1.SelectedIndex].Regions.RemoveAt(comboBox7.SelectedIndex);
                MessageBox.Show("Успішно видалено");
                comboBox1.SelectedIndex = -1;
                comboBox7.SelectedIndex = -1;
                return;
            }
            MessageBox.Show("Заповніть усі дані!");
        }*/
    }
}





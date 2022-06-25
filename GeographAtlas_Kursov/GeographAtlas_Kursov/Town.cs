using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographAtlas_Kursov
{
    public class Town
    {
        public string Name { get; set; }
        public List<Area> Areas { get; set; }

        public Town() { }
        public Town(string Name)
        {
            this.Name = Name;

            Areas = new List<Area>();
        }
        /*public static void TownAdd()
        {
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
        }*/
       /* public static void TownRemove()
        {
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
        }*/
    }
}





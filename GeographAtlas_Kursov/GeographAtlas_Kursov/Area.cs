using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographAtlas_Kursov
{
    public class Area 
    {
        public string Name { get; set; }
        public Area() { }

        public Area(string Name)
        {
            this.Name = Name;

        }
       /* public static void AreaAdd()
        {
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
        }*/
      /*  public static void AreaRemove()
        {
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
        }*/
    }
}





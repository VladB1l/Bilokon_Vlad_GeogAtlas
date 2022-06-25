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
    public partial class Form1 : Form
    {
        public static List<Country> Countries { get; set; } = new List<Country>();
        public Form1()
        {
            InitializeComponent();
            Country C1 = new Country("Україна");
            Country C2 = new Country("Польща");
            Country C3 = new Country("Великобританія");
            C1.Nations.Add("Українці");
            C1.Nations.Add("Греки");
            C1.Nations.Add("Білоруси");
            C1.Nations.Add("Поляки");
            C1.Nations.Add("Угорці");
            C2.Nations.Add("Поляки");
            C2.Nations.Add("Українці");
            C3.Nations.Add("Англійці");
            C3.Nations.Add("Шотландці");
            C3.Nations.Add("Валійці");
            C1.Monuments.Add("Софіївський собор");
            C1.Monuments.Add("Майдан Незалежності");
            C1.MonumentsInfo.Add("Софія Київська — визначна пам'ятка історії та архітектури України, розташована на Софійській площі міста Києва");
            C1.MonumentsInfo.Add("18–20 лютого 2014 року на Майдані відбувалося силове протистояння, в результаті якого були значні жертви серед протестувальників, майдан був серйозно пошкоджений; окрім того, в ніч на 19 лютого був спалений Будинок профспілок України. Наметове містечко Євромайдану було розібране лише 9 серпня");
            C2.Monuments.Add("Король Ян Собеський");
            C2.Monuments.Add("Леви, що сплять");
            C2.MonumentsInfo.Add("Пам’ятник урочисто відкрили 1898-го, коли місто ще перебувало в межах Австро-Угорської монархії, ліберальної до таких проявів польського патріотизму. Він височів у представницькому місці — на Гетьманських валах (тепер — проспект Свободи)");
            C2.MonumentsInfo.Add("Пам’ятники мандрували і в протилежному напрямку — із заходу на схід. Виготовлені для так званих повернених земель, вони мали прикрасити відбудовану Варшаву");
            C3.Monuments.Add("Біг-Бен");
            C3.Monuments.Add("Букінгемський палац");
            C3.MonumentsInfo.Add("Біг-Бен - популярна туристична назва годинникової вежі Вестмінстерського палацу. Офіційна назва вежі з 2015 року — Вежа Єлизавети");
            C3.MonumentsInfo.Add("Початковий георгіанський інтер'єр включав штучний мармур і лазуровий та рожевий ляпіс. В 1853 було обладнано велику бальну залу. За правління короля Едуарда VII(1901 - 1910) внутрішню обстановку Букінгемського палацу змінено з канонами пануючої тоді французької бель епок, надавши інтер'єру кремові та золотаві кольорові тони. Численні маленькі приймальні та покої було обставлено в китайському стилі меблями з королівського палацу в Брайтоні та з палацу Картон-Хаус");
            Region R1 = new Region("Київська");
            Town T1 = new Town("Ірпінь");
            Town T2 = new Town("Київ");
            T1.Areas.Add(new Area("Парківний"));
            T1.Areas.Add(new Area("Набережний"));
            T2.Areas.Add(new Area("Солом'янський"));
            T2.Areas.Add(new Area("Шевченківський"));
            R1.Towns.Add(T1);
            R1.Towns.Add(T2);
            C1.Regions.Add(R1);
            Region R2 = new Region("Мазовецька");
            Town T3 = new Town("Варшава");
            R2.Towns.Add(T3);
            T3.Areas.Add(new Area("Варшавський"));
            C2.Regions.Add(R2);
            Region R3 = new Region("Англія");
            Town T4 = new Town("Лондон");
            T4.Areas.Add(new Area("Саттон"));
            T4.Areas.Add(new Area("Кройдон"));
            T4.Areas.Add(new Area("Бромлі"));
            R3.Towns.Add(T4);
            C3.Regions.Add(R3);
            Countries.Add(C1);
            Countries.Add(C2);
            Countries.Add(C3);
            SetCountries();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Clear();
                foreach (string T in Countries[comboBox1.SelectedIndex].Nations)
                {
                    listBox1.Items.Add(T);
                }
                return;
            }
            MessageBox.Show("Оберіть країну!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Form2 F2 = new Form2(Countries[comboBox1.SelectedIndex].Monuments, Countries[comboBox1.SelectedIndex].MonumentsInfo);
                F2.ShowDialog();
                return;
            }
            MessageBox.Show("Оберіть країну!");
        }

        private void SetCountries()
        {
            comboBox1.Items.Clear();
            foreach (Country C in Countries)
            {
                comboBox1.Items.Add(C.Name);
                comboBox2.Items.Add(C.Name);
                comboBox4.Items.Add(C.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (comboBox1.SelectedIndex != -1)
            {
                foreach (Region R in Countries[comboBox1.SelectedIndex].Regions)
                {
                    listBox3.Items.Add(R.Name);
                }
                return;
            }
            MessageBox.Show("Оберіть країну!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            if (comboBox2.SelectedIndex != -1)
            {
                SetRegions1();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                listBox2.Items.Clear();
                foreach (Town T in Countries[comboBox2.SelectedIndex].Regions[comboBox3.SelectedIndex].Towns)
                {
                    listBox2.Items.Add(T.Name);
                }
                return;
            }
            MessageBox.Show("Заповніть дані!");
        }

        private void SetRegions1()
        {
            comboBox3.Items.Clear();
            foreach (Region R in Countries[comboBox2.SelectedIndex].Regions)
            {
                comboBox3.Items.Add(R.Name);
            }
        }

        private void SetRegions2()
        {
            comboBox5.Items.Clear();
            foreach (Region R in Countries[comboBox4.SelectedIndex].Regions)
            {
                comboBox5.Items.Add(R.Name);
            }
        }

        private void SetTowns()
        {
            comboBox6.Items.Clear();
            foreach (Town T in Countries[comboBox4.SelectedIndex].Regions[comboBox5.SelectedIndex].Towns)
            {
                comboBox6.Items.Add(T.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = -1;
            if (comboBox5.SelectedIndex != -1)
            {
                SetTowns();
                return;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            if (comboBox4.SelectedIndex != -1)
            {
                SetRegions2();
                return;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            if (comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {
                foreach (Area A in Countries[comboBox4.SelectedIndex].
                    Regions[comboBox5.SelectedIndex].
                    Towns[comboBox6.SelectedIndex].Areas)
                {
                    listBox4.Items.Add(A.Name);
                }
                return;
            }
            MessageBox.Show("Заповніть дані!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.ShowDialog();
        }

      
    }
}
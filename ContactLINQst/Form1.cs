using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactLINQst
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Det här blev bra.
            // För varje rad i names.csv, gör en split på ';'
            // Gör en ny Person för varje rad med radens-arrayens första och andra innehåll
            // som argument in i Persons konstruktor. Gruppera hela listan efter namn,
            // plocka ut det första namnet ur varje grupp och skapa en ny lista.

            people = (from line in File.ReadAllLines("names.csv", Encoding.Default)
                      let nameAndNameday = line.Split(';')
                      select new Person(nameAndNameday[0], DateTime.Parse(nameAndNameday[1])))
                      .GroupBy(x => x.Namn)
                      .Select(y => y.First())
                      .ToList();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            Clear();

            listBox1.Items.AddRange(people.Where(x => x.Namn.Length >= 3 && x.Namn.StartsWith("And"))
                .Select(y => y.Namn)
                .ToArray());
        }

        private void nameDayJuly23Button_Click(object sender, EventArgs e)
        {
            Clear();

            DateTime july23 = DateTime.Parse("23 July");

            listBox1.Items.AddRange(people.Where(x => x.NameDay.Day == july23.Day && x.NameDay.Month == july23.Month)
                .Select(y => y.Namn)
                .ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();

            DateTime april = DateTime.Parse("April 1");

            listBox1.Items.AddRange(people.Where(x => x.Namn.Substring(0, 1) == "P" && x.NameDay.Month == april.Month)
                .Select(y => y.Namn)
                .ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            textBox2.Clear();

            listBox1.Items.AddRange(people.Where(x => x.Namn.ToLower() == textBox1.Text.ToLower())
                .Select(y => y.Namn)
                .ToArray());
        }

        private void Clear()
        {
            listBox1.Items.Clear();

            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Clear();

            DateTime date = DateTime.Now.AddYears(1);

            try
            {
                date = DateTime.Parse(textBox2.Text);

                listBox1.Items.AddRange(people.Where(x => x.NameDay.Date == date.Date)
                .Select(y => y.Namn)
                .ToArray());
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add($"{i}: {(people.Where(x => x.Namn.StartsWith(i.ToString())).Count())}");
            }

            listBox1.Items.Add($"{'Å'}: {(people.Where(x => x.Namn.StartsWith("Å")).Count())}");
            listBox1.Items.Add($"{'Ä'}: {(people.Where(x => x.Namn.StartsWith("Ä")).Count())}");
            listBox1.Items.Add($"{'Ö'}: {(people.Where(x => x.Namn.StartsWith("Ö")).Count())}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();

            listBox1.Items.AddRange(people.GroupBy(x => x.NameDay.Month)
                //.OrderBy(x => x.Key)
                .Select(g => $"{(MonthName)g.Key}: {g.Count()}")
                .ToArray());
        }

        enum MonthName
        {
            Januari = 1,
            Februari,
            Mars,
            April,
            Maj,
            Juni,
            Juli,
            Augusti,
            September,
            Oktober,
            November,
            December
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();

            listBox1.Items.AddRange(people
                .ToLookup(p => ((p.NameDay.Month - 1) / 3) + 1)
                .OrderBy(k => k.Key)
                .Select(s => $"Kvartal {s.Key}: {s.Count()}")
                .ToArray());
        }
    }
}

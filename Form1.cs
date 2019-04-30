using System;
using System.Windows.Forms;
using static comparisonOfSorts.Fillings;
using static comparisonOfSorts.SortingTime;
using System.Collections.Generic;

namespace comparisonOfSorts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && comboBox1.SelectedIndex >=0 && comboBox2.SelectedIndex >= 0)
            {
                var quantity = int.Parse(textBox1.Text);
                var array = new int[quantity];
                var fillingType = comboBox2.SelectedItem.ToString();
                switch (fillingType)
                {
                    case "Случайно":
                        FillRandomly(array);
                        break;
                    case "По возрастанию":
                        FillAscending(array);
                        break;
                    case "По убыванию":
                        FillDescending(array);
                        break;
                }
                var sorting = comboBox1.SelectedItem.ToString();
                textBox2.Text = GetSortingTime(array, sorting).ToString();
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0 && comboBox3.SelectedIndex >= 0)
            {
                var sortings = new List<string>();
                foreach (string sort in checkedListBox1.CheckedItems)
                {
                    sortings.Add(sort);
                }
                var form = new Form2(comboBox3.Text, sortings);
                form.Show();
            }
            else
                MessageBox.Show("Заполните все поля!");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            comboBox3.SelectedItem = null;
        }
    }
}

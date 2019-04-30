using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static comparisonOfSorts.SortingTime;

namespace comparisonOfSorts
{
    public partial class Form2 : Form
    {
        public Form2(string fillingType, List<string> sortingTypes)
        {
            InitializeComponent();
            var  pane = zedGraphControl1.GraphPane;
            pane.XAxis.Title = "Размер массива";
            pane.YAxis.Title = "Время сортировки";
            pane.Title = "Время сортировки";
            pane.CurveList.Clear();
            var color = new Color();

            foreach (var type in sortingTypes)
            {
                switch(type)
                {
                    case "Пузырьковая":
                        color = Color.Red;
                        break;
                    case "Вставками":
                        color = Color.Orange;
                        break;
                    case "Слиянием":
                        color = Color.Yellow;
                        break;
                    case "Быстрая":
                        color = Color.Black;
                        break;
                    case "Выбором":
                        color = Color.Blue;
                        break;
                    case "Шейкерная":
                        color = Color.Violet;
                        break;
                }

                var list = GetSortingList(fillingType, type);
                pane.AddCurve(type, list, color);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

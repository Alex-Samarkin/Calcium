using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// для генерации случайных чисел
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;
using MathNet.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Statistics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = chart1;
        }

        /// <summary>
        /// данные для отображения
        /// </summary>
        public List<double> items { get; set; } = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            // удаляем старые данные
            items.Clear();

            // create an array with 1000 random values
            double[] c = new double[100000];
            Normal.Samples(c, 0.0, 1.0);
            // добавляем данные в хранилище
            items.AddRange(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (items.Count < 2) return;
            // убираем лишние оси
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(
                new ChartArea("Сырые данные"));
            // чистим серии, добавляем новую
            chart1.Series.Clear();
            var srs = new 
                System.Windows.Forms.DataVisualization.Charting.Series(
                "Нормальное распределение");
            srs.ChartType = SeriesChartType.Point;
            srs.ChartArea = "Сырые данные";
            // заливаем точки в серию
            for (int i = 0; i < items.Count; i++)
            {
                srs.Points.Add(items[i]);
            }
            // показываем
            chart1.Series.Add(srs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (items.Count < 2) return;
            // добавляем новую ось
            chart1.ChartAreas.Add(
                new ChartArea("Гистограмма"));
            // добавляем новую серию
            var srs = new
                System.Windows.Forms.DataVisualization.Charting.Series(
                "Гистограмма распределения");
            // тип серии - прямоугольники от горизонтальной оси
            srs.ChartType = SeriesChartType.Column;
            srs.ChartArea = "Гистограмма";

            // расчет гистограммы 
            int bins1 = (int)Math.Sqrt(items.Count);
            int bins2 = 1+(int)(Math.Log10(items.Count)*3.22);
            var hst = new Histogram(items,bins2);

            // для каждого интервала гистограммы
            for (int i = 0;i < hst.BucketCount;i++) 
            {
                // интревал
                var b = hst[i];
                // x - середина интервала
                // y - количество данных
                srs.Points.AddXY((b.LowerBound+b.UpperBound)/2,b.Count);
            }
            // добавляем серию
            chart1.Series.Add(srs);
        }
    }
}

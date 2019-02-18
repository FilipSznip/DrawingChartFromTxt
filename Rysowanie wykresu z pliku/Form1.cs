using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Drawing_Chart
{
    public partial class Form1 : Form
    {
        private double FirstAngle;
        private double ScanRange;
        private double StepWidth;
        private double NrOfData;
        private double maxValue = 0;
        private double leftSide = 0;
        private double rightSide = 0;

        
        StreamReader file;
        string[] Values;

        public Form1()
        {
            InitializeComponent();
        }

        private double ReadValues(int lineNumber, int index)
        {

            string[] split = Values[lineNumber].Split(new string[] { " ", ",", "\r\n", "\n" }, StringSplitOptions.None);
            double Value = double.Parse(split[index], new System.Globalization.CultureInfo("en-US"));
            return (Value);
        }

        private void Chart()
        {
            int index = 21;
            double x = FirstAngle;
            double y = Convert.ToInt32((ReadValues(21, 0)));
            chart.Series["Series1"].Points.Clear();
            chart.Series["Series2"].Points.Clear();
            for (double i = 0; i < NrOfData; i++)
            {
                chart.Series["Series1"].Points.AddXY(x, y);
                x = x + StepWidth;
                y = Convert.ToInt32((ReadValues(index, 0)));
                index++;

            }
        }

        private void Range()
        {
            chart.Series["Series2"].Points.AddXY(leftSide, 0);
            chart.Series["Series2"].Points.AddXY(leftSide,maxValue / 2);
            chart.Series["Series2"].Points.AddXY(rightSide, maxValue / 2);
            chart.Series["Series2"].Points.AddXY(rightSide, 0);
        }

        private void HighestValue()
        {
            double step = 0;
            int index = 21;
            for (double i = 0; i < NrOfData; i++)
            {
                step = ReadValues(index,0);
                if(step > maxValue)
                {
                    maxValue = step;
                }
                index++;
            }
        }

        private void LeftHalfMax()
        {
            double step = 0;
            int index = 21;
            double i = 0;
            while (i <= (maxValue/2))
            {
                i = ReadValues(index, 0);
                step = index;
                index++;
            }
            leftSide = FirstAngle + ((step-20.2 ) * StepWidth);
        }

        private void RightHalfMax()
        {
            int index =0 ;
            int step = 0;
            int nr = 0;
            nr = (int)NrOfData;
            int back_index = nr + index;
            
            double i = 0;
            while (i <= (maxValue/2))
            {
                i = ReadValues(back_index, 0);
                step = back_index;
                back_index--;
            }
            rightSide = FirstAngle + ((step-19.2 ) * StepWidth);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (Load.ShowDialog() == DialogResult.OK)
            {
                if (Load.FileName != "")
                {
                    FileStream _file = (FileStream)Load.OpenFile();
                    file = new StreamReader(_file);
                    string filename = Load.FileName;
                    Values = File.ReadAllLines(filename);
                }
            }
            FirstAngle = ReadValues(15, 2);
            ScanRange = ReadValues(16, 2);
            StepWidth = ReadValues(17, 2);
            NrOfData = ReadValues(19, 2);
            label1.Text = FirstAngle.ToString();
            label3.Text = StepWidth.ToString();
            label4.Text = NrOfData.ToString();
            HighestValue();
            label5.Text = maxValue.ToString();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                Chart();
            }
            catch (Exception)
            {

                MessageBox.Show("Please pick a measurement file");
            }
        }

        private void Draw_Fwhm(object sender, EventArgs e)
        {
            try
            {
                label6.Text = (maxValue / 2).ToString();
                LeftHalfMax();
                RightHalfMax();
                double fwhm = leftSide - rightSide;
                label8.Text = fwhm.ToString();
                Range();
            }
            catch (Exception)
            {

                MessageBox.Show("Please pick a measurement file");
                Application.Restart();

            }
        }
    }
}

namespace Drawing_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.przycisk_Wczytaj = new System.Windows.Forms.Button();
            this.przycisk_Rysuj = new System.Windows.Forms.Button();
            this.ikona_FirstAngle = new System.Windows.Forms.Label();
            this.ikona_StepWidth = new System.Windows.Forms.Label();
            this.ikona_NrOfData = new System.Windows.Forms.Label();
            this.label_NrOfData = new System.Windows.Forms.Label();
            this.label_FirstAngle = new System.Windows.Forms.Label();
            this.label_StepWidth = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_TheBiggest = new System.Windows.Forms.Label();
            this.ikona_TheBiggest = new System.Windows.Forms.Label();
            this.label_Second = new System.Windows.Forms.Label();
            this.label_First = new System.Windows.Forms.Label();
            this.przycisk_RysujZakres = new System.Windows.Forms.Button();
            this.ikona_Middle = new System.Windows.Forms.Label();
            this.label_Middle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk_Wczytaj
            // 
            this.przycisk_Wczytaj.BackColor = System.Drawing.Color.PeachPuff;
            this.przycisk_Wczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_Wczytaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.przycisk_Wczytaj.Location = new System.Drawing.Point(631, 12);
            this.przycisk_Wczytaj.Name = "przycisk_Wczytaj";
            this.przycisk_Wczytaj.Size = new System.Drawing.Size(104, 27);
            this.przycisk_Wczytaj.TabIndex = 0;
            this.przycisk_Wczytaj.Text = "Open file";
            this.przycisk_Wczytaj.UseVisualStyleBackColor = false;
            this.przycisk_Wczytaj.Click += new System.EventHandler(this.Load_Click);
            // 
            // przycisk_Rysuj
            // 
            this.przycisk_Rysuj.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.przycisk_Rysuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_Rysuj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.przycisk_Rysuj.Location = new System.Drawing.Point(631, 45);
            this.przycisk_Rysuj.Name = "przycisk_Rysuj";
            this.przycisk_Rysuj.Size = new System.Drawing.Size(104, 29);
            this.przycisk_Rysuj.TabIndex = 1;
            this.przycisk_Rysuj.Text = "Start";
            this.przycisk_Rysuj.UseVisualStyleBackColor = false;
            this.przycisk_Rysuj.Click += new System.EventHandler(this.Draw_Click);
            // 
            // ikona_FirstAngle
            // 
            this.ikona_FirstAngle.AutoSize = true;
            this.ikona_FirstAngle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ikona_FirstAngle.Location = new System.Drawing.Point(621, 113);
            this.ikona_FirstAngle.Name = "ikona_FirstAngle";
            this.ikona_FirstAngle.Size = new System.Drawing.Size(114, 30);
            this.ikona_FirstAngle.TabIndex = 2;
            this.ikona_FirstAngle.Text = "Poczatek X:";
            // 
            // ikona_StepWidth
            // 
            this.ikona_StepWidth.AutoSize = true;
            this.ikona_StepWidth.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ikona_StepWidth.Location = new System.Drawing.Point(620, 148);
            this.ikona_StepWidth.Name = "ikona_StepWidth";
            this.ikona_StepWidth.Size = new System.Drawing.Size(169, 27);
            this.ikona_StepWidth.TabIndex = 4;
            this.ikona_StepWidth.Text = "Krok Pomiarowy:";
            // 
            // ikona_NrOfData
            // 
            this.ikona_NrOfData.AutoSize = true;
            this.ikona_NrOfData.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ikona_NrOfData.Location = new System.Drawing.Point(620, 164);
            this.ikona_NrOfData.Name = "ikona_NrOfData";
            this.ikona_NrOfData.Size = new System.Drawing.Size(154, 30);
            this.ikona_NrOfData.TabIndex = 5;
            this.ikona_NrOfData.Text = "Liczba punktow:";
            // 
            // label_NrOfData
            // 
            this.label_NrOfData.AutoSize = true;
            this.label_NrOfData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NrOfData.Location = new System.Drawing.Point(300, 391);
            this.label_NrOfData.Name = "label_NrOfData";
            this.label_NrOfData.Size = new System.Drawing.Size(0, 20);
            this.label_NrOfData.TabIndex = 6;
            // 
            // label_FirstAngle
            // 
            this.label_FirstAngle.AutoSize = true;
            this.label_FirstAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_FirstAngle.Location = new System.Drawing.Point(351, 491);
            this.label_FirstAngle.Name = "label_FirstAngle";
            this.label_FirstAngle.Size = new System.Drawing.Size(0, 20);
            this.label_FirstAngle.TabIndex = 7;
            // 
            // label_StepWidth
            // 
            this.label_StepWidth.AutoSize = true;
            this.label_StepWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_StepWidth.Location = new System.Drawing.Point(300, 361);
            this.label_StepWidth.Name = "label_StepWidth";
            this.label_StepWidth.Size = new System.Drawing.Size(0, 20);
            this.label_StepWidth.TabIndex = 9;
            // 
            // chart
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.Size = 0.5F;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.Size = 0.5F;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series2";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(577, 322);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // label_TheBiggest
            // 
            this.label_TheBiggest.AutoSize = true;
            this.label_TheBiggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_TheBiggest.Location = new System.Drawing.Point(300, 421);
            this.label_TheBiggest.Name = "label_TheBiggest";
            this.label_TheBiggest.Size = new System.Drawing.Size(0, 20);
            this.label_TheBiggest.TabIndex = 11;
            // 
            // ikona_TheBiggest
            // 
            this.ikona_TheBiggest.AutoSize = true;
            this.ikona_TheBiggest.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ikona_TheBiggest.Location = new System.Drawing.Point(620, 181);
            this.ikona_TheBiggest.Name = "ikona_TheBiggest";
            this.ikona_TheBiggest.Size = new System.Drawing.Size(75, 27);
            this.ikona_TheBiggest.TabIndex = 12;
            this.ikona_TheBiggest.Text = "Max Y:";
            // 
            // label_Second
            // 
            this.label_Second.AutoSize = true;
            this.label_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Second.Location = new System.Drawing.Point(114, 410);
            this.label_Second.Name = "label_Second";
            this.label_Second.Size = new System.Drawing.Size(0, 20);
            this.label_Second.TabIndex = 13;
            // 
            // label_First
            // 
            this.label_First.AutoSize = true;
            this.label_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_First.Location = new System.Drawing.Point(114, 380);
            this.label_First.Name = "label_First";
            this.label_First.Size = new System.Drawing.Size(0, 20);
            this.label_First.TabIndex = 14;
            // 
            // przycisk_RysujZakres
            // 
            this.przycisk_RysujZakres.BackColor = System.Drawing.SystemColors.Desktop;
            this.przycisk_RysujZakres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_RysujZakres.ForeColor = System.Drawing.Color.Tomato;
            this.przycisk_RysujZakres.Location = new System.Drawing.Point(631, 80);
            this.przycisk_RysujZakres.Name = "przycisk_RysujZakres";
            this.przycisk_RysujZakres.Size = new System.Drawing.Size(104, 30);
            this.przycisk_RysujZakres.TabIndex = 17;
            this.przycisk_RysujZakres.Text = "FWHM";
            this.przycisk_RysujZakres.UseVisualStyleBackColor = false;
            this.przycisk_RysujZakres.Click += new System.EventHandler(this.Draw_Fwhm);
            // 
            // ikona_Middle
            // 
            this.ikona_Middle.AutoSize = true;
            this.ikona_Middle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ikona_Middle.Location = new System.Drawing.Point(621, 198);
            this.ikona_Middle.Name = "ikona_Middle";
            this.ikona_Middle.Size = new System.Drawing.Size(159, 27);
            this.ikona_Middle.TabIndex = 18;
            this.ikona_Middle.Text = "Wart. Srednia X:";
            // 
            // label_Middle
            // 
            this.label_Middle.AutoSize = true;
            this.label_Middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Middle.Location = new System.Drawing.Point(114, 350);
            this.label_Middle.Name = "label_Middle";
            this.label_Middle.Size = new System.Drawing.Size(0, 20);
            this.label_Middle.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(626, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "FWHM:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(804, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Middle);
            this.Controls.Add(this.ikona_Middle);
            this.Controls.Add(this.przycisk_RysujZakres);
            this.Controls.Add(this.label_First);
            this.Controls.Add(this.label_Second);
            this.Controls.Add(this.ikona_TheBiggest);
            this.Controls.Add(this.label_TheBiggest);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label_StepWidth);
            this.Controls.Add(this.label_FirstAngle);
            this.Controls.Add(this.label_NrOfData);
            this.Controls.Add(this.ikona_NrOfData);
            this.Controls.Add(this.ikona_StepWidth);
            this.Controls.Add(this.ikona_FirstAngle);
            this.Controls.Add(this.przycisk_Rysuj);
            this.Controls.Add(this.przycisk_Wczytaj);
            this.Name = "Form1";
            this.Text = "Wykres z Pliku";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_Wczytaj;
        private System.Windows.Forms.Button przycisk_Rysuj;
        private System.Windows.Forms.Label ikona_FirstAngle;
        private System.Windows.Forms.Label ikona_StepWidth;
        private System.Windows.Forms.Label ikona_NrOfData;
        private System.Windows.Forms.Label label_NrOfData;
        private System.Windows.Forms.Label label_FirstAngle;
        private System.Windows.Forms.Label label_StepWidth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label_TheBiggest;
        private System.Windows.Forms.Label ikona_TheBiggest;
        private System.Windows.Forms.Label label_Second;
        private System.Windows.Forms.Label label_First;
        private System.Windows.Forms.Button przycisk_RysujZakres;
        private System.Windows.Forms.Label ikona_Middle;
        private System.Windows.Forms.Label label_Middle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}


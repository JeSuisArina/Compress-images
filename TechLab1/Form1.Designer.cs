namespace TechLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LoadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.RLE = new System.Windows.Forms.Button();
            this.LZW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textStart = new System.Windows.Forms.TextBox();
            this.textRLE = new System.Windows.Forms.TextBox();
            this.textLZW = new System.Windows.Forms.TextBox();
            this.textLost = new System.Windows.Forms.TextBox();
            this.JpegB = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Graph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(103, 319);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(144, 28);
            this.LoadImage.TabIndex = 0;
            this.LoadImage.Text = "Загрузить изображение";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Алгоритмы сжатия:";
            // 
            // RLE
            // 
            this.RLE.Enabled = false;
            this.RLE.Location = new System.Drawing.Point(281, 31);
            this.RLE.Name = "RLE";
            this.RLE.Size = new System.Drawing.Size(75, 23);
            this.RLE.TabIndex = 3;
            this.RLE.Text = "RLE";
            this.RLE.UseVisualStyleBackColor = true;
            this.RLE.Click += new System.EventHandler(this.RLE_Click);
            // 
            // LZW
            // 
            this.LZW.Enabled = false;
            this.LZW.Location = new System.Drawing.Point(407, 31);
            this.LZW.Name = "LZW";
            this.LZW.Size = new System.Drawing.Size(75, 23);
            this.LZW.TabIndex = 4;
            this.LZW.Text = "LZW";
            this.LZW.UseVisualStyleBackColor = true;
            this.LZW.Click += new System.EventHandler(this.LZW_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Объем данных:";
            // 
            // textStart
            // 
            this.textStart.Enabled = false;
            this.textStart.Location = new System.Drawing.Point(100, 60);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(144, 20);
            this.textStart.TabIndex = 7;
            // 
            // textRLE
            // 
            this.textRLE.Enabled = false;
            this.textRLE.Location = new System.Drawing.Point(281, 60);
            this.textRLE.Name = "textRLE";
            this.textRLE.Size = new System.Drawing.Size(120, 20);
            this.textRLE.TabIndex = 8;
            // 
            // textLZW
            // 
            this.textLZW.Enabled = false;
            this.textLZW.Location = new System.Drawing.Point(407, 60);
            this.textLZW.Name = "textLZW";
            this.textLZW.Size = new System.Drawing.Size(120, 20);
            this.textLZW.TabIndex = 9;
            // 
            // textLost
            // 
            this.textLost.Enabled = false;
            this.textLost.Location = new System.Drawing.Point(533, 60);
            this.textLost.Name = "textLost";
            this.textLost.Size = new System.Drawing.Size(120, 20);
            this.textLost.TabIndex = 10;
            // 
            // JpegB
            // 
            this.JpegB.Enabled = false;
            this.JpegB.Location = new System.Drawing.Point(533, 31);
            this.JpegB.Name = "JpegB";
            this.JpegB.Size = new System.Drawing.Size(75, 23);
            this.JpegB.TabIndex = 11;
            this.JpegB.Text = "JPEG";
            this.JpegB.UseVisualStyleBackColor = true;
            this.JpegB.Click += new System.EventHandler(this.JpegB_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(281, 86);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(372, 227);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(533, 317);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(117, 28);
            this.Graph.TabIndex = 13;
            this.Graph.Text = "Построить график";
            this.Graph.UseVisualStyleBackColor = true;
            this.Graph.Click += new System.EventHandler(this.Graph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 353);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.JpegB);
            this.Controls.Add(this.textLost);
            this.Controls.Add(this.textLZW);
            this.Controls.Add(this.textRLE);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LZW);
            this.Controls.Add(this.RLE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadImage);
            this.Name = "Form1";
            this.Text = "Сжатие изображений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RLE;
        private System.Windows.Forms.Button LZW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.TextBox textRLE;
        private System.Windows.Forms.TextBox textLZW;
        private System.Windows.Forms.TextBox textLost;
        private System.Windows.Forms.Button JpegB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Graph;
    }
}


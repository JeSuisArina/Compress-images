using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;
            }

            FileInfo file = new FileInfo(openFileDialog1.FileName);
            textStart.Text = file.Length.ToString();

            RLE.Enabled = true;
            LZW.Enabled = true;
            JpegB.Enabled = true;
        }

        static int f(FileStream fout, byte thisByte, int count)
        {
            if (count > 1)
            {
                fout.WriteByte(thisByte);
                fout.WriteByte((byte)count);
            } return 1;
        }

        private void RLE_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream("RLEfile.rle", FileMode.Create, FileAccess.Write);

            byte thisByte = (byte)fs.ReadByte();            
            fout.WriteByte(thisByte);
            int count = 1;

            while (fs.Position != fs.Length)
            {
                byte nextByte = (byte)fs.ReadByte();
                if (nextByte == thisByte)
                {
                    if (count++ > 250)
                    {
                        count = f(fout, thisByte, count);
                        thisByte = (byte)fs.ReadByte();
                        fout.WriteByte(thisByte);
                    }
                    continue;
                }
                count = f(fout, thisByte, count);
                fout.WriteByte(nextByte);
                thisByte = nextByte;
                count = 1;
            }
            count = f(fout, thisByte, count);

            fs.Close();            
            fout.Close();

            FileInfo file = new FileInfo("RLEfile.rle");
            textRLE.Text = file.Length.ToString();
        }
        
        private void LZW_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader biReader = new BinaryReader(fs);
            byte[] source1 = biReader.ReadBytes((int)fs.Length);
            List<char> Char = new List<char>();
            List<UInt16> Res16 = new List<ushort>();
            List<uint> Res32 = new List<uint>();
            List<int> count = new List<int>();
            List<uint> compressed = new List<uint>();
            List<byte> source = new List<byte>();
            source = source1.ToList();

            foreach (byte piece in source)
                Char.Add(Convert.ToChar(piece));

            Dictionary<string, UInt32> dict = new Dictionary<string, uint>();

            for (UInt32 i = 0; i <= 255; i++)
            {
                dict.Add(Convert.ToChar(i).ToString(), i);
            }

            string w = ""; //current string
            string c = ""; //new string
            string wc = "";
            bool twoBytes = true;
            UInt32 size = 256;

            for (int i = 0; i < source.Count; i++)
            {
                c = Char[i].ToString();
                wc = w + c;
                if (dict.ContainsKey(wc))
                {
                    w = wc;
                }
                else
                {
                    dict.Add(wc, size);
                    compressed.Add(dict[w]);
                    w = c;
                    size++;
                }
            }

            if (!string.IsNullOrEmpty(w))
                compressed.Add(dict[w]);

            UInt16 temp16 = 0;
            UInt32 temp32 = 0;

            for (int i = 0; i < compressed.Count; i++)
            {
                if (twoBytes == true)
                {
                    if (compressed[i] < Math.Pow(2, 16))
                    {
                        Res16.Add(Convert.ToUInt16(compressed[i]));
                        temp16++;
                    }
                    else
                    {
                        count.Add(temp16);
                        temp16 = 1;
                        Res32.Add(compressed[i]);
                        twoBytes = false;
                        temp32 = 1;
                    }
                }
                else
                {
                    if (compressed[i] < Math.Pow(2, 16))
                    {
                        count.Add(Convert.ToUInt16(temp32));
                        temp32 = 0;
                        Res16.Add(Convert.ToUInt16(compressed[i]));
                        twoBytes = true;
                        temp16 = 1;
                    }
                    else
                    {
                        Res32.Add(compressed[i]);
                        temp32++;
                    }
                }
            }
            if (twoBytes == true) count.Add(temp16);
            else count.Add(Convert.ToUInt16(temp32));

            int k = 4 * Res32.Count + 2 * Res16.Count + 4 * count.Count; 
            textLZW.Text = k.ToString();

            fs.Close();
        }
        

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo code in codecs)
            {
                if (code.FormatID == format.Guid)
                    return code;
            }
            return null;
        }

        private void JpegB_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParametres = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameter = new EncoderParameter(myEncoder, 0L);
            myEncoderParametres.Param[0] = myEncoderParameter;
            bitmap.Save("Jpeg.jpg", jpgEncoder, myEncoderParametres);
            FileInfo file = new FileInfo("Jpeg.jpg");
            textLost.Text = file.Length.ToString();
        }

        private void Graph_Click(object sender, EventArgs e)
        {
            this.chart1.Visible = true;
            this.chart1.Series.Clear();
            string[] series = { "Исходный", "RLE", "LZW", "JPEG" };

            int startint;
            bool d = int.TryParse(textStart.Text, out startint);

            int rleint;
            bool a = int.TryParse(textRLE.Text, out rleint);

            int lzwint;
            bool b = int.TryParse(textLZW.Text, out lzwint);

            int jpegint;
            bool c = int.TryParse(textLost.Text, out jpegint);

            int[] values = { startint, rleint, lzwint, jpegint };
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            for (int i = 0; i < series.Length; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.Series seri = this.chart1.Series.Add(series[i]);
                seri.Points.Add(values[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace obrabotka
{
    public partial class Form1 : Form
    {
        private Point start, end, center;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        public Form1()
        {
            InitializeComponent();
            PixelBar.Hide();
            PixelBar_value.Hide();
            button_hide();
            axis.Hide();
            ScailingConst.Hide();
            axis.SelectedItem = "Центр";
            ScailingConst.Text = "1";
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(open_dialog.FileName);
                Bitmap bmp = new Bitmap(image, new Size(600, 440 * image.Size.Height / image.Size.Width));
                //Bitmap bmp = new Bitmap(image, image.Size.Height , image.Size.Width);
                image_mass = new byte[bmp.Width, bmp.Height];
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color color = bmp.GetPixel(x, y);
                        image_mass[x, y] = (byte)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    }
                }
                BasicImage.Image = bmp;
                //gen_graph(image_mass);
                BasicImage.Invalidate();
            }
        }

        string flag;
        byte[,] image_mass;

        private void PixelBar_Scroll(object sender, EventArgs e)
        {
            PixelBar_value.Text = string.Format("Текущее значение: {0}", PixelBar.Value);
            switch (flag)
            {
                case "Enlightenment":
                    Enlightenment_Click(sender, e);
                    break;
                case "Binarization":
                    Binarization_Click(sender, e);
                    break;
                case "Binarization_two":
                    Binarization_two_Click(sender, e);
                    break;
                case "Gamma":
                    Gamma_Click(sender, e);
                    break;
                case "High frequency":
                    High_frequency_Click(sender, e);
                    break;
                case "Quantization":
                    Quantization_Click(sender, e);
                    break;
                case "Rotation":
                    Rotation_Click(sender, e);
                    break;
                default:
                    break;

            }

        }

   

        private void Enlightenment_Click(object sender, EventArgs e)
        {
            PixelBar.Show();
            PixelBar_value.Show();
            PixelBar.Maximum = 255;
            PixelBar.Minimum = -255;
            PixelBar_value.Text = string.Format("Текущее значение: {0}", PixelBar.Value);
            button_hide();

            flag = "Enlightenment";
            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;
            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {
                    Color color = old_image.GetPixel(i, j);
                    int R = color.R + PixelBar.Value;
                    int G = color.G + PixelBar.Value;
                    int B = color.B + PixelBar.Value;
                    R = proverka(R);
                    G = proverka(G);
                    B = proverka(B);
                    new_image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            newImage.Image = new_image;
        }
        int proverka(int c)
        {
            if (c > 255) { c = 255; }
            if (c < 0) { c = 0; }

            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button6.BackColor = colorDialog1.Color;
                Coloring_Click(sender, e);
            }
        }

        private void Coloring_Click(object sender, EventArgs e)
        {
            PixelBar.Hide();
            PixelBar_value.Hide();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();

            flag = "Coloring";
            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;
            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {
                    if (old_image.GetPixel(i, j).GetBrightness() <= 0.16)
                    {
                        new_image.SetPixel(i, j, button1.BackColor);
                    }
                    else if (old_image.GetPixel(i, j).GetBrightness() <= 0.33)
                    {
                        new_image.SetPixel(i, j, button2.BackColor);
                    }
                    else if (old_image.GetPixel(i, j).GetBrightness() <= 0.49)
                    {
                        new_image.SetPixel(i, j, button3.BackColor);
                    }
                    else if (old_image.GetPixel(i, j).GetBrightness() <= 0.66)
                    {
                        new_image.SetPixel(i, j, button4.BackColor);
                    }
                    else if (old_image.GetPixel(i, j).GetBrightness() <= 0.82)
                    {
                        new_image.SetPixel(i, j, button5.BackColor);
                    }
                    else
                    {
                        new_image.SetPixel(i, j, button6.BackColor);
                    }
                }
                newImage.Image = new_image;
            }
        }

        private void Binarization_Click(object sender, EventArgs e)
        {

            PixelBar.Minimum = 0;
            PixelBar.Maximum = 100;
            PixelBar_value.Text = string.Format("Текущее значение: {0}", PixelBar.Value / 100.0);
            PixelBar.Show();
            PixelBar_value.Show();
            button_hide();

            flag = "Binarization";
            double n = PixelBar.Value / 100.0;
            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;
            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {
                    new_image.SetPixel(i, j, old_image.GetPixel(i, j).GetBrightness() < n ? Color.Black : Color.White);
                }
            }
            newImage.Image = new_image;
        }
        void button_hide()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
        }
        private void Gamma_Click(object sender, EventArgs e)
        {
            flag = "Gamma";
            PixelBar.Minimum = 0;
            PixelBar.Maximum = 500;
            PixelBar_value.Text = string.Format("Текущее значение: {0}", PixelBar.Value / 100.0);
            PixelBar.Show();
            PixelBar_value.Show();

            double Gamma = (PixelBar.Value / 100.0);

            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;
            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {

                    Color color = old_image.GetPixel(i, j);
                    byte R = (byte)(Math.Pow((double)color.R / (double)255, Gamma) * 255);
                    byte G = (byte)(Math.Pow((double)color.G / (double)255, Gamma) * 255);
                    byte B = (byte)(Math.Pow((double)color.B / (double)255, Gamma) * 255);

                    new_image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            newImage.Image = new_image;


        }

        private void High_frequency_Click(object sender, EventArgs e)
        {
            flag = "High frequency";
            PixelBar.Hide();
            PixelBar_value.Hide();
            button_hide();

            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;

            int R = 0;
            int G = 0;
            int B = 0;
            for (int i = 1; i < BasicImage.Image.Width - 1; i++)
            {
                for (int j = 1; j < BasicImage.Image.Height - 1; j++)
                {
                    Color color = old_image.GetPixel(i, j);

                    R = -old_image.GetPixel(i - 1, j - 1).R - old_image.GetPixel(i - 1, j).R - old_image.GetPixel(i - 1, j + 1).R - old_image.GetPixel(i, j - 1).R + 9 * old_image.GetPixel(i, j).R - old_image.GetPixel(i, j + 1).R - old_image.GetPixel(i + 1, j - 1).R - old_image.GetPixel(i + 1, j).R - old_image.GetPixel(i + 1, j + 1).R;
                    G = -old_image.GetPixel(i - 1, j - 1).G - old_image.GetPixel(i - 1, j).G - old_image.GetPixel(i - 1, j + 1).G - old_image.GetPixel(i, j - 1).G + 9 * old_image.GetPixel(i, j).G - old_image.GetPixel(i, j + 1).G - old_image.GetPixel(i + 1, j - 1).G - old_image.GetPixel(i + 1, j).G - old_image.GetPixel(i + 1, j + 1).G;
                    B = -old_image.GetPixel(i - 1, j - 1).B - old_image.GetPixel(i - 1, j).B - old_image.GetPixel(i - 1, j + 1).B - old_image.GetPixel(i, j - 1).B + 9 * old_image.GetPixel(i, j).B - old_image.GetPixel(i, j + 1).B - old_image.GetPixel(i + 1, j - 1).B - old_image.GetPixel(i + 1, j).B - old_image.GetPixel(i + 1, j + 1).B;


                    R = proverka(R);
                    G = proverka(G);
                    B = proverka(B);
                    new_image.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            newImage.Image = new_image;
        }

        private void Quantization_Click(object sender, EventArgs e)
        {
            flag = "Quantization";
            PixelBar.Show();
            PixelBar_value.Show();
            PixelBar.Minimum = 2;
            PixelBar.Maximum = 100;
            PixelBar_value.Text = string.Format("Текущее значение: {0}", (double)PixelBar.Value);
            button_hide();

            byte[] palette = new byte[PixelBar.Value];

            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;

            for (int i = 0; i < PixelBar.Value; i++)
            {
                palette[i] = (byte)(i * (256 / PixelBar.Value));
            }
            for (int x = 0; x < old_image.Width; x++)
            {
                for (int y = 0; y < old_image.Height; y++)
                {
                    for (int j = 1; j < PixelBar.Value; j++)
                    {
                        if ((palette[j - 1] <= image_mass[x, y]) && (image_mass[x, y] < palette[j]))
                        {

                            new_image.SetPixel(x, y, Color.FromArgb(palette[j - 1], palette[j - 1], palette[j - 1]));
                        }
                    }
                }
            }
            newImage.Image = new_image;
        }

        private void Binarization_two_Click(object sender, EventArgs e)
        {
            PixelBar.Minimum = 0;
            PixelBar.Maximum = 255;
            PixelBar_value.Text = string.Format("Текущее значение: {0}", (double)PixelBar.Value);
            PixelBar.Show();
            PixelBar_value.Show();
            button_hide();

            flag = "Binarization_two";
            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old_image = (Bitmap)BasicImage.Image;
            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {
                    new_image.SetPixel(i, j, image_mass[i, j] < PixelBar.Value ? Color.Black : Color.White);
                }
            }
            newImage.Image = new_image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PixelBar_value_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newImage.Image != null)
            {

                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        newImage.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int getD(int cr, int cl, int cu, int cd, int cld, int clu, int cru, int crd, int[,] matrix)
        {
            return Math.Abs(matrix[0, 0] * clu + matrix[0, 1] * cu + matrix[0, 2] * cru
               + matrix[1, 0] * cl + matrix[1, 2] * cr
                  + matrix[2, 0] * cld + matrix[2, 1] * cd + matrix[2, 2] * crd);
        }
        private int getMaxD(int cr, int cl, int cu, int cd, int cld, int clu, int cru, int crd)
        {
            int max = int.MinValue;
            for (int i = 0; i < templates.Count; i++)
            {
                int newVal = getD(cr, cl, cu, cd, cld, clu, cru, crd, templates[i]);
                if (newVal > max)
                    max = newVal;
            }
            return max;
        }
        private List<int[,]> templates = new List<int[,]>
        {
           new int[,] {{ -3, -3, 5 }, { -3, 0, 5 }, { -3, -3, 5 } },
           new int[,] {{ -3, 5, 5 }, { -3, 0, 5 }, { -3, -3, -3 } },
           new int[,] {{ 5, 5, 5 }, { -3, 0, -3 }, { -3, -3, -3 } },
           new int[,] {{ 5, 5, -3 }, { 5, 0, -3 }, { -3, -3, -3 } },
           new int[,] {{ 5, -3, -3 }, { 5, 0, -3 }, { 5, -3, -3 } },
           new int[,] {{ -3, -3, -3 }, { 5, 0, -3 }, { 5, 5, -3 } },
           new int[,] {{ -3, -3, -3 }, { -3, 0, -3 }, { 5, 5, 5 } },
           new int[,] {{ -3, -3, -3 }, { -3, 0, 5 }, { -3, 5, 5 } }
        };

        private void button8_Click(object sender, EventArgs e)
        {
            PixelBar.Hide();
            PixelBar_value.Hide();
            axis.Hide();
            ScailingConst.Hide();
            Bitmap ret = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old = (Bitmap)BasicImage.Image;

            for (int i = 1; i < BasicImage.Image.Width - 1; i++)
            {
                for (int j = 1; j < BasicImage.Image.Height - 1; j++)
                {
                    
                    Color cr = old.GetPixel(i + 1, j);
                    Color cl = old.GetPixel(i - 1, j);
                    Color cu = old.GetPixel(i, j - 1);
                    Color cd = old.GetPixel(i, j + 1);
                    Color cld = old.GetPixel(i - 1, j + 1);
                    Color clu = old.GetPixel(i - 1, j - 1);
                    Color crd = old.GetPixel(i + 1, j + 1);
                    Color cru = old.GetPixel(i + 1, j - 1);
                    int power = getMaxD(cr.R, cl.R, cu.R, cd.R, cld.R, clu.R, cru.R, crd.R);
                    power = proverka(power);
                    ret.SetPixel(i, j, Color.FromArgb(power, power, power));

                }
            }
            newImage.Image = ret;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            PixelBar.Hide();
            PixelBar_value.Hide();
            axis.Hide();
            ScailingConst.Hide();
            int num = (int)numericUpDown1.Value;
            int min = 255;
            int max = 0;
            int p = (num - 1) / 2;
            int c = (int)numericUpDown2.Value;
            Bitmap new_image = new Bitmap(BasicImage.Image.Width, BasicImage.Image.Height);
            Bitmap old = (Bitmap)BasicImage.Image;

            for (int i = 0; i < BasicImage.Image.Width; i++)
            {
                for (int j = 0; j < BasicImage.Image.Height; j++)
                {
                    for (int k = -p; k < p; k++)
                    {
                        for (int m = -p; m < p; m++)
                        {
                            if ((i + k) > p && (j + m) > p && (j + m) < BasicImage.Image.Height && (i + k) < BasicImage.Image.Width)
                            {
                                if (image_mass[i + k, j + m] > max)
                                {
                                    max = image_mass[i + k, j + m];
                                }
                                if (image_mass[i + k, j + m] < min)
                                {
                                    min = image_mass[i + k, j + m];
                                }
                            }
                        }
                    }
                    min = proverka(min);
                    max = proverka(max);
                    new_image.SetPixel(i, j, image_mass[i, j] >= (max + min) / 2 + c ? Color.Black : Color.White);
                    min = 255;
                    max = 0;
                }
            }
            newImage.Image = new_image;
        }

        private void BasicImage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BasicImage_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (flag == "Rotation" || flag == "Scaling")
            {
                if ((e.Button == MouseButtons.Right && (axis.SelectedItem.ToString() == "Произвольная точка")))
                {
                    center = e.Location;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    end = e.Location;
                }
            }


        }

        private void BasicImage_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (flag == "Rotation" || flag == "Scaling")
            {
                if (e.Button == MouseButtons.Left)
                {
                    start = e.Location;
                    Invalidate();
                }
            }
        }
        private void BasicImage_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (flag == "Rotation" || flag == "Scaling")
            {
                if (e.Button != MouseButtons.Left)
                    return;
                end = e.Location;
                Rect.Location = new Point(
                    Math.Min(start.X, end.X),
                    Math.Min(start.Y, end.Y));
                Rect.Size = new Size(
                    Math.Abs(start.X - end.X),
                    Math.Abs(start.Y - end.Y));
                BasicImage.Invalidate();
            }

        }

        private void BasicImage_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (flag == "Rotation" || flag == "Scaling")
            {
                if (BasicImage.Image != null)
                {
                    if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                    {
                        e.Graphics.FillRectangle(selectionBrush, Rect);
                    }
                }
            }
        }

        private void ScailingConst_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private double determinant(List<double> matrix)
        {
            double deter = matrix[0] * matrix[4] * matrix[8] -
                matrix[0] * matrix[7] * matrix[5] +
                matrix[1] * matrix[5] * matrix[6] -
                matrix[1] * matrix[8] * matrix[3] +
                matrix[2] * matrix[3] * matrix[7] -
                matrix[2] * matrix[6] * matrix[4];
            return deter;
        }

        private void axis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Scalling_Click(object sender, EventArgs e)
        {
            flag = "Scaling";
            PixelBar.Hide();
            PixelBar_value.Hide();
            axis.Hide();
            ScailingConst.Show();


            if (Rect.Width == 0 || Rect.Height == 0)
            {
                return;
            }

          
            double ScConst = Convert.ToDouble(ScailingConst.Text);
            int newHeight = (int)(Rect.Height * ScConst);
            int newWidth = (int)(Rect.Width * ScConst);

            Bitmap new_image = new Bitmap(newWidth, newHeight);
            Bitmap old_image = (Bitmap)BasicImage.Image;

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                { // выделение начальные координаты
                    double scaledX = start.X + x / ScConst;
                    double scaledY = start.Y + y / ScConst;
                    int flooredX = (int)(scaledX);
                    int flooredY = (int)(scaledY);

                    List<double> iter = new List<double>()
                        {
                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).R,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).R,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).R, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).R,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).R,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).R, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).R,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).R,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).R, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).G,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).G,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).G, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).G,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).G,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).G, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).G,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).G,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).G, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).B,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).B,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY-1))).B, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).B,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).B,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY))).B, scaledX),

                            parabola(flooredX, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).B,
                            flooredX+1, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+1)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).B,
                            flooredX+2, old_image.GetPixel(Math.Min(old_image.Width-1,Math.Max(0,flooredX+2)), Math.Min(old_image.Height-1,Math.Max(0,flooredY+1))).B, scaledX)
                        };
                    Color c = new Color();

                    int R = (int)(parabola(flooredY, iter[0], flooredY + 1, iter[1], flooredY + 2, iter[2], scaledY));

                    R = proverka(R);
                    int G = (int)(parabola(flooredY, iter[3], flooredY + 1, iter[4], flooredY + 2, iter[5], scaledY));

                    G = proverka(G);

                    int B = (int)(parabola(flooredY, iter[6], flooredY + 1, iter[7], flooredY + 2, iter[8], scaledY));

                    B = proverka(B);

                    c = Color.FromArgb(R, G, B);
                    new_image.SetPixel(x, y, c);
                }
            }
            newImage.Image = new_image;
        
    }

        private double parabola(double x1, double y1, double x2, double y2,
            double x3, double y3, double x)
        {
            List<double> mat = new List<double>() { x1 * x1, x1, 1, x2 * x2, x2, 1, x3 * x3, x3, 1 };
            List<double> mat1 = new List<double>() { y1, x1, 1, y2, x2, 1, y3, x3, 1 };
            List<double> mat2 = new List<double>() { x1 * x1, y1, 1, x2 * x2, y2, 1, x3 * x3, y3, 1 };
            List<double> mat3 = new List<double>() { x1 * x1, x1, y1, x2 * x2, x2, y2, x3 * x3, x3, y3 };

            double det = determinant(mat);
            double det1 = determinant(mat1);
            double det2 = determinant(mat2);
            double det3 = determinant(mat3);

            double a = det1 / det;
            double b = det2 / det;
            double c = det3 / det;

            return (a * x * x + b * x + c);
        }

        private void Rotation_Click(object sender, EventArgs e)
        {
            //параметры элементов
            flag = "Rotation";
            PixelBar.Show();
            PixelBar_value.Show();
            PixelBar.Minimum = -360;
            PixelBar.Maximum = 360;
            PixelBar_value.Text = String.Format("Текущее значение: {0}", (double)PixelBar.Value);
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            axis.Show();
            ScailingConst.Hide();

            if (Rect.Width == 0 || Rect.Height == 0)
            {
                return;
            }

            if (axis.SelectedItem.ToString() == "Центр")
            {
                center.X = start.X + (int)(Rect.Width / 2);
                center.Y = start.Y + (int)(Rect.Height / 2);
            }

            Bitmap new_image = new Bitmap(BasicImage.Image);
            Bitmap old_image = (Bitmap)BasicImage.Image;

            double angle = (double)PixelBar.Value * 0.01745;

            for (int y = 0; y <= old_image.Height; ++y)
            {
                for (int x = 0; x <= old_image.Width; ++x)
                {
                    int newX = (int)Math.Round(center.X +
                        (x - center.X) * Math.Cos(angle) -
                        (y - center.Y) * Math.Sin(angle));
                    int newY = (int)Math.Round(center.Y +
                        (x - center.X) * Math.Sin(angle) +
                        (y - center.Y) * Math.Cos(angle));

                    if ((start.X <= newX) && (end.X >= newX) && (newY >= start.Y) && (newY <= end.Y))
                    {
                        new_image.SetPixel(Math.Min(old_image.Width - 1, Math.Max(0, x)), Math.Min(old_image.Height - 1, Math.Max(0, y)),
                            old_image.GetPixel(Math.Min(old_image.Width - 1, Math.Max(0, newX)), Math.Min(old_image.Height - 1, Math.Max(0, newY))));
                    }
                }
            }
            newImage.Image = new_image;
        }
    }
}
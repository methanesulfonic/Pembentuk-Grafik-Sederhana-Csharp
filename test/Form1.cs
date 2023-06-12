using System.Drawing;
using System.Windows.Forms;
using static test.Form1;

namespace test
{
    public partial class Form1 : Form
    {
        private Bentuk bentuk;
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLuasLingkaran_Click(object sender, EventArgs e)
        {
            if (double.TryParse(jarijariTextBox.Text, out double jari))
            {
                Lingkaran lingkaran = new Lingkaran(jari);
                bentuk = lingkaran;
                DetailBentuk();
                GambarBentuk();
            }
            else
            {
                MessageBox.Show("Nilai salah, masukkan nilai yang benar.");
            }
        }

        private void btn_LuasPersegi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(panjangTextBox.Text, out double panjang) && double.TryParse(lebarTextBox.Text, out double lebar))
            {
                Persegi persegi = new Persegi(panjang, lebar);
                bentuk = persegi;
                DetailBentuk();
                GambarBentuk();
            }
            else
            {
                MessageBox.Show("Nilai salah, masukkan nilai yang benar.");
            }
        }

        private void GambarBentuk()
        {
            Graphics graphics = panel1.CreateGraphics();

            graphics.Clear(Color.GhostWhite);

            if (bentuk == null)
                return;

            Pen pen = new Pen(Color.SlateGray, 2);

            Brush brush = new SolidBrush(Color.SteelBlue); 

            if (bentuk is Lingkaran lingkaran)
            {
                graphics.FillEllipse(brush, 20, 20, (float)lingkaran.Jarijari * 2, (float)lingkaran.Jarijari * 2);
                graphics.DrawEllipse(pen, 20, 20, (float)lingkaran.Jarijari * 2, (float)lingkaran.Jarijari * 2);
            }
            else if (bentuk is Persegi persegi)
            {
                graphics.FillRectangle(brush, 20, 20, (float)persegi.Panjang, (float)persegi.Lebar);
                graphics.DrawRectangle(pen, 20, 20, (float)persegi.Panjang, (float)persegi.Lebar);
            }
            graphics.Dispose();
        }

        public class Persegi : Bentuk
        {
            public double Lebar { get; }
            public double Panjang { get; }

            public Persegi(double panjang, double lebar)
            {
                Panjang = panjang;
                Lebar = lebar;
            }

            public override double HitungLuas()
            {
                return Panjang * Lebar;
            }
        }

        private void DetailBentuk()
        {
            resultLabel.Text = string.Empty;
            if (bentuk == null)
                return;

            double area = bentuk.HitungLuas();
            string areaText = area.ToString("0.##");
            resultLabel.Text = $"Bentuk : {bentuk.GetType().Name}\nLuas : {areaText}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lingkaran lingkaran = new Lingkaran(0);
            Persegi persegi = new Persegi(0, 0);
            jarijariTextBox.ForeColor = Color.Gray;
            panjangTextBox.ForeColor = Color.Gray;
            lebarTextBox.ForeColor = Color.Gray;
        }

        public abstract class Bentuk
        {
            public abstract double HitungLuas();
        }

        public class Lingkaran : Bentuk
        {
            public double Jarijari { get; }

            public Lingkaran(double jari)
            {
                Jarijari = jari;
            }

            public override double HitungLuas()
            {
                return Math.PI * Jarijari * Jarijari;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

        }

        private void shapeTextBox_Click(object sender, EventArgs e)
        {
            jarijariTextBox.Text = "";
            jarijariTextBox.ForeColor = Color.Black;
        }

        private void lengthTextBox_Click(object sender, EventArgs e)
        {
            panjangTextBox.Text = "";
            panjangTextBox.ForeColor = Color.Black;
            
        }

        private void widthTextBox_Click(object sender, EventArgs e)
        {
            lebarTextBox.Text = "";
            lebarTextBox.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
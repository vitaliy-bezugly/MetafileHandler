using System.Drawing.Imaging;

namespace Merafile.Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var i = Image.FromFile(@"D:\dz\хоо\Projects\MatafileHandler\Metafile.FiguresCreator\bin\Debug\net6.0\MatafileHandler.emf");
            pictureBox1.Image = i;
        }
    }
}
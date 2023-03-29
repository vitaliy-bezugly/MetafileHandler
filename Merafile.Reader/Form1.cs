using System.Drawing.Imaging;

namespace Merafile.Reader
{
    public partial class Form1 : Form
    {
        private readonly string _filePath = @"D:\dz\хоо\Projects\MatafileHandler\Metafile.FiguresCreator\bin\Debug\net6.0\MatafileHandler.emf";
        private int _counter;
        public Form1()
        {
            InitializeComponent();

            _counter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            using (var i = Image.FromFile(_filePath, true))
            {
                pictureBox1.Image = new Bitmap(i);
                if (string.IsNullOrEmpty(detailsRichTextBox.Text))
                {
                    detailsRichTextBox.Text = $"Updated: #{_counter}";
                }
                else
                {
                    detailsRichTextBox.Text = detailsRichTextBox.Text + $"\nUpdated: #{_counter}";
                }
                _counter += 1;
            }
        }

        private void stopProcessButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
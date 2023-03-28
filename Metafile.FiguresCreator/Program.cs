using System.Drawing;
using System.Drawing.Imaging;

int width = 300;
int height = 100;

var b = new Bitmap(width, height);
int pos = 0;
string encodedValue = "1001011011010101001101101011011001010101101001011010101001101101010100110110101010011011010110110010101011010011010101011001101010101100101011011010010101101011001101010100101101101";

int barWidth = width / encodedValue.Length;
int shiftAdjustment = (width % encodedValue.Length) / 2;
int barWidthModifier = 1;

using (Graphics g = Graphics.FromImage(b))
{
    // clears the image and colors the entire background
    g.Clear(Color.White);

    // lines are barWidth wide so draw the appropriate color line vertically
    using (Pen pen = new Pen(Color.Red, (float)barWidth / barWidthModifier))
    {
        while (pos < encodedValue.Length)
        {
            if (encodedValue[pos] == '0' && Random.Shared.Next(0, 2) == 1)
            {
                g.DrawLine(pen, new Point(pos * barWidth + shiftAdjustment + 1, 0), new Point(pos * barWidth + shiftAdjustment + 1, height));
            }

            pos++;
        } // while
    } // using
} // using

b.Save("MatafileHandler.png", ImageFormat.Png);
b.Save("MatafileHandler.emf", ImageFormat.Emf);
using System.Drawing;
using System.Drawing.Imaging;

int width = 300;
int height = 100;
int sleepTime = 5 * 1000;

while (true)
{
    var b = new Bitmap(width, height);

    using (Graphics g = Graphics.FromImage(b))
    {
        g.Clear(Color.White);

        using (Pen pen = new Pen(Color.Red, 1))
        {
            for (int i = 0; i < Random.Shared.Next(5, 10); i++)
            {
                var randomValue = Random.Shared.Next(0, 3);

                if (randomValue == 0)
                    DrawSquare(new Point(Random.Shared.Next(10, width - 10), Random.Shared.Next(15, height - 10)), 20, g, pen);
                else if (randomValue == 1)
                    DrawTriangle(new Point(Random.Shared.Next(10, width - 10), Random.Shared.Next(15, height - 10)), 25, g, pen);
                else if (randomValue == 2)
                    DrawElipse(new Point(Random.Shared.Next(10, width - 10), Random.Shared.Next(15, height - 10)), 50, 23, g, pen);
            }
        }
    }

    b.Save("MatafileHandler.png", ImageFormat.Png);
    b.Save("MatafileHandler.emf", ImageFormat.Emf);
    b.Dispose();

    Console.WriteLine($"{Guid.NewGuid()}: Updated image!");
    Thread.Sleep(sleepTime);
}

static void DrawSquare(Point topLeft, int width, Graphics g, Pen pen)
{
    var topRight = new Point(topLeft.X + width, topLeft.Y);
    var bottomRight = new Point(topRight.X, topRight.Y - width);
    var bottomLeft = new Point(bottomRight.X - width, bottomRight.Y);  
    
    g.DrawLine(pen, topLeft, topRight);
    g.DrawLine(pen, topRight, bottomRight);
    g.DrawLine(pen, bottomRight, bottomLeft);
    g.DrawLine(pen, bottomLeft, topLeft);
}
static void DrawTriangle(Point bottom, int length, Graphics g, Pen pen)
{
    var right = new Point(bottom.X + length, bottom.Y - length);
    var left = new Point(bottom.X - length, right.Y);
    g.DrawLine(pen, bottom, right);
    g.DrawLine(pen, right, left);
    g.DrawLine(pen, left, bottom);
}
static void DrawElipse(Point leftTop, int width, int height, Graphics g, Pen pen)
{
    g.DrawEllipse(pen, new Rectangle(leftTop, new Size(width, height)));
}
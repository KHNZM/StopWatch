using System.Windows.Forms;
using System.Drawing;

namespace StopWatch
{
    /// <summary>
    /// ⓘボタンのためのクラス
    /// </summary>
    class InfoButton : UserControl
    {
        // Draw the new button.
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen1 = new Pen(Color.White, 4.8f);
            Pen myPen2 = new Pen(Color.White, 4.0f);
            // Draw the button in the form of a circle
            graphics.FillEllipse(Brushes.Blue, 0, 0, 24, 24);
            graphics.DrawEllipse(myPen1, 11, 5, 1, 1);
            graphics.FillEllipse(Brushes.White, 9, 3, 5, 5);
            graphics.DrawLine(myPen2, 12, 11, 12, 21);
            myPen1.Dispose();
            myPen2.Dispose();
        }
    }
}

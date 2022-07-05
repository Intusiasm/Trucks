using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Library.Controllers
{
    /// <summary>
    /// Class which uses WINAPI to create rounded button.
    /// </summary>
    class RoundedButton : Button
    {
        /// <summary>
        /// Method to make from default button rounded.
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottonRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns><see cref="IntPtr"/></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundButton(int nLeftRect, int nTopRect, int nRightRect, int nBottonRect, int nWidthEllipse, int nHeightEllipse);

        /// <summary>
        /// Value of width ellipse.
        /// </summary>
        protected int nWidthEllipse = 15;

        /// <summary>
        /// Value of height ellipse.
        /// </summary>
        protected int nHeightEllipse = 15;

        /// <summary>
        /// Overrided OnPaint method.
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = RoundButton(0, 0, Width, Height, this.nWidthEllipse, this.nHeightEllipse);
            Region = Region.FromHrgn(ptr);
        }
    }
}

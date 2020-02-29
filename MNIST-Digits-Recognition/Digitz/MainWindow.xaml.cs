using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Digitz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DigitRecognizer _digitRecognizer = new DigitRecognizer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void recognizeButton_Click(object sender, RoutedEventArgs e)
        {
            List<DigitResult> results = _digitRecognizer.Evaluate(GetHandWrittenImage());

            // the result is sorted by confidence. so the first is the highest
            numberLabel.Text = results.FirstOrDefault()?.Digit.ToString() ?? "N/A";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
            numberLabel.Text = "";
        }

        private Bitmap GetHandWrittenImage()
        {
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap((int)inkCanvas.ActualWidth, (int)inkCanvas.ActualHeight, 96d, 96d, PixelFormats.Default);
            renderBitmap.Render(inkCanvas);

            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(renderBitmap));

            Bitmap bitmap;
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                ms.Flush();

                //get the bitmap bytes from the memory stream
                ms.Position = 0;
                bitmap = new Bitmap(Image.FromStream(ms));
            }

            return bitmap;
        }

        #region HideIcon
        protected override void OnSourceInitialized(EventArgs e)
        {
            const int GWL_EXSTYLE = -20;
            const int WS_EX_DLGMODALFRAME = 0x0001;
            const int SWP_NOSIZE = 0x0001;
            const int SWP_NOMOVE = 0x0002;
            const int SWP_NOZORDER = 0x0004;
            const int SWP_FRAMECHANGED = 0x0020;

            var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;

            // Change the extended window style to not show a window icon
            int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
            SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_DLGMODALFRAME);

            // Update the window's non-client area to reflect the changes
            SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
                  SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hwnd, int index);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
            int x, int y, int width, int height, uint flags);
        #endregion
    }
}

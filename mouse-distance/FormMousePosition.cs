
using System.Runtime.InteropServices;
namespace mouse_position
{
    public partial class FormMousePosition : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private (int X, int Y) GetWindowCenterRegardingScreen()
        { 
            int windowWidth = this.Width;
            int windowHeight = this.Height;
            int windowTop = this.Top;
            int windowLeft = this.Left;

            int x = windowLeft+ windowWidth / 2;
            int y = windowTop + windowHeight / 2;

            (int, int) coords = (x, y);

            return coords;
        }

        private void freezeCursor (object? sender, MouseEventArgs e)
        {
            var (centerX, centerY) = GetWindowCenterRegardingScreen();
            Point currentPosition = new((Size)System.Windows.Forms.Control.MousePosition);
            if (this.distanceCounter != null && centerX != currentPosition.X)
            {
                int updatedDistance = Int32.Parse(this.distanceCounter.Text) + Math.Abs(currentPosition.X - centerX);
                this.distanceCounter.Text = updatedDistance.ToString();
            }

            SetCursorPos(centerX, centerY);
        }

        public FormMousePosition()
        {
            InitializeComponent();
            this.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.Shift && e.KeyCode == Keys.S)
                {
                    Cursor.Hide();
                    this.MouseMove += this.freezeCursor;
                } 
                if (e.Shift && e.KeyCode == Keys.F)
                {
                    this.MouseMove -= this.freezeCursor;
                    Cursor.Show();
                }
            };

        }

        private int GetPaddingBottomForAdditionalInfo()
        {
            return Screen.PrimaryScreen.Bounds.Bottom - this.Height;
        }

        private void FormMousePosition_ResizeEnd(object sender, EventArgs e)
        {
            this.additionalInformationStart.Location = new Point(12, this.GetPaddingBottomForAdditionalInfo());
        }
    }
}
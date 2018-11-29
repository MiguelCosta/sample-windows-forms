using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Core.Messages
{
    public static class Information
    {
        public static void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System.Windows.Forms;

namespace Mpc.WinFormsIoC.PresentationCore.Core
{
    public static class ApplicationContext
    {
        public static Form MainForm { get; set; }

        public static string Username { get; set; } = string.Empty;
    }
}

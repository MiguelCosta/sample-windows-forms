using System.Windows.Forms;

namespace Mpc.WinFormsIoC.PresentationCore.Core.Helpers
{
    public static class OpenFormsHelpers
    {
        public static void OpenForm<TFrom>() where TFrom : Form
        {
            var form = Config.IoC.GetForm<TFrom>();
            OpenForm(form);
        }

        public static void OpenForm(Form form)
        {
            var previousChild = ApplicationContext.MainForm.ActiveMdiChild?.WindowState ?? FormWindowState.Maximized;

            if (previousChild == FormWindowState.Maximized)
            {
                foreach (var item in ApplicationContext.MainForm.MdiChildren)
                {
                    item.Close();
                }
                form.WindowState = FormWindowState.Maximized;
            }

            form.MdiParent = ApplicationContext.MainForm;
            form.Show();

            form.WindowState = FormWindowState.Normal;
            form.WindowState = previousChild;
        }

        public static void OpenFormDialog<TFrom>() where TFrom : Form
        {
            var form = Config.IoC.GetForm<TFrom>();
            form.ShowDialog();
        }

        public static void OpenFormDialog(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}

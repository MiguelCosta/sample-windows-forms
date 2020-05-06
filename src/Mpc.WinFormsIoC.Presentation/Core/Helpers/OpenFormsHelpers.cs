﻿using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Core.Helpers
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
            foreach (var item in ApplicationContext.MainForm.MdiChildren)
            {
                item.Close();
            }
            form.MdiParent = ApplicationContext.MainForm;
            form.Show();
            form.WindowState = FormWindowState.Minimized;
            form.WindowState = FormWindowState.Maximized;
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

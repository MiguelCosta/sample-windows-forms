using System;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Core
{
    public class ShowLoading : IDisposable
    {
        private Form _formLoading;

        public ShowLoading()
        {
            _formLoading = Config.IoC.GetForm<FrmLoading>();
            _formLoading.StartPosition = FormStartPosition.CenterScreen;
            _formLoading.TopMost = true;
            _formLoading.TopLevel = true;
            _formLoading.Show();
        }

        public void Dispose()
        {
            _formLoading.Hide();
        }
    }
}

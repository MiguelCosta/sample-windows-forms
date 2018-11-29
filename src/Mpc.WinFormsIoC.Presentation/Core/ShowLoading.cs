using System;
using System.Windows.Forms;

namespace Mpc.WinFormsIoC.Presentation.Core
{
    public class ShowLoading : IDisposable
    {
        private FrmLoading _formLoading;
        private FrmMain _formMain;

        public ShowLoading()
        {
            _formLoading = Config.IoC.GetForm<FrmLoading>();
            _formLoading.StartPosition = FormStartPosition.CenterScreen;
            _formLoading.TopMost = true;
            _formLoading.TopLevel = true;
            _formLoading.Show();

            _formMain = Config.IoC.GetForm<FrmMain>();
            _formMain.StatusProgressBar.Style = ProgressBarStyle.Marquee;
            _formMain.StatusProgressBar.MarqueeAnimationSpeed = 30;
        }

        public void Dispose()
        {
            _formMain.StatusProgressBar.MarqueeAnimationSpeed = 0;
            _formMain.StatusProgressBar.Style = ProgressBarStyle.Continuous;
            _formLoading.Hide();
        }
    }
}

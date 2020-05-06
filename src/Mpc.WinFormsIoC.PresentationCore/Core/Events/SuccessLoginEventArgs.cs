using System;

namespace Mpc.WinFormsIoC.PresentationCore.Core.Events
{
    public class SuccessLoginEventArgs : EventArgs
    {
        public string Username { get; set; }
    }
}

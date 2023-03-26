using Microsoft.Win32;

namespace DigaoDeskApp
{
    internal class WindowsPowerCtrl
    {

        public void Init()
        {
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
        }

        public void Release()
        {
            SystemEvents.PowerModeChanged -= OnPowerModeChanged;
        }

        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    EventAudit.Do("Windows Suspended");
                    break;
                case PowerModes.Resume:
                    EventAudit.Do("Windows Resumed");
                    break;
            }
        }

    }
}

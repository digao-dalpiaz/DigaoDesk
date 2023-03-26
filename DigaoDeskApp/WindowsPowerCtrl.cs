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

                    break;
                case PowerModes.Resume:

                    break;
            }
        }

    }
}

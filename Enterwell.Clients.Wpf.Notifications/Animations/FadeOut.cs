using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Enterwell.Clients.Wpf.Notifications.Animations
{
    public class FadeOut : DoubleAnimation
    {
        public FadeOut() : base()
        {
            From = 1;
            To = 0;
            BeginTime = TimeSpan.FromSeconds(0);
            FillBehavior = FillBehavior.HoldEnd;
        }

        public static DependencyProperty DependencyProperty = UIElement.OpacityProperty;
    }
}

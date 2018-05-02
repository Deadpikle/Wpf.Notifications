using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Enterwell.Clients.Wpf.Notifications.Animations
{
    public class SlideInAnimation : ThicknessAnimation
    {
        public SlideInAnimation() : base()
        {
            From = new Thickness(0, -75, 0, 0);
            To = new Thickness(0, 0, 0, 0);
            BeginTime = TimeSpan.FromSeconds(0);
            FillBehavior = FillBehavior.HoldEnd;
        }

        public static DependencyProperty DependencyProperty = FrameworkElement.MarginProperty;
    }
}

using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Enterwell.Clients.Wpf.Notifications.Animations
{
    public class FadeIn : DoubleAnimation
    {
        public FadeIn() : base()
        {
            From = 0;
            To = 1;
            BeginTime = TimeSpan.FromSeconds(0);
            FillBehavior = FillBehavior.HoldEnd;
        }

        public static DependencyProperty DependencyProperty = UIElement.OpacityProperty;
    }
}

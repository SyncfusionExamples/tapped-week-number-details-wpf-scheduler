using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.WeekNumberTapped += AssociatedObject_WeekNumberTapped;
        }
        private void AssociatedObject_WeekNumberTapped(object sender, WeekNumberTappedEventArgs e)
        {
            var no = e.WeekNumber.ToString();
            MessageBox.Show("WeekNumber" + " " + no, "WeekNumberTapped", MessageBoxButton.OK);
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.WeekNumberTapped -= AssociatedObject_WeekNumberTapped;
            this.scheduler = null;
        }
    }
}
    


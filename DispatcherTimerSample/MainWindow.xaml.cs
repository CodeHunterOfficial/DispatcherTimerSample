using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DispatcherTimerSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
			InitializeComponent();
			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
			lblTime.Content = "30";
		}

		void timer_Tick(object sender, EventArgs e)
		{
			int t = Int32.Parse(lblTime.Content.ToString());
			t = t - 1;
			lblTime.Content = t.ToString();
			if (t == 25)
				Button_Click(this, null);

            
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
			MessageBox.Show("Hahahah");
        }
	
	}
}


namespace ExperimentalShell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
#if WINDOWS
        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);


            window.Activated += Window_Activated;


            return window;
        }


        private static async void Window_Activated(object sender, EventArgs e)
        {
            const int defaultWidth = 480;
            const int defaultHeight = 725;

            // change window size.
            if (sender is Window window)
            {
	            window.Width = defaultWidth;
	            window.Height = defaultHeight;

	            // give it some time to complete window resizing task.
	            await window.Dispatcher.DispatchAsync(() => { });

	            var disp = DeviceDisplay.Current.MainDisplayInfo;

	            // move to screen center
	            window.X = (disp.Width / disp.Density - window.Width) / 2 + 400;
	            window.Y = (disp.Height / disp.Density - window.Height) / 2;

	            window.Activated -= Window_Activated;
            }
        }
#endif
    }
}

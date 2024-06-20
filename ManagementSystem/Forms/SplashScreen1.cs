using DevExpress.XtraSplashScreen;

namespace ManagementSystem.Forms
{
	public partial class SplashScreen1 : SplashScreen
	{
		public SplashScreen1()
		{
			InitializeComponent();
			this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
		}

		#region Overrides

		public override void ProcessCommand(System.Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);

			switch (cmd)
			{
				case SplashScreenCommand.Info:
					this.labelStatus.Text = arg.ToString();
					break;
			}
		}

		#endregion

		public enum SplashScreenCommand
		{
			Info,
			Update,
			Delete
		}
	}
}
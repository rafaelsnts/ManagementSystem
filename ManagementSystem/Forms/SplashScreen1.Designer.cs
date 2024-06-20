namespace ManagementSystem.Forms
{
	partial class SplashScreen1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen1));
			progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			labelCopyright = new DevExpress.XtraEditors.LabelControl();
			labelStatus = new DevExpress.XtraEditors.LabelControl();
			peImage = new DevExpress.XtraEditors.PictureEdit();
			peLogo = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)peLogo.Properties).BeginInit();
			SuspendLayout();
			// 
			// progressBarControl
			// 
			progressBarControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			progressBarControl.EditValue = 0;
			progressBarControl.Location = new Point(24, 239);
			progressBarControl.Name = "progressBarControl";
			progressBarControl.Properties.Appearance.BackColor = Color.Transparent;
			progressBarControl.Size = new Size(502, 12);
			progressBarControl.TabIndex = 5;
			// 
			// labelCopyright
			// 
			labelCopyright.Appearance.BackColor = Color.Transparent;
			labelCopyright.Appearance.Options.UseBackColor = true;
			labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			labelCopyright.Location = new Point(24, 286);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(51, 13);
			labelCopyright.TabIndex = 6;
			labelCopyright.Text = "Copyright";
			// 
			// labelStatus
			// 
			labelStatus.Appearance.BackColor = Color.Transparent;
			labelStatus.Appearance.Options.UseBackColor = true;
			labelStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			labelStatus.Location = new Point(24, 257);
			labelStatus.LookAndFeel.UseDefaultLookAndFeel = false;
			labelStatus.Margin = new Padding(3, 3, 3, 1);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(57, 13);
			labelStatus.TabIndex = 7;
			labelStatus.Text = "Iniciando...";
			// 
			// peImage
			// 
			peImage.Dock = DockStyle.Top;
			peImage.EditValue = resources.GetObject("peImage.EditValue");
			peImage.Location = new Point(1, 1);
			peImage.Name = "peImage";
			peImage.Properties.AllowFocused = false;
			peImage.Properties.Appearance.BackColor = Color.Transparent;
			peImage.Properties.Appearance.Options.UseBackColor = true;
			peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			peImage.Properties.ShowMenu = false;
			peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
			peImage.Size = new Size(548, 309);
			peImage.TabIndex = 9;
			// 
			// peLogo
			// 
			peLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			peLogo.EditValue = resources.GetObject("peLogo.EditValue");
			peLogo.Location = new Point(504, 268);
			peLogo.Name = "peLogo";
			peLogo.Properties.AllowFocused = false;
			peLogo.Properties.Appearance.BackColor = Color.Transparent;
			peLogo.Properties.Appearance.Options.UseBackColor = true;
			peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			peLogo.Properties.ShowMenu = false;
			peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			peLogo.Properties.ZoomAcceleration = 0D;
			peLogo.Size = new Size(45, 42);
			peLogo.TabIndex = 8;
			// 
			// SplashScreen1
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(550, 310);
			Controls.Add(peLogo);
			Controls.Add(labelStatus);
			Controls.Add(labelCopyright);
			Controls.Add(progressBarControl);
			Controls.Add(peImage);
			Name = "SplashScreen1";
			Padding = new Padding(1);
			Text = "SplashScreen1";
			((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)peLogo.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private DevExpress.XtraEditors.LabelControl labelCopyright;
		private DevExpress.XtraEditors.LabelControl labelStatus;
		private DevExpress.XtraEditors.PictureEdit peLogo;
		private DevExpress.XtraEditors.PictureEdit peImage;
	}
}

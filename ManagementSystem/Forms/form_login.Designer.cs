namespace ManagementSystem.Forms
{
	partial class form_Login
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
			components = new System.ComponentModel.Container();
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(SplashScreen1), false, false);
			DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
			skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
			workspaceManager1 = new DevExpress.Utils.WorkspaceManager(components);
			barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
			btn_Entrar = new Button();
			btn_Cadastrar_Usuario = new Button();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			txt_Login = new DevExpress.XtraEditors.TextEdit();
			txt_Senha = new DevExpress.XtraEditors.TextEdit();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl5 = new DevExpress.XtraEditors.LabelControl();
			pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			chk_Lembrar_Login = new DevExpress.XtraEditors.CheckEdit();
			btn_Sair = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemColorEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Login.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Senha.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)chk_Lembrar_Login.Properties).BeginInit();
			SuspendLayout();
			// 
			// barManager1
			// 
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { skinDropDownButtonItem1, skinPaletteDropDownButtonItem1, barSubItem1, barWorkspaceMenuItem1, barEditItem1 });
			barManager1.MainMenu = bar2;
			barManager1.MaxItemId = 5;
			barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemColorEdit1 });
			barManager1.StatusBar = bar3;
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(skinDropDownButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(skinPaletteDropDownButtonItem1) });
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// skinDropDownButtonItem1
			// 
			skinDropDownButtonItem1.ActAsDropDown = true;
			skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			skinDropDownButtonItem1.Id = 0;
			skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
			// 
			// skinPaletteDropDownButtonItem1
			// 
			skinPaletteDropDownButtonItem1.ActAsDropDown = true;
			skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			skinPaletteDropDownButtonItem1.Enabled = false;
			skinPaletteDropDownButtonItem1.Id = 1;
			skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
			// 
			// bar3
			// 
			bar3.BarName = "Status bar";
			bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			bar3.DockCol = 0;
			bar3.DockRow = 0;
			bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			bar3.OptionsBar.AllowQuickCustomization = false;
			bar3.OptionsBar.DrawDragBorder = false;
			bar3.OptionsBar.UseWholeRow = true;
			bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Size = new Size(550, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 290);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(550, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 266);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(550, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 266);
			// 
			// barSubItem1
			// 
			barSubItem1.Caption = "barSubItem1";
			barSubItem1.Id = 2;
			barSubItem1.Name = "barSubItem1";
			// 
			// barWorkspaceMenuItem1
			// 
			barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
			barWorkspaceMenuItem1.Id = 3;
			barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
			barWorkspaceMenuItem1.WorkspaceManager = workspaceManager1;
			// 
			// workspaceManager1
			// 
			workspaceManager1.TargetControl = this;
			workspaceManager1.TransitionType = pushTransition1;
			// 
			// barEditItem1
			// 
			barEditItem1.Caption = "barEditItem1";
			barEditItem1.Edit = repositoryItemColorEdit1;
			barEditItem1.Id = 4;
			barEditItem1.Name = "barEditItem1";
			// 
			// repositoryItemColorEdit1
			// 
			repositoryItemColorEdit1.AutoHeight = false;
			repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
			repositoryItemColorEdit1.NullColor = Color.Empty;
			// 
			// btn_Entrar
			// 
			btn_Entrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_Entrar.ForeColor = Color.Black;
			btn_Entrar.Location = new Point(293, 198);
			btn_Entrar.Name = "btn_Entrar";
			btn_Entrar.Size = new Size(239, 39);
			btn_Entrar.TabIndex = 3;
			btn_Entrar.Text = "Entrar";
			btn_Entrar.UseVisualStyleBackColor = true;
			btn_Entrar.Click += btn_Entrar_Click;
			// 
			// btn_Cadastrar_Usuario
			// 
			btn_Cadastrar_Usuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_Cadastrar_Usuario.ForeColor = Color.Black;
			btn_Cadastrar_Usuario.Location = new Point(293, 243);
			btn_Cadastrar_Usuario.Name = "btn_Cadastrar_Usuario";
			btn_Cadastrar_Usuario.Size = new Size(239, 39);
			btn_Cadastrar_Usuario.TabIndex = 9999;
			btn_Cadastrar_Usuario.TabStop = false;
			btn_Cadastrar_Usuario.Text = "Cadastrar";
			btn_Cadastrar_Usuario.UseVisualStyleBackColor = true;
			btn_Cadastrar_Usuario.Click += btn_Cadastrar_Usuario_Click;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Location = new Point(392, 30);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new Size(39, 21);
			labelControl1.TabIndex = 17;
			labelControl1.Text = "Login";
			// 
			// txt_Login
			// 
			txt_Login.Location = new Point(293, 57);
			txt_Login.MenuManager = barManager1;
			txt_Login.Name = "txt_Login";
			txt_Login.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Login.Properties.Appearance.Options.UseFont = true;
			txt_Login.Size = new Size(239, 28);
			txt_Login.TabIndex = 1;
			// 
			// txt_Senha
			// 
			txt_Senha.Location = new Point(293, 118);
			txt_Senha.MenuManager = barManager1;
			txt_Senha.Name = "txt_Senha";
			txt_Senha.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Senha.Properties.Appearance.Options.UseFont = true;
			txt_Senha.Properties.PasswordChar = '*';
			txt_Senha.Size = new Size(239, 28);
			txt_Senha.TabIndex = 2;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl2.Appearance.Options.UseFont = true;
			labelControl2.Location = new Point(388, 91);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new Size(43, 21);
			labelControl2.TabIndex = 19;
			labelControl2.Text = "Senha";
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 20F);
			labelControl3.Appearance.Options.UseFont = true;
			labelControl3.Location = new Point(21, 182);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new Size(249, 37);
			labelControl3.TabIndex = 25;
			labelControl3.Text = "Management System";
			// 
			// labelControl5
			// 
			labelControl5.Appearance.Font = new Font("Segoe UI", 10F);
			labelControl5.Appearance.Options.UseFont = true;
			labelControl5.Location = new Point(54, 243);
			labelControl5.Name = "labelControl5";
			labelControl5.Size = new Size(190, 34);
			labelControl5.TabIndex = 27;
			labelControl5.Text = "   Simplificando sua gestão,\r\npotencializando seus resultados.";
			// 
			// pictureEdit1
			// 
			pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
			pictureEdit1.Location = new Point(92, 50);
			pictureEdit1.MenuManager = barManager1;
			pictureEdit1.Name = "pictureEdit1";
			pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pictureEdit1.Size = new Size(100, 96);
			pictureEdit1.TabIndex = 28;
			// 
			// chk_Lembrar_Login
			// 
			chk_Lembrar_Login.Location = new Point(293, 152);
			chk_Lembrar_Login.MenuManager = barManager1;
			chk_Lembrar_Login.Name = "chk_Lembrar_Login";
			chk_Lembrar_Login.Properties.Caption = "Lembrar Login";
			chk_Lembrar_Login.Size = new Size(103, 20);
			chk_Lembrar_Login.TabIndex = 33;
			chk_Lembrar_Login.CheckedChanged += chk_Lembrar_Login_CheckedChanged;
			// 
			// btn_Sair
			// 
			btn_Sair.ImageOptions.Image = (Image)resources.GetObject("btn_Sair.ImageOptions.Image");
			btn_Sair.ImeMode = ImeMode.NoControl;
			btn_Sair.Location = new Point(511, -1);
			btn_Sair.Name = "btn_Sair";
			btn_Sair.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Sair.Size = new Size(37, 36);
			btn_Sair.TabIndex = 38;
			btn_Sair.Click += btn_Sair_Click;
			// 
			// form_Login
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(550, 310);
			Controls.Add(btn_Sair);
			Controls.Add(chk_Lembrar_Login);
			Controls.Add(pictureEdit1);
			Controls.Add(labelControl5);
			Controls.Add(labelControl3);
			Controls.Add(txt_Senha);
			Controls.Add(labelControl2);
			Controls.Add(txt_Login);
			Controls.Add(labelControl1);
			Controls.Add(btn_Cadastrar_Usuario);
			Controls.Add(btn_Entrar);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Font = new Font("Segoe UI", 8.25F);
			FormBorderStyle = FormBorderStyle.None;
			KeyPreview = true;
			Name = "form_Login";
			StartPosition = FormStartPosition.CenterScreen;
			Load += form_login_Load;
			Shown += form_Login_Shown;
			Click += form_login_Click;
			KeyDown += form_login_KeyDown;
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemColorEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Login.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Senha.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)chk_Lembrar_Login.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
		private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
		private Button btn_Cadastrar_Usuario;
		private Button btn_Entrar;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
		private DevExpress.Utils.WorkspaceManager workspaceManager1;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
		private DevExpress.XtraEditors.TextEdit txt_Senha;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txt_Login;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.CheckEdit chk_Lembrar_Login;
		private DevExpress.XtraEditors.SimpleButton btn_Sair;
	}
}
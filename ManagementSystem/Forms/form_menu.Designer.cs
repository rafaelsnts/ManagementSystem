namespace ManagementSystem.Forms
{
	partial class form_Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Menu));
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar2 = new DevExpress.XtraBars.Bar();
			barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			btn_Novo_Cadastro = new DevExpress.XtraBars.BarButtonItem();
			btn_Exibir_Usuarios = new DevExpress.XtraBars.BarButtonItem();
			barSubItem4 = new DevExpress.XtraBars.BarSubItem();
			btn_Novo_Cliente = new DevExpress.XtraBars.BarButtonItem();
			btn_Exibir_Clientes = new DevExpress.XtraBars.BarButtonItem();
			btn_Novo_Fornecedor = new DevExpress.XtraBars.BarSubItem();
			barSubItem6 = new DevExpress.XtraBars.BarSubItem();
			bar3 = new DevExpress.XtraBars.Bar();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			bar_Novo_Usuario = new DevExpress.XtraBars.BarCheckItem();
			bar_Exibir_Usuarios = new DevExpress.XtraBars.BarCheckItem();
			barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
			barSubItem7 = new DevExpress.XtraBars.BarSubItem();
			pnl_Menu = new DevExpress.XtraEditors.PanelControl();
			barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			btn_Exibir_Fornecedores = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pnl_Menu).BeginInit();
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
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barSubItem1, bar_Novo_Usuario, bar_Exibir_Usuarios, barButtonItem1, barSubItem2, btn_Novo_Cadastro, btn_Exibir_Usuarios, barButtonItem4, barSubItem3, barButtonItem2, barSubItem4, btn_Novo_Fornecedor, barSubItem6, barToggleSwitchItem1, barSubItem7, btn_Novo_Cliente, btn_Exibir_Clientes, barButtonItem3, btn_Exibir_Fornecedores, barButtonItem5, barButtonItem6 });
			barManager1.MainMenu = bar2;
			barManager1.MaxItemId = 21;
			barManager1.StatusBar = bar3;
			// 
			// bar2
			// 
			bar2.BarName = "Main menu";
			bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
			bar2.DockCol = 0;
			bar2.DockRow = 0;
			bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barSubItem2), new DevExpress.XtraBars.LinkPersistInfo(barSubItem4), new DevExpress.XtraBars.LinkPersistInfo(btn_Novo_Fornecedor), new DevExpress.XtraBars.LinkPersistInfo(barSubItem6) });
			bar2.OptionsBar.AllowQuickCustomization = false;
			bar2.OptionsBar.DisableCustomization = true;
			bar2.OptionsBar.DrawDragBorder = false;
			bar2.OptionsBar.MinHeight = 35;
			bar2.OptionsBar.MultiLine = true;
			bar2.OptionsBar.UseWholeRow = true;
			bar2.Text = "Main menu";
			// 
			// barSubItem2
			// 
			barSubItem2.Caption = "Usuário";
			barSubItem2.Id = 4;
			barSubItem2.ImageOptions.Image = (Image)resources.GetObject("barSubItem2.ImageOptions.Image");
			barSubItem2.ItemAppearance.Normal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			barSubItem2.ItemAppearance.Normal.Options.UseFont = true;
			barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn_Novo_Cadastro), new DevExpress.XtraBars.LinkPersistInfo(btn_Exibir_Usuarios) });
			barSubItem2.Name = "barSubItem2";
			barSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// btn_Novo_Cadastro
			// 
			btn_Novo_Cadastro.Caption = "Novo Usúario";
			btn_Novo_Cadastro.Id = 5;
			btn_Novo_Cadastro.Name = "btn_Novo_Cadastro";
			btn_Novo_Cadastro.ItemClick += btn_Novo_Cadastro_ItemClick;
			// 
			// btn_Exibir_Usuarios
			// 
			btn_Exibir_Usuarios.Caption = "Exibir Usuários";
			btn_Exibir_Usuarios.Id = 6;
			btn_Exibir_Usuarios.Name = "btn_Exibir_Usuarios";
			btn_Exibir_Usuarios.ItemClick += btn_Exibir_Usuarios_ItemClick;
			// 
			// barSubItem4
			// 
			barSubItem4.Caption = "Clientes";
			barSubItem4.Id = 10;
			barSubItem4.ImageOptions.Image = (Image)resources.GetObject("barSubItem4.ImageOptions.Image");
			barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn_Novo_Cliente), new DevExpress.XtraBars.LinkPersistInfo(btn_Exibir_Clientes) });
			barSubItem4.Name = "barSubItem4";
			barSubItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// btn_Novo_Cliente
			// 
			btn_Novo_Cliente.Caption = "Novo Cliente";
			btn_Novo_Cliente.Id = 15;
			btn_Novo_Cliente.Name = "btn_Novo_Cliente";
			btn_Novo_Cliente.ItemClick += btn_Novo_Cliente_ItemClick;
			// 
			// btn_Exibir_Clientes
			// 
			btn_Exibir_Clientes.Caption = "Exibir Clientes";
			btn_Exibir_Clientes.Id = 16;
			btn_Exibir_Clientes.Name = "btn_Exibir_Clientes";
			btn_Exibir_Clientes.ItemClick += btn_Exibir_Clientes_ItemClick;
			// 
			// btn_Novo_Fornecedor
			// 
			btn_Novo_Fornecedor.Caption = "Fornecedores";
			btn_Novo_Fornecedor.Id = 11;
			btn_Novo_Fornecedor.ImageOptions.Image = (Image)resources.GetObject("barSubItem5.ImageOptions.Image");
			btn_Novo_Fornecedor.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3), new DevExpress.XtraBars.LinkPersistInfo(btn_Exibir_Fornecedores) });
			btn_Novo_Fornecedor.Name = "btn_Novo_Fornecedor";
			btn_Novo_Fornecedor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// barSubItem6
			// 
			barSubItem6.Caption = "Produtos";
			barSubItem6.Id = 12;
			barSubItem6.ImageOptions.Image = (Image)resources.GetObject("barSubItem6.ImageOptions.Image");
			barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem5), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem6) });
			barSubItem6.Name = "barSubItem6";
			barSubItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
			barDockControlTop.Size = new Size(1280, 35);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 700);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(1280, 20);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 35);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 665);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(1280, 35);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 665);
			// 
			// barSubItem1
			// 
			barSubItem1.Caption = "Usuário";
			barSubItem1.Id = 0;
			barSubItem1.ImageOptions.Image = (Image)resources.GetObject("barSubItem1.ImageOptions.Image");
			barSubItem1.ImageOptions.SvgImageSize = new Size(16, 16);
			barSubItem1.ItemAppearance.Disabled.Font = new Font("Segoe UI", 12F);
			barSubItem1.ItemAppearance.Disabled.Options.UseFont = true;
			barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bar_Novo_Usuario), new DevExpress.XtraBars.LinkPersistInfo(bar_Exibir_Usuarios) });
			barSubItem1.Name = "barSubItem1";
			// 
			// bar_Novo_Usuario
			// 
			bar_Novo_Usuario.Caption = "Novo Cadastro";
			bar_Novo_Usuario.Id = 1;
			bar_Novo_Usuario.Name = "bar_Novo_Usuario";
			// 
			// bar_Exibir_Usuarios
			// 
			bar_Exibir_Usuarios.Caption = "Exibir Usuários";
			bar_Exibir_Usuarios.Id = 2;
			bar_Exibir_Usuarios.Name = "bar_Exibir_Usuarios";
			// 
			// barButtonItem1
			// 
			barButtonItem1.Caption = "barButtonItem1";
			barButtonItem1.Id = 3;
			barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
			barButtonItem1.Name = "barButtonItem1";
			barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// barButtonItem4
			// 
			barButtonItem4.Caption = "barButtonItem4";
			barButtonItem4.Id = 7;
			barButtonItem4.Name = "barButtonItem4";
			// 
			// barSubItem3
			// 
			barSubItem3.Caption = "barSubItem3";
			barSubItem3.Id = 8;
			barSubItem3.Name = "barSubItem3";
			// 
			// barButtonItem2
			// 
			barButtonItem2.Caption = "Clientes";
			barButtonItem2.Id = 9;
			barButtonItem2.Name = "barButtonItem2";
			// 
			// barToggleSwitchItem1
			// 
			barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
			barToggleSwitchItem1.Id = 13;
			barToggleSwitchItem1.Name = "barToggleSwitchItem1";
			// 
			// barSubItem7
			// 
			barSubItem7.Caption = "barSubItem7";
			barSubItem7.Id = 14;
			barSubItem7.ImageOptions.Image = (Image)resources.GetObject("barSubItem7.ImageOptions.Image");
			barSubItem7.Name = "barSubItem7";
			// 
			// pnl_Menu
			// 
			pnl_Menu.Location = new Point(0, 34);
			pnl_Menu.Name = "pnl_Menu";
			pnl_Menu.Size = new Size(1280, 687);
			pnl_Menu.TabIndex = 4;
			// 
			// barButtonItem3
			// 
			barButtonItem3.Caption = "Novo Fornecedor";
			barButtonItem3.Id = 17;
			barButtonItem3.Name = "barButtonItem3";
			// 
			// btn_Exibir_Fornecedores
			// 
			btn_Exibir_Fornecedores.Caption = "Exibir Fornecedores";
			btn_Exibir_Fornecedores.Id = 18;
			btn_Exibir_Fornecedores.Name = "btn_Exibir_Fornecedores";
			// 
			// barButtonItem5
			// 
			barButtonItem5.Caption = "Novo Produto";
			barButtonItem5.Id = 19;
			barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem6
			// 
			barButtonItem6.Caption = "Exibir Produtos";
			barButtonItem6.Id = 20;
			barButtonItem6.Name = "barButtonItem6";
			// 
			// form_Menu
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 720);
			Controls.Add(pnl_Menu);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Font = new Font("Segoe UI", 8.25F);
			FormBorderStyle = FormBorderStyle.None;
			IconOptions.ShowIcon = false;
			Name = "form_Menu";
			StartPosition = FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)pnl_Menu).EndInit();
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
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarCheckItem bar_Novo_Usuario;
		private DevExpress.XtraBars.BarCheckItem bar_Exibir_Usuarios;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarSubItem barSubItem2;
		private DevExpress.XtraBars.BarButtonItem btn_Novo_Cadastro;
		private DevExpress.XtraBars.BarButtonItem btn_Exibir_Usuarios;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarSubItem barSubItem3;
		private DevExpress.XtraBars.BarSubItem barSubItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarSubItem btn_Novo_Fornecedor;
		private DevExpress.XtraBars.BarSubItem barSubItem6;
		private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
		private DevExpress.XtraBars.BarSubItem barSubItem7;
		private DevExpress.XtraBars.BarButtonItem btn_Novo_Cliente;
		private DevExpress.XtraBars.BarButtonItem btn_Exibir_Clientes;
		private DevExpress.XtraEditors.PanelControl pnl_Menu;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem btn_Exibir_Fornecedores;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
	}
}
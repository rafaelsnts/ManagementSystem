namespace ManagementSystem.Forms
{
	partial class form_Exibir_Usuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Exibir_Usuarios));
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			grid_Exibir_Usuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
			gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			picEditFotoUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
			gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
			colusu_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
			colusu_bloqueado = new DevExpress.XtraGrid.Columns.GridColumn();
			repositoryItemToggleSwitch2 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
			colusu_ultimo_login = new DevExpress.XtraGrid.Columns.GridColumn();
			imgEditFotoUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
			popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
			btn_Excluir = new DevExpress.XtraBars.BarButtonItem();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)grid_Exibir_Usuarios).BeginInit();
			((System.ComponentModel.ISupportInitialize)picEditFotoUsuario).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemToggleSwitch1).BeginInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemToggleSwitch2).BeginInit();
			((System.ComponentModel.ISupportInitialize)imgEditFotoUsuario).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			SuspendLayout();
			// 
			// gridControl1
			// 
			gridControl1.DataSource = typeof(Models.tb_usuario);
			gridControl1.Location = new Point(0, -2);
			gridControl1.MainView = grid_Exibir_Usuarios;
			gridControl1.Name = "gridControl1";
			gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemToggleSwitch1, repositoryItemToggleSwitch2, imgEditFotoUsuario, picEditFotoUsuario });
			gridControl1.Size = new Size(1280, 689);
			gridControl1.TabIndex = 0;
			gridControl1.UseEmbeddedNavigator = true;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grid_Exibir_Usuarios });
			// 
			// grid_Exibir_Usuarios
			// 
			grid_Exibir_Usuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn4, gridColumn2, gridColumn3, colusu_cargo, colusu_bloqueado, colusu_ultimo_login });
			grid_Exibir_Usuarios.GridControl = gridControl1;
			grid_Exibir_Usuarios.Name = "grid_Exibir_Usuarios";
			grid_Exibir_Usuarios.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
			grid_Exibir_Usuarios.RowHeight = 200;
			grid_Exibir_Usuarios.PopupMenuShowing += grid_Exibir_Usuarios_PopupMenuShowing;
			grid_Exibir_Usuarios.FocusedRowChanged += grid_Exibir_Usuarios_FocusedRowChanged;
			grid_Exibir_Usuarios.ValidatingEditor += grid_Exibir_Usuarios_ValidatingEditor;
			// 
			// gridColumn1
			// 
			gridColumn1.Caption = "ID";
			gridColumn1.FieldName = "usu_id_usuario";
			gridColumn1.Name = "gridColumn1";
			// 
			// gridColumn4
			// 
			gridColumn4.Caption = "Foto";
			gridColumn4.ColumnEdit = picEditFotoUsuario;
			gridColumn4.FieldName = "usu_imagem_perfil";
			gridColumn4.Name = "gridColumn4";
			gridColumn4.Visible = true;
			gridColumn4.VisibleIndex = 0;
			// 
			// picEditFotoUsuario
			// 
			picEditFotoUsuario.Name = "picEditFotoUsuario";
			// 
			// gridColumn2
			// 
			gridColumn2.Caption = "Login";
			gridColumn2.FieldName = "usu_login";
			gridColumn2.Name = "gridColumn2";
			gridColumn2.Visible = true;
			gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			gridColumn3.Caption = "Ativo";
			gridColumn3.ColumnEdit = repositoryItemToggleSwitch1;
			gridColumn3.FieldName = "usu_status";
			gridColumn3.Name = "gridColumn3";
			gridColumn3.Visible = true;
			gridColumn3.VisibleIndex = 2;
			// 
			// repositoryItemToggleSwitch1
			// 
			repositoryItemToggleSwitch1.AutoHeight = false;
			repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
			repositoryItemToggleSwitch1.OffText = "Off";
			repositoryItemToggleSwitch1.OnText = "On";
			// 
			// colusu_cargo
			// 
			colusu_cargo.Caption = "Cargo";
			colusu_cargo.FieldName = "usu_cargo";
			colusu_cargo.Name = "colusu_cargo";
			colusu_cargo.Visible = true;
			colusu_cargo.VisibleIndex = 3;
			// 
			// colusu_bloqueado
			// 
			colusu_bloqueado.Caption = "Bloqueado";
			colusu_bloqueado.ColumnEdit = repositoryItemToggleSwitch2;
			colusu_bloqueado.FieldName = "usu_bloqueado";
			colusu_bloqueado.Name = "colusu_bloqueado";
			colusu_bloqueado.Visible = true;
			colusu_bloqueado.VisibleIndex = 4;
			// 
			// repositoryItemToggleSwitch2
			// 
			repositoryItemToggleSwitch2.AutoHeight = false;
			repositoryItemToggleSwitch2.Name = "repositoryItemToggleSwitch2";
			repositoryItemToggleSwitch2.OffText = "Off";
			repositoryItemToggleSwitch2.OnText = "On";
			// 
			// colusu_ultimo_login
			// 
			colusu_ultimo_login.Caption = "Ultimo Login";
			colusu_ultimo_login.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
			colusu_ultimo_login.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			colusu_ultimo_login.FieldName = "usu_ultimo_login";
			colusu_ultimo_login.Name = "colusu_ultimo_login";
			colusu_ultimo_login.Visible = true;
			colusu_ultimo_login.VisibleIndex = 5;
			// 
			// imgEditFotoUsuario
			// 
			imgEditFotoUsuario.AutoHeight = false;
			imgEditFotoUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			imgEditFotoUsuario.Name = "imgEditFotoUsuario";
			// 
			// popupMenu1
			// 
			popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn_Excluir) });
			popupMenu1.Manager = barManager1;
			popupMenu1.Name = "popupMenu1";
			// 
			// btn_Excluir
			// 
			btn_Excluir.Caption = "Excluir";
			btn_Excluir.Id = 1;
			btn_Excluir.ImageOptions.LargeImage = (Image)resources.GetObject("btn_Excluir.ImageOptions.LargeImage");
			btn_Excluir.Name = "btn_Excluir";
			// 
			// barManager1
			// 
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btn_Excluir });
			barManager1.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Size = new Size(1280, 0);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 687);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(1280, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 687);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(1280, 0);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 687);
			// 
			// form_Exibir_Usuarios
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 687);
			Controls.Add(gridControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			FormBorderStyle = FormBorderStyle.None;
			Name = "form_Exibir_Usuarios";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "form_Exibir_Usuarios";
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)grid_Exibir_Usuarios).EndInit();
			((System.ComponentModel.ISupportInitialize)picEditFotoUsuario).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemToggleSwitch1).EndInit();
			((System.ComponentModel.ISupportInitialize)repositoryItemToggleSwitch2).EndInit();
			((System.ComponentModel.ISupportInitialize)imgEditFotoUsuario).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView grid_Exibir_Usuarios;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
		private DevExpress.XtraBars.PopupMenu popupMenu1;
		private DevExpress.XtraBars.BarButtonItem btn_Excluir;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraGrid.Columns.GridColumn colusu_cargo;
		private DevExpress.XtraGrid.Columns.GridColumn colusu_bloqueado;
		private DevExpress.XtraGrid.Columns.GridColumn colusu_ultimo_login;
		private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch2;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imgEditFotoUsuario;
		private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit picEditFotoUsuario;
	}
}
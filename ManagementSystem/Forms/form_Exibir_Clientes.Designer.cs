namespace ManagementSystem.Forms
{
	partial class form_Exibir_Clientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Exibir_Clientes));
			gridControl1 = new DevExpress.XtraGrid.GridControl();
			tbclientesBindingSource = new BindingSource(components);
			grid_Cliente = new DevExpress.XtraGrid.Views.Grid.GridView();
			colcli_id_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_foto_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_data_criacao = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_nome = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_cpf = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_email = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_telefone = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_cep = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_rua = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_numero_casa = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_bairro = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_cidade = new DevExpress.XtraGrid.Columns.GridColumn();
			colcli_estado = new DevExpress.XtraGrid.Columns.GridColumn();
			popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
			btn_Editar = new DevExpress.XtraBars.BarButtonItem();
			btn_Excluir = new DevExpress.XtraBars.BarButtonItem();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbclientesBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)grid_Cliente).BeginInit();
			((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			SuspendLayout();
			// 
			// gridControl1
			// 
			gridControl1.DataSource = tbclientesBindingSource;
			gridControl1.Location = new Point(-1, 0);
			gridControl1.MainView = grid_Cliente;
			gridControl1.Name = "gridControl1";
			gridControl1.Size = new Size(1280, 689);
			gridControl1.TabIndex = 0;
			gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grid_Cliente });
			// 
			// tbclientesBindingSource
			// 
			tbclientesBindingSource.DataSource = typeof(Models.tb_clientes);
			// 
			// grid_Cliente
			// 
			grid_Cliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colcli_id_cliente, colcli_foto_cliente, colcli_data_criacao, colcli_nome, colcli_cpf, colcli_email, colcli_telefone, colcli_cep, colcli_rua, colcli_numero_casa, colcli_bairro, colcli_cidade, colcli_estado });
			grid_Cliente.GridControl = gridControl1;
			grid_Cliente.Name = "grid_Cliente";
			grid_Cliente.PopupMenuShowing += grid_Cliente_PopupMenuShowing;
			grid_Cliente.FocusedRowChanged += grid_Cliente_FocusedRowChanged;
			// 
			// colcli_id_cliente
			// 
			colcli_id_cliente.FieldName = "cli_id_cliente";
			colcli_id_cliente.Name = "colcli_id_cliente";
			// 
			// colcli_foto_cliente
			// 
			colcli_foto_cliente.Caption = "Foto";
			colcli_foto_cliente.FieldName = "cli_foto_cliente";
			colcli_foto_cliente.Name = "colcli_foto_cliente";
			colcli_foto_cliente.Visible = true;
			colcli_foto_cliente.VisibleIndex = 0;
			// 
			// colcli_data_criacao
			// 
			colcli_data_criacao.Caption = "Data Criação";
			colcli_data_criacao.FieldName = "cli_data_criacao";
			colcli_data_criacao.Name = "colcli_data_criacao";
			colcli_data_criacao.Visible = true;
			colcli_data_criacao.VisibleIndex = 1;
			// 
			// colcli_nome
			// 
			colcli_nome.Caption = "Nome";
			colcli_nome.FieldName = "cli_nome";
			colcli_nome.Name = "colcli_nome";
			colcli_nome.Visible = true;
			colcli_nome.VisibleIndex = 2;
			// 
			// colcli_cpf
			// 
			colcli_cpf.Caption = "CPF";
			colcli_cpf.FieldName = "cli_cpf";
			colcli_cpf.Name = "colcli_cpf";
			colcli_cpf.Visible = true;
			colcli_cpf.VisibleIndex = 3;
			// 
			// colcli_email
			// 
			colcli_email.Caption = "Email";
			colcli_email.FieldName = "cli_email";
			colcli_email.Name = "colcli_email";
			colcli_email.Visible = true;
			colcli_email.VisibleIndex = 4;
			// 
			// colcli_telefone
			// 
			colcli_telefone.Caption = "Telefone";
			colcli_telefone.FieldName = "cli_telefone";
			colcli_telefone.Name = "colcli_telefone";
			colcli_telefone.Visible = true;
			colcli_telefone.VisibleIndex = 5;
			// 
			// colcli_cep
			// 
			colcli_cep.Caption = "CEP";
			colcli_cep.FieldName = "cli_cep";
			colcli_cep.Name = "colcli_cep";
			colcli_cep.Visible = true;
			colcli_cep.VisibleIndex = 6;
			// 
			// colcli_rua
			// 
			colcli_rua.Caption = "Rua";
			colcli_rua.FieldName = "cli_rua";
			colcli_rua.Name = "colcli_rua";
			colcli_rua.Visible = true;
			colcli_rua.VisibleIndex = 7;
			// 
			// colcli_numero_casa
			// 
			colcli_numero_casa.Caption = "Nº";
			colcli_numero_casa.FieldName = "cli_numero_casa";
			colcli_numero_casa.Name = "colcli_numero_casa";
			colcli_numero_casa.Visible = true;
			colcli_numero_casa.VisibleIndex = 8;
			// 
			// colcli_bairro
			// 
			colcli_bairro.Caption = "Bairro";
			colcli_bairro.FieldName = "cli_bairro";
			colcli_bairro.Name = "colcli_bairro";
			colcli_bairro.Visible = true;
			colcli_bairro.VisibleIndex = 9;
			// 
			// colcli_cidade
			// 
			colcli_cidade.Caption = "Cidade";
			colcli_cidade.FieldName = "cli_cidade";
			colcli_cidade.Name = "colcli_cidade";
			colcli_cidade.Visible = true;
			colcli_cidade.VisibleIndex = 10;
			// 
			// colcli_estado
			// 
			colcli_estado.Caption = "Estado";
			colcli_estado.FieldName = "cli_estado";
			colcli_estado.Name = "colcli_estado";
			colcli_estado.Visible = true;
			colcli_estado.VisibleIndex = 11;
			// 
			// popupMenu1
			// 
			popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btn_Editar), new DevExpress.XtraBars.LinkPersistInfo(btn_Excluir) });
			popupMenu1.Manager = barManager1;
			popupMenu1.Name = "popupMenu1";
			// 
			// btn_Editar
			// 
			btn_Editar.Caption = "Editar";
			btn_Editar.Id = 0;
			btn_Editar.ImageOptions.Image = (Image)resources.GetObject("btn_Editar.ImageOptions.Image");
			btn_Editar.Name = "btn_Editar";
			// 
			// btn_Excluir
			// 
			btn_Excluir.Caption = "Excluir";
			btn_Excluir.Id = 1;
			btn_Excluir.ImageOptions.Image = (Image)resources.GetObject("btn_Excluir.ImageOptions.Image");
			btn_Excluir.Name = "btn_Excluir";
			// 
			// barManager1
			// 
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btn_Editar, btn_Excluir });
			barManager1.MaxItemId = 2;
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
			barDockControlBottom.Location = new Point(0, 689);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Size = new Size(1280, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Size = new Size(0, 689);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(1280, 0);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Size = new Size(0, 689);
			// 
			// form_Exibir_Clientes
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 689);
			Controls.Add(gridControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			FormBorderStyle = FormBorderStyle.None;
			Name = "form_Exibir_Clientes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "form_Exibir_Clientes";
			((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)tbclientesBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)grid_Cliente).EndInit();
			((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView grid_Cliente;
		private DevExpress.XtraBars.PopupMenu popupMenu1;
		private DevExpress.XtraBars.BarButtonItem btn_Editar;
		private DevExpress.XtraBars.BarButtonItem btn_Excluir;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private BindingSource tbclientesBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_id_cliente;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_nome;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_cpf;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_email;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_telefone;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_rua;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_bairro;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_cidade;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_estado;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_data_criacao;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_numero_casa;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_cep;
		private DevExpress.XtraGrid.Columns.GridColumn colcli_foto_cliente;
	}
}
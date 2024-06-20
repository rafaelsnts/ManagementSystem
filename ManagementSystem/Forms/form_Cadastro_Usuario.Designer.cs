namespace ManagementSystem.Forms
{
	partial class form_Cadastro_Usuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Cadastro_Usuario));
			txt_Cadastro_Senha = new DevExpress.XtraEditors.TextEdit();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			txt_Cadastro_Login = new DevExpress.XtraEditors.TextEdit();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			dte_Data_Criacao = new DevExpress.XtraEditors.DateEdit();
			labelControl3 = new DevExpress.XtraEditors.LabelControl();
			labelControl4 = new DevExpress.XtraEditors.LabelControl();
			cmb_Cadastro_Cargo = new DevExpress.XtraEditors.ComboBoxEdit();
			pic_Adicionar_Foto = new DevExpress.XtraEditors.PictureEdit();
			btn_Carregar_Foto = new Button();
			btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
			btn_Voltar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)txt_Cadastro_Senha.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Cadastro_Login.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Criacao.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Criacao.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)cmb_Cadastro_Cargo.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)pic_Adicionar_Foto.Properties).BeginInit();
			SuspendLayout();
			// 
			// txt_Cadastro_Senha
			// 
			txt_Cadastro_Senha.Location = new Point(24, 156);
			txt_Cadastro_Senha.Name = "txt_Cadastro_Senha";
			txt_Cadastro_Senha.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Cadastro_Senha.Properties.Appearance.Options.UseFont = true;
			txt_Cadastro_Senha.Properties.PasswordChar = '*';
			txt_Cadastro_Senha.Size = new Size(222, 28);
			txt_Cadastro_Senha.TabIndex = 24;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl2.Appearance.Options.UseFont = true;
			labelControl2.Location = new Point(112, 129);
			labelControl2.Name = "labelControl2";
			labelControl2.Size = new Size(43, 21);
			labelControl2.TabIndex = 23;
			labelControl2.Text = "Senha";
			// 
			// txt_Cadastro_Login
			// 
			txt_Cadastro_Login.Location = new Point(24, 95);
			txt_Cadastro_Login.Name = "txt_Cadastro_Login";
			txt_Cadastro_Login.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Cadastro_Login.Properties.Appearance.Options.UseFont = true;
			txt_Cadastro_Login.Size = new Size(222, 28);
			txt_Cadastro_Login.TabIndex = 22;
			// 
			// labelControl1
			// 
			labelControl1.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl1.Appearance.Options.UseFont = true;
			labelControl1.Location = new Point(112, 67);
			labelControl1.Name = "labelControl1";
			labelControl1.Size = new Size(39, 21);
			labelControl1.TabIndex = 21;
			labelControl1.Text = "Login";
			// 
			// dte_Data_Criacao
			// 
			dte_Data_Criacao.EditValue = null;
			dte_Data_Criacao.Location = new Point(24, 34);
			dte_Data_Criacao.Name = "dte_Data_Criacao";
			dte_Data_Criacao.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			dte_Data_Criacao.Properties.Appearance.Options.UseFont = true;
			dte_Data_Criacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dte_Data_Criacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dte_Data_Criacao.Size = new Size(222, 28);
			dte_Data_Criacao.TabIndex = 25;
			// 
			// labelControl3
			// 
			labelControl3.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl3.Appearance.Options.UseFont = true;
			labelControl3.Location = new Point(112, 12);
			labelControl3.Name = "labelControl3";
			labelControl3.Size = new Size(32, 21);
			labelControl3.TabIndex = 28;
			labelControl3.Text = "Data";
			// 
			// labelControl4
			// 
			labelControl4.Appearance.Font = new Font("Segoe UI", 12F);
			labelControl4.Appearance.Options.UseFont = true;
			labelControl4.Location = new Point(112, 187);
			labelControl4.Name = "labelControl4";
			labelControl4.Size = new Size(42, 21);
			labelControl4.TabIndex = 26;
			labelControl4.Text = "Cargo";
			// 
			// cmb_Cadastro_Cargo
			// 
			cmb_Cadastro_Cargo.Location = new Point(24, 216);
			cmb_Cadastro_Cargo.Name = "cmb_Cadastro_Cargo";
			cmb_Cadastro_Cargo.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			cmb_Cadastro_Cargo.Properties.Appearance.Options.UseFont = true;
			cmb_Cadastro_Cargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			cmb_Cadastro_Cargo.Size = new Size(222, 28);
			cmb_Cadastro_Cargo.TabIndex = 30;
			// 
			// pic_Adicionar_Foto
			// 
			pic_Adicionar_Foto.Location = new Point(314, 12);
			pic_Adicionar_Foto.Name = "pic_Adicionar_Foto";
			pic_Adicionar_Foto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pic_Adicionar_Foto.Size = new Size(200, 200);
			pic_Adicionar_Foto.TabIndex = 31;
			// 
			// btn_Carregar_Foto
			// 
			btn_Carregar_Foto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			btn_Carregar_Foto.ForeColor = Color.Black;
			btn_Carregar_Foto.Location = new Point(314, 214);
			btn_Carregar_Foto.Name = "btn_Carregar_Foto";
			btn_Carregar_Foto.Size = new Size(200, 30);
			btn_Carregar_Foto.TabIndex = 34;
			btn_Carregar_Foto.Text = "Carregar Foto";
			btn_Carregar_Foto.UseVisualStyleBackColor = true;
			btn_Carregar_Foto.Click += btn_Carregar_Foto_Click;
			// 
			// btn_Salvar
			// 
			btn_Salvar.ImageOptions.Image = (Image)resources.GetObject("btn_Salvar.ImageOptions.Image");
			btn_Salvar.Location = new Point(247, 266);
			btn_Salvar.Name = "btn_Salvar";
			btn_Salvar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Salvar.Size = new Size(39, 41);
			btn_Salvar.TabIndex = 35;
			btn_Salvar.Click += btn_Salvar_Click;
			// 
			// btn_Voltar
			// 
			btn_Voltar.ImageOptions.Image = (Image)resources.GetObject("btn_Voltar.ImageOptions.Image");
			btn_Voltar.Location = new Point(292, 266);
			btn_Voltar.Name = "btn_Voltar";
			btn_Voltar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Voltar.Size = new Size(39, 41);
			btn_Voltar.TabIndex = 36;
			btn_Voltar.Click += btn_Voltar_Click;
			// 
			// form_Cadastro_Usuario
			// 
			ActiveGlowColor = Color.Red;
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(550, 310);
			Controls.Add(btn_Voltar);
			Controls.Add(btn_Salvar);
			Controls.Add(btn_Carregar_Foto);
			Controls.Add(pic_Adicionar_Foto);
			Controls.Add(cmb_Cadastro_Cargo);
			Controls.Add(labelControl3);
			Controls.Add(labelControl4);
			Controls.Add(dte_Data_Criacao);
			Controls.Add(txt_Cadastro_Senha);
			Controls.Add(labelControl2);
			Controls.Add(txt_Cadastro_Login);
			Controls.Add(labelControl1);
			Font = new Font("Segoe UI", 8.25F);
			FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
			FormBorderStyle = FormBorderStyle.None;
			Name = "form_Cadastro_Usuario";
			StartPosition = FormStartPosition.CenterScreen;
			Load += form_Cadastro_Usuario_Load;
			((System.ComponentModel.ISupportInitialize)txt_Cadastro_Senha.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Cadastro_Login.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Criacao.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Criacao.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)cmb_Cadastro_Cargo.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)pic_Adicionar_Foto.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txt_Cadastro_Senha;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txt_Cadastro_Login;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.DateEdit dte_Data_Criacao;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.ComboBoxEdit cmb_Cadastro_Cargo;
		private DevExpress.XtraEditors.PictureEdit pic_Adicionar_Foto;
		private Button btn_Cadastrar_Usuario;
		private Button btn_Carregar_Foto;
		private DevExpress.XtraEditors.SimpleButton btn_Salvar;
		private DevExpress.XtraEditors.SimpleButton btn_Voltar;
	}
}
namespace ManagementSystem.Forms
{
	partial class form_Cadastro_Cliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Cadastro_Cliente));
			label1 = new Label();
			txt_Nome_Cliente = new DevExpress.XtraEditors.TextEdit();
			pic_Foto_Cliente = new DevExpress.XtraEditors.PictureEdit();
			btn_Carregar_Foto = new DevExpress.XtraEditors.SimpleButton();
			txt_Email_Cliente = new DevExpress.XtraEditors.TextEdit();
			label2 = new Label();
			txt_Cep_Cliente = new DevExpress.XtraEditors.TextEdit();
			label3 = new Label();
			txt_Telefone_Cliente = new DevExpress.XtraEditors.TextEdit();
			label4 = new Label();
			txt_Bairro_Cliente = new DevExpress.XtraEditors.TextEdit();
			label5 = new Label();
			txt_Rua_Cliente = new DevExpress.XtraEditors.TextEdit();
			label6 = new Label();
			txt_Numero_Cliente = new DevExpress.XtraEditors.TextEdit();
			label7 = new Label();
			txt_Cidade_Cliente = new DevExpress.XtraEditors.TextEdit();
			label8 = new Label();
			dte_Data_Cadastro = new DevExpress.XtraEditors.DateEdit();
			label9 = new Label();
			btn_Voltar = new DevExpress.XtraEditors.SimpleButton();
			btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
			txt_Estado_Cliente = new DevExpress.XtraEditors.TextEdit();
			label10 = new Label();
			txt_Cpf_Cliente = new DevExpress.XtraEditors.TextEdit();
			label11 = new Label();
			lbl_Id_Cliente = new Label();
			btn_Alterar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)txt_Nome_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)pic_Foto_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Email_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Cep_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Telefone_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Bairro_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Rua_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Numero_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Cidade_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Cadastro.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Cadastro.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Estado_Cliente.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)txt_Cpf_Cliente.Properties).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label1.Location = new Point(57, 122);
			label1.Name = "label1";
			label1.Size = new Size(59, 21);
			label1.TabIndex = 0;
			label1.Text = "Nome:";
			// 
			// txt_Nome_Cliente
			// 
			txt_Nome_Cliente.Location = new Point(57, 147);
			txt_Nome_Cliente.Name = "txt_Nome_Cliente";
			txt_Nome_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Nome_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Nome_Cliente.Size = new Size(437, 28);
			txt_Nome_Cliente.TabIndex = 1;
			// 
			// pic_Foto_Cliente
			// 
			pic_Foto_Cliente.Location = new Point(998, 149);
			pic_Foto_Cliente.Name = "pic_Foto_Cliente";
			pic_Foto_Cliente.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			pic_Foto_Cliente.Size = new Size(246, 280);
			pic_Foto_Cliente.TabIndex = 2;
			// 
			// btn_Carregar_Foto
			// 
			btn_Carregar_Foto.Appearance.Font = new Font("Segoe UI", 12F);
			btn_Carregar_Foto.Appearance.Options.UseFont = true;
			btn_Carregar_Foto.Location = new Point(998, 438);
			btn_Carregar_Foto.Name = "btn_Carregar_Foto";
			btn_Carregar_Foto.Size = new Size(246, 33);
			btn_Carregar_Foto.TabIndex = 3;
			btn_Carregar_Foto.Text = "Carregar Foto";
			btn_Carregar_Foto.Click += btn_Carregar_Foto_Click;
			// 
			// txt_Email_Cliente
			// 
			txt_Email_Cliente.Location = new Point(57, 226);
			txt_Email_Cliente.Name = "txt_Email_Cliente";
			txt_Email_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Email_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Email_Cliente.Size = new Size(437, 28);
			txt_Email_Cliente.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label2.Location = new Point(57, 201);
			label2.Name = "label2";
			label2.Size = new Size(58, 21);
			label2.TabIndex = 4;
			label2.Text = "E-mail:";
			// 
			// txt_Cep_Cliente
			// 
			txt_Cep_Cliente.Location = new Point(57, 298);
			txt_Cep_Cliente.Name = "txt_Cep_Cliente";
			txt_Cep_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Cep_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Cep_Cliente.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			txt_Cep_Cliente.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			txt_Cep_Cliente.Properties.MaskSettings.Set("mask", "00000-000");
			txt_Cep_Cliente.Size = new Size(437, 28);
			txt_Cep_Cliente.TabIndex = 9;
			txt_Cep_Cliente.Leave += txt_Cep_Cliente_Leave;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label3.Location = new Point(57, 273);
			label3.Name = "label3";
			label3.Size = new Size(41, 21);
			label3.TabIndex = 8;
			label3.Text = "CEP:";
			// 
			// txt_Telefone_Cliente
			// 
			txt_Telefone_Cliente.Location = new Point(538, 225);
			txt_Telefone_Cliente.Name = "txt_Telefone_Cliente";
			txt_Telefone_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Telefone_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Telefone_Cliente.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
			txt_Telefone_Cliente.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			txt_Telefone_Cliente.Properties.MaskSettings.Set("mask", "(\\d?\\d?) \\d \\d\\d\\d\\d-\\d\\d\\d\\d");
			txt_Telefone_Cliente.Size = new Size(437, 28);
			txt_Telefone_Cliente.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label4.Location = new Point(535, 201);
			label4.Name = "label4";
			label4.Size = new Size(77, 21);
			label4.TabIndex = 6;
			label4.Text = "Telefone:";
			// 
			// txt_Bairro_Cliente
			// 
			txt_Bairro_Cliente.Location = new Point(57, 443);
			txt_Bairro_Cliente.Name = "txt_Bairro_Cliente";
			txt_Bairro_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Bairro_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Bairro_Cliente.Size = new Size(437, 28);
			txt_Bairro_Cliente.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label5.Location = new Point(57, 418);
			label5.Name = "label5";
			label5.Size = new Size(58, 21);
			label5.TabIndex = 12;
			label5.Text = "Bairro:";
			// 
			// txt_Rua_Cliente
			// 
			txt_Rua_Cliente.Location = new Point(538, 298);
			txt_Rua_Cliente.Name = "txt_Rua_Cliente";
			txt_Rua_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Rua_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Rua_Cliente.Size = new Size(437, 28);
			txt_Rua_Cliente.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label6.Location = new Point(538, 273);
			label6.Name = "label6";
			label6.Size = new Size(41, 21);
			label6.TabIndex = 10;
			label6.Text = "Rua:";
			// 
			// txt_Numero_Cliente
			// 
			txt_Numero_Cliente.Location = new Point(538, 374);
			txt_Numero_Cliente.Name = "txt_Numero_Cliente";
			txt_Numero_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Numero_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Numero_Cliente.Size = new Size(437, 28);
			txt_Numero_Cliente.TabIndex = 17;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label7.Location = new Point(535, 349);
			label7.Name = "label7";
			label7.Size = new Size(74, 21);
			label7.TabIndex = 16;
			label7.Text = "Número:";
			// 
			// txt_Cidade_Cliente
			// 
			txt_Cidade_Cliente.Location = new Point(57, 374);
			txt_Cidade_Cliente.Name = "txt_Cidade_Cliente";
			txt_Cidade_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Cidade_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Cidade_Cliente.Size = new Size(437, 28);
			txt_Cidade_Cliente.TabIndex = 15;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label8.Location = new Point(57, 349);
			label8.Name = "label8";
			label8.Size = new Size(65, 21);
			label8.TabIndex = 14;
			label8.Text = "Cidade:";
			// 
			// dte_Data_Cadastro
			// 
			dte_Data_Cadastro.EditValue = null;
			dte_Data_Cadastro.Location = new Point(57, 37);
			dte_Data_Cadastro.Name = "dte_Data_Cadastro";
			dte_Data_Cadastro.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			dte_Data_Cadastro.Properties.Appearance.Options.UseFont = true;
			dte_Data_Cadastro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dte_Data_Cadastro.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			dte_Data_Cadastro.Size = new Size(176, 28);
			dte_Data_Cadastro.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label9.Location = new Point(57, 13);
			label9.Name = "label9";
			label9.Size = new Size(116, 21);
			label9.TabIndex = 19;
			label9.Text = "Data Cadastro:";
			// 
			// btn_Voltar
			// 
			btn_Voltar.ImageOptions.Image = (Image)resources.GetObject("btn_Voltar.ImageOptions.Image");
			btn_Voltar.Location = new Point(637, 625);
			btn_Voltar.Name = "btn_Voltar";
			btn_Voltar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Voltar.Size = new Size(39, 41);
			btn_Voltar.TabIndex = 38;
			btn_Voltar.Click += btn_Voltar_Click;
			// 
			// btn_Salvar
			// 
			btn_Salvar.ImageOptions.Image = (Image)resources.GetObject("btn_Salvar.ImageOptions.Image");
			btn_Salvar.Location = new Point(559, 625);
			btn_Salvar.Name = "btn_Salvar";
			btn_Salvar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Salvar.Size = new Size(39, 41);
			btn_Salvar.TabIndex = 37;
			btn_Salvar.Click += btn_Salvar_Click;
			// 
			// txt_Estado_Cliente
			// 
			txt_Estado_Cliente.Location = new Point(535, 443);
			txt_Estado_Cliente.Name = "txt_Estado_Cliente";
			txt_Estado_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Estado_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Estado_Cliente.Size = new Size(437, 28);
			txt_Estado_Cliente.TabIndex = 40;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label10.Location = new Point(535, 418);
			label10.Name = "label10";
			label10.Size = new Size(63, 21);
			label10.TabIndex = 39;
			label10.Text = "Estado:";
			// 
			// txt_Cpf_Cliente
			// 
			txt_Cpf_Cliente.Location = new Point(538, 147);
			txt_Cpf_Cliente.Name = "txt_Cpf_Cliente";
			txt_Cpf_Cliente.Properties.Appearance.Font = new Font("Segoe UI", 12F);
			txt_Cpf_Cliente.Properties.Appearance.Options.UseFont = true;
			txt_Cpf_Cliente.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			txt_Cpf_Cliente.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
			txt_Cpf_Cliente.Properties.MaskSettings.Set("mask", "000.000.000-00");
			txt_Cpf_Cliente.Size = new Size(437, 28);
			txt_Cpf_Cliente.TabIndex = 42;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label11.Location = new Point(538, 122);
			label11.Name = "label11";
			label11.Size = new Size(41, 21);
			label11.TabIndex = 41;
			label11.Text = "CPF:";
			// 
			// lbl_Id_Cliente
			// 
			lbl_Id_Cliente.AutoSize = true;
			lbl_Id_Cliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			lbl_Id_Cliente.Location = new Point(1242, 9);
			lbl_Id_Cliente.Name = "lbl_Id_Cliente";
			lbl_Id_Cliente.Size = new Size(26, 21);
			lbl_Id_Cliente.TabIndex = 43;
			lbl_Id_Cliente.Text = "ID";
			lbl_Id_Cliente.Visible = false;
			// 
			// btn_Alterar
			// 
			btn_Alterar.ImageOptions.Image = (Image)resources.GetObject("btn_Alterar.ImageOptions.Image");
			btn_Alterar.Location = new Point(601, 625);
			btn_Alterar.Name = "btn_Alterar";
			btn_Alterar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
			btn_Alterar.Size = new Size(39, 41);
			btn_Alterar.TabIndex = 44;
			btn_Alterar.Visible = false;
			btn_Alterar.Click += btn_Alterar_Click;
			// 
			// form_Cadastro_Cliente
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 689);
			Controls.Add(btn_Alterar);
			Controls.Add(lbl_Id_Cliente);
			Controls.Add(txt_Cpf_Cliente);
			Controls.Add(label11);
			Controls.Add(txt_Estado_Cliente);
			Controls.Add(label10);
			Controls.Add(btn_Voltar);
			Controls.Add(btn_Salvar);
			Controls.Add(label9);
			Controls.Add(dte_Data_Cadastro);
			Controls.Add(txt_Numero_Cliente);
			Controls.Add(label7);
			Controls.Add(txt_Cidade_Cliente);
			Controls.Add(label8);
			Controls.Add(txt_Bairro_Cliente);
			Controls.Add(label5);
			Controls.Add(txt_Rua_Cliente);
			Controls.Add(label6);
			Controls.Add(txt_Cep_Cliente);
			Controls.Add(label3);
			Controls.Add(txt_Telefone_Cliente);
			Controls.Add(label4);
			Controls.Add(txt_Email_Cliente);
			Controls.Add(label2);
			Controls.Add(btn_Carregar_Foto);
			Controls.Add(pic_Foto_Cliente);
			Controls.Add(txt_Nome_Cliente);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "form_Cadastro_Cliente";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "form_Cadastro_Cliente";
			((System.ComponentModel.ISupportInitialize)txt_Nome_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)pic_Foto_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Email_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Cep_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Telefone_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Bairro_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Rua_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Numero_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Cidade_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Cadastro.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)dte_Data_Cadastro.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Estado_Cliente.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)txt_Cpf_Cliente.Properties).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		public Label lbl_Id_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Nome_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Email_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Cep_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Telefone_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Bairro_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Rua_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Numero_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Cidade_Cliente;
		public DevExpress.XtraEditors.DateEdit dte_Data_Cadastro;
		public DevExpress.XtraEditors.TextEdit txt_Estado_Cliente;
		public DevExpress.XtraEditors.TextEdit txt_Cpf_Cliente;
		public DevExpress.XtraEditors.PictureEdit pic_Foto_Cliente;
		public DevExpress.XtraEditors.SimpleButton btn_Carregar_Foto;
		public DevExpress.XtraEditors.SimpleButton btn_Alterar;
		public DevExpress.XtraEditors.SimpleButton btn_Voltar;
		public DevExpress.XtraEditors.SimpleButton btn_Salvar;
	}
}
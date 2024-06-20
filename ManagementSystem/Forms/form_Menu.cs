namespace ManagementSystem.Forms
{
	public partial class form_Menu : DevExpress.XtraEditors.XtraForm
	{
		public form_Menu()
		{
			InitializeComponent();

		}

		public void showChildForminPanel(object Form)
		{
			//0 = 1
			//1 = 2
			if (this.pnl_Menu.Controls.Count > 1)
			{
				this.pnl_Menu.Controls.RemoveAt(0);
			}
			Form form = Form as Form;
			form.FormBorderStyle = FormBorderStyle.None;
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			this.pnl_Menu.Controls.Add(form);
			form.BringToFront();
			form.Show();
		}
		private void btn_Novo_Cadastro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			form_Cadastro_Usuario cadastroUsuario = new form_Cadastro_Usuario();
			cadastroUsuario.ShowDialog();
		}

		private void btn_Exibir_Usuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			showChildForminPanel(new form_Exibir_Usuarios());
		}

		private void btn_Novo_Cliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			showChildForminPanel(new form_Cadastro_Cliente());
		}

		private void btn_Exibir_Clientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			showChildForminPanel(new form_Exibir_Clientes(this));
		}
	}
}
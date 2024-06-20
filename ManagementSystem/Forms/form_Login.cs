using ManagementSystem.Context;
using ManagementSystem.Enum;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Forms
{
	public partial class form_Login : DevExpress.XtraEditors.XtraForm
	{
		ManagementSystemContext context = new ManagementSystemContext();
		int tentativasLogin = 0;
		public form_Login()
		{
			InitializeComponent();
			txt_Senha.Focus();
		}
		private async void btn_Entrar_Click(object sender, EventArgs e)
		{
			SeCheckedIsMarcado();
			await Login();
		}
		private async Task Login()
		{
			form_Menu menu = new form_Menu();
			try
			{
				if (txt_Login.Text == "" || txt_Senha.Text == "")
				{
					MessageBox.Show("Preencha todos os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				var usuario = await context.tb_usuario.FirstOrDefaultAsync(x => x.usu_login == txt_Login.Text);

				if (usuario == null)
				{
					MessageBox.Show("Usuário não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (usuario.usu_bloqueado == true)
				{
					if (usuario.usu_bloqueado_ate != null)
					{
						MessageBox.Show("Usuário bloqueado até " + usuario.usu_bloqueado_ate, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
					{
						MessageBox.Show("Usuário bloqueado permanentemente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

				}

				if (usuario.usu_senha != txt_Senha.Text)
				{
					tentativasLogin++;
					if (tentativasLogin >= 3)
					{
						usuario.usu_bloqueado = true;
						usuario.usu_bloqueado_ate = DateTime.Now.AddMinutes(15);
						context.tb_usuario.Update(usuario);
						await context.SaveChangesAsync();
						MessageBox.Show("Usuário bloqueado por 15 minutos devido a múltiplas tentativas de login falhas.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Usuário ou senha inválidos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					return;
				}



				tentativasLogin = 0;
				usuario.usu_ultimo_login = DateTime.Now;
				usuario.usu_bloqueado_ate = null;
				context.tb_usuario.Update(usuario);
				await context.SaveChangesAsync();

				// ainda preciso informar o que cada cargo pode fazer
				switch (usuario.usu_cargo)
				{
					case nameof(CargosUsuario.Cargos.Administrador):
						menu.Enabled = true;
						break;
					case nameof(CargosUsuario.Cargos.Analista):
						menu.Enabled = true;
						break;
					case nameof(CargosUsuario.Cargos.Usuario):
						menu.Enabled = true;
						break;
					default:
						MessageBox.Show("Cargo não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
				}

				// Usuario logado
				Program.isLogado = true;
				this.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show("Ocorreu um erro: " + e.Message);
			}

		}
		// Aqui estou salvando as credenciais do usuario
		private void SalvarCredenciais(string login)
		{
			Properties.Settings.Default.LoginSalvo = login;
			Properties.Settings.Default.SalvarCredenciais = true;
			Properties.Settings.Default.Save();
		}

		// Aqui estou recuperando as credenciais salvas do usuario
		private void RecuperarCredenciais()
		{
			if (Properties.Settings.Default.SalvarCredenciais)
			{
				txt_Login.Text = Properties.Settings.Default.LoginSalvo;
				chk_Lembrar_Login.Checked = true;
			}
		}
		private void form_login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
		private void form_login_Click(object sender, EventArgs e)
		{
			SeCheckedIsMarcado();
		}
		private void SeCheckedIsMarcado()
		{

			if (chk_Lembrar_Login.Checked)
			{
				// Se a caixa de seleção estiver marcada, salvar as credenciais
				SalvarCredenciais(txt_Login.Text);
			}
			else
			{
				// Se não estiver marcada, limpar as credenciais salvas
				Properties.Settings.Default.LoginSalvo = "";
				Properties.Settings.Default.SalvarCredenciais = false;
				Properties.Settings.Default.Save();
			}
		}
		private void form_login_Load(object sender, EventArgs e)
		{
			RecuperarCredenciais();
		}
		private void btn_Cadastrar_Usuario_Click(object sender, EventArgs e)
		{
			form_Cadastro_Usuario cadastro = new form_Cadastro_Usuario();
			cadastro.Show();
		}
		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
			this.Close();
		}

		private void chk_Lembrar_Login_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SalvarCredenciais = chk_Lembrar_Login.Checked;
		}
		private void form_Login_Shown(object sender, EventArgs e)
		{
			txt_Senha.Focus();
		}
	}
}
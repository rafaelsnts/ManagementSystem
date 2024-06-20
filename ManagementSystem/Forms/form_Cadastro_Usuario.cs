using ManagementSystem.Context;
using ManagementSystem.Models;
using System.IO;
using ManagementSystem.Enum;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Forms
{
	public partial class form_Cadastro_Usuario : DevExpress.XtraEditors.XtraForm
	{
		ManagementSystemContext context = new ManagementSystemContext();
		tb_usuario novoUsuario = new tb_usuario();
		public form_Cadastro_Usuario()
		{
			InitializeComponent();
			dte_Data_Criacao.DateTime = DateTime.Now;
			
			
		}

		private void btn_Voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void btn_Salvar_Click(object sender, EventArgs e)
		{
			await CadastrarUsuario();
		}

		private async Task CadastrarUsuario()
		{
			bool loginExiste = await context.tb_usuario.AnyAsync(x => x.usu_login == txt_Cadastro_Login.Text);

			if (txt_Cadastro_Login.Text == "" || txt_Cadastro_Senha.Text == "")
			{
				MessageBox.Show("Preencha todos os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Aqui eu converto a imagem em um array de bytes para salvar no banco de dados
			byte[] fotoByteArray;
			using (MemoryStream ms = new MemoryStream())
			{
				pic_Adicionar_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				fotoByteArray = ms.ToArray();
			}

			if (loginExiste)
			{
				MessageBox.Show("Login já existente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				novoUsuario.usu_login = txt_Cadastro_Login.Text;
				novoUsuario.usu_senha = txt_Cadastro_Senha.Text;
				novoUsuario.usu_data_criacao = dte_Data_Criacao.DateTime;
				novoUsuario.usu_cargo = cmb_Cadastro_Cargo.Text;
				novoUsuario.usu_imagem_perfil = fotoByteArray;
				novoUsuario.usu_status = Convert.ToBoolean(StatusUsuario.Status.Ativo); 
				novoUsuario.usu_bloqueado =Convert.ToBoolean(BloqueioUsuario.Bloqueio.Desbloqueado);
				novoUsuario.usu_ultimo_login = null;

				context.tb_usuario.Add(novoUsuario);
				await context.SaveChangesAsync();
				MessageBox.Show("Usuário cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}

		}
		private void btn_Carregar_Foto_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				pic_Adicionar_Foto.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void CarregarComboboxCargosUsuario()
		{
			cmb_Cadastro_Cargo.Properties.Items.Add(CargosUsuario.Cargos.Administrador.ToString());
			cmb_Cadastro_Cargo.Properties.Items.Add(CargosUsuario.Cargos.Analista.ToString());
			cmb_Cadastro_Cargo.Properties.Items.Add(CargosUsuario.Cargos.Usuario.ToString());
		}

		private void form_Cadastro_Usuario_Load(object sender, EventArgs e)
		{
			CarregarComboboxCargosUsuario();
		}
	}
}
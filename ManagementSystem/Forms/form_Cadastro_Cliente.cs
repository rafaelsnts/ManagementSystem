using ManagementSystem.Context;
using ManagementSystem.Models;
using System.IO;

namespace ManagementSystem.Forms
{
	public partial class form_Cadastro_Cliente : DevExpress.XtraEditors.XtraForm
	{
		ManagementSystemContext context = new ManagementSystemContext();
		tb_clientes novoCliente = new tb_clientes();
		public form_Cadastro_Cliente()
		{
			InitializeComponent();
		}

		private async void btn_Salvar_Click(object sender, EventArgs e)
		{
			await CadastrarCliente();
		}
		private async Task CadastrarCliente()
		{
			try
			{

				byte[] fotoByteArray;
				using (MemoryStream ms = new MemoryStream())
				{
					pic_Foto_Cliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					fotoByteArray = ms.ToArray();
				}

				if (txt_Nome_Cliente.Text == "" || txt_Cpf_Cliente.Text == "" || txt_Email_Cliente.Text == "")
				{
					MessageBox.Show("Preencha todos os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					novoCliente.cli_data_criacao = DateTime.Now;
					novoCliente.cli_nome = txt_Nome_Cliente.Text;
					novoCliente.cli_cpf = txt_Cpf_Cliente.Text;
					novoCliente.cli_email = txt_Email_Cliente.Text;
					novoCliente.cli_telefone = txt_Telefone_Cliente.Text;
					novoCliente.cli_cep = txt_Cep_Cliente.Text;
					novoCliente.cli_rua = txt_Rua_Cliente.Text;
					novoCliente.cli_cidade = txt_Cidade_Cliente.Text;
					novoCliente.cli_numero_casa = txt_Numero_Cliente.Text;
					novoCliente.cli_bairro = txt_Bairro_Cliente.Text;
					novoCliente.cli_estado = txt_Estado_Cliente.Text;
					novoCliente.cli_foto_cliente = fotoByteArray;

					context.tb_clientes.Add(novoCliente);
					await context.SaveChangesAsync();
					MessageBox.Show("Cliente cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Erro ao cadastrar cliente: " + e.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw;
			}
		}
		public async void LocalizarCEP()
		{
			var enderecoRetornado = await CepApi.Buscar(txt_Cep_Cliente.Text.Replace("-",""));

			txt_Rua_Cliente.Text = enderecoRetornado[0].Endereco;
			txt_Bairro_Cliente.Text = enderecoRetornado[0].Bairro;
			txt_Cidade_Cliente.Text = enderecoRetornado[0].Cidade;
			//txt.Text = enderecoRetornado[0].Complemento;
			txt_Estado_Cliente.Text = enderecoRetornado[0].UF;

		}

		private void txt_Cep_Cliente_Leave(object sender, EventArgs e)
		{
			if (txt_Cep_Cliente.Text == "")
			{
				MessageBox.Show("CEP inválido");
				return;
			}

			if (txt_Cep_Cliente.Text.Length == 9)
			{
				LocalizarCEP();
				return;
			}

			
		}
		private void btn_Carregar_Foto_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				pic_Foto_Cliente.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void btn_Voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Alterar_Click(object sender, EventArgs e)
		{
			AlterarCliente();
		}

		private void AlterarCliente()
		{
			try
			{
				byte[] fotoByteArray = null;
				if (pic_Foto_Cliente.Image != null)
				{

					using (MemoryStream ms = new MemoryStream())
					{
						pic_Foto_Cliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
						fotoByteArray = ms.ToArray();
					}
				}

				var idCliente = Convert.ToInt32(lbl_Id_Cliente.Text);
				var cliente = context.tb_clientes.FirstOrDefault(x => x.cli_id_cliente == idCliente);
				cliente.cli_data_criacao = dte_Data_Cadastro.DateTime;
				cliente.cli_nome = txt_Nome_Cliente.Text;
				cliente.cli_cpf = txt_Cpf_Cliente.Text;
				cliente.cli_email = txt_Email_Cliente.Text;
				cliente.cli_telefone = txt_Telefone_Cliente.Text;
				cliente.cli_cep = txt_Cep_Cliente.Text;
				cliente.cli_rua = txt_Rua_Cliente.Text;
				cliente.cli_cidade = txt_Cidade_Cliente.Text;
				cliente.cli_numero_casa = txt_Numero_Cliente.Text;
				cliente.cli_bairro = txt_Bairro_Cliente.Text;
				cliente.cli_estado = txt_Estado_Cliente.Text;
				cliente.cli_foto_cliente = fotoByteArray;

				context.tb_clientes.Update(cliente);
				context.SaveChanges();
				MessageBox.Show("Cliente alterado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception e)
			{
				MessageBox.Show("Erro ao alterar cliente: " + e.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

}

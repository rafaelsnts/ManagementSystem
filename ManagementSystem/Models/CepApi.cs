using Correios.NET;

namespace ManagementSystem.Models
{
	internal static class CepApi
	{
		public static async Task<List<CepModel>> Buscar(string _CEP)
		{
			List<CepModel> listEndereco = new List<CepModel>();
			try
			{
				var correiosApi = new CorreiosService();

				var enderecoResult = await correiosApi.GetAddressesAsync(_CEP);
				var endereco = enderecoResult.FirstOrDefault();

				listEndereco.Add(new CepModel()
				{
					Endereco = endereco.Street ?? "------",
					Bairro = endereco.District ?? "------",
					Cidade = endereco.City ?? "------",
				//	Complemento = "------",
					UF = endereco.State ?? "------"
				});

				return listEndereco;
			}
			catch (Exception)
			{
				return listEndereco;
			}
		}
	}
}

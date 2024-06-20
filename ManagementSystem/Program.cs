using DevExpress.Xpo.DB;
using ManagementSystem.Context;
using ManagementSystem.Forms;
using ManagementSystem.XPO.ManagementSystem;
using Microsoft.Extensions.Configuration;
using System.IO;
using DevExpress.XtraSplashScreen;

namespace ManagementSystem
{

	internal static class Program
	{
		public static bool isLogado = false;
		[STAThread]
		static void Main()
		{

			VerificacaoBanimentoUsuarios();
			ApplicationConfiguration.Initialize();

			//Inicializa o SplashScreen
			SplashScreenManager.ShowForm(typeof(SplashScreen1));


			//Envia um comando para o SplashScreen
			SplashScreenManager.Default.SendCommand(SplashScreen1.SplashScreenCommand.Info, "Carregando...");

			Thread.Sleep(2000);
			SplashScreenManager.CloseForm();

			//Validar login
			using (form_Login login = new form_Login())
			{
				login.ShowDialog();
			}

			if (isLogado == true)
			{
				// Cria uma instância de ConfigurationBuilder
				var builder = new ConfigurationBuilder()
					.SetBasePath(Directory.GetCurrentDirectory()) // Define o diretório base para o arquivo de configuração
					.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // Adiciona o arquivo appsettings.json

				// Constrói a configuração
				IConfiguration configuration = builder.Build();

				// Chama o método Connect
				ConnectionHelper.Connect(configuration, AutoCreateOption.None);

				Application.Run(new form_Menu());

			}
		}
		private static void VerificacaoBanimentoUsuarios()
		{
			ManagementSystemContext context = new ManagementSystemContext();
			var usuarios = context.tb_usuario.ToList();

			foreach (var usuario in usuarios)
			{
				if (usuario.usu_bloqueado == true)
				{
					if (usuario.usu_bloqueado_ate != null)
					{
						if (usuario.usu_bloqueado_ate < DateTime.Now)
						{
							usuario.usu_bloqueado = false;
							usuario.usu_bloqueado_ate = null;
							context.SaveChanges();
						}
					}
				}
			}
		}
	}
}
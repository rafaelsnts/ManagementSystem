using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using ManagementSystem.Context;
using ManagementSystem.Models;
using ManagementSystem.XPO.ManagementSystem;

namespace ManagementSystem.Forms
{
	public partial class form_Exibir_Usuarios : DevExpress.XtraEditors.XtraForm
	{
		private UnitOfWork uow = new UnitOfWork();
		private XPServerCollectionSource XPOSource;


		private int linhaSelecionada;
		ManagementSystemContext context = new ManagementSystemContext();
		public form_Exibir_Usuarios()
		{
			InitializeComponent();

			AtualizarGrid();
			btn_Excluir.ItemClick += Btn_Excluir_ItemClick;
		}

		private void AtualizarGrid()
		{
			//ManagementSystem.Context.ManagementSystemContext dbContext = new ManagementSystem.Context.ManagementSystemContext();
			//dbContext.tb_usuario.LoadAsync().ContinueWith(loadTask =>
			//{
			//	gridControl1.DataSource = dbContext.tb_usuario.Local.ToBindingList();
			//}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

			uow = new UnitOfWork(XpoDefault.DataLayer); //Mesma coisa do context do EF Core.
			var criteria = CriteriaOperator.FromLambda<tb_usuarioXPO>(x => x.usu_id_usuario > 0);
			XPClassInfo classInfo = uow.GetClassInfo(typeof(tb_usuarioXPO));

			XPOSource = new XPServerCollectionSource(uow, classInfo, criteria)
			{
				AllowEdit = true
			};

			//grid_Exibir_Usuarios.OptionsDetail.EnableMasterViewMode = false;
			gridControl1.DataSource = XPOSource;

		}
		private void Btn_Excluir_ItemClick(object sender, ItemClickEventArgs e)
		{
			DialogResult usuarioEscolha = XtraMessageBox.Show("Deseja realmente excluir este usuário?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (usuarioEscolha == DialogResult.Yes)
			{
				tb_usuario usuario = (tb_usuario)grid_Exibir_Usuarios.GetRow(linhaSelecionada);
				var deletarUsuario = context.tb_usuario.FirstOrDefault(x => x.usu_id_usuario == usuario.usu_id_usuario);
				context.tb_usuario.Remove(deletarUsuario);
				context.SaveChanges();
				AtualizarGrid();
			}

		}
		private void grid_Exibir_Usuarios_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
		{
			if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
			{
				e.Allow = false;
				popupMenu1.ShowPopup(gridControl1.PointToScreen(e.Point));
			}
		}

		private void grid_Exibir_Usuarios_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			linhaSelecionada = e.FocusedRowHandle;
		}

		private void grid_Exibir_Usuarios_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
		{
			var escolha = XtraMessageBox.Show("Deseja realmente editar este usuário?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (escolha == DialogResult.Yes)
			{
				e.Valid = true;
				var grid = (GridView)sender;

				BeginInvoke(new Action(() =>
				{
					grid.UpdateCurrentRow();
					grid.CloseEditor();
					uow.CommitChanges();
				}));
			}
		}
	}
}
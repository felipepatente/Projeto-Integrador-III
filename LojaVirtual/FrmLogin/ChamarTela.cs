using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class ChamarTela
    {

        public void CategoriaCrud()
        {
            FrmCategoriaCrud frmCategoriaCrud = new FrmCategoriaCrud();
            frmCategoriaCrud.MdiParent = MdiPrincipal.ActiveForm;
            frmCategoriaCrud.Show();
        }

        public void Inicial()
        {
            FrmInicial frmInicial = new FrmInicial();
            frmInicial.MdiParent = MdiPrincipal.ActiveForm;
            frmInicial.Show();
        }

        public void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            //frmLogin.MdiParent = MdiPrincipal.ActiveForm;
            frmLogin.ShowDialog();
            
        }
        
        public void ProdutoConsultarExcluir()
        {
            Produtos frmProdutoConsultarExcluir = new Produtos();
            frmProdutoConsultarExcluir.MdiParent = MdiPrincipal.ActiveForm;
            frmProdutoConsultarExcluir.Show();
        }
        
        public void UsuarioConsultarExcluir()
        {
            Usuarios frmUsuarioConsultarExcluir = new Usuarios();
            frmUsuarioConsultarExcluir.MdiParent = MdiPrincipal.ActiveForm;
            frmUsuarioConsultarExcluir.Show();
        }
    }
}

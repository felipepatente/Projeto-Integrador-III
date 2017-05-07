using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class ChamarTela
    {

        // chmando a tela Categoria
        public void CategoriaCrud()
        {
            FrmCategoriaCrud frmCategoriaCrud = new FrmCategoriaCrud();
            frmCategoriaCrud.MdiParent = MdiPrincipal.ActiveForm;
            frmCategoriaCrud.Show();
        }
        // fim da tela Categoria



        // chamando a tela iniciar
        public void Inicial()
        {
            FrmInicial frmInicial = new FrmInicial();
            frmInicial.MdiParent = MdiPrincipal.ActiveForm;
            frmInicial.Show();
        }
        //fim da iniciar


        // chamando a tela Login
        public void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            //frmLogin.MdiParent = MdiPrincipal.ActiveForm;
            frmLogin.ShowDialog();
            
        }
        //fim da Login



        // chamando as telas Produtos
        public void ProdutoAlterarCadastrar()
        {
            FrmProdutoAlterarCadastrar frmProdutoAlterarCadastrar = new FrmProdutoAlterarCadastrar();
            frmProdutoAlterarCadastrar.MdiParent = MdiPrincipal.ActiveForm;
            frmProdutoAlterarCadastrar.Show();
        }

        public void ProdutoConsultarExcluir()
        {
            FrmProdutoConsultarExcluir frmProdutoConsultarExcluir = new FrmProdutoConsultarExcluir();
            frmProdutoConsultarExcluir.MdiParent = MdiPrincipal.ActiveForm;
            frmProdutoConsultarExcluir.Show();
        }
        // fim das telas Produtos

        // chamando as telas Usuario
        public void UsuarioAlterarCadastrar()
        {
            FrmUsuarioAlterarCadastrar frmUsuarioAlterarCadastrar = new FrmUsuarioAlterarCadastrar();
            frmUsuarioAlterarCadastrar.MdiParent = MdiPrincipal.ActiveForm;
            frmUsuarioAlterarCadastrar.Show();
        }

        public void UsuarioConsultarExcluir()
        {
            FrmUsuarioConsultarExcluir frmUsuarioConsultarExcluir = new FrmUsuarioConsultarExcluir();
            frmUsuarioConsultarExcluir.MdiParent = MdiPrincipal.ActiveForm;
            frmUsuarioConsultarExcluir.Show();
        }
        // fim das telas Usuario
    }
}

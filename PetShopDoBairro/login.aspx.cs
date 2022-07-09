using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopDoBairro
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            BancoDeDadosPadraoDataContext contexto = new BancoDeDadosPadraoDataContext();
            var usuario = (from u in contexto.USUARIOs
                           where u.EMAIL == txtEmail.Text && u.SENHA == txtSenha.Text
                           && u.ATIVO
                           select u).FirstOrDefault();
            if (usuario != null)
            {
                //autenticado com sucesso
                string usuarioEmail = txtEmail.Text;
                Session["email"] = txtEmail.Text;
                //FormsAuthentication.RedirectFromLoginPage(usuarioEmail, true);
                Response.Redirect("adm/BemVindo.aspx");
            }
            else
            {
                //erro ao autenticar
                Response.Write("Login falhou");
            }

        }
    }
}
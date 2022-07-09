using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShopDoBairro.adm
{
    public partial class usuarioForm : System.Web.UI.Page
    {
        private int _idUsuario = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                int.TryParse(Request["id"].ToString(), out _idUsuario);

                if (!Page.IsPostBack)
                {

                    BancoDeDadosPadraoDataContext contexto = new BancoDeDadosPadraoDataContext();
                    var usuario = (from u in contexto.USUARIOs
                                   where u.ID == _idUsuario
                                   select u).FirstOrDefault();
                    if (usuario !=null)
                    {
                        txtNome.Text = usuario.NOME;
                        txtCPFCNPJ.Text = usuario.CPFCNPJ;
                        txtEmail.Text = usuario.EMAIL;
                        txtSenha.Text = usuario.SENHA;
                        txtTipoPessoa.Text = usuario.TIPOPESSOA;
                        ckbAtivo.Checked = usuario.ATIVO;
                    }
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            BancoDeDadosPadraoDataContext contexto = new BancoDeDadosPadraoDataContext();
            USUARIO usuario = null;
            if (_idUsuario == -1)
            {
                usuario = new USUARIO();
                contexto.USUARIOs.InsertOnSubmit(usuario);
            }
            else
            {
                usuario = (from u in contexto.USUARIOs
                           where u.ID == _idUsuario
                           select u).FirstOrDefault();
            }

            usuario.NOME = txtNome.Text;
            usuario.CPFCNPJ = txtCPFCNPJ.Text;
            usuario.EMAIL = txtEmail.Text;
            usuario.SENHA = txtSenha.Text;
            usuario.TIPOPESSOA = txtTipoPessoa.Text;
            usuario.ATIVO = ckbAtivo.Checked;

            contexto.SubmitChanges();
        }
    }
}
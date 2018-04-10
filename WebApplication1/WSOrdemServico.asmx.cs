using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WSOrdemServico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSOrdemServico : System.Web.Services.WebService
    {
    
        Classes_Ordem_Servico.Ordem ordem = new Classes_Ordem_Servico.Ordem();
        Classes_Ordem_Servico.Marca marca = new Classes_Ordem_Servico.Marca();
        Classes_Ordem_Servico.Status status = new Classes_Ordem_Servico.Status();

        // Método Buscar
        [WebMethod]
        public DataTable BuscarOrdem()
        {
            return ordem.Buscar();
        }

        // Método Salvar
        [WebMethod]
        public void Salvar(Classes_Ordem_Servico.Ordem ordem)
        {
            ordem.Salvar(ordem);
        }

        // Método Alterar
        [WebMethod]
        public void Alterar(Classes_Ordem_Servico.Ordem ordem)
        {
            ordem.Alterar(ordem);
        }

        // Método Deletar
        [WebMethod]
        public void Deletar(int id)
        {
            ordem.Deletar(id);
        }

        // Método Buscar Marca
        [WebMethod]
        public DataTable BuscarMarca()
        {
            return marca.Buscar();
        }

        // Método Buscar Status
        [WebMethod]
        public DataTable BuscarStatus()
        {
            return status.Buscar();
        }
    }
}
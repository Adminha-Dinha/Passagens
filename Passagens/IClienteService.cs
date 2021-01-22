using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract]
   public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "searchClientes/{nome}")]
        Cliente Buscar(string nome);
        //[WebInvoke(Method = "GET", ResponseFormat =WebMessageFormat.Xml,UriTemplate ="addCliente/{nome};{cpf}")]  //para ue o serviço possa ser acessado pelo browser
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addCliente/{nome};{cpf}")]  //para ue o serviço possa ser acessado pelo browser
        [OperationContract]
        bool Add(string nome, string cpf);
        // void Add(String nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        List<Cliente> getCliente();


    }
}

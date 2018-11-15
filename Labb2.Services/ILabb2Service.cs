using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Labb2.Services
{
    [ServiceContract]
    public interface ILabb2Service
    {
        [OperationContract]
        List<Book> GetBooks();
        [OperationContract]
        List<Client> GetClients();
        [OperationContract]
        void SubmitOrder(Order order);
    }
}

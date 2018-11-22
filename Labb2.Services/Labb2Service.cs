using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Labb2.Data;
using Labb2.Entities;

namespace Labb2.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Labb2Service : ILabb2Service, IDisposable
    {
        readonly Labb2DbContext _context = new Labb2DbContext();

        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _context.Orders.Add(order);
            order.BookItems.ForEach(i => _context.BookItems.Add(i));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

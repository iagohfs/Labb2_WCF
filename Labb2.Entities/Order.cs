using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Labb2.Entities
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public Guid ClientId { get; set; }
        [DataMember]
        public int OrderStatusId { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public decimal ItemsTotal { get; set; }
        [DataMember]
        public List<BookItem> BookItems { get; set; }
    }
}

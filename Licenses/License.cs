using System;
using System.ComponentModel.DataAnnotations;

namespace Licenses
{
    public class License
    {        
        public Guid Id { get; internal set; }

        [StringLength (50, ErrorMessage = "Customer name not more 50 characters ")]
        [DataType (DataType.Text)]
        public string CustomerName { get; set; }

        public DateTime CreationDate { get; internal set; }

        public DateTime ExpirationDate { get; set; }

        public License(Guid id, string customerName, DateTime creationDate, DateTime expirationDate)
        {
            Id = id;
            CustomerName = customerName;
            CreationDate = creationDate;
            ExpirationDate = expirationDate;
        }
    }
}

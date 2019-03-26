using System;
using System.Collections.Generic;
using System.Text;

namespace LicensesDAL_EF.Entities
{
    public class License
    {
        public Guid Id { get; internal set; }

        /*[DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Customer name not more 50 characters ")]*/
        public string CustomerName { get; set; }

        public DateTime CreationDate { get; internal set; }


       /* [DataType(DataType.DateTime)]
        [DateNotExpiredValidation]*/
        public DateTime ExpirationDate { get; set; }
    }
}

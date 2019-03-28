using System;
using System.ComponentModel.DataAnnotations;
using Licenses.ValidationAttributes;

namespace Licenses
{
    [Serializable]
    public class License
    {        
        public Guid Id { get; internal set; }

        [Required]
        [DataType (DataType.Text)]
        [StringLength (50, ErrorMessage = "Customer name not more 50 characters ")]
        public string CustomerName { get; set; }

        [Required]
        public DateTime CreationDate { get; internal set; }


        [Required]
        [DataType (DataType.DateTime)]
        [DateNotExpiredValidation]
        public DateTime ExpirationDate { get; set; }

        public License(Guid id, string customerName, DateTime creationDate, DateTime expirationDate)
        {
            Id = id;
            CustomerName = customerName;
            CreationDate = creationDate;
            ExpirationDate = expirationDate;
        }

        public string LicenceKey
        {
            get
            {
                return this.ToString();
            }
        }


        public void Validate()
        {
            Validator.ValidateObject(this, new ValidationContext(this), true);
        }
    }
}

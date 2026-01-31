using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    [Serializable]
    public class CurrencyDomainModel: Currency
    {
        [DisplayName("Currency Code")]                            // Mã tiền tệ
        [Required(ErrorMessage = "*")]
        [StringLength(3, ErrorMessage = "* <= 3 ký tự.")]
        public virtual new string CurrencyCode { get; set; }

        [DisplayName("Currency Name")]                               // Tiền tệ
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public virtual new string CurrencyName { get; set; }

        [DisplayName("Currency Name")]                           // Tiền tệ
        public virtual string CurrencyCodeName { get { return CurrencyCode + " -- " + CurrencyName; } }

        [DisplayName("Active")]                                   // Kích hoạt
        public virtual new bool Active { get; set; }
        [DisplayName("Modified User")]                                  // Người thay đổi
        public virtual new string ModifiedUser { get; set; }
        [DisplayName("Modified Date")]                              // Ngày thay đổi
        public virtual new DateTime? ModifiedDate { get; set; }   
    }
}

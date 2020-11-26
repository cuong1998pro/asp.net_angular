using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Models.Abstract
{
    public interface IAuditable
    {
        
        DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        string UpdatedBy { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
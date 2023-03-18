using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace BTLON.Prototype_Forms.ChildForms.Theo_doi.Models
{
    public class CtyModel
    {
        private int CompanyID;
        private string CompanyName;
        private string CompanyAddress;
        private string CompanyCurrentStockPrice;
        private string CompanyFirstStockPrice;
        private string CompanyMaxStockPrice;
        private string CompanyMinStockPrice;
        
        
        //properties - validations
        [DisplayName("Company ID")]
        [Required(ErrorMessage = "Company ID is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Company ID must be between 3 and 50 characters")]
        public int Id { get => CompanyID; set => CompanyID = value; }
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company Name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Company Name must be between 3 and 50 characters")]
        public string Name { get => CompanyName; set => CompanyName = value; }
        [DisplayName("Company Address")]
        [Required(ErrorMessage = "Company Address is required")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "Company Address must be between 3 and 50 characters")]
        public string Adddress { get => CompanyAddress; set => CompanyAddress = value; }
        [DisplayName("PublicCompanyCurrentStockPrice")]
        [Required(ErrorMessage = "PublicCompanyCurrentStockPrice is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "PublicCompanyCurrentStockPrice must be between 3 and 50 characters")]
        public string PublicCompanyCurrentStockPrice { get => CompanyCurrentStockPrice; set => CompanyCurrentStockPrice = value; }
        public string PublicCompanyFirstStockPrice { get => CompanyFirstStockPrice; set => CompanyFirstStockPrice = value; }
        public string PublicCompanyMaxStockPrice { get => CompanyMaxStockPrice; set => CompanyMaxStockPrice = value; }
        public string PublicCompanyMinStockPrice { get => CompanyMinStockPrice; set => CompanyMinStockPrice = value; }
    }
}

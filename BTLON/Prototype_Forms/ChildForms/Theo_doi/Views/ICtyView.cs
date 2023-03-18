using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Prototype_Forms.ChildForms.Theo_doi.Views
{
    public interface ICtyView
    {
        //Properties - Fields
        string CompanyId        {            get;set;        }
        string CompanyName        {      get; set;        }
        string CompanyAddress        {            get;set;        }
        string CompanyCurrentStockPrice        {            get;set;        }
        string SearchValue        {            get;set;        }
        bool isEdit        {            get;set;        }
        bool isSuccessful        {            get;set;        }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler DeleteEvent;

        void SetPetListBindingSource(BindingSource petlist);
        void Show();//Optional
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLON.Prototype_Forms.ChildForms.Theo_doi.Models
{
    public interface ICtyRepositary
    {
        void Add(CtyModel CtyModel);
        void Edit(CtyModel CtyModel);
        void Delete(int id);
        IEnumerable<CtyModel> GetAll();
        IEnumerable<CtyModel> GetByValue();

    }
}

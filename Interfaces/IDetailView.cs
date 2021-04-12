using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IDetailView
    {
        void ShowModal();
        BindingSource BindingSource { get; set; }
    }
}

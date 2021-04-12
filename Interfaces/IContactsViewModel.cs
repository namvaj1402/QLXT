using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Interfaces
{
    public interface IContactsViewModel
    {
        BindingSource PhongBindingSource { get; set; }
        BindingSource NguoiBindingSource { get; set; }
        BindingSource TienBindingSource { get; set; }


        void New();
        void Delete();
        void Save();
        void Load();
        void themNguoi();
        void xoaNguoi();
        void themTien();
        void xoaTien();
        void First();
        void Last();
        void Previous();
        void Next();
        //void ShowDetail(IDetailView detail);
    }
}

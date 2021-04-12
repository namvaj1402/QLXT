using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace App
{
    using Interfaces;
    using Unity;
    public partial class DxContacts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        private IContactsViewModel vw = Config.Container.Resolve<IContactsViewModel>();
        public DxContacts()
        {
            InitializeComponent();
            vw.PhongBindingSource = phongBindingSource;
            vw.NguoiBindingSource = nguoiBindingSource;
            vw.TienBindingSource = tienBindingSource;
            Load += delegate { vw.Load(); };

            //thêm xoá phòng
            dxload.ItemClick += delegate { vw.Load(); };
            dxsave.ItemClick += delegate { vw.Save(); };
            dxnew.ItemClick += delegate { vw.New(); };
            dxdelete.ItemClick += delegate { vw.Delete(); };
            //thêm xoá người
            dxthemn.ItemClick += delegate { vw.themNguoi(); };
            dxxoan.ItemClick += delegate { vw.xoaNguoi(); };
            //thêm xoá tiền
            dxthemt.ItemClick += delegate { vw.themTien(); };
            dxxoat.ItemClick += delegate { vw.xoaTien(); };
            //trước sau đầu cuối
            dxfirst.ItemClick += delegate { vw.First(); };
            dxprev.ItemClick += delegate { vw.Previous(); };
            dxnext.ItemClick += delegate { vw.Next(); };
            dxlast.ItemClick += delegate { vw.Last(); };
        }
    }
}
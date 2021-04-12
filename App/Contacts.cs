using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Unity;

namespace App
{
    public partial class Contacts : Form
    {
        private IContactsViewModel vw = Config.Container.Resolve<IContactsViewModel>();

        public Contacts()
        {
            InitializeComponent();

            vw.PhongBindingSource = phongBindingSource;
            vw.NguoiBindingSource = nguoiBindingSource;
            vw.TienBindingSource = tienBindingSource;
            //phongBindingNavigatorSaveItem.Click += delegate { vw.Save(); };
            Load += delegate { vw.Load(); };

            //Phòng
            btthemP.Click += delegate { vw.New(); };
            btxoaP.Click += delegate { vw.Delete(); };
            btluu.Click += delegate { vw.Save(); };
            btfirst.Click += delegate { vw.First(); };
            btlast.Click += delegate { vw.Last(); };
            btprev.Click += delegate { vw.Previous(); };
            btnext.Click += delegate { vw.Next(); };
            //Người
            btthemN.Click += delegate { vw.themNguoi(); };
            btxoaN.Click += delegate { vw.xoaNguoi(); };
            //Tiền
            btthemT.Click += delegate { vw.themTien(); };
            btxoaT.Click += delegate { vw.xoaTien(); };

            //phongDataGridView.MouseDoubleClick += delegate { vw.ShowDetail(Config.Container.Resolve<IDetailView>()); };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Interfaces;
using System.Data.Entity;


namespace ViewModels
{
    public class ContactsViewModel : IContactsViewModel
    {
        public BindingSource PhongBindingSource { get; set; }

        private readonly Context _context = new Context();
        public void Load()
        {
            /*List<Phong> Phong;
            var formatter = new BinaryFormatter();

            if (!File.Exists("data.dat"))
            {
                Phong = new List<Phong>();
                var stream = File.Create("data.dat");
                formatter.Serialize(stream, Phong);
                stream.Close();
            }
            else
            {
                using (var stream = File.OpenRead("data.dat"))
                {
                    Phong = formatter.Deserialize(stream) as List<Phong>;
                }
            }

            PhongBindingSource.ResetBindings(false);
            PhongBindingSource.DataSource = Phong;*/
            _context.Phong.Load();
            _context.Nguoi.Load();
            _context.Tien.Load();
            PhongBindingSource.ResetBindings(false);
            PhongBindingSource.DataSource = _context.Phong.Local;
        }

        /*public void ShowDetail(IDetailView detail)
        {
            detail.BindingSource.DataSource = PhongBindingSource.Current;
            detail.ShowModal();
        } */

        public void Save()
        {
            _context.SaveChanges();
            /*using (var stream = File.OpenWrite("data.dat"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, PhongBindingSource.DataSource);
            }*/
        }
                //Thêm phòng
        public void New()
        {
            var phong = PhongBindingSource.AddNew() as Phong;
            phong.status = "< Trống >";

        }
        public void Delete() => PhongBindingSource.RemoveCurrent();
        public void First() => PhongBindingSource.MoveFirst();
        public void Last() => PhongBindingSource.MoveLast();
        public void Previous() => PhongBindingSource.MovePrevious();
        public void Next() => PhongBindingSource.MoveNext();

        public BindingSource NguoiBindingSource { get; set; }
        public BindingSource TienBindingSource { get; set; }

        /// <summary>
        /// ///Thêm người và tiền
        /// </summary>
        public void themNguoi()
        {
            var nguoi = NguoiBindingSource.AddNew() as Nguoi;
            nguoi.ngaysinh = DateTime.Now;
        }
        public void xoaNguoi() => NguoiBindingSource.RemoveCurrent();
        public void themTien()
        {
            var tien = TienBindingSource.AddNew() as Tien;
            tien.tienphong = 0;
            tien.tiendien = 0;
            tien.tiennuoc = 0;
        }
        public void xoaTien() => TienBindingSource.RemoveCurrent();


    }
}

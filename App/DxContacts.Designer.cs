namespace App
{
    partial class DxContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DxContacts));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dxload = new DevExpress.XtraBars.BarButtonItem();
            this.dxsave = new DevExpress.XtraBars.BarButtonItem();
            this.dxnew = new DevExpress.XtraBars.BarButtonItem();
            this.dxdelete = new DevExpress.XtraBars.BarButtonItem();
            this.dxthemn = new DevExpress.XtraBars.BarButtonItem();
            this.dxxoan = new DevExpress.XtraBars.BarButtonItem();
            this.dxthemt = new DevExpress.XtraBars.BarButtonItem();
            this.dxxoat = new DevExpress.XtraBars.BarButtonItem();
            this.dxfirst = new DevExpress.XtraBars.BarButtonItem();
            this.dxprev = new DevExpress.XtraBars.BarButtonItem();
            this.dxnext = new DevExpress.XtraBars.BarButtonItem();
            this.dxlast = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsophong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltiendien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltiennuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltienphong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.dxload,
            this.dxsave,
            this.dxnew,
            this.dxdelete,
            this.dxthemn,
            this.dxxoan,
            this.dxthemt,
            this.dxxoat,
            this.dxfirst,
            this.dxprev,
            this.dxnext,
            this.dxlast});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1135, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;

            // 
            // dxload
            // 
            this.dxload.Caption = "Load";
            this.dxload.Id = 3;
            this.dxload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxload.ImageOptions.Image")));
            this.dxload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxload.ImageOptions.LargeImage")));
            this.dxload.Name = "dxload";
            // 
            // dxsave
            // 
            this.dxsave.Caption = "Lưu";
            this.dxsave.Id = 4;
            this.dxsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxsave.ImageOptions.Image")));
            this.dxsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxsave.ImageOptions.LargeImage")));
            this.dxsave.Name = "dxsave";
            // 
            // dxnew
            // 
            this.dxnew.Caption = "Mới";
            this.dxnew.Id = 5;
            this.dxnew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxnew.ImageOptions.Image")));
            this.dxnew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxnew.ImageOptions.LargeImage")));
            this.dxnew.Name = "dxnew";
            // 
            // dxdelete
            // 
            this.dxdelete.Caption = "Xoá";
            this.dxdelete.Id = 7;
            this.dxdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxdelete.ImageOptions.Image")));
            this.dxdelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxdelete.ImageOptions.LargeImage")));
            this.dxdelete.Name = "dxdelete";
            // 
            // dxthemn
            // 
            this.dxthemn.Caption = "Thêm";
            this.dxthemn.Id = 8;
            this.dxthemn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxthemn.ImageOptions.Image")));
            this.dxthemn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxthemn.ImageOptions.LargeImage")));
            this.dxthemn.Name = "dxthemn";
            // 
            // dxxoan
            // 
            this.dxxoan.Caption = "Xoá";
            this.dxxoan.Id = 9;
            this.dxxoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxxoan.ImageOptions.Image")));
            this.dxxoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxxoan.ImageOptions.LargeImage")));
            this.dxxoan.Name = "dxxoan";
            // 
            // dxthemt
            // 
            this.dxthemt.Caption = "Thêm";
            this.dxthemt.Id = 10;
            this.dxthemt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxthemt.ImageOptions.Image")));
            this.dxthemt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxthemt.ImageOptions.LargeImage")));
            this.dxthemt.Name = "dxthemt";
            // 
            // dxxoat
            // 
            this.dxxoat.Caption = "Xoá";
            this.dxxoat.Id = 11;
            this.dxxoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxxoat.ImageOptions.Image")));
            this.dxxoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxxoat.ImageOptions.LargeImage")));
            this.dxxoat.Name = "dxxoat";
            // 
            // dxfirst
            // 
            this.dxfirst.Caption = "Đầu";
            this.dxfirst.Id = 12;
            this.dxfirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxfirst.ImageOptions.Image")));
            this.dxfirst.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxfirst.ImageOptions.LargeImage")));
            this.dxfirst.Name = "dxfirst";
            // 
            // dxprev
            // 
            this.dxprev.Caption = "Trước";
            this.dxprev.Id = 13;
            this.dxprev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxprev.ImageOptions.Image")));
            this.dxprev.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxprev.ImageOptions.LargeImage")));
            this.dxprev.Name = "dxprev";
            // 
            // dxnext
            // 
            this.dxnext.Caption = "Sau";
            this.dxnext.Id = 14;
            this.dxnext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxnext.ImageOptions.Image")));
            this.dxnext.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxnext.ImageOptions.LargeImage")));
            this.dxnext.Name = "dxnext";
            // 
            // dxlast
            // 
            this.dxlast.Caption = "Cuối";
            this.dxlast.Id = 15;
            this.dxlast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dxlast.ImageOptions.Image")));
            this.dxlast.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dxlast.ImageOptions.LargeImage")));
            this.dxlast.Name = "dxlast";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.dxsave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Data";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.dxnew);
            this.ribbonPageGroup2.ItemLinks.Add(this.dxdelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Phòng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.dxthemn);
            this.ribbonPageGroup3.ItemLinks.Add(this.dxxoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Người thuê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.dxthemt);
            this.ribbonPageGroup4.ItemLinks.Add(this.dxxoat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tiền điện";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.dxfirst);
            this.ribbonPageGroup5.ItemLinks.Add(this.dxprev);
            this.ribbonPageGroup5.ItemLinks.Add(this.dxnext);
            this.ribbonPageGroup5.ItemLinks.Add(this.dxlast);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 652);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1135, 24);
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(Models.Phong);
            // 
            // phongGridControl
            // 
            this.phongGridControl.DataSource = this.phongBindingSource;
            this.phongGridControl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Nguoi";
            gridLevelNode2.RelationName = "Tien";
            this.phongGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.phongGridControl.Location = new System.Drawing.Point(0, 186);
            this.phongGridControl.MainView = this.gridView1;
            this.phongGridControl.MenuManager = this.ribbon;
            this.phongGridControl.Name = "phongGridControl";
            this.phongGridControl.Size = new System.Drawing.Size(438, 461);
            this.phongGridControl.TabIndex = 3;
            this.phongGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsophong,
            this.colstatus});
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.phongGridControl;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // colsophong
            // 
            this.colsophong.AppearanceCell.Options.UseTextOptions = true;
            this.colsophong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsophong.AppearanceHeader.Options.UseTextOptions = true;
            this.colsophong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsophong.Caption = "Số phòng";
            this.colsophong.FieldName = "sophong";
            this.colsophong.Name = "colsophong";
            this.colsophong.Visible = true;
            this.colsophong.VisibleIndex = 0;
            this.colsophong.Width = 157;
            // 
            // colstatus
            // 
            this.colstatus.AppearanceCell.Options.UseTextOptions = true;
            this.colstatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colstatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colstatus.Caption = "Trạng thái";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 1;
            this.colstatus.Width = 162;
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataMember = "Nguoi";
            this.nguoiBindingSource.DataSource = this.phongBindingSource;
            // 
            // nguoiGridControl
            // 
            this.nguoiGridControl.DataSource = this.nguoiBindingSource;
            this.nguoiGridControl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoiGridControl.Location = new System.Drawing.Point(444, 186);
            this.nguoiGridControl.MainView = this.gridView2;
            this.nguoiGridControl.MenuManager = this.ribbon;
            this.nguoiGridControl.Name = "nguoiGridControl";
            this.nguoiGridControl.Size = new System.Drawing.Size(686, 235);
            this.nguoiGridControl.TabIndex = 5;
            this.nguoiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.ColumnPanelRowHeight = 0;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcmnd,
            this.coldiachi,
            this.colngaysinh,
            this.colsdt,
            this.colten});
            this.gridView2.FooterPanelHeight = 0;
            this.gridView2.GridControl = this.nguoiGridControl;
            this.gridView2.GroupRowHeight = 0;
            this.gridView2.LevelIndent = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PreviewIndent = 0;
            this.gridView2.RowHeight = 0;
            this.gridView2.ViewCaptionHeight = 0;
            // 
            // colcmnd
            // 
            this.colcmnd.AppearanceCell.Options.UseTextOptions = true;
            this.colcmnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.AppearanceHeader.Options.UseTextOptions = true;
            this.colcmnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.Caption = "Số CMT";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 1;
            this.colcmnd.Width = 117;
            // 
            // coldiachi
            // 
            this.coldiachi.AppearanceCell.Options.UseTextOptions = true;
            this.coldiachi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiachi.AppearanceHeader.Options.UseTextOptions = true;
            this.coldiachi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 4;
            this.coldiachi.Width = 126;
            // 
            // colngaysinh
            // 
            this.colngaysinh.AppearanceCell.Options.UseTextOptions = true;
            this.colngaysinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaysinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaysinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaysinh.Caption = "Ngày sinh";
            this.colngaysinh.FieldName = "ngaysinh";
            this.colngaysinh.Name = "colngaysinh";
            this.colngaysinh.Visible = true;
            this.colngaysinh.VisibleIndex = 3;
            this.colngaysinh.Width = 117;
            // 
            // colsdt
            // 
            this.colsdt.AppearanceCell.Options.UseTextOptions = true;
            this.colsdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.AppearanceHeader.Options.UseTextOptions = true;
            this.colsdt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.Caption = "SĐT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 2;
            this.colsdt.Width = 117;
            // 
            // colten
            // 
            this.colten.AppearanceCell.Options.UseTextOptions = true;
            this.colten.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colten.AppearanceHeader.Options.UseTextOptions = true;
            this.colten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colten.Caption = "Họ tên";
            this.colten.FieldName = "ten";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 0;
            this.colten.Width = 117;
            // 
            // tienBindingSource
            // 
            this.tienBindingSource.DataMember = "Tien";
            this.tienBindingSource.DataSource = this.phongBindingSource;
            // 
            // tienGridControl
            // 
            this.tienGridControl.DataSource = this.tienBindingSource;
            this.tienGridControl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienGridControl.Location = new System.Drawing.Point(444, 427);
            this.tienGridControl.MainView = this.gridView3;
            this.tienGridControl.MenuManager = this.ribbon;
            this.tienGridControl.Name = "tienGridControl";
            this.tienGridControl.Size = new System.Drawing.Size(686, 220);
            this.tienGridControl.TabIndex = 5;
            this.tienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.ColumnPanelRowHeight = 0;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltiendien,
            this.coltiennuoc,
            this.coltienphong});
            this.gridView3.FooterPanelHeight = 0;
            this.gridView3.GridControl = this.tienGridControl;
            this.gridView3.GroupRowHeight = 0;
            this.gridView3.LevelIndent = 0;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.PreviewIndent = 0;
            this.gridView3.RowHeight = 0;
            this.gridView3.ViewCaptionHeight = 0;
            // 
            // coltiendien
            // 
            this.coltiendien.AppearanceCell.Options.UseTextOptions = true;
            this.coltiendien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltiendien.AppearanceHeader.Options.UseTextOptions = true;
            this.coltiendien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltiendien.Caption = "Tiền điện";
            this.coltiendien.FieldName = "tiendien";
            this.coltiendien.Name = "coltiendien";
            this.coltiendien.Visible = true;
            this.coltiendien.VisibleIndex = 0;
            this.coltiendien.Width = 196;
            // 
            // coltiennuoc
            // 
            this.coltiennuoc.AppearanceCell.Options.UseTextOptions = true;
            this.coltiennuoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltiennuoc.AppearanceHeader.Options.UseTextOptions = true;
            this.coltiennuoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltiennuoc.Caption = "Tiền nước";
            this.coltiennuoc.FieldName = "tiennuoc";
            this.coltiennuoc.Name = "coltiennuoc";
            this.coltiennuoc.Visible = true;
            this.coltiennuoc.VisibleIndex = 1;
            this.coltiennuoc.Width = 196;
            // 
            // coltienphong
            // 
            this.coltienphong.AppearanceCell.Options.UseTextOptions = true;
            this.coltienphong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltienphong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltienphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltienphong.Caption = "Tiền phòng";
            this.coltienphong.FieldName = "tienphong";
            this.coltienphong.Name = "coltienphong";
            this.coltienphong.Visible = true;
            this.coltienphong.VisibleIndex = 2;
            this.coltienphong.Width = 200;
            // 
            // DxContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 676);
            this.Controls.Add(this.tienGridControl);
            this.Controls.Add(this.nguoiGridControl);
            this.Controls.Add(this.phongGridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DxContacts";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý xóm trọ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem dxload;
        private DevExpress.XtraBars.BarButtonItem dxsave;
        private DevExpress.XtraBars.BarButtonItem dxnew;
        private DevExpress.XtraBars.BarButtonItem dxdelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private DevExpress.XtraGrid.GridControl phongGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsophong;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private DevExpress.XtraGrid.GridControl nguoiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private System.Windows.Forms.BindingSource tienBindingSource;
        private DevExpress.XtraGrid.GridControl tienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn coltiendien;
        private DevExpress.XtraGrid.Columns.GridColumn coltiennuoc;
        private DevExpress.XtraGrid.Columns.GridColumn coltienphong;
        private DevExpress.XtraBars.BarButtonItem dxthemn;
        private DevExpress.XtraBars.BarButtonItem dxxoan;
        private DevExpress.XtraBars.BarButtonItem dxthemt;
        private DevExpress.XtraBars.BarButtonItem dxxoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem dxfirst;
        private DevExpress.XtraBars.BarButtonItem dxprev;
        private DevExpress.XtraBars.BarButtonItem dxnext;
        private DevExpress.XtraBars.BarButtonItem dxlast;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}
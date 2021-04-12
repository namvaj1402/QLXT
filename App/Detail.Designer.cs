namespace App
{
    partial class Detail
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label sophongLabel;
            System.Windows.Forms.Label statusLabel;
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.sophongTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            sophongLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(Models.Phong);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(589, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(646, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // sophongLabel
            // 
            sophongLabel.AutoSize = true;
            sophongLabel.Location = new System.Drawing.Point(589, 90);
            sophongLabel.Name = "sophongLabel";
            sophongLabel.Size = new System.Drawing.Size(51, 13);
            sophongLabel.TabIndex = 3;
            sophongLabel.Text = "sophong:";
            // 
            // sophongTextBox
            // 
            this.sophongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "sophong", true));
            this.sophongTextBox.Location = new System.Drawing.Point(646, 87);
            this.sophongTextBox.Name = "sophongTextBox";
            this.sophongTextBox.Size = new System.Drawing.Size(100, 20);
            this.sophongTextBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(589, 116);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(646, 113);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 6;
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataMember = "Nguoi";
            this.nguoiBindingSource.DataSource = this.phongBindingSource;
            // 
            // nguoiDataGridView
            // 
            this.nguoiDataGridView.AutoGenerateColumns = false;
            this.nguoiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nguoiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.nguoiDataGridView.DataSource = this.nguoiBindingSource;
            this.nguoiDataGridView.Location = new System.Drawing.Point(12, 230);
            this.nguoiDataGridView.Name = "nguoiDataGridView";
            this.nguoiDataGridView.Size = new System.Drawing.Size(642, 220);
            this.nguoiDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "ten";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sdt";
            this.dataGridViewTextBoxColumn3.HeaderText = "sdt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cmnd";
            this.dataGridViewTextBoxColumn4.HeaderText = "cmnd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ngaysinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "ngaysinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn6.HeaderText = "diachi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tienBindingSource
            // 
            this.tienBindingSource.DataMember = "Tien";
            this.tienBindingSource.DataSource = this.phongBindingSource;
            // 
            // tienDataGridView
            // 
            this.tienDataGridView.AutoGenerateColumns = false;
            this.tienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tienDataGridView.DataSource = this.tienBindingSource;
            this.tienDataGridView.Location = new System.Drawing.Point(102, 21);
            this.tienDataGridView.Name = "tienDataGridView";
            this.tienDataGridView.Size = new System.Drawing.Size(444, 189);
            this.tienDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tienphong";
            this.dataGridViewTextBoxColumn8.HeaderText = "tienphong";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tiendien";
            this.dataGridViewTextBoxColumn9.HeaderText = "tiendien";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tiennuoc";
            this.dataGridViewTextBoxColumn10.HeaderText = "tiennuoc";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.tienDataGridView);
            this.Controls.Add(this.nguoiDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(sophongLabel);
            this.Controls.Add(this.sophongTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Name = "Detail";
            this.Text = "Detail";
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox sophongTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private System.Windows.Forms.DataGridView nguoiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tienBindingSource;
        private System.Windows.Forms.DataGridView tienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
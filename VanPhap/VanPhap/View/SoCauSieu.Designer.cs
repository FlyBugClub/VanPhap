namespace VanPhap.View
{
    partial class SoCauSieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoCauSieu));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("hello");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("vccc");
            this.lbl_List = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_List = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.rdbtn_coso = new System.Windows.Forms.RadioButton();
            this.rdbtn_chua = new System.Windows.Forms.RadioButton();
            this.lbl_PhieuDiemThongTin = new System.Windows.Forms.Label();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.txt_idchubai = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_LuuTru = new System.Windows.Forms.Label();
            this.txt_nguyenquan = new System.Windows.Forms.TextBox();
            this.rbm_Woman = new System.Windows.Forms.RadioButton();
            this.rbm_Man = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.pnl_List.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_List
            // 
            this.lbl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(25, 434);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(471, 38);
            this.lbl_List.TabIndex = 40;
            this.lbl_List.Text = "Danh sách người nhận cầu siêu";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "Pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon.png");
            this.imageList1.Images.SetKeyName(5, "guide_icon.png");
            this.imageList1.Images.SetKeyName(6, "print_48_icon.png");
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "find_icon.png");
            this.icon.Images.SetKeyName(1, "find_icon1.png");
            this.icon.Images.SetKeyName(2, "computer_icon.png");
            this.icon.Images.SetKeyName(3, "add-icon.png");
            this.icon.Images.SetKeyName(4, "delete-icon.png");
            this.icon.Images.SetKeyName(5, "Pencil-icon.png");
            this.icon.Images.SetKeyName(6, "search-icon.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(-2, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1257, 420);
            this.listView1.SmallImageList = this.icon;
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "hello";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "alo";
            // 
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.listView1);
            this.pnl_List.Location = new System.Drawing.Point(16, 486);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(1257, 420);
            this.pnl_List.TabIndex = 38;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageIndex = 6;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(823, 926);
            this.btn_print.Margin = new System.Windows.Forms.Padding(0);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_print.Size = new System.Drawing.Size(173, 49);
            this.btn_print.TabIndex = 111;
            this.btn_print.Text = "In sớ";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 6;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(645, 926);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Delete.Size = new System.Drawing.Size(173, 49);
            this.btn_Delete.TabIndex = 110;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageIndex = 3;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(464, 926);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Update.Size = new System.Drawing.Size(173, 49);
            this.btn_Update.TabIndex = 109;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(287, 926);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btn_Add.Size = new System.Drawing.Size(173, 49);
            this.btn_Add.TabIndex = 108;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(892, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 117;
            this.button1.Text = "Sửa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lammoi.FlatAppearance.BorderSize = 0;
            this.btn_lammoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ImageIndex = 1;
            this.btn_lammoi.ImageList = this.imageList1;
            this.btn_lammoi.Location = new System.Drawing.Point(1081, 357);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_lammoi.Size = new System.Drawing.Size(173, 49);
            this.btn_lammoi.TabIndex = 112;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // rdbtn_coso
            // 
            this.rdbtn_coso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtn_coso.AutoSize = true;
            this.rdbtn_coso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_coso.Location = new System.Drawing.Point(891, 17);
            this.rdbtn_coso.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_coso.Name = "rdbtn_coso";
            this.rdbtn_coso.Size = new System.Drawing.Size(114, 40);
            this.rdbtn_coso.TabIndex = 116;
            this.rdbtn_coso.Text = "Có sổ";
            this.rdbtn_coso.UseVisualStyleBackColor = true;
            // 
            // rdbtn_chua
            // 
            this.rdbtn_chua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtn_chua.AutoSize = true;
            this.rdbtn_chua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_chua.Location = new System.Drawing.Point(1037, 17);
            this.rdbtn_chua.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_chua.Name = "rdbtn_chua";
            this.rdbtn_chua.Size = new System.Drawing.Size(187, 40);
            this.rdbtn_chua.TabIndex = 115;
            this.rdbtn_chua.Text = "Chưa có sổ";
            this.rdbtn_chua.UseVisualStyleBackColor = true;
            // 
            // lbl_PhieuDiemThongTin
            // 
            this.lbl_PhieuDiemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PhieuDiemThongTin.AutoSize = true;
            this.lbl_PhieuDiemThongTin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDiemThongTin.Location = new System.Drawing.Point(28, 21);
            this.lbl_PhieuDiemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PhieuDiemThongTin.Name = "lbl_PhieuDiemThongTin";
            this.lbl_PhieuDiemThongTin.Size = new System.Drawing.Size(311, 38);
            this.lbl_PhieuDiemThongTin.TabIndex = 114;
            this.lbl_PhieuDiemThongTin.Text = "Phiếu điền thông tin";
            this.lbl_PhieuDiemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Form
            // 
            this.pnl_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.txt_idchubai);
            this.pnl_Form.Controls.Add(this.txt_id);
            this.pnl_Form.Controls.Add(this.txt_gioi_tinh);
            this.pnl_Form.Controls.Add(this.txt_diachi);
            this.pnl_Form.Controls.Add(this.lbl_LuuTru);
            this.pnl_Form.Controls.Add(this.txt_nguyenquan);
            this.pnl_Form.Controls.Add(this.rbm_Woman);
            this.pnl_Form.Controls.Add(this.rbm_Man);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.lbl_diachi);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Form.Location = new System.Drawing.Point(16, 70);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1253, 269);
            this.pnl_Form.TabIndex = 113;
            // 
            // txt_idchubai
            // 
            this.txt_idchubai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_idchubai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchubai.Location = new System.Drawing.Point(1035, 159);
            this.txt_idchubai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idchubai.Name = "txt_idchubai";
            this.txt_idchubai.Size = new System.Drawing.Size(152, 42);
            this.txt_idchubai.TabIndex = 31;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(844, 159);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(181, 42);
            this.txt_id.TabIndex = 30;
            this.txt_id.TabStop = false;
            this.txt_id.Text = " ";
            // 
            // txt_gioi_tinh
            // 
            this.txt_gioi_tinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_gioi_tinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh.Location = new System.Drawing.Point(224, 182);
            this.txt_gioi_tinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioi_tinh.Name = "txt_gioi_tinh";
            this.txt_gioi_tinh.Size = new System.Drawing.Size(9, 42);
            this.txt_gioi_tinh.TabIndex = 29;
            this.txt_gioi_tinh.TabStop = false;
            this.txt_gioi_tinh.Visible = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(844, 28);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(343, 42);
            this.txt_diachi.TabIndex = 3;
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(632, 113);
            this.lbl_LuuTru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LuuTru.Name = "lbl_LuuTru";
            this.lbl_LuuTru.Size = new System.Drawing.Size(174, 34);
            this.lbl_LuuTru.TabIndex = 26;
            this.lbl_LuuTru.Text = "Nguyên quán";
            this.lbl_LuuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nguyenquan
            // 
            this.txt_nguyenquan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_nguyenquan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguyenquan.Location = new System.Drawing.Point(844, 103);
            this.txt_nguyenquan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nguyenquan.Name = "txt_nguyenquan";
            this.txt_nguyenquan.ReadOnly = true;
            this.txt_nguyenquan.Size = new System.Drawing.Size(343, 42);
            this.txt_nguyenquan.TabIndex = 4;
            // 
            // rbm_Woman
            // 
            this.rbm_Woman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(431, 190);
            this.rbm_Woman.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Woman.Name = "rbm_Woman";
            this.rbm_Woman.Size = new System.Drawing.Size(74, 38);
            this.rbm_Woman.TabIndex = 24;
            this.rbm_Woman.Text = "Nữ";
            this.rbm_Woman.UseVisualStyleBackColor = true;
            // 
            // rbm_Man
            // 
            this.rbm_Man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbm_Man.AutoSize = true;
            this.rbm_Man.Checked = true;
            this.rbm_Man.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Man.Location = new System.Drawing.Point(272, 187);
            this.rbm_Man.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Man.Name = "rbm_Man";
            this.rbm_Man.Size = new System.Drawing.Size(94, 38);
            this.rbm_Man.TabIndex = 100;
            this.rbm_Man.TabStop = true;
            this.rbm_Man.Text = "Nam";
            this.rbm_Man.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(29, 38);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(108, 34);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(224, 28);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(343, 42);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_sex
            // 
            this.lbl_sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(29, 192);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(121, 34);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(632, 38);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(100, 34);
            this.lbl_diachi.TabIndex = 12;
            this.lbl_diachi.Text = "Địa chỉ";
            this.lbl_diachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(29, 113);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(141, 34);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(224, 103);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.ReadOnly = true;
            this.txt_nickname.Size = new System.Drawing.Size(343, 42);
            this.txt_nickname.TabIndex = 2;
            // 
            // SoCauSieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 990);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.rdbtn_coso);
            this.Controls.Add(this.rdbtn_chua);
            this.Controls.Add(this.lbl_PhieuDiemThongTin);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SoCauSieu";
            this.Text = "SoCauSieu";
            this.Load += new System.EventHandler(this.SoCauSieu_Load);
            this.pnl_List.ResumeLayout(false);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.RadioButton rdbtn_coso;
        private System.Windows.Forms.RadioButton rdbtn_chua;
        private System.Windows.Forms.Label lbl_PhieuDiemThongTin;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.TextBox txt_idchubai;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_gioi_tinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_LuuTru;
        private System.Windows.Forms.TextBox txt_nguyenquan;
        private System.Windows.Forms.RadioButton rbm_Woman;
        private System.Windows.Forms.RadioButton rbm_Man;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
    }
}
namespace DataProject
{
    partial class Frm_inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inventory));
            this.tblLyt_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tblLyt_Head = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Ind = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_ceng = new System.Windows.Forms.Label();
            this.tblLyt_Order = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.cmb_ItemID = new System.Windows.Forms.ComboBox();
            this.lbl_piece = new System.Windows.Forms.Label();
            this.btn_Order = new System.Windows.Forms.Button();
            this.txt_Piece = new System.Windows.Forms.TextBox();
            this.tbl_Week = new System.Windows.Forms.TableLayoutPanel();
            this.txt_week = new System.Windows.Forms.TextBox();
            this.pcrBox_Week = new System.Windows.Forms.PictureBox();
            this.lbl_Warning2 = new System.Windows.Forms.Label();
            this.dataGrid_items = new System.Windows.Forms.DataGridView();
            this.tblLyt_Logo = new System.Windows.Forms.TableLayoutPanel();
            this.pcrBox_Logo = new System.Windows.Forms.PictureBox();
            this.rchBox_Information = new System.Windows.Forms.RichTextBox();
            this.tblLyt_Main.SuspendLayout();
            this.tblLyt_Head.SuspendLayout();
            this.tblLyt_Order.SuspendLayout();
            this.tbl_Week.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBox_Week)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_items)).BeginInit();
            this.tblLyt_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLyt_Main
            // 
            this.tblLyt_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyt_Main.ColumnCount = 2;
            this.tblLyt_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLyt_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLyt_Main.Controls.Add(this.tblLyt_Head, 1, 0);
            this.tblLyt_Main.Controls.Add(this.tblLyt_Logo, 0, 0);
            this.tblLyt_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLyt_Main.Name = "tblLyt_Main";
            this.tblLyt_Main.RowCount = 1;
            this.tblLyt_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLyt_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 710F));
            this.tblLyt_Main.Size = new System.Drawing.Size(1345, 710);
            this.tblLyt_Main.TabIndex = 0;
            // 
            // tblLyt_Head
            // 
            this.tblLyt_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyt_Head.ColumnCount = 1;
            this.tblLyt_Head.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLyt_Head.Controls.Add(this.lbl_Ind, 0, 2);
            this.tblLyt_Head.Controls.Add(this.lbl_Head, 0, 0);
            this.tblLyt_Head.Controls.Add(this.lbl_ceng, 0, 1);
            this.tblLyt_Head.Controls.Add(this.tblLyt_Order, 0, 3);
            this.tblLyt_Head.Controls.Add(this.tbl_Week, 0, 5);
            this.tblLyt_Head.Controls.Add(this.dataGrid_items, 0, 4);
            this.tblLyt_Head.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLyt_Head.Location = new System.Drawing.Point(339, 3);
            this.tblLyt_Head.Name = "tblLyt_Head";
            this.tblLyt_Head.RowCount = 6;
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblLyt_Head.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLyt_Head.Size = new System.Drawing.Size(1003, 704);
            this.tblLyt_Head.TabIndex = 1;
            // 
            // lbl_Ind
            // 
            this.lbl_Ind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ind.AutoSize = true;
            this.lbl_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ind.Location = new System.Drawing.Point(3, 122);
            this.lbl_Ind.Name = "lbl_Ind";
            this.lbl_Ind.Size = new System.Drawing.Size(997, 52);
            this.lbl_Ind.TabIndex = 2;
            this.lbl_Ind.Text = "~";
            this.lbl_Ind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Head
            // 
            this.lbl_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("Sitka Heading", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Head.Location = new System.Drawing.Point(3, 0);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(997, 70);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "The Inventory Project";
            this.lbl_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ceng
            // 
            this.lbl_ceng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ceng.AutoSize = true;
            this.lbl_ceng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ceng.Location = new System.Drawing.Point(3, 70);
            this.lbl_ceng.Name = "lbl_ceng";
            this.lbl_ceng.Size = new System.Drawing.Size(997, 52);
            this.lbl_ceng.TabIndex = 1;
            this.lbl_ceng.Text = "MRP SYSTEM";
            this.lbl_ceng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblLyt_Order
            // 
            this.tblLyt_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyt_Order.ColumnCount = 5;
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLyt_Order.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLyt_Order.Controls.Add(this.lbl_itemID, 0, 0);
            this.tblLyt_Order.Controls.Add(this.cmb_ItemID, 1, 0);
            this.tblLyt_Order.Controls.Add(this.lbl_piece, 2, 0);
            this.tblLyt_Order.Controls.Add(this.btn_Order, 4, 0);
            this.tblLyt_Order.Controls.Add(this.txt_Piece, 3, 0);
            this.tblLyt_Order.Location = new System.Drawing.Point(3, 177);
            this.tblLyt_Order.Name = "tblLyt_Order";
            this.tblLyt_Order.RowCount = 1;
            this.tblLyt_Order.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLyt_Order.Size = new System.Drawing.Size(997, 64);
            this.tblLyt_Order.TabIndex = 3;
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_itemID.Location = new System.Drawing.Point(97, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(99, 64);
            this.lbl_itemID.TabIndex = 3;
            this.lbl_itemID.Text = "Item ID :";
            this.lbl_itemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ItemID
            // 
            this.cmb_ItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ItemID.FormattingEnabled = true;
            this.cmb_ItemID.Items.AddRange(new object[] {
            "1605",
            "13122",
            "048",
            "118",
            "062",
            "14127",
            "314",
            "457",
            "11495",
            "129",
            "1118",
            "2142",
            "019"});
            this.cmb_ItemID.Location = new System.Drawing.Point(199, 15);
            this.cmb_ItemID.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.cmb_ItemID.Name = "cmb_ItemID";
            this.cmb_ItemID.Size = new System.Drawing.Size(199, 37);
            this.cmb_ItemID.TabIndex = 4;
            this.cmb_ItemID.Text = "1605";
            this.cmb_ItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_ItemID_KeyPress);
            // 
            // lbl_piece
            // 
            this.lbl_piece.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_piece.AutoSize = true;
            this.lbl_piece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_piece.Location = new System.Drawing.Point(497, 0);
            this.lbl_piece.Name = "lbl_piece";
            this.lbl_piece.Size = new System.Drawing.Size(97, 64);
            this.lbl_piece.TabIndex = 6;
            this.lbl_piece.Text = "Pieces :";
            this.lbl_piece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Order.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Order.Location = new System.Drawing.Point(801, 16);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(5, 16, 0, 8);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(141, 40);
            this.btn_Order.TabIndex = 5;
            this.btn_Order.Text = "Give the Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // txt_Piece
            // 
            this.txt_Piece.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Piece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Piece.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Piece.Location = new System.Drawing.Point(597, 20);
            this.txt_Piece.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.txt_Piece.MaxLength = 4;
            this.txt_Piece.Name = "txt_Piece";
            this.txt_Piece.Size = new System.Drawing.Size(199, 35);
            this.txt_Piece.TabIndex = 7;
            this.txt_Piece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Piece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Piece_KeyPress);
            // 
            // tbl_Week
            // 
            this.tbl_Week.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Week.ColumnCount = 3;
            this.tbl_Week.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbl_Week.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Week.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl_Week.Controls.Add(this.txt_week, 1, 0);
            this.tbl_Week.Controls.Add(this.pcrBox_Week, 2, 0);
            this.tbl_Week.Controls.Add(this.lbl_Warning2, 0, 0);
            this.tbl_Week.Location = new System.Drawing.Point(3, 634);
            this.tbl_Week.Name = "tbl_Week";
            this.tbl_Week.RowCount = 1;
            this.tbl_Week.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Week.Size = new System.Drawing.Size(997, 67);
            this.tbl_Week.TabIndex = 5;
            // 
            // txt_week
            // 
            this.txt_week.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_week.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_week.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_week.ForeColor = System.Drawing.Color.Black;
            this.txt_week.Location = new System.Drawing.Point(700, 14);
            this.txt_week.MaxLength = 2;
            this.txt_week.Name = "txt_week";
            this.txt_week.Size = new System.Drawing.Size(143, 38);
            this.txt_week.TabIndex = 0;
            this.txt_week.Text = "1";
            this.txt_week.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_week.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_week_KeyPress);
            // 
            // pcrBox_Week
            // 
            this.pcrBox_Week.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcrBox_Week.BackColor = System.Drawing.Color.Transparent;
            this.pcrBox_Week.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcrBox_Week.Image = global::DataProject.Properties.Resources.iconfinder_Next_372912__2_;
            this.pcrBox_Week.Location = new System.Drawing.Point(849, 8);
            this.pcrBox_Week.Name = "pcrBox_Week";
            this.pcrBox_Week.Size = new System.Drawing.Size(56, 50);
            this.pcrBox_Week.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcrBox_Week.TabIndex = 1;
            this.pcrBox_Week.TabStop = false;
            this.pcrBox_Week.Click += new System.EventHandler(this.pcrBox_Week_Click);
            this.pcrBox_Week.MouseLeave += new System.EventHandler(this.pcrBox_Week_MouseLeave);
            this.pcrBox_Week.MouseHover += new System.EventHandler(this.pcrBox_Week_MouseHover);
            // 
            // lbl_Warning2
            // 
            this.lbl_Warning2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Warning2.AutoSize = true;
            this.lbl_Warning2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Warning2.Location = new System.Drawing.Point(3, 0);
            this.lbl_Warning2.Name = "lbl_Warning2";
            this.lbl_Warning2.Size = new System.Drawing.Size(691, 67);
            this.lbl_Warning2.TabIndex = 2;
            this.lbl_Warning2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGrid_items
            // 
            this.dataGrid_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_items.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_items.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_items.Location = new System.Drawing.Point(0, 244);
            this.dataGrid_items.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.dataGrid_items.Name = "dataGrid_items";
            this.dataGrid_items.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_items.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_items.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_items.Size = new System.Drawing.Size(983, 387);
            this.dataGrid_items.TabIndex = 6;
            // 
            // tblLyt_Logo
            // 
            this.tblLyt_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLyt_Logo.ColumnCount = 1;
            this.tblLyt_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLyt_Logo.Controls.Add(this.pcrBox_Logo, 0, 0);
            this.tblLyt_Logo.Controls.Add(this.rchBox_Information, 0, 1);
            this.tblLyt_Logo.Location = new System.Drawing.Point(3, 15);
            this.tblLyt_Logo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tblLyt_Logo.Name = "tblLyt_Logo";
            this.tblLyt_Logo.RowCount = 2;
            this.tblLyt_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyt_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLyt_Logo.Size = new System.Drawing.Size(330, 692);
            this.tblLyt_Logo.TabIndex = 0;
            // 
            // pcrBox_Logo
            // 
            this.pcrBox_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcrBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pcrBox_Logo.Image = global::DataProject.Properties.Resources.graph__1_;
            this.pcrBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pcrBox_Logo.Name = "pcrBox_Logo";
            this.pcrBox_Logo.Size = new System.Drawing.Size(324, 340);
            this.pcrBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcrBox_Logo.TabIndex = 0;
            this.pcrBox_Logo.TabStop = false;
            // 
            // rchBox_Information
            // 
            this.rchBox_Information.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchBox_Information.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchBox_Information.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchBox_Information.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchBox_Information.Location = new System.Drawing.Point(3, 349);
            this.rchBox_Information.Name = "rchBox_Information";
            this.rchBox_Information.Size = new System.Drawing.Size(324, 340);
            this.rchBox_Information.TabIndex = 1;
            this.rchBox_Information.Text = "";
            // 
            // Frm_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1344, 711);
            this.Controls.Add(this.tblLyt_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1800, 900);
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "Frm_inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Program";
            this.tblLyt_Main.ResumeLayout(false);
            this.tblLyt_Head.ResumeLayout(false);
            this.tblLyt_Head.PerformLayout();
            this.tblLyt_Order.ResumeLayout(false);
            this.tblLyt_Order.PerformLayout();
            this.tbl_Week.ResumeLayout(false);
            this.tbl_Week.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBox_Week)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_items)).EndInit();
            this.tblLyt_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcrBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLyt_Main;
        private System.Windows.Forms.TableLayoutPanel tblLyt_Logo;
        private System.Windows.Forms.PictureBox pcrBox_Logo;
        private System.Windows.Forms.TableLayoutPanel tblLyt_Head;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_ceng;
        private System.Windows.Forms.Label lbl_Ind;
        private System.Windows.Forms.TableLayoutPanel tblLyt_Order;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.ComboBox cmb_ItemID;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label lbl_piece;
        private System.Windows.Forms.DataGridView dataGrid_items;
        private System.Windows.Forms.TextBox txt_Piece;
        public System.Windows.Forms.RichTextBox rchBox_Information;
        private System.Windows.Forms.TableLayoutPanel tbl_Week;
        private System.Windows.Forms.TextBox txt_week;
        private System.Windows.Forms.PictureBox pcrBox_Week;
        private System.Windows.Forms.Label lbl_Warning2;
    }
}


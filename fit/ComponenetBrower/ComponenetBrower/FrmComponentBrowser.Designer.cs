namespace ComponenetBrower
{
    partial class FrmComponentBrowser
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditCurrent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.bxImage = new System.Windows.Forms.PictureBox();
            this.txBxDescribtion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txBxSKU = new System.Windows.Forms.TextBox();
            this.txBxName = new System.Windows.Forms.TextBox();
            this.txBxPrice = new System.Windows.Forms.TextBox();
            this.cmBxCategory = new System.Windows.Forms.ComboBox();
            this.cmBxSubcategory = new System.Windows.Forms.ComboBox();
            this.dateTmFirstInStock = new System.Windows.Forms.DateTimePicker();
            this.cxBxAvailable = new System.Windows.Forms.CheckBox();
            this.txBxRecordDisplay = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bxImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Plum;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(713, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 43);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditCurrent
            // 
            this.btnEditCurrent.BackColor = System.Drawing.Color.Plum;
            this.btnEditCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCurrent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCurrent.Location = new System.Drawing.Point(713, 88);
            this.btnEditCurrent.Name = "btnEditCurrent";
            this.btnEditCurrent.Size = new System.Drawing.Size(130, 43);
            this.btnEditCurrent.TabIndex = 1;
            this.btnEditCurrent.Text = "Edit Current";
            this.btnEditCurrent.UseVisualStyleBackColor = false;
            this.btnEditCurrent.Click += new System.EventHandler(this.btnEdit);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Plum;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(713, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Plum;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(713, 186);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(130, 43);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Plum;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(713, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Plum;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(713, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Plum;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Location = new System.Drawing.Point(12, 22);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(110, 43);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Plum;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(138, 22);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 43);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Plum;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(431, 22);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 43);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Plum;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Location = new System.Drawing.Point(551, 22);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(104, 43);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Plum;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(713, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 43);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Plum;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUploadImage.Location = new System.Drawing.Point(51, 214);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(158, 37);
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // bxImage
            // 
            this.bxImage.BackColor = System.Drawing.Color.Silver;
            this.bxImage.Location = new System.Drawing.Point(27, 40);
            this.bxImage.Name = "bxImage";
            this.bxImage.Size = new System.Drawing.Size(215, 168);
            this.bxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bxImage.TabIndex = 12;
            this.bxImage.TabStop = false;
            this.bxImage.Click += new System.EventHandler(this.bxImage_Click);
            this.bxImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.bxImage_DragDrop);
            this.bxImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.bxImage_DragEnter);
            // 
            // txBxDescribtion
            // 
            this.txBxDescribtion.Location = new System.Drawing.Point(32, 294);
            this.txBxDescribtion.Name = "txBxDescribtion";
            this.txBxDescribtion.Size = new System.Drawing.Size(209, 149);
            this.txBxDescribtion.TabIndex = 13;
            this.txBxDescribtion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Description: ";
            // 
            // txBxSKU
            // 
            this.txBxSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxSKU.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txBxSKU.Location = new System.Drawing.Point(341, 59);
            this.txBxSKU.Name = "txBxSKU";
            this.txBxSKU.Size = new System.Drawing.Size(186, 23);
            this.txBxSKU.TabIndex = 15;
            this.txBxSKU.Text = "SKU (Unique ID)";
            this.txBxSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txBxSKU.TextChanged += new System.EventHandler(this.txBxSKU_TextChanged);
            this.txBxSKU.Enter += new System.EventHandler(this.txBxSKU_Enter);
            this.txBxSKU.Leave += new System.EventHandler(this.txBxSKU_Leave);
            // 
            // txBxName
            // 
            this.txBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txBxName.Location = new System.Drawing.Point(341, 108);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(186, 23);
            this.txBxName.TabIndex = 16;
            this.txBxName.Text = "Name";
            this.txBxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txBxName.Enter += new System.EventHandler(this.txBxName_Enter);
            this.txBxName.Leave += new System.EventHandler(this.txBxName_Leave);
            // 
            // txBxPrice
            // 
            this.txBxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txBxPrice.Location = new System.Drawing.Point(341, 157);
            this.txBxPrice.Name = "txBxPrice";
            this.txBxPrice.Size = new System.Drawing.Size(186, 23);
            this.txBxPrice.TabIndex = 17;
            this.txBxPrice.Text = "Price";
            this.txBxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txBxPrice.Enter += new System.EventHandler(this.txBxPrice_Enter);
            this.txBxPrice.Leave += new System.EventHandler(this.txBxPrice_Leave);
            // 
            // cmBxCategory
            // 
            this.cmBxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxCategory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmBxCategory.FormattingEnabled = true;
            this.cmBxCategory.Location = new System.Drawing.Point(340, 222);
            this.cmBxCategory.Name = "cmBxCategory";
            this.cmBxCategory.Size = new System.Drawing.Size(186, 24);
            this.cmBxCategory.TabIndex = 18;
            this.cmBxCategory.Text = "Category";
            this.cmBxCategory.SelectedIndexChanged += new System.EventHandler(this.cmBxCategory_SelectedIndexChanged);
            // 
            // cmBxSubcategory
            // 
            this.cmBxSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxSubcategory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmBxSubcategory.FormattingEnabled = true;
            this.cmBxSubcategory.Location = new System.Drawing.Point(341, 267);
            this.cmBxSubcategory.Name = "cmBxSubcategory";
            this.cmBxSubcategory.Size = new System.Drawing.Size(186, 24);
            this.cmBxSubcategory.TabIndex = 19;
            this.cmBxSubcategory.Text = "Sub Category";
            // 
            // dateTmFirstInStock
            // 
            this.dateTmFirstInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTmFirstInStock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTmFirstInStock.Location = new System.Drawing.Point(339, 345);
            this.dateTmFirstInStock.Name = "dateTmFirstInStock";
            this.dateTmFirstInStock.Size = new System.Drawing.Size(187, 23);
            this.dateTmFirstInStock.TabIndex = 21;
            // 
            // cxBxAvailable
            // 
            this.cxBxAvailable.AutoSize = true;
            this.cxBxAvailable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cxBxAvailable.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cxBxAvailable.Location = new System.Drawing.Point(341, 396);
            this.cxBxAvailable.Name = "cxBxAvailable";
            this.cxBxAvailable.Size = new System.Drawing.Size(69, 17);
            this.cxBxAvailable.TabIndex = 22;
            this.cxBxAvailable.Text = "Available";
            this.cxBxAvailable.UseVisualStyleBackColor = false;
            // 
            // txBxRecordDisplay
            // 
            this.txBxRecordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxRecordDisplay.Location = new System.Drawing.Point(290, 34);
            this.txBxRecordDisplay.Name = "txBxRecordDisplay";
            this.txBxRecordDisplay.Size = new System.Drawing.Size(121, 23);
            this.txBxRecordDisplay.TabIndex = 23;
            this.txBxRecordDisplay.TextChanged += new System.EventHandler(this.txBxRecordDisplay_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBxRecordDisplay);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Location = new System.Drawing.Point(10, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 86);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date First in Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Unique ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Sub Category";
            // 
            // FrmComponentBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(902, 542);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cxBxAvailable);
            this.Controls.Add(this.dateTmFirstInStock);
            this.Controls.Add(this.cmBxSubcategory);
            this.Controls.Add(this.cmBxCategory);
            this.Controls.Add(this.txBxPrice);
            this.Controls.Add(this.txBxName);
            this.Controls.Add(this.txBxSKU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBxDescribtion);
            this.Controls.Add(this.bxImage);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCurrent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmComponentBrowser";
            this.Text = "FrmComponentBrowser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApp);
            this.Load += new System.EventHandler(this.FrmComponentBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bxImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditCurrent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox bxImage;
        private System.Windows.Forms.RichTextBox txBxDescribtion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBxSKU;
        private System.Windows.Forms.TextBox txBxName;
        private System.Windows.Forms.TextBox txBxPrice;
        private System.Windows.Forms.ComboBox cmBxCategory;
        private System.Windows.Forms.ComboBox cmBxSubcategory;
        private System.Windows.Forms.DateTimePicker dateTmFirstInStock;
        private System.Windows.Forms.CheckBox cxBxAvailable;
        private System.Windows.Forms.TextBox txBxRecordDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
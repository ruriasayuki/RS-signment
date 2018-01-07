namespace MapControlApplication1
{
    partial class MainForm
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
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_loadRater = new System.Windows.Forms.ToolStripMenuItem();
            this.MI2_loadFromSDE = new System.Windows.Forms.ToolStripMenuItem();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_importRstDataset = new System.Windows.Forms.TextBox();
            this.btn_importRstDataset = new System.Windows.Forms.Button();
            this.cmb_importRstCatalog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_loadRstDataset = new System.Windows.Forms.Button();
            this.cmb_loadRstDataset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_loadRstCatalog = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_newRstCat = new System.Windows.Forms.TextBox();
            this.btn_createRstCat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmb_BBand = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_GBand = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_RBand = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cmb_rgbLayer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_renderBand = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_renderLayer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_stretchBand = new System.Windows.Forms.ComboBox();
            this.cmb_stretchLayer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_drawHisBand = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_drawHisLayer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_ndviLayer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.cmb_statisticsBand = new System.Windows.Forms.ComboBox();
            this.cmb_statisticsLayer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox_B3 = new System.Windows.Forms.ComboBox();
            this.B4闭值40判定法 = new System.Windows.Forms.Button();
            this.cms_TOCRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_zoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_deleteLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox_B4 = new System.Windows.Forms.ComboBox();
            this.comboBox_B5 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.cms_TOCRightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.MI_loadRater});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.menuSeparator,
            this.menuExitApp});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(39, 21);
            this.menuFile.Text = "File";
            // 
            // menuNewDoc
            // 
            this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
            this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuNewDoc.Name = "menuNewDoc";
            this.menuNewDoc.Size = new System.Drawing.Size(180, 22);
            this.menuNewDoc.Text = "New Document";
            this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
            // 
            // menuOpenDoc
            // 
            this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
            this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenDoc.Name = "menuOpenDoc";
            this.menuOpenDoc.Size = new System.Drawing.Size(180, 22);
            this.menuOpenDoc.Text = "Open Document...";
            this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
            // 
            // menuSaveDoc
            // 
            this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
            this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveDoc.Name = "menuSaveDoc";
            this.menuSaveDoc.Size = new System.Drawing.Size(180, 22);
            this.menuSaveDoc.Text = "SaveDocument";
            this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // menuExitApp
            // 
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(180, 22);
            this.menuExitApp.Text = "Exit";
            this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
            // 
            // MI_loadRater
            // 
            this.MI_loadRater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI2_loadFromSDE});
            this.MI_loadRater.Name = "MI_loadRater";
            this.MI_loadRater.Size = new System.Drawing.Size(92, 21);
            this.MI_loadRater.Text = "加载栅格图像";
            // 
            // MI2_loadFromSDE
            // 
            this.MI2_loadFromSDE.Name = "MI2_loadFromSDE";
            this.MI2_loadFromSDE.Size = new System.Drawing.Size(136, 22);
            this.MI2_loadFromSDE.Text = "连接数据库";
            this.MI2_loadFromSDE.Click += new System.EventHandler(this.MI2_loadFromSDE_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(191, 53);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(419, 530);
            this.axMapControl1.TabIndex = 2;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 25);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(859, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axTOCControl1.Location = new System.Drawing.Point(3, 53);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(188, 530);
            this.axTOCControl1.TabIndex = 4;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(466, 278);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 53);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 552);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
            this.statusStrip1.Location = new System.Drawing.Point(3, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(57, 17);
            this.statusBarXY.Text = "Test 123";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(611, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(248, 530);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据处理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_importRstDataset);
            this.groupBox3.Controls.Add(this.btn_importRstDataset);
            this.groupBox3.Controls.Add(this.cmb_importRstCatalog);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(16, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导入栅格图像";
            // 
            // txb_importRstDataset
            // 
            this.txb_importRstDataset.Location = new System.Drawing.Point(67, 56);
            this.txb_importRstDataset.Name = "txb_importRstDataset";
            this.txb_importRstDataset.Size = new System.Drawing.Size(128, 21);
            this.txb_importRstDataset.TabIndex = 5;
            this.txb_importRstDataset.Click += new System.EventHandler(this.txb_importRstDataset_Click);
            // 
            // btn_importRstDataset
            // 
            this.btn_importRstDataset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_importRstDataset.Location = new System.Drawing.Point(67, 85);
            this.btn_importRstDataset.Name = "btn_importRstDataset";
            this.btn_importRstDataset.Size = new System.Drawing.Size(75, 23);
            this.btn_importRstDataset.TabIndex = 4;
            this.btn_importRstDataset.Text = "导入";
            this.btn_importRstDataset.UseVisualStyleBackColor = true;
            this.btn_importRstDataset.Click += new System.EventHandler(this.btn_importRstDataset_Click);
            // 
            // cmb_importRstCatalog
            // 
            this.cmb_importRstCatalog.FormattingEnabled = true;
            this.cmb_importRstCatalog.Location = new System.Drawing.Point(67, 24);
            this.cmb_importRstCatalog.Name = "cmb_importRstCatalog";
            this.cmb_importRstCatalog.Size = new System.Drawing.Size(128, 20);
            this.cmb_importRstCatalog.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "栅格图像";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "栅格目录";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_loadRstDataset);
            this.groupBox2.Controls.Add(this.cmb_loadRstDataset);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_loadRstCatalog);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(16, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "加载栅格图像";
            // 
            // btn_loadRstDataset
            // 
            this.btn_loadRstDataset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_loadRstDataset.Location = new System.Drawing.Point(67, 85);
            this.btn_loadRstDataset.Name = "btn_loadRstDataset";
            this.btn_loadRstDataset.Size = new System.Drawing.Size(75, 23);
            this.btn_loadRstDataset.TabIndex = 9;
            this.btn_loadRstDataset.Text = "加载";
            this.btn_loadRstDataset.UseVisualStyleBackColor = true;
            this.btn_loadRstDataset.Click += new System.EventHandler(this.btn_loadRstDataset_Click);
            // 
            // cmb_loadRstDataset
            // 
            this.cmb_loadRstDataset.FormattingEnabled = true;
            this.cmb_loadRstDataset.Location = new System.Drawing.Point(67, 57);
            this.cmb_loadRstDataset.Name = "cmb_loadRstDataset";
            this.cmb_loadRstDataset.Size = new System.Drawing.Size(128, 20);
            this.cmb_loadRstDataset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "栅格图像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "栅格目录";
            // 
            // cmb_loadRstCatalog
            // 
            this.cmb_loadRstCatalog.FormattingEnabled = true;
            this.cmb_loadRstCatalog.Location = new System.Drawing.Point(67, 24);
            this.cmb_loadRstCatalog.Name = "cmb_loadRstCatalog";
            this.cmb_loadRstCatalog.Size = new System.Drawing.Size(128, 20);
            this.cmb_loadRstCatalog.TabIndex = 0;
            this.cmb_loadRstCatalog.SelectedIndexChanged += new System.EventHandler(this.cmb_rstCatalog_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_newRstCat);
            this.groupBox1.Controls.Add(this.btn_createRstCat);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建栅格目录";
            // 
            // txb_newRstCat
            // 
            this.txb_newRstCat.Location = new System.Drawing.Point(15, 29);
            this.txb_newRstCat.Name = "txb_newRstCat";
            this.txb_newRstCat.Size = new System.Drawing.Size(112, 21);
            this.txb_newRstCat.TabIndex = 1;
            // 
            // btn_createRstCat
            // 
            this.btn_createRstCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_createRstCat.Location = new System.Drawing.Point(133, 28);
            this.btn_createRstCat.Name = "btn_createRstCat";
            this.btn_createRstCat.Size = new System.Drawing.Size(62, 23);
            this.btn_createRstCat.TabIndex = 0;
            this.btn_createRstCat.Text = "创建";
            this.btn_createRstCat.UseVisualStyleBackColor = true;
            this.btn_createRstCat.Click += new System.EventHandler(this.btn_createRstCat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(240, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图像处理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmb_BBand);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.cmb_GBand);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.cmb_RBand);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.button7);
            this.groupBox9.Controls.Add(this.cmb_rgbLayer);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox9.Location = new System.Drawing.Point(15, 414);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(210, 76);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "多波段假彩色合成";
            // 
            // cmb_BBand
            // 
            this.cmb_BBand.FormattingEnabled = true;
            this.cmb_BBand.Location = new System.Drawing.Point(151, 46);
            this.cmb_BBand.Name = "cmb_BBand";
            this.cmb_BBand.Size = new System.Drawing.Size(49, 20);
            this.cmb_BBand.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(138, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "B";
            // 
            // cmb_GBand
            // 
            this.cmb_GBand.FormattingEnabled = true;
            this.cmb_GBand.Location = new System.Drawing.Point(85, 46);
            this.cmb_GBand.Name = "cmb_GBand";
            this.cmb_GBand.Size = new System.Drawing.Size(49, 20);
            this.cmb_GBand.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(72, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "G";
            // 
            // cmb_RBand
            // 
            this.cmb_RBand.FormattingEnabled = true;
            this.cmb_RBand.Location = new System.Drawing.Point(20, 46);
            this.cmb_RBand.Name = "cmb_RBand";
            this.cmb_RBand.Size = new System.Drawing.Size(49, 20);
            this.cmb_RBand.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(7, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 16;
            this.label16.Text = "R";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(151, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 20);
            this.button7.TabIndex = 7;
            this.button7.Text = "合成";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cmb_rgbLayer
            // 
            this.cmb_rgbLayer.FormattingEnabled = true;
            this.cmb_rgbLayer.Location = new System.Drawing.Point(38, 20);
            this.cmb_rgbLayer.Name = "cmb_rgbLayer";
            this.cmb_rgbLayer.Size = new System.Drawing.Size(107, 20);
            this.cmb_rgbLayer.TabIndex = 8;
            this.cmb_rgbLayer.SelectedIndexChanged += new System.EventHandler(this.cmb_rgbLayer_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(7, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "图层";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBox3);
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.pictureBox2);
            this.groupBox8.Controls.Add(this.pictureBox1);
            this.groupBox8.Controls.Add(this.cmb_renderBand);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.cmb_renderLayer);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox8.Location = new System.Drawing.Point(15, 324);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(210, 83);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "单波段伪彩色渲染";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(122, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 20);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(151, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 20);
            this.button6.TabIndex = 10;
            this.button6.Text = "渲染";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(38, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 20);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_renderBand
            // 
            this.cmb_renderBand.FormattingEnabled = true;
            this.cmb_renderBand.Location = new System.Drawing.Point(151, 21);
            this.cmb_renderBand.Name = "cmb_renderBand";
            this.cmb_renderBand.Size = new System.Drawing.Size(49, 20);
            this.cmb_renderBand.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(120, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "波段";
            // 
            // cmb_renderLayer
            // 
            this.cmb_renderLayer.FormattingEnabled = true;
            this.cmb_renderLayer.Location = new System.Drawing.Point(38, 21);
            this.cmb_renderLayer.Name = "cmb_renderLayer";
            this.cmb_renderLayer.Size = new System.Drawing.Size(81, 20);
            this.cmb_renderLayer.TabIndex = 10;
            this.cmb_renderLayer.SelectedIndexChanged += new System.EventHandler(this.cmb_renderLayer_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(7, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "图层";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.comboBox8);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.cmb_stretchBand);
            this.groupBox7.Controls.Add(this.cmb_stretchLayer);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox7.Location = new System.Drawing.Point(15, 241);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 77);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "单波段灰度增强";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(151, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 20);
            this.button5.TabIndex = 7;
            this.button5.Text = "增强";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(38, 46);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(81, 20);
            this.comboBox8.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(7, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "方法";
            // 
            // cmb_stretchBand
            // 
            this.cmb_stretchBand.FormattingEnabled = true;
            this.cmb_stretchBand.Location = new System.Drawing.Point(151, 20);
            this.cmb_stretchBand.Name = "cmb_stretchBand";
            this.cmb_stretchBand.Size = new System.Drawing.Size(49, 20);
            this.cmb_stretchBand.TabIndex = 7;
            // 
            // cmb_stretchLayer
            // 
            this.cmb_stretchLayer.FormattingEnabled = true;
            this.cmb_stretchLayer.Location = new System.Drawing.Point(38, 20);
            this.cmb_stretchLayer.Name = "cmb_stretchLayer";
            this.cmb_stretchLayer.Size = new System.Drawing.Size(81, 20);
            this.cmb_stretchLayer.TabIndex = 7;
            this.cmb_stretchLayer.SelectedIndexChanged += new System.EventHandler(this.cmb_stretchLayer_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(120, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "波段";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "图层";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.cmb_drawHisBand);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cmb_drawHisLayer);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox6.Location = new System.Drawing.Point(15, 157);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(210, 78);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "直方图绘制";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(151, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 20);
            this.button4.TabIndex = 6;
            this.button4.Text = "多波段";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(151, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "单波段";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmb_drawHisBand
            // 
            this.cmb_drawHisBand.FormattingEnabled = true;
            this.cmb_drawHisBand.Location = new System.Drawing.Point(38, 45);
            this.cmb_drawHisBand.Name = "cmb_drawHisBand";
            this.cmb_drawHisBand.Size = new System.Drawing.Size(107, 20);
            this.cmb_drawHisBand.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "波段";
            // 
            // cmb_drawHisLayer
            // 
            this.cmb_drawHisLayer.FormattingEnabled = true;
            this.cmb_drawHisLayer.Location = new System.Drawing.Point(38, 19);
            this.cmb_drawHisLayer.Name = "cmb_drawHisLayer";
            this.cmb_drawHisLayer.Size = new System.Drawing.Size(107, 20);
            this.cmb_drawHisLayer.TabIndex = 3;
            this.cmb_drawHisLayer.SelectedIndexChanged += new System.EventHandler(this.cmb_drawHisLayer_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "图层";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.cmb_ndviLayer);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(15, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NDVI指数计算";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(151, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmb_ndviLayer
            // 
            this.cmb_ndviLayer.FormattingEnabled = true;
            this.cmb_ndviLayer.Location = new System.Drawing.Point(38, 21);
            this.cmb_ndviLayer.Name = "cmb_ndviLayer";
            this.cmb_ndviLayer.Size = new System.Drawing.Size(107, 20);
            this.cmb_ndviLayer.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "图层";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_statistics);
            this.groupBox4.Controls.Add(this.cmb_statisticsBand);
            this.groupBox4.Controls.Add(this.cmb_statisticsLayer);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(15, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 76);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "波段信息统计";
            // 
            // btn_statistics
            // 
            this.btn_statistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_statistics.Location = new System.Drawing.Point(151, 20);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(49, 46);
            this.btn_statistics.TabIndex = 4;
            this.btn_statistics.Text = "统计";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // cmb_statisticsBand
            // 
            this.cmb_statisticsBand.FormattingEnabled = true;
            this.cmb_statisticsBand.Location = new System.Drawing.Point(38, 46);
            this.cmb_statisticsBand.Name = "cmb_statisticsBand";
            this.cmb_statisticsBand.Size = new System.Drawing.Size(107, 20);
            this.cmb_statisticsBand.TabIndex = 3;
            // 
            // cmb_statisticsLayer
            // 
            this.cmb_statisticsLayer.FormattingEnabled = true;
            this.cmb_statisticsLayer.Location = new System.Drawing.Point(38, 20);
            this.cmb_statisticsLayer.Name = "cmb_statisticsLayer";
            this.cmb_statisticsLayer.Size = new System.Drawing.Size(107, 20);
            this.cmb_statisticsLayer.TabIndex = 2;
            this.cmb_statisticsLayer.SelectedIndexChanged += new System.EventHandler(this.cmb_statisticsLayer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "波段";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "图层";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox15);
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(240, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图像分析";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button14);
            this.groupBox15.Controls.Add(this.textBox3);
            this.groupBox15.Controls.Add(this.label29);
            this.groupBox15.Controls.Add(this.button13);
            this.groupBox15.Controls.Add(this.comboBox18);
            this.groupBox15.Controls.Add(this.label31);
            this.groupBox15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox15.Location = new System.Drawing.Point(15, 396);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(210, 76);
            this.groupBox15.TabIndex = 14;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "图像分类";
            // 
            // button14
            // 
            this.button14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button14.Location = new System.Drawing.Point(8, 46);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 20);
            this.button14.TabIndex = 7;
            this.button14.Text = "分类";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 21);
            this.textBox3.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(135, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 5;
            this.label29.Text = "数量";
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(106, 46);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 20);
            this.button13.TabIndex = 4;
            this.button13.Text = "分类后处理";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(38, 20);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(94, 20);
            this.comboBox18.TabIndex = 2;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(6, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "图层";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBox1);
            this.groupBox14.Controls.Add(this.label28);
            this.groupBox14.Controls.Add(this.button12);
            this.groupBox14.Controls.Add(this.comboBox15);
            this.groupBox14.Controls.Add(this.comboBox16);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox14.Location = new System.Drawing.Point(15, 314);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(210, 76);
            this.groupBox14.TabIndex = 13;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "图像变换";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(135, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 5;
            this.label28.Text = "角度";
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(151, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 20);
            this.button12.TabIndex = 4;
            this.button12.Text = "变换";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(38, 46);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(107, 20);
            this.comboBox15.TabIndex = 3;
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(38, 20);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(94, 20);
            this.comboBox16.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(6, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 1;
            this.label26.Text = "方式";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(6, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "图层";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button9);
            this.groupBox11.Controls.Add(this.comboBox3);
            this.groupBox11.Controls.Add(this.comboBox4);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox11.Location = new System.Drawing.Point(15, 232);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(210, 76);
            this.groupBox11.TabIndex = 12;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "卷积运算";
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(151, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 46);
            this.button9.TabIndex = 4;
            this.button9.Text = "滤波";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(38, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(107, 20);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(38, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(107, 20);
            this.comboBox4.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(6, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "方式";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(6, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "图层";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.comboBox1);
            this.groupBox10.Controls.Add(this.comboBox6);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox10.Location = new System.Drawing.Point(15, 94);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(210, 76);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "全色锐化(融合)";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(151, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 46);
            this.button8.TabIndex = 4;
            this.button8.Text = "融合";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(47, 20);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(98, 20);
            this.comboBox6.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(6, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "多波段";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(6, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "单波段";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox2);
            this.groupBox13.Controls.Add(this.button11);
            this.groupBox13.Controls.Add(this.comboBox11);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox13.Location = new System.Drawing.Point(15, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(210, 76);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "图像裁剪";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 21);
            this.textBox2.TabIndex = 7;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(151, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 46);
            this.button11.TabIndex = 4;
            this.button11.Text = "裁剪";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(38, 20);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(107, 20);
            this.comboBox11.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(6, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "矢量";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(6, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "图层";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button10);
            this.groupBox12.Controls.Add(this.comboBox9);
            this.groupBox12.Controls.Add(this.label24);
            this.groupBox12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox12.Location = new System.Drawing.Point(15, 176);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(210, 50);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "图像镶嵌";
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(151, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 20);
            this.button10.TabIndex = 7;
            this.button10.Text = "镶嵌";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(59, 19);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(86, 20);
            this.comboBox9.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(6, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 3;
            this.label24.Text = "栅格目录";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(240, 504);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "空间分析";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox16);
            this.tabPage5.Controls.Add(this.B4闭值40判定法);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(240, 504);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "太湖蓝藻";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBox_B5);
            this.groupBox16.Controls.Add(this.label33);
            this.groupBox16.Controls.Add(this.comboBox_B4);
            this.groupBox16.Controls.Add(this.label30);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Controls.Add(this.comboBox_B3);
            this.groupBox16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox16.Location = new System.Drawing.Point(6, 6);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(210, 136);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "选择输入";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(13, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "Band4";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(13, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 12);
            this.label32.TabIndex = 1;
            this.label32.Text = "Band3";
            // 
            // comboBox_B3
            // 
            this.comboBox_B3.FormattingEnabled = true;
            this.comboBox_B3.Location = new System.Drawing.Point(67, 24);
            this.comboBox_B3.Name = "comboBox_B3";
            this.comboBox_B3.Size = new System.Drawing.Size(128, 20);
            this.comboBox_B3.TabIndex = 0;
            // 
            // B4闭值40判定法
            // 
            this.B4闭值40判定法.Location = new System.Drawing.Point(73, 148);
            this.B4闭值40判定法.Name = "B4闭值40判定法";
            this.B4闭值40判定法.Size = new System.Drawing.Size(75, 23);
            this.B4闭值40判定法.TabIndex = 0;
            this.B4闭值40判定法.Text = "button1";
            this.B4闭值40判定法.UseVisualStyleBackColor = true;
            this.B4闭值40判定法.Click += new System.EventHandler(this.button1_Click);
            // 
            // cms_TOCRightMenu
            // 
            this.cms_TOCRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_zoomToLayer,
            this.tsmi_deleteLayer});
            this.cms_TOCRightMenu.Name = "cms_TOCRightMenu";
            this.cms_TOCRightMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // tsmi_zoomToLayer
            // 
            this.tsmi_zoomToLayer.Name = "tsmi_zoomToLayer";
            this.tsmi_zoomToLayer.Size = new System.Drawing.Size(160, 22);
            this.tsmi_zoomToLayer.Text = "缩放至当前图层";
            this.tsmi_zoomToLayer.Click += new System.EventHandler(this.tsmi_zoomToLayer_Click);
            // 
            // tsmi_deleteLayer
            // 
            this.tsmi_deleteLayer.Name = "tsmi_deleteLayer";
            this.tsmi_deleteLayer.Size = new System.Drawing.Size(160, 22);
            this.tsmi_deleteLayer.Text = "删除图层";
            this.tsmi_deleteLayer.Click += new System.EventHandler(this.tsmi_deleteLayer_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(13, 96);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "Band5";
            // 
            // comboBox_B4
            // 
            this.comboBox_B4.FormattingEnabled = true;
            this.comboBox_B4.Location = new System.Drawing.Point(67, 57);
            this.comboBox_B4.Name = "comboBox_B4";
            this.comboBox_B4.Size = new System.Drawing.Size(128, 20);
            this.comboBox_B4.TabIndex = 3;
            // 
            // comboBox_B5
            // 
            this.comboBox_B5.FormattingEnabled = true;
            this.comboBox_B5.Location = new System.Drawing.Point(67, 93);
            this.comboBox_B5.Name = "comboBox_B5";
            this.comboBox_B5.Size = new System.Drawing.Size(128, 20);
            this.comboBox_B5.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ArcEngine Controls Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.cms_TOCRightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txb_newRstCat;
        private System.Windows.Forms.Button btn_createRstCat;
        private System.Windows.Forms.ToolStripMenuItem MI_loadRater;
        private System.Windows.Forms.ToolStripMenuItem MI2_loadFromSDE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_loadRstCatalog;
        private System.Windows.Forms.Button btn_loadRstDataset;
        private System.Windows.Forms.ComboBox cmb_loadRstDataset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_importRstDataset;
        private System.Windows.Forms.ComboBox cmb_importRstCatalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_importRstDataset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.ComboBox cmb_statisticsBand;
        private System.Windows.Forms.ComboBox cmb_statisticsLayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmb_stretchLayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_drawHisBand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_drawHisLayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_ndviLayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cmb_BBand;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb_GBand;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_RBand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmb_rgbLayer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_renderBand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_renderLayer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_stretchBand;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ContextMenuStrip cms_TOCRightMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_zoomToLayer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_deleteLayer;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button B4闭值40判定法;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBox_B3;
        private System.Windows.Forms.ComboBox comboBox_B5;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBox_B4;
    }
}


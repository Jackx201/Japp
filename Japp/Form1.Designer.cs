namespace Japp
{
    partial class Main_Interface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Interface));
            this.Title_Bar = new System.Windows.Forms.Panel();
            this.Vertical_Menu = new System.Windows.Forms.Panel();
            this.Menu_Container = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_products = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClients = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPayments = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.SummaryPannel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPurchasesReport = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnPaymentsReport = new System.Windows.Forms.Button();
            this.Title_Bar.SuspendLayout();
            this.Vertical_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SummaryPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Bar
            // 
            this.Title_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Title_Bar.Controls.Add(this.btnRestore);
            this.Title_Bar.Controls.Add(this.btnMaximize);
            this.Title_Bar.Controls.Add(this.btnMinimize);
            this.Title_Bar.Controls.Add(this.btnClose);
            this.Title_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Bar.Location = new System.Drawing.Point(0, 0);
            this.Title_Bar.Name = "Title_Bar";
            this.Title_Bar.Size = new System.Drawing.Size(1300, 35);
            this.Title_Bar.TabIndex = 0;
            this.Title_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_Bar_MouseDown);
            // 
            // Vertical_Menu
            // 
            this.Vertical_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Vertical_Menu.Controls.Add(this.SummaryPannel);
            this.Vertical_Menu.Controls.Add(this.panel7);
            this.Vertical_Menu.Controls.Add(this.btnSummary);
            this.Vertical_Menu.Controls.Add(this.panel6);
            this.Vertical_Menu.Controls.Add(this.btnPayments);
            this.Vertical_Menu.Controls.Add(this.panel5);
            this.Vertical_Menu.Controls.Add(this.btnEmployees);
            this.Vertical_Menu.Controls.Add(this.panel4);
            this.Vertical_Menu.Controls.Add(this.btnPurchases);
            this.Vertical_Menu.Controls.Add(this.panel3);
            this.Vertical_Menu.Controls.Add(this.btnClients);
            this.Vertical_Menu.Controls.Add(this.panel2);
            this.Vertical_Menu.Controls.Add(this.btnSales);
            this.Vertical_Menu.Controls.Add(this.panel1);
            this.Vertical_Menu.Controls.Add(this.btn_products);
            this.Vertical_Menu.Controls.Add(this.pb_logo);
            this.Vertical_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Vertical_Menu.Location = new System.Drawing.Point(0, 35);
            this.Vertical_Menu.Name = "Vertical_Menu";
            this.Vertical_Menu.Size = new System.Drawing.Size(220, 615);
            this.Vertical_Menu.TabIndex = 1;
            // 
            // Menu_Container
            // 
            this.Menu_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Menu_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_Container.Location = new System.Drawing.Point(220, 35);
            this.Menu_Container.Name = "Menu_Container";
            this.Menu_Container.Size = new System.Drawing.Size(1080, 615);
            this.Menu_Container.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1250, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1177, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1212, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(1213, 6);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(25, 25);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 3;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(3, 6);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(217, 139);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_products.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_products.Image = ((System.Drawing.Image)(resources.GetObject("btn_products.Image")));
            this.btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_products.Location = new System.Drawing.Point(9, 152);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(208, 32);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 2;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(9, 200);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(208, 32);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 4;
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(9, 248);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(208, 32);
            this.btnClients.TabIndex = 5;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 6;
            // 
            // btnPurchases
            // 
            this.btnPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchases.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchases.Image")));
            this.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.Location = new System.Drawing.Point(9, 296);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(208, 32);
            this.btnPurchases.TabIndex = 7;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 342);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 8;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(9, 342);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(208, 32);
            this.btnEmployees.TabIndex = 9;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 389);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 10;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(9, 389);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(208, 32);
            this.btnPayments.TabIndex = 11;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 438);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
            this.panel7.TabIndex = 12;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Font = new System.Drawing.Font("Patua One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnSummary.Image")));
            this.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.Location = new System.Drawing.Point(9, 438);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(208, 32);
            this.btnSummary.TabIndex = 13;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // SummaryPannel
            // 
            this.SummaryPannel.Controls.Add(this.panel10);
            this.SummaryPannel.Controls.Add(this.btnPaymentsReport);
            this.SummaryPannel.Controls.Add(this.panel8);
            this.SummaryPannel.Controls.Add(this.btnPurchasesReport);
            this.SummaryPannel.Controls.Add(this.panel9);
            this.SummaryPannel.Controls.Add(this.btnSalesReport);
            this.SummaryPannel.Location = new System.Drawing.Point(49, 476);
            this.SummaryPannel.Name = "SummaryPannel";
            this.SummaryPannel.Size = new System.Drawing.Size(171, 100);
            this.SummaryPannel.TabIndex = 0;
            this.SummaryPannel.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(8, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 28);
            this.panel9.TabIndex = 14;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Patua One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(17, 3);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(154, 28);
            this.btnSalesReport.TabIndex = 15;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(8, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 28);
            this.panel8.TabIndex = 16;
            // 
            // btnPurchasesReport
            // 
            this.btnPurchasesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPurchasesReport.FlatAppearance.BorderSize = 0;
            this.btnPurchasesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPurchasesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchasesReport.Font = new System.Drawing.Font("Patua One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasesReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurchasesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchasesReport.Location = new System.Drawing.Point(17, 35);
            this.btnPurchasesReport.Name = "btnPurchasesReport";
            this.btnPurchasesReport.Size = new System.Drawing.Size(154, 28);
            this.btnPurchasesReport.TabIndex = 17;
            this.btnPurchasesReport.Text = "Purchases Report";
            this.btnPurchasesReport.UseVisualStyleBackColor = false;
            this.btnPurchasesReport.Click += new System.EventHandler(this.btnPurchasesReport_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(8, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 28);
            this.panel10.TabIndex = 18;
            // 
            // btnPaymentsReport
            // 
            this.btnPaymentsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPaymentsReport.FlatAppearance.BorderSize = 0;
            this.btnPaymentsReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPaymentsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsReport.Font = new System.Drawing.Font("Patua One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaymentsReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentsReport.Location = new System.Drawing.Point(17, 67);
            this.btnPaymentsReport.Name = "btnPaymentsReport";
            this.btnPaymentsReport.Size = new System.Drawing.Size(154, 28);
            this.btnPaymentsReport.TabIndex = 19;
            this.btnPaymentsReport.Text = "Payments Report";
            this.btnPaymentsReport.UseVisualStyleBackColor = false;
            this.btnPaymentsReport.Click += new System.EventHandler(this.btnPaymentsReport_Click);
            // 
            // Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Menu_Container);
            this.Controls.Add(this.Vertical_Menu);
            this.Controls.Add(this.Title_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Title_Bar.ResumeLayout(false);
            this.Vertical_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.SummaryPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title_Bar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel Vertical_Menu;
        private System.Windows.Forms.Panel Menu_Container;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel SummaryPannel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnPaymentsReport;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPurchasesReport;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSalesReport;
    }
}


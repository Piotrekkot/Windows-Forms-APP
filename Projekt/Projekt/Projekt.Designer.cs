namespace Projekt
{
    partial class ProjektApp
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
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odwiedźStronęWWWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ClientTabPage = new System.Windows.Forms.TabPage();
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imię = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDolaczenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscountTabPage = new System.Windows.Forms.TabPage();
            this.DiscountDataGridView = new System.Windows.Forms.DataGridView();
            this.RName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RabatyGroupBox = new System.Windows.Forms.GroupBox();
            this.PrzyznajRabatButton = new System.Windows.Forms.Button();
            this.AppMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ClientTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.ClientContextMenuStrip.SuspendLayout();
            this.DiscountTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountDataGridView)).BeginInit();
            this.RabatyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oAutorzeToolStripMenuItem,
            this.odwiedźStronęWWWToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.ShowItemToolTips = true;
            this.AppMenuStrip.Size = new System.Drawing.Size(757, 24);
            this.AppMenuStrip.TabIndex = 0;
            this.AppMenuStrip.Text = "AppMenuStrip";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlToolStripMenuItem});
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.oAutorzeToolStripMenuItem.Text = "O Autorze";
            this.oAutorzeToolStripMenuItem.ToolTipText = "Informacje o autorze oraz o aplikacji";
            // 
            // wyświetlToolStripMenuItem
            // 
            this.wyświetlToolStripMenuItem.Name = "wyświetlToolStripMenuItem";
            this.wyświetlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.wyświetlToolStripMenuItem.Text = "Wyświetl";
            this.wyświetlToolStripMenuItem.Click += new System.EventHandler(this.wyświetlToolStripMenuItem_Click);
            // 
            // odwiedźStronęWWWToolStripMenuItem
            // 
            this.odwiedźStronęWWWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wAplikacjiToolStripMenuItem,
            this.googleChromeToolStripMenuItem});
            this.odwiedźStronęWWWToolStripMenuItem.Name = "odwiedźStronęWWWToolStripMenuItem";
            this.odwiedźStronęWWWToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.odwiedźStronęWWWToolStripMenuItem.Text = "Odwiedź Stronę WWW";
            // 
            // wAplikacjiToolStripMenuItem
            // 
            this.wAplikacjiToolStripMenuItem.Name = "wAplikacjiToolStripMenuItem";
            this.wAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.wAplikacjiToolStripMenuItem.Text = "W Aplikacji";
            this.wAplikacjiToolStripMenuItem.Click += new System.EventHandler(this.wAplikacjiToolStripMenuItem_Click);
            // 
            // googleChromeToolStripMenuItem
            // 
            this.googleChromeToolStripMenuItem.Name = "googleChromeToolStripMenuItem";
            this.googleChromeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.googleChromeToolStripMenuItem.Text = "Google Chrome";
            this.googleChromeToolStripMenuItem.Click += new System.EventHandler(this.googleChromeToolStripMenuItem_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ClientTabPage);
            this.MainTabControl.Controls.Add(this.DiscountTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(757, 450);
            this.MainTabControl.TabIndex = 1;
            // 
            // ClientTabPage
            // 
            this.ClientTabPage.Controls.Add(this.ClientsDataGridView);
            this.ClientTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClientTabPage.Name = "ClientTabPage";
            this.ClientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientTabPage.Size = new System.Drawing.Size(749, 424);
            this.ClientTabPage.TabIndex = 0;
            this.ClientTabPage.Text = "Klienci";
            this.ClientTabPage.UseVisualStyleBackColor = true;
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.Imię,
            this.Nazwisko,
            this.DataDolaczenia,
            this.Email,
            this.StatusKlienta,
            this.Disc});
            this.ClientsDataGridView.ContextMenuStrip = this.ClientContextMenuStrip;
            this.ClientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.Size = new System.Drawing.Size(743, 418);
            this.ClientsDataGridView.TabIndex = 0;
            this.ClientsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellEndEdit);
            this.ClientsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientsDataGridView_MouseDown);
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // Imię
            // 
            this.Imię.DataPropertyName = "Nname";
            this.Imię.HeaderText = "Name";
            this.Imię.Name = "Imię";
            // 
            // Nazwisko
            // 
            this.Nazwisko.DataPropertyName = "Ename";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // DataDolaczenia
            // 
            this.DataDolaczenia.DataPropertyName = "AddDate";
            this.DataDolaczenia.HeaderText = "Data Dołączenia";
            this.DataDolaczenia.Name = "DataDolaczenia";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // StatusKlienta
            // 
            this.StatusKlienta.DataPropertyName = "ClientStatus";
            this.StatusKlienta.HeaderText = "StatusKlienta";
            this.StatusKlienta.Name = "StatusKlienta";
            // 
            // Disc
            // 
            this.Disc.DataPropertyName = "Rabat";
            this.Disc.HeaderText = "Rabat";
            this.Disc.Name = "Disc";
            this.Disc.ReadOnly = true;
            // 
            // ClientContextMenuStrip
            // 
            this.ClientContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ClientContextMenuStrip.Name = "contextMenuStrip1";
            this.ClientContextMenuStrip.Size = new System.Drawing.Size(106, 48);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.AddToolStripMenuItem.Text = "Dodaj";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.DeleteToolStripMenuItem.Text = "Usuń";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DiscountTabPage
            // 
            this.DiscountTabPage.Controls.Add(this.RabatyGroupBox);
            this.DiscountTabPage.Controls.Add(this.DiscountDataGridView);
            this.DiscountTabPage.Location = new System.Drawing.Point(4, 22);
            this.DiscountTabPage.Name = "DiscountTabPage";
            this.DiscountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiscountTabPage.Size = new System.Drawing.Size(749, 424);
            this.DiscountTabPage.TabIndex = 1;
            this.DiscountTabPage.Text = "Rabaty";
            this.DiscountTabPage.UseVisualStyleBackColor = true;
            // 
            // DiscountDataGridView
            // 
            this.DiscountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RName,
            this.Nname,
            this.REname,
            this.ClientStatus,
            this.Rabat});
            this.DiscountDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DiscountDataGridView.Name = "DiscountDataGridView";
            this.DiscountDataGridView.Size = new System.Drawing.Size(743, 418);
            this.DiscountDataGridView.TabIndex = 0;
            this.DiscountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellEndEdit);
            // 
            // RName
            // 
            this.RName.DataPropertyName = "ClientId";
            this.RName.HeaderText = "Id";
            this.RName.Name = "RName";
            this.RName.ReadOnly = true;
            // 
            // Nname
            // 
            this.Nname.DataPropertyName = "Nname";
            this.Nname.HeaderText = "Imię";
            this.Nname.Name = "Nname";
            this.Nname.ReadOnly = true;
            // 
            // REname
            // 
            this.REname.DataPropertyName = "Ename";
            this.REname.HeaderText = "Nazwisko";
            this.REname.Name = "REname";
            // 
            // ClientStatus
            // 
            this.ClientStatus.DataPropertyName = "ClientStatus";
            this.ClientStatus.HeaderText = "Status Klienta";
            this.ClientStatus.Name = "ClientStatus";
            // 
            // Rabat
            // 
            this.Rabat.DataPropertyName = "Rabat";
            this.Rabat.HeaderText = "Rabat";
            this.Rabat.Name = "Rabat";
            // 
            // RabatyGroupBox
            // 
            this.RabatyGroupBox.Controls.Add(this.PrzyznajRabatButton);
            this.RabatyGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RabatyGroupBox.Location = new System.Drawing.Point(3, 321);
            this.RabatyGroupBox.Name = "RabatyGroupBox";
            this.RabatyGroupBox.Size = new System.Drawing.Size(743, 100);
            this.RabatyGroupBox.TabIndex = 1;
            this.RabatyGroupBox.TabStop = false;
            // 
            // PrzyznajRabatButton
            // 
            this.PrzyznajRabatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrzyznajRabatButton.AutoSize = true;
            this.PrzyznajRabatButton.Location = new System.Drawing.Point(560, 19);
            this.PrzyznajRabatButton.Name = "PrzyznajRabatButton";
            this.PrzyznajRabatButton.Size = new System.Drawing.Size(164, 64);
            this.PrzyznajRabatButton.TabIndex = 0;
            this.PrzyznajRabatButton.Text = "Przyznaj Rabat";
            this.PrzyznajRabatButton.UseVisualStyleBackColor = true;
            this.PrzyznajRabatButton.Click += new System.EventHandler(this.PrzyznajRabatButton_Click);
            // 
            // ProjektApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 474);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.AppMenuStrip);
            this.MainMenuStrip = this.AppMenuStrip;
            this.Name = "ProjektApp";
            this.Text = "ProjektApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ClientTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ClientContextMenuStrip.ResumeLayout(false);
            this.DiscountTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountDataGridView)).EndInit();
            this.RabatyGroupBox.ResumeLayout(false);
            this.RabatyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyświetlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odwiedźStronęWWWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wAplikacjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleChromeToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ClientTabPage;
        private System.Windows.Forms.TabPage DiscountTabPage;
        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.ContextMenuStrip ClientContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView DiscountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imię;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDolaczenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nname;
        private System.Windows.Forms.DataGridViewTextBoxColumn REname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rabat;
        private System.Windows.Forms.GroupBox RabatyGroupBox;
        private System.Windows.Forms.Button PrzyznajRabatButton;
    }
}


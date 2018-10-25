namespace DosyaAdDedgistirme
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_eski_dosya_listesi = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bte_klasor_yol = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_yeniden_sırala = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_ayrac = new DevExpress.XtraEditors.TextEdit();
            this.txt_uzanti = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.list_yeni_dosya_listesi = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_basamak = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.txt_yeni_klasor_adi = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.list_eski_dosya_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bte_klasor_yol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ayrac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_uzanti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_yeni_dosya_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_basamak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_klasor_adi.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_eski_dosya_listesi
            // 
            this.list_eski_dosya_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_eski_dosya_listesi.Location = new System.Drawing.Point(0, 0);
            this.list_eski_dosya_listesi.Name = "list_eski_dosya_listesi";
            this.list_eski_dosya_listesi.Size = new System.Drawing.Size(480, 594);
            this.list_eski_dosya_listesi.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bte_klasor_yol);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1449, 73);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Klasör Seç";
            // 
            // bte_klasor_yol
            // 
            this.bte_klasor_yol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bte_klasor_yol.Location = new System.Drawing.Point(6, 33);
            this.bte_klasor_yol.Name = "bte_klasor_yol";
            this.bte_klasor_yol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bte_klasor_yol.Properties.Appearance.Options.UseFont = true;
            this.bte_klasor_yol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bte_klasor_yol.Size = new System.Drawing.Size(1420, 28);
            this.bte_klasor_yol.TabIndex = 0;
            this.bte_klasor_yol.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // btn_yeniden_sırala
            // 
            this.btn_yeniden_sırala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_yeniden_sırala.Image = ((System.Drawing.Image)(resources.GetObject("btn_yeniden_sırala.Image")));
            this.btn_yeniden_sırala.Location = new System.Drawing.Point(2, 25);
            this.btn_yeniden_sırala.Name = "btn_yeniden_sırala";
            this.btn_yeniden_sırala.Size = new System.Drawing.Size(430, 71);
            this.btn_yeniden_sırala.TabIndex = 2;
            this.btn_yeniden_sırala.Text = "Yeniden Sırala";
            this.btn_yeniden_sırala.Click += new System.EventHandler(this.btn_yeniden_sırala_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "İsimlerdeki Ayrac";
            this.textEdit1.Location = new System.Drawing.Point(9, 165);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(178, 24);
            this.textEdit1.TabIndex = 3;
            // 
            // txt_ayrac
            // 
            this.txt_ayrac.EditValue = "-";
            this.txt_ayrac.Location = new System.Drawing.Point(193, 165);
            this.txt_ayrac.Name = "txt_ayrac";
            this.txt_ayrac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ayrac.Properties.Appearance.Options.UseFont = true;
            this.txt_ayrac.Size = new System.Drawing.Size(189, 24);
            this.txt_ayrac.TabIndex = 4;
            // 
            // txt_uzanti
            // 
            this.txt_uzanti.Location = new System.Drawing.Point(193, 105);
            this.txt_uzanti.Name = "txt_uzanti";
            this.txt_uzanti.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_uzanti.Properties.Appearance.Options.UseFont = true;
            this.txt_uzanti.Properties.ReadOnly = true;
            this.txt_uzanti.Size = new System.Drawing.Size(189, 24);
            this.txt_uzanti.TabIndex = 6;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Dosya Uzantısı";
            this.textEdit3.Location = new System.Drawing.Point(9, 105);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(178, 24);
            this.textEdit3.TabIndex = 5;
            // 
            // list_yeni_dosya_listesi
            // 
            this.list_yeni_dosya_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_yeni_dosya_listesi.Location = new System.Drawing.Point(0, 0);
            this.list_yeni_dosya_listesi.Name = "list_yeni_dosya_listesi";
            this.list_yeni_dosya_listesi.Size = new System.Drawing.Size(525, 594);
            this.list_yeni_dosya_listesi.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainerControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 73);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1015, 621);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Listeler";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.list_eski_dosya_listesi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.list_yeni_dosya_listesi);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1011, 594);
            this.splitContainerControl1.SplitterPosition = 480;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panel1);
            this.groupControl3.Controls.Add(this.textEdit5);
            this.groupControl3.Controls.Add(this.txt_yeni_klasor_adi);
            this.groupControl3.Controls.Add(this.textEdit4);
            this.groupControl3.Controls.Add(this.comboBoxEdit1);
            this.groupControl3.Controls.Add(this.textEdit2);
            this.groupControl3.Controls.Add(this.txt_basamak);
            this.groupControl3.Controls.Add(this.textEdit3);
            this.groupControl3.Controls.Add(this.btn_yeniden_sırala);
            this.groupControl3.Controls.Add(this.txt_uzanti);
            this.groupControl3.Controls.Add(this.textEdit1);
            this.groupControl3.Controls.Add(this.txt_ayrac);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(1015, 73);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(434, 621);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Listeler";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Numara Kaç Basamak";
            this.textEdit2.Location = new System.Drawing.Point(9, 195);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(178, 24);
            this.textEdit2.TabIndex = 7;
            // 
            // txt_basamak
            // 
            this.txt_basamak.EditValue = "4";
            this.txt_basamak.Location = new System.Drawing.Point(193, 195);
            this.txt_basamak.Name = "txt_basamak";
            this.txt_basamak.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_basamak.Properties.Appearance.Options.UseFont = true;
            this.txt_basamak.Size = new System.Drawing.Size(189, 24);
            this.txt_basamak.TabIndex = 8;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Yeni Klasöre Koplaya";
            this.comboBoxEdit1.Location = new System.Drawing.Point(193, 135);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Yeni Klasöre Koplaya",
            "Yeni Klasöre Taşı"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(189, 24);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "İşlem Türü";
            this.textEdit4.Location = new System.Drawing.Point(9, 135);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(178, 24);
            this.textEdit4.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(4, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(285, 21);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://mustafabukulmez.com/";
            this.linkLabel1.Text = "https://mustafabukulmez.com/";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "Yeni Klasör Adı";
            this.textEdit5.Location = new System.Drawing.Point(9, 225);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Size = new System.Drawing.Size(178, 24);
            this.textEdit5.TabIndex = 11;
            // 
            // txt_yeni_klasor_adi
            // 
            this.txt_yeni_klasor_adi.EditValue = "Değiştirilen";
            this.txt_yeni_klasor_adi.Location = new System.Drawing.Point(193, 225);
            this.txt_yeni_klasor_adi.Name = "txt_yeni_klasor_adi";
            this.txt_yeni_klasor_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yeni_klasor_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_yeni_klasor_adi.Size = new System.Drawing.Size(189, 24);
            this.txt_yeni_klasor_adi.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 69);
            this.panel1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(10, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(301, 21);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "mustafabukulmez3446@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 694);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Dosya Yeniden İsimlendirme - Mustafa BÜKÜLMEZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_eski_dosya_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bte_klasor_yol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ayrac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_uzanti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_yeni_dosya_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_basamak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yeni_klasor_adi.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl list_eski_dosya_listesi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit bte_klasor_yol;
        private DevExpress.XtraEditors.SimpleButton btn_yeniden_sırala;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txt_ayrac;
        private DevExpress.XtraEditors.TextEdit txt_uzanti;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.ListBoxControl list_yeni_dosya_listesi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txt_basamak;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit txt_yeni_klasor_adi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}


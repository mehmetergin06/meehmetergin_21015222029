namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüşteriE = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriD = new System.Windows.Forms.ToolStripButton();
            this.btnMüşteriS = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnMusteriB = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUrunE = new System.Windows.Forms.ToolStripButton();
            this.btnUrunD = new System.Windows.Forms.ToolStripButton();
            this.btnUrunS = new System.Windows.Forms.ToolStripButton();
            this.btnUrunB = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MÜŞTERİLER";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 371);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriE,
            this.btnMüşteriD,
            this.btnMüşteriS,
            this.btnMusteriB,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüşteriE
            // 
            this.btnMüşteriE.Image = global::WindowsFormsApp4.Properties.Resources.royalty_free_stock_photography_computer_icons_clip_art_add_to_cart_button_a09734695fe06b078b4e7500640c5f01;
            this.btnMüşteriE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriE.Name = "btnMüşteriE";
            this.btnMüşteriE.Size = new System.Drawing.Size(48, 22);
            this.btnMüşteriE.Text = "Ekle";
            this.btnMüşteriE.Click += new System.EventHandler(this.btnMüşteriE_Click);
            // 
            // btnMüşteriD
            // 
            this.btnMüşteriD.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_editing_icon_design_download_edit_icon_orange_pencil_534a2bfd686de0bad86bf9f882b15700;
            this.btnMüşteriD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriD.Name = "btnMüşteriD";
            this.btnMüşteriD.Size = new System.Drawing.Size(69, 22);
            this.btnMüşteriD.Text = "Düzenle";
            this.btnMüşteriD.Click += new System.EventHandler(this.btnMüşteriD_Click);
            // 
            // btnMüşteriS
            // 
            this.btnMüşteriS.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_symbol_clip_art_delete_cliparts_0de16f0c421bb043cd41f69e06c182ef;
            this.btnMüşteriS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriS.Name = "btnMüşteriS";
            this.btnMüşteriS.Size = new System.Drawing.Size(39, 22);
            this.btnMüşteriS.Text = "Sil";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel1.Text = "ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            // 
            // btnMusteriB
            // 
            this.btnMusteriB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMusteriB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMusteriB.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_desktop_wallpaper_success_save_png_90ff39907f5cfe102f7f2322fd013c4a;
            this.btnMusteriB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriB.Name = "btnMusteriB";
            this.btnMusteriB.Size = new System.Drawing.Size(23, 22);
            this.btnMusteriB.Text = "Bul";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SİPARİŞLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 393);
            this.dataGridView2.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUrunE,
            this.btnUrunD,
            this.btnUrunS,
            this.btnUrunB,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnUrunE
            // 
            this.btnUrunE.Image = global::WindowsFormsApp4.Properties.Resources.royalty_free_stock_photography_computer_icons_clip_art_add_to_cart_button_a09734695fe06b078b4e7500640c5f01;
            this.btnUrunE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunE.Name = "btnUrunE";
            this.btnUrunE.Size = new System.Drawing.Size(48, 22);
            this.btnUrunE.Text = "Ekle";
            this.btnUrunE.Click += new System.EventHandler(this.btnUrunE_Click);
            // 
            // btnUrunD
            // 
            this.btnUrunD.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_editing_icon_design_download_edit_icon_orange_pencil_534a2bfd686de0bad86bf9f882b15700;
            this.btnUrunD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunD.Name = "btnUrunD";
            this.btnUrunD.Size = new System.Drawing.Size(69, 22);
            this.btnUrunD.Text = "Düzenle";
            // 
            // btnUrunS
            // 
            this.btnUrunS.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_symbol_clip_art_delete_cliparts_0de16f0c421bb043cd41f69e06c182ef;
            this.btnUrunS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunS.Name = "btnUrunS";
            this.btnUrunS.Size = new System.Drawing.Size(39, 22);
            this.btnUrunS.Text = "Sil";
            // 
            // btnUrunB
            // 
            this.btnUrunB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUrunB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUrunB.Image = global::WindowsFormsApp4.Properties.Resources.computer_icons_desktop_wallpaper_success_save_png_90ff39907f5cfe102f7f2322fd013c4a;
            this.btnUrunB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunB.Name = "btnUrunB";
            this.btnUrunB.Size = new System.Drawing.Size(23, 22);
            this.btnUrunB.Text = "Bul";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "KURUTEMİZLEME";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriD;
        private System.Windows.Forms.ToolStripButton btnMüşteriS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnMusteriB;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUrunE;
        private System.Windows.Forms.ToolStripButton btnUrunD;
        private System.Windows.Forms.ToolStripButton btnUrunS;
        private System.Windows.Forms.ToolStripButton btnUrunB;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}


namespace Projektet
{
    partial class tb
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
            this.ScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorier = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.Nykategori = new System.Windows.Forms.Button();
            this.Sparakategori = new System.Windows.Forms.Button();
            this.tabortkategori = new System.Windows.Forms.Button();
            this.lburl = new System.Windows.Forms.Label();
            this.tburl = new System.Windows.Forms.TextBox();
            this.lbfrek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbkategori = new System.Windows.Forms.Label();
            this.cboxfrek = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.Nyurl = new System.Windows.Forms.Button();
            this.Sparaurl = new System.Windows.Forms.Button();
            this.taborturl = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.ScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.lbpodcastavsnitt1 = new System.Windows.Forms.Label();
            this.lbpodcastavsnitt2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tbkategori = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScrollBar1
            // 
            this.ScrollBar1.Location = new System.Drawing.Point(539, 43);
            this.ScrollBar1.Name = "ScrollBar1";
            this.ScrollBar1.Size = new System.Drawing.Size(29, 181);
            this.ScrollBar1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_avsnitt,
            this.ch_namn,
            this.ch_frekvens,
            this.ch_kategori});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 43);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 182);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ch_avsnitt
            // 
            this.ch_avsnitt.Text = "Avsnitt";
            this.ch_avsnitt.Width = 100;
            // 
            // ch_namn
            // 
            this.ch_namn.Text = "Namn";
            this.ch_namn.Width = 200;
            // 
            // ch_frekvens
            // 
            this.ch_frekvens.Text = "Frekvens";
            this.ch_frekvens.Width = 100;
            // 
            // ch_kategori
            // 
            this.ch_kategori.Text = "Kategori";
            this.ch_kategori.Width = 100;
            // 
            // Kategorier
            // 
            this.Kategorier.AutoSize = true;
            this.Kategorier.Location = new System.Drawing.Point(719, 35);
            this.Kategorier.Name = "Kategorier";
            this.Kategorier.Size = new System.Drawing.Size(78, 17);
            this.Kategorier.TabIndex = 2;
            this.Kategorier.Text = "Kategorier:";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(723, 62);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(323, 140);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // ScrollBar2
            // 
            this.ScrollBar2.Location = new System.Drawing.Point(1048, 62);
            this.ScrollBar2.Name = "ScrollBar2";
            this.ScrollBar2.Size = new System.Drawing.Size(34, 139);
            this.ScrollBar2.TabIndex = 4;
            this.ScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // Nykategori
            // 
            this.Nykategori.Location = new System.Drawing.Point(723, 261);
            this.Nykategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nykategori.Name = "Nykategori";
            this.Nykategori.Size = new System.Drawing.Size(74, 27);
            this.Nykategori.TabIndex = 6;
            this.Nykategori.Text = "Ny..";
            this.Nykategori.UseVisualStyleBackColor = true;
            this.Nykategori.Click += new System.EventHandler(this.Nykategori_Click);
            // 
            // Sparakategori
            // 
            this.Sparakategori.Location = new System.Drawing.Point(844, 260);
            this.Sparakategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sparakategori.Name = "Sparakategori";
            this.Sparakategori.Size = new System.Drawing.Size(75, 30);
            this.Sparakategori.TabIndex = 7;
            this.Sparakategori.Text = "Spara";
            this.Sparakategori.UseVisualStyleBackColor = true;
            this.Sparakategori.Click += new System.EventHandler(this.Sparakategori_Click);
            // 
            // tabortkategori
            // 
            this.tabortkategori.Location = new System.Drawing.Point(967, 260);
            this.tabortkategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabortkategori.Name = "tabortkategori";
            this.tabortkategori.Size = new System.Drawing.Size(79, 30);
            this.tabortkategori.TabIndex = 8;
            this.tabortkategori.Text = "Ta bort..";
            this.tabortkategori.UseVisualStyleBackColor = true;
            this.tabortkategori.Click += new System.EventHandler(this.button3_Click);
            // 
            // lburl
            // 
            this.lburl.AutoSize = true;
            this.lburl.Location = new System.Drawing.Point(-1, 243);
            this.lburl.Name = "lburl";
            this.lburl.Size = new System.Drawing.Size(40, 17);
            this.lburl.TabIndex = 9;
            this.lburl.Text = "URL:";
            // 
            // tburl
            // 
            this.tburl.Location = new System.Drawing.Point(3, 264);
            this.tburl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(221, 22);
            this.tburl.TabIndex = 10;
            // 
            // lbfrek
            // 
            this.lbfrek.AutoSize = true;
            this.lbfrek.Location = new System.Drawing.Point(258, 243);
            this.lbfrek.Name = "lbfrek";
            this.lbfrek.Size = new System.Drawing.Size(151, 17);
            this.lbfrek.TabIndex = 11;
            this.lbfrek.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // lbkategori
            // 
            this.lbkategori.AutoSize = true;
            this.lbkategori.Location = new System.Drawing.Point(439, 243);
            this.lbkategori.Name = "lbkategori";
            this.lbkategori.Size = new System.Drawing.Size(65, 17);
            this.lbkategori.TabIndex = 14;
            this.lbkategori.Text = "Kategori:";
            this.lbkategori.Click += new System.EventHandler(this.lbkategori_Click);
            // 
            // cboxfrek
            // 
            this.cboxfrek.FormattingEnabled = true;
            this.cboxfrek.Location = new System.Drawing.Point(261, 264);
            this.cboxfrek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxfrek.Name = "cboxfrek";
            this.cboxfrek.Size = new System.Drawing.Size(135, 24);
            this.cboxfrek.TabIndex = 16;
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(443, 266);
            this.cbkategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(108, 24);
            this.cbkategori.TabIndex = 17;
            // 
            // Nyurl
            // 
            this.Nyurl.Location = new System.Drawing.Point(220, 307);
            this.Nyurl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nyurl.Name = "Nyurl";
            this.Nyurl.Size = new System.Drawing.Size(100, 26);
            this.Nyurl.TabIndex = 18;
            this.Nyurl.Text = "Ny..";
            this.Nyurl.UseVisualStyleBackColor = true;
            this.Nyurl.Click += new System.EventHandler(this.Nyurl_Click);
            // 
            // Sparaurl
            // 
            this.Sparaurl.Location = new System.Drawing.Point(343, 307);
            this.Sparaurl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sparaurl.Name = "Sparaurl";
            this.Sparaurl.Size = new System.Drawing.Size(84, 26);
            this.Sparaurl.TabIndex = 19;
            this.Sparaurl.Text = "Spara";
            this.Sparaurl.UseVisualStyleBackColor = true;
            // 
            // taborturl
            // 
            this.taborturl.Location = new System.Drawing.Point(454, 307);
            this.taborturl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taborturl.Name = "taborturl";
            this.taborturl.Size = new System.Drawing.Size(82, 26);
            this.taborturl.TabIndex = 20;
            this.taborturl.Text = "Ta bort..";
            this.taborturl.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 365);
            this.listView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(562, 185);
            this.listView3.TabIndex = 21;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // ScrollBar3
            // 
            this.ScrollBar3.Location = new System.Drawing.Point(567, 365);
            this.ScrollBar3.Name = "ScrollBar3";
            this.ScrollBar3.Size = new System.Drawing.Size(26, 184);
            this.ScrollBar3.TabIndex = 22;
            // 
            // lbpodcastavsnitt1
            // 
            this.lbpodcastavsnitt1.AutoSize = true;
            this.lbpodcastavsnitt1.Location = new System.Drawing.Point(11, 335);
            this.lbpodcastavsnitt1.Name = "lbpodcastavsnitt1";
            this.lbpodcastavsnitt1.Size = new System.Drawing.Size(141, 17);
            this.lbpodcastavsnitt1.TabIndex = 23;
            this.lbpodcastavsnitt1.Text = "Podcast #  : Avsnitt #";
            // 
            // lbpodcastavsnitt2
            // 
            this.lbpodcastavsnitt2.AutoSize = true;
            this.lbpodcastavsnitt2.Location = new System.Drawing.Point(710, 346);
            this.lbpodcastavsnitt2.Name = "lbpodcastavsnitt2";
            this.lbpodcastavsnitt2.Size = new System.Drawing.Size(141, 17);
            this.lbpodcastavsnitt2.TabIndex = 24;
            this.lbpodcastavsnitt2.Text = "Podcast # :  Avsnitt #";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(714, 361);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(344, 156);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // tbkategori
            // 
            this.tbkategori.Location = new System.Drawing.Point(723, 225);
            this.tbkategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.Size = new System.Drawing.Size(323, 22);
            this.tbkategori.TabIndex = 26;
            this.tbkategori.TextChanged += new System.EventHandler(this.tbkategori_TextChanged);
            // 
            // tb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 558);
            this.Controls.Add(this.tbkategori);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lbpodcastavsnitt2);
            this.Controls.Add(this.lbpodcastavsnitt1);
            this.Controls.Add(this.ScrollBar3);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.taborturl);
            this.Controls.Add(this.Sparaurl);
            this.Controls.Add(this.Nyurl);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.cboxfrek);
            this.Controls.Add(this.lbkategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbfrek);
            this.Controls.Add(this.tburl);
            this.Controls.Add(this.lburl);
            this.Controls.Add(this.tabortkategori);
            this.Controls.Add(this.Sparakategori);
            this.Controls.Add(this.Nykategori);
            this.Controls.Add(this.ScrollBar2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Kategorier);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ScrollBar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tb";
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar ScrollBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_avsnitt;
        private System.Windows.Forms.ColumnHeader ch_namn;
        private System.Windows.Forms.ColumnHeader ch_frekvens;
        private System.Windows.Forms.ColumnHeader ch_kategori;
        private System.Windows.Forms.Label Kategorier;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.VScrollBar ScrollBar2;
        private System.Windows.Forms.Button Nykategori;
        private System.Windows.Forms.Button Sparakategori;
        private System.Windows.Forms.Button tabortkategori;
        private System.Windows.Forms.Label lburl;
        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.Label lbfrek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbkategori;
        private System.Windows.Forms.ComboBox cboxfrek;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Button Nyurl;
        private System.Windows.Forms.Button Sparaurl;
        private System.Windows.Forms.Button taborturl;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.VScrollBar ScrollBar3;
        private System.Windows.Forms.Label lbpodcastavsnitt1;
        private System.Windows.Forms.Label lbpodcastavsnitt2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox tbkategori;
    }
}


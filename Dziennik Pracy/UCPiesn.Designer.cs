namespace Dziennik_Pracy
{
    partial class UCPiesn
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.shortBox = new System.Windows.Forms.ComboBox();
            this.CatBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortBox
            // 
            this.shortBox.AccessibleDescription = "Typ";
            this.shortBox.AccessibleName = "Typ";
            this.shortBox.AutoCompleteCustomSource.AddRange(new string[] {
            "W",
            "PD",
            "K",
            "D",
            "R",
            "B",
            "A",
            "N"});
            this.shortBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.shortBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.shortBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shortBox.FormattingEnabled = true;
            this.shortBox.Location = new System.Drawing.Point(3, 11);
            this.shortBox.Name = "shortBox";
            this.shortBox.Size = new System.Drawing.Size(52, 29);
            this.shortBox.TabIndex = 0;
            this.shortBox.SelectedIndexChanged += new System.EventHandler(this.shortBox_SelectedIndexChanged);
            this.shortBox.Leave += new System.EventHandler(this.shortBox_Leave);
            // 
            // CatBox
            // 
            this.CatBox.AccessibleDescription = "Kategoria";
            this.CatBox.AccessibleName = "Kategoria";
            this.CatBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CatBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CatBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CatBox.FormattingEnabled = true;
            this.CatBox.Location = new System.Drawing.Point(6, 11);
            this.CatBox.Name = "CatBox";
            this.CatBox.Size = new System.Drawing.Size(267, 29);
            this.CatBox.TabIndex = 1;
            this.CatBox.SelectedIndexChanged += new System.EventHandler(this.CatBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.AccessibleDescription = "Nazwa";
            this.NameBox.AccessibleName = "Nazwa";
            this.NameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameBox.Enabled = false;
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(18, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(455, 29);
            this.NameBox.TabIndex = 2;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shortBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 50);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CatBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(62, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 50);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NameBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(351, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 50);
            this.panel3.TabIndex = 5;
            // 
            // UCPiesn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPiesn";
            this.Size = new System.Drawing.Size(827, 50);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox shortBox;
        private System.Windows.Forms.ComboBox CatBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

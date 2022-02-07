namespace Dziennik_Pracy
{
    partial class Home
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.PanelHome = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.buttonZestaw = new System.Windows.Forms.Button();
            this.buttonObecnosc = new System.Windows.Forms.Button();
            this.buttonDane = new System.Windows.Forms.Button();
            this.buttonSprawozdanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.folderBrowserSettings = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.PanelHome.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.ColumnCount = 2;
            this.PanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelHome.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.PanelHome.Controls.Add(this.buttonZestaw, 1, 1);
            this.PanelHome.Controls.Add(this.buttonObecnosc, 1, 2);
            this.PanelHome.Controls.Add(this.buttonDane, 1, 3);
            this.PanelHome.Controls.Add(this.buttonSprawozdanie, 1, 4);
            this.PanelHome.Controls.Add(this.label1, 0, 1);
            this.PanelHome.Controls.Add(this.label2, 0, 2);
            this.PanelHome.Controls.Add(this.label3, 0, 3);
            this.PanelHome.Controls.Add(this.label4, 0, 4);
            this.PanelHome.Controls.Add(this.settingsButton, 0, 5);
            this.PanelHome.Controls.Add(this.exitButton, 1, 5);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.RowCount = 6;
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelHome.Size = new System.Drawing.Size(484, 262);
            this.PanelHome.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.PanelHome.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.LabelWelcome);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(481, 59);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "DZIENNIK PRACY";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonZestaw
            // 
            this.buttonZestaw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonZestaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZestaw.Location = new System.Drawing.Point(245, 68);
            this.buttonZestaw.Name = "buttonZestaw";
            this.buttonZestaw.Size = new System.Drawing.Size(236, 33);
            this.buttonZestaw.TabIndex = 1;
            this.buttonZestaw.Text = "Utwórz zestaw";
            this.buttonZestaw.UseVisualStyleBackColor = false;
            this.buttonZestaw.Click += new System.EventHandler(this.buttonZestaw_Click);
            // 
            // buttonObecnosc
            // 
            this.buttonObecnosc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonObecnosc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonObecnosc.Location = new System.Drawing.Point(245, 107);
            this.buttonObecnosc.Name = "buttonObecnosc";
            this.buttonObecnosc.Size = new System.Drawing.Size(236, 33);
            this.buttonObecnosc.TabIndex = 2;
            this.buttonObecnosc.Text = "Zgłoś czas pracy";
            this.buttonObecnosc.UseVisualStyleBackColor = false;
            this.buttonObecnosc.Click += new System.EventHandler(this.buttonObecnosc_Click);
            // 
            // buttonDane
            // 
            this.buttonDane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDane.Location = new System.Drawing.Point(245, 146);
            this.buttonDane.Name = "buttonDane";
            this.buttonDane.Size = new System.Drawing.Size(236, 33);
            this.buttonDane.TabIndex = 3;
            this.buttonDane.Text = "Wyświetl dane";
            this.buttonDane.UseVisualStyleBackColor = false;
            this.buttonDane.Click += new System.EventHandler(this.buttonDane_Click);
            // 
            // buttonSprawozdanie
            // 
            this.buttonSprawozdanie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSprawozdanie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSprawozdanie.Location = new System.Drawing.Point(245, 185);
            this.buttonSprawozdanie.Name = "buttonSprawozdanie";
            this.buttonSprawozdanie.Size = new System.Drawing.Size(236, 33);
            this.buttonSprawozdanie.TabIndex = 4;
            this.buttonSprawozdanie.Text = "Druk sprawozdania";
            this.buttonSprawozdanie.UseVisualStyleBackColor = false;
            this.buttonSprawozdanie.Click += new System.EventHandler(this.buttonSprawozdanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodaj zestaw";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zapisz obecność";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wyświetl zestaw";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utwórz sprawozdanie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.Location = new System.Drawing.Point(3, 224);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(236, 35);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Ustawienia aplikacji";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Wybór folderu";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(245, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(236, 35);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Wyjście";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.PanelHome);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik pracy";
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.Button buttonZestaw;
        private System.Windows.Forms.Button buttonObecnosc;
        private System.Windows.Forms.Button buttonDane;
        private System.Windows.Forms.Button buttonSprawozdanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSettings;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button exitButton;
    }
}


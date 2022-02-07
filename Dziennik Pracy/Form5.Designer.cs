namespace Dziennik_Pracy
{
    partial class zestawy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zestawy));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazwaZestawu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.radioLabel1 = new System.Windows.Forms.Label();
            this.nazwaRadioB = new System.Windows.Forms.RadioButton();
            this.radioLabel2 = new System.Windows.Forms.Label();
            this.dataRadioB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.excButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaZestawu,
            this.Data,
            this.Typ,
            this.Nazwa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // NazwaZestawu
            // 
            this.NazwaZestawu.Frozen = true;
            this.NazwaZestawu.HeaderText = "Nazwa";
            this.NazwaZestawu.Name = "NazwaZestawu";
            this.NazwaZestawu.ReadOnly = true;
            this.NazwaZestawu.Width = 400;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Typ
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Typ.DefaultCellStyle = dataGridViewCellStyle1;
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            this.Typ.Width = 50;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nazwa.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nazwa.HeaderText = "Nazwa pieśni";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // excButton
            // 
            this.excButton.BackColor = System.Drawing.Color.Transparent;
            this.excButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excButton.FlatAppearance.BorderSize = 0;
            this.excButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.excButton.Image = global::Dziennik_Pracy.Properties.Resources.abort_32;
            this.excButton.Location = new System.Drawing.Point(3, 548);
            this.excButton.Name = "excButton";
            this.excButton.Size = new System.Drawing.Size(50, 40);
            this.excButton.TabIndex = 1;
            this.excButton.UseVisualStyleBackColor = false;
            this.excButton.Click += new System.EventHandler(this.excButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nazwaRadioB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioLabel2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataRadioB, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 473);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 69);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(1059, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 29);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.textLabel.Location = new System.Drawing.Point(41, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(191, 34);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Poszukiwany ciąg znaków";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.searchBox, 3);
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Location = new System.Drawing.Point(238, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(699, 26);
            this.searchBox.TabIndex = 2;
            // 
            // radioLabel1
            // 
            this.radioLabel1.AutoSize = true;
            this.radioLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioLabel1.Location = new System.Drawing.Point(44, 34);
            this.radioLabel1.Name = "radioLabel1";
            this.radioLabel1.Size = new System.Drawing.Size(188, 35);
            this.radioLabel1.TabIndex = 3;
            this.radioLabel1.Text = "Szukaj w nazwie zestawu";
            this.radioLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nazwaRadioB
            // 
            this.nazwaRadioB.AutoSize = true;
            this.nazwaRadioB.Checked = true;
            this.nazwaRadioB.Dock = System.Windows.Forms.DockStyle.Left;
            this.nazwaRadioB.Location = new System.Drawing.Point(238, 37);
            this.nazwaRadioB.Name = "nazwaRadioB";
            this.nazwaRadioB.Size = new System.Drawing.Size(138, 29);
            this.nazwaRadioB.TabIndex = 4;
            this.nazwaRadioB.TabStop = true;
            this.nazwaRadioB.Text = "Nazwa zestawu";
            this.nazwaRadioB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nazwaRadioB.UseVisualStyleBackColor = true;
            // 
            // radioLabel2
            // 
            this.radioLabel2.AutoSize = true;
            this.radioLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioLabel2.Location = new System.Drawing.Point(525, 34);
            this.radioLabel2.Name = "radioLabel2";
            this.radioLabel2.Size = new System.Drawing.Size(177, 35);
            this.radioLabel2.TabIndex = 5;
            this.radioLabel2.Text = "Szukaj w dacie zestawu";
            this.radioLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataRadioB
            // 
            this.dataRadioB.AutoSize = true;
            this.dataRadioB.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataRadioB.Location = new System.Drawing.Point(708, 37);
            this.dataRadioB.Name = "dataRadioB";
            this.dataRadioB.Size = new System.Drawing.Size(125, 29);
            this.dataRadioB.TabIndex = 6;
            this.dataRadioB.Text = "Data zestawu";
            this.dataRadioB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataRadioB.UseVisualStyleBackColor = true;
            // 
            // zestawy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "zestawy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik pracy | Zestawy";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaZestawu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.Button excButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label radioLabel1;
        private System.Windows.Forms.RadioButton nazwaRadioB;
        private System.Windows.Forms.Label radioLabel2;
        private System.Windows.Forms.RadioButton dataRadioB;
    }
}
namespace Dziennik_Pracy
{
    partial class UtworzZestaw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtworzZestaw));
            this.PanelZestaw = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CanceledButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ucPiesn15 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn14 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn13 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn12 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn11 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn10 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn9 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn8 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn7 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn6 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn5 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn4 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn3 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn2 = new Dziennik_Pracy.UCPiesn();
            this.ucPiesn1 = new Dziennik_Pracy.UCPiesn();
            this.labelNazwa = new System.Windows.Forms.Label();
            this.NazwaBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelZestaw.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelZestaw
            // 
            this.PanelZestaw.ColumnCount = 3;
            this.PanelZestaw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelZestaw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelZestaw.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PanelZestaw.Controls.Add(this.SaveButton, 2, 2);
            this.PanelZestaw.Controls.Add(this.CanceledButton, 0, 2);
            this.PanelZestaw.Controls.Add(this.refreshButton, 1, 2);
            this.PanelZestaw.Controls.Add(this.MainPanel, 0, 1);
            this.PanelZestaw.Controls.Add(this.labelNazwa, 1, 0);
            this.PanelZestaw.Controls.Add(this.NazwaBox, 2, 0);
            this.PanelZestaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelZestaw.Location = new System.Drawing.Point(0, 0);
            this.PanelZestaw.Name = "PanelZestaw";
            this.PanelZestaw.RowCount = 3;
            this.PanelZestaw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PanelZestaw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PanelZestaw.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelZestaw.Size = new System.Drawing.Size(832, 911);
            this.PanelZestaw.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoEllipsis = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = global::Dziennik_Pracy.Properties.Resources.save_32;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(754, 822);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 86);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.UseCompatibleTextRendering = true;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CanceledButton
            // 
            this.CanceledButton.AccessibleDescription = "Przycisk wyjścia z okna.";
            this.CanceledButton.AccessibleName = "Escape";
            this.CanceledButton.AutoEllipsis = true;
            this.CanceledButton.BackColor = System.Drawing.Color.Transparent;
            this.CanceledButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanceledButton.FlatAppearance.BorderSize = 0;
            this.CanceledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanceledButton.Image = global::Dziennik_Pracy.Properties.Resources.abort_32;
            this.CanceledButton.Location = new System.Drawing.Point(3, 822);
            this.CanceledButton.Name = "CanceledButton";
            this.CanceledButton.Size = new System.Drawing.Size(77, 86);
            this.CanceledButton.TabIndex = 28;
            this.CanceledButton.UseVisualStyleBackColor = false;
            this.CanceledButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImage = global::Dziennik_Pracy.Properties.Resources.refresh_32;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Location = new System.Drawing.Point(86, 822);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 86);
            this.refreshButton.TabIndex = 43;
            this.toolTip1.SetToolTip(this.refreshButton, "Odświeżenie listy pieśni");
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.PanelZestaw.SetColumnSpan(this.MainPanel, 3);
            this.MainPanel.Controls.Add(this.ucPiesn15);
            this.MainPanel.Controls.Add(this.ucPiesn14);
            this.MainPanel.Controls.Add(this.ucPiesn13);
            this.MainPanel.Controls.Add(this.ucPiesn12);
            this.MainPanel.Controls.Add(this.ucPiesn11);
            this.MainPanel.Controls.Add(this.ucPiesn10);
            this.MainPanel.Controls.Add(this.ucPiesn9);
            this.MainPanel.Controls.Add(this.ucPiesn8);
            this.MainPanel.Controls.Add(this.ucPiesn7);
            this.MainPanel.Controls.Add(this.ucPiesn6);
            this.MainPanel.Controls.Add(this.ucPiesn5);
            this.MainPanel.Controls.Add(this.ucPiesn4);
            this.MainPanel.Controls.Add(this.ucPiesn3);
            this.MainPanel.Controls.Add(this.ucPiesn2);
            this.MainPanel.Controls.Add(this.ucPiesn1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 48);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(826, 768);
            this.MainPanel.TabIndex = 45;
            // 
            // ucPiesn15
            // 
            this.ucPiesn15.Category = null;
            this.ucPiesn15.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn15.Location = new System.Drawing.Point(0, 700);
            this.ucPiesn15.Name = "ucPiesn15";
            this.ucPiesn15.Nameof = null;
            this.ucPiesn15.Piesni = null;
            this.ucPiesn15.Short = null;
            this.ucPiesn15.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn15.TabIndex = 14;
            this.ucPiesn15.ChooseCategory += new System.EventHandler(this.UcPiesn15_ChooseCategory);
            // 
            // ucPiesn14
            // 
            this.ucPiesn14.Category = null;
            this.ucPiesn14.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn14.Location = new System.Drawing.Point(0, 650);
            this.ucPiesn14.Name = "ucPiesn14";
            this.ucPiesn14.Nameof = null;
            this.ucPiesn14.Piesni = null;
            this.ucPiesn14.Short = null;
            this.ucPiesn14.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn14.TabIndex = 13;
            this.ucPiesn14.ChooseCategory += new System.EventHandler(this.UcPiesn14_ChooseCategory);
            // 
            // ucPiesn13
            // 
            this.ucPiesn13.Category = null;
            this.ucPiesn13.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn13.Location = new System.Drawing.Point(0, 600);
            this.ucPiesn13.Name = "ucPiesn13";
            this.ucPiesn13.Nameof = null;
            this.ucPiesn13.Piesni = null;
            this.ucPiesn13.Short = null;
            this.ucPiesn13.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn13.TabIndex = 12;
            this.ucPiesn13.ChooseCategory += new System.EventHandler(this.UcPiesn13_ChooseCategory);
            // 
            // ucPiesn12
            // 
            this.ucPiesn12.Category = null;
            this.ucPiesn12.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn12.Location = new System.Drawing.Point(0, 550);
            this.ucPiesn12.Name = "ucPiesn12";
            this.ucPiesn12.Nameof = null;
            this.ucPiesn12.Piesni = null;
            this.ucPiesn12.Short = null;
            this.ucPiesn12.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn12.TabIndex = 11;
            this.ucPiesn12.ChooseCategory += new System.EventHandler(this.UcPiesn12_ChooseCategory);
            // 
            // ucPiesn11
            // 
            this.ucPiesn11.Category = null;
            this.ucPiesn11.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn11.Location = new System.Drawing.Point(0, 500);
            this.ucPiesn11.Name = "ucPiesn11";
            this.ucPiesn11.Nameof = null;
            this.ucPiesn11.Piesni = null;
            this.ucPiesn11.Short = null;
            this.ucPiesn11.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn11.TabIndex = 10;
            this.ucPiesn11.ChooseCategory += new System.EventHandler(this.UcPiesn11_ChooseCategory);
            // 
            // ucPiesn10
            // 
            this.ucPiesn10.Category = null;
            this.ucPiesn10.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn10.Location = new System.Drawing.Point(0, 450);
            this.ucPiesn10.Name = "ucPiesn10";
            this.ucPiesn10.Nameof = null;
            this.ucPiesn10.Piesni = null;
            this.ucPiesn10.Short = null;
            this.ucPiesn10.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn10.TabIndex = 9;
            this.ucPiesn10.ChooseCategory += new System.EventHandler(this.UcPiesn10_ChooseCategory);
            // 
            // ucPiesn9
            // 
            this.ucPiesn9.Category = null;
            this.ucPiesn9.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn9.Location = new System.Drawing.Point(0, 400);
            this.ucPiesn9.Name = "ucPiesn9";
            this.ucPiesn9.Nameof = null;
            this.ucPiesn9.Piesni = null;
            this.ucPiesn9.Short = null;
            this.ucPiesn9.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn9.TabIndex = 8;
            this.ucPiesn9.ChooseCategory += new System.EventHandler(this.UcPiesn9_ChooseCategory);
            // 
            // ucPiesn8
            // 
            this.ucPiesn8.Category = null;
            this.ucPiesn8.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn8.Location = new System.Drawing.Point(0, 350);
            this.ucPiesn8.Name = "ucPiesn8";
            this.ucPiesn8.Nameof = null;
            this.ucPiesn8.Piesni = null;
            this.ucPiesn8.Short = null;
            this.ucPiesn8.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn8.TabIndex = 7;
            this.ucPiesn8.ChooseCategory += new System.EventHandler(this.UcPiesn8_ChooseCategory);
            // 
            // ucPiesn7
            // 
            this.ucPiesn7.Category = null;
            this.ucPiesn7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn7.Location = new System.Drawing.Point(0, 300);
            this.ucPiesn7.Name = "ucPiesn7";
            this.ucPiesn7.Nameof = null;
            this.ucPiesn7.Piesni = null;
            this.ucPiesn7.Short = null;
            this.ucPiesn7.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn7.TabIndex = 6;
            this.ucPiesn7.ChooseCategory += new System.EventHandler(this.UcPiesn7_ChooseCategory);
            // 
            // ucPiesn6
            // 
            this.ucPiesn6.Category = null;
            this.ucPiesn6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn6.Location = new System.Drawing.Point(0, 250);
            this.ucPiesn6.Name = "ucPiesn6";
            this.ucPiesn6.Nameof = null;
            this.ucPiesn6.Piesni = null;
            this.ucPiesn6.Short = null;
            this.ucPiesn6.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn6.TabIndex = 5;
            this.ucPiesn6.ChooseCategory += new System.EventHandler(this.UcPiesn6_ChooseCategory);
            // 
            // ucPiesn5
            // 
            this.ucPiesn5.Category = null;
            this.ucPiesn5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn5.Location = new System.Drawing.Point(0, 200);
            this.ucPiesn5.Name = "ucPiesn5";
            this.ucPiesn5.Nameof = null;
            this.ucPiesn5.Piesni = null;
            this.ucPiesn5.Short = null;
            this.ucPiesn5.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn5.TabIndex = 4;
            this.ucPiesn5.ChooseCategory += new System.EventHandler(this.UcPiesn5_ChooseCategory);
            // 
            // ucPiesn4
            // 
            this.ucPiesn4.Category = null;
            this.ucPiesn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn4.Location = new System.Drawing.Point(0, 150);
            this.ucPiesn4.Name = "ucPiesn4";
            this.ucPiesn4.Nameof = null;
            this.ucPiesn4.Piesni = null;
            this.ucPiesn4.Short = null;
            this.ucPiesn4.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn4.TabIndex = 3;
            this.ucPiesn4.ChooseCategory += new System.EventHandler(this.UcPiesn4_ChooseCategory);
            // 
            // ucPiesn3
            // 
            this.ucPiesn3.Category = null;
            this.ucPiesn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn3.Location = new System.Drawing.Point(0, 100);
            this.ucPiesn3.Name = "ucPiesn3";
            this.ucPiesn3.Nameof = null;
            this.ucPiesn3.Piesni = null;
            this.ucPiesn3.Short = null;
            this.ucPiesn3.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn3.TabIndex = 2;
            this.ucPiesn3.ChooseCategory += new System.EventHandler(this.UcPiesn3_ChooseCategory);
            // 
            // ucPiesn2
            // 
            this.ucPiesn2.Category = null;
            this.ucPiesn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn2.Location = new System.Drawing.Point(0, 50);
            this.ucPiesn2.Name = "ucPiesn2";
            this.ucPiesn2.Nameof = null;
            this.ucPiesn2.Piesni = null;
            this.ucPiesn2.Short = null;
            this.ucPiesn2.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn2.TabIndex = 1;
            this.ucPiesn2.ChooseCategory += new System.EventHandler(this.UcPiesn2_ChooseCategory);
            // 
            // ucPiesn1
            // 
            this.ucPiesn1.Category = null;
            this.ucPiesn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPiesn1.Location = new System.Drawing.Point(0, 0);
            this.ucPiesn1.Name = "ucPiesn1";
            this.ucPiesn1.Nameof = null;
            this.ucPiesn1.Piesni = null;
            this.ucPiesn1.Short = null;
            this.ucPiesn1.Size = new System.Drawing.Size(826, 50);
            this.ucPiesn1.TabIndex = 0;
            this.ucPiesn1.ChooseCategory += new System.EventHandler(this.UcPiesn1_ChooseCategory);
            // 
            // labelNazwa
            // 
            this.labelNazwa.AutoSize = true;
            this.labelNazwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNazwa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwa.Location = new System.Drawing.Point(86, 0);
            this.labelNazwa.Name = "labelNazwa";
            this.labelNazwa.Size = new System.Drawing.Size(77, 45);
            this.labelNazwa.TabIndex = 46;
            this.labelNazwa.Text = "Nazwa";
            this.labelNazwa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NazwaBox
            // 
            this.NazwaBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1 Niedziela zwykła rok A",
            "1 Niedziela zwykła rok B",
            "1 Niedziela zwykła rok C",
            "1 Tydzień zwykły - Poniedziałek",
            "1 Tydzień zwykły - Wtorek",
            "1 Tydzień zwykły - Środa",
            "1 Tydzień zwykły - Czwartek",
            "1 Tydzień zwykły - Piątek",
            "1 Tydzień zwykły - Sobota",
            "2 Niedziela zwykła rok A",
            "2 Niedziela zwykła rok B",
            "2 Niedziela zwykła rok C",
            "2 Tydzień zwykły - Poniedziałek",
            "2 Tydzień zwykły - Wtorek",
            "2 Tydzień zwykły - Środa",
            "2 Tydzień zwykły - Czwartek",
            "2 Tydzień zwykły - Piątek",
            "2 Tydzień zwykły - Sobota",
            "3 Niedziela zwykła rok A",
            "3 Niedziela zwykła rok B",
            "3 Niedziela zwykła rok C",
            "3 Tydzień zwykły - Poniedziałek",
            "3 Tydzień zwykły - Wtorek",
            "3 Tydzień zwykły - Środa",
            "3 Tydzień zwykły - Czwartek",
            "3 Tydzień zwykły - Piątek",
            "3 Tydzień zwykły - Sobota",
            "4 Niedziela zwykła rok A",
            "4 Niedziela zwykła rok B",
            "4 Niedziela zwykła rok C",
            "4 Tydzień zwykły - Poniedziałek",
            "4 Tydzień zwykły - Wtorek",
            "4 Tydzień zwykły - Środa",
            "4 Tydzień zwykły - Czwartek",
            "4 Tydzień zwykły - Piątek",
            "4 Tydzień zwykły - Sobota",
            "5 Niedziela zwykła rok A",
            "5 Niedziela zwykła rok B",
            "5 Niedziela zwykła rok C",
            "5 Tydzień zwykły - Poniedziałek",
            "5 Tydzień zwykły - Wtorek",
            "5 Tydzień zwykły - Środa",
            "5 Tydzień zwykły - Czwartek",
            "5 Tydzień zwykły - Piątek",
            "5 Tydzień zwykły - Sobota",
            "6 Niedziela zwykła rok A",
            "6 Niedziela zwykła rok B",
            "6 Niedziela zwykła rok C",
            "6 Tydzień zwykły - Poniedziałek",
            "6 Tydzień zwykły - Wtorek",
            "6 Tydzień zwykły - Środa",
            "6 Tydzień zwykły - Czwartek",
            "6 Tydzień zwykły - Piątek",
            "6 Tydzień zwykły - Sobota",
            "7 Niedziela zwykła rok A",
            "7 Niedziela zwykła rok B",
            "7 Niedziela zwykła rok C",
            "7 Tydzień zwykły - Poniedziałek",
            "7 Tydzień zwykły - Wtorek",
            "7 Tydzień zwykły - Środa",
            "7 Tydzień zwykły - Czwartek",
            "7 Tydzień zwykły - Piątek",
            "7 Tydzień zwykły - Sobota",
            "8 Niedziela zwykła rok A",
            "8 Niedziela zwykła rok B",
            "8 Niedziela zwykła rok C",
            "8 Tydzień zwykły - Poniedziałek",
            "8 Tydzień zwykły - Wtorek",
            "8 Tydzień zwykły - Środa",
            "8 Tydzień zwykły - Czwartek",
            "8 Tydzień zwykły - Piątek",
            "8 Tydzień zwykły - Sobota",
            "9 Niedziela zwykła rok A",
            "9 Niedziela zwykła rok B",
            "9 Niedziela zwykła rok C",
            "9 Tydzień zwykły - Poniedziałek",
            "9 Tydzień zwykły - Wtorek",
            "9 Tydzień zwykły - Środa",
            "9 Tydzień zwykły - Czwartek",
            "9 Tydzień zwykły - Piątek",
            "9 Tydzień zwykły - Sobota",
            "10 Niedziela zwykła rok A",
            "10 Niedziela zwykła rok B",
            "10 Niedziela zwykła rok C",
            "10 Tydzień zwykły - Poniedziałek",
            "10 Tydzień zwykły - Wtorek",
            "10 Tydzień zwykły - Środa",
            "10 Tydzień zwykły - Czwartek",
            "10 Tydzień zwykły - Piątek",
            "10 Tydzień zwykły - Sobota",
            "11 Niedziela zwykła rok A",
            "11 Niedziela zwykła rok B",
            "11 Niedziela zwykła rok C",
            "11 Tydzień zwykły - Poniedziałek",
            "11 Tydzień zwykły - Wtorek",
            "11 Tydzień zwykły - Środa",
            "11 Tydzień zwykły - Czwartek",
            "11 Tydzień zwykły - Piątek",
            "11 Tydzień zwykły - Sobota",
            "12 Niedziela zwykła rok A",
            "12 Niedziela zwykła rok B",
            "12 Niedziela zwykła rok C",
            "12 Tydzień zwykły - Poniedziałek",
            "12 Tydzień zwykły - Wtorek",
            "12 Tydzień zwykły - Środa",
            "12 Tydzień zwykły - Czwartek",
            "12 Tydzień zwykły - Piątek",
            "12 Tydzień zwykły - Sobota",
            "13 Niedziela zwykła rok A",
            "13 Niedziela zwykła rok B",
            "13 Niedziela zwykła rok C",
            "13 Tydzień zwykły - Poniedziałek",
            "13 Tydzień zwykły - Wtorek",
            "13 Tydzień zwykły - Środa",
            "13 Tydzień zwykły - Czwartek",
            "13 Tydzień zwykły - Piątek",
            "13 Tydzień zwykły - Sobota",
            "14 Niedziela zwykła rok A",
            "14 Niedziela zwykła rok B",
            "14 Niedziela zwykła rok C",
            "14 Tydzień zwykły - Poniedziałek",
            "14 Tydzień zwykły - Wtorek",
            "14 Tydzień zwykły - Środa",
            "14 Tydzień zwykły - Czwartek",
            "14 Tydzień zwykły - Piątek",
            "14 Tydzień zwykły - Sobota",
            "15 Niedziela zwykła rok A",
            "15 Niedziela zwykła rok B",
            "15 Niedziela zwykła rok C",
            "15 Tydzień zwykły - Poniedziałek",
            "15 Tydzień zwykły - Wtorek",
            "15 Tydzień zwykły - Środa",
            "15 Tydzień zwykły - Czwartek",
            "15 Tydzień zwykły - Piątek",
            "15 Tydzień zwykły - Sobota",
            "16 Niedziela zwykła rok A",
            "16 Niedziela zwykła rok B",
            "16 Niedziela zwykła rok C",
            "16 Tydzień zwykły - Poniedziałek",
            "16 Tydzień zwykły - Wtorek",
            "16 Tydzień zwykły - Środa",
            "16 Tydzień zwykły - Czwartek",
            "16 Tydzień zwykły - Piątek",
            "16 Tydzień zwykły - Sobota",
            "17 Niedziela zwykła rok A",
            "17 Niedziela zwykła rok B",
            "17 Niedziela zwykła rok C",
            "17 Tydzień zwykły - Poniedziałek",
            "17 Tydzień zwykły - Wtorek",
            "17 Tydzień zwykły - Środa",
            "17 Tydzień zwykły - Czwartek",
            "17 Tydzień zwykły - Piątek",
            "17 Tydzień zwykły - Sobota",
            "18 Niedziela zwykła rok A",
            "18 Niedziela zwykła rok B",
            "18 Niedziela zwykła rok C",
            "18 Tydzień zwykły - Poniedziałek",
            "18 Tydzień zwykły - Wtorek",
            "18 Tydzień zwykły - Środa",
            "18 Tydzień zwykły - Czwartek",
            "18 Tydzień zwykły - Piątek",
            "18 Tydzień zwykły - Sobota",
            "19 Niedziela zwykła rok A",
            "19 Niedziela zwykła rok B",
            "19 Niedziela zwykła rok C",
            "19 Tydzień zwykły - Poniedziałek",
            "19 Tydzień zwykły - Wtorek",
            "19 Tydzień zwykły - Środa",
            "19 Tydzień zwykły - Czwartek",
            "19 Tydzień zwykły - Piątek",
            "19 Tydzień zwykły - Sobota",
            "20 Niedziela zwykła rok A",
            "20 Niedziela zwykła rok B",
            "20 Niedziela zwykła rok C",
            "20 Tydzień zwykły - Poniedziałek",
            "20 Tydzień zwykły - Wtorek",
            "20 Tydzień zwykły - Środa",
            "20 Tydzień zwykły - Czwartek",
            "20 Tydzień zwykły - Piątek",
            "20 Tydzień zwykły - Sobota",
            "21 Niedziela zwykła rok A",
            "21 Niedziela zwykła rok B",
            "21 Niedziela zwykła rok C",
            "21 Tydzień zwykły - Poniedziałek",
            "21 Tydzień zwykły - Wtorek",
            "21 Tydzień zwykły - Środa",
            "21 Tydzień zwykły - Czwartek",
            "21 Tydzień zwykły - Piątek",
            "21 Tydzień zwykły - Sobota",
            "22 Niedziela zwykła rok A",
            "22 Niedziela zwykła rok B",
            "22 Niedziela zwykła rok C",
            "22 Tydzień zwykły - Poniedziałek",
            "22 Tydzień zwykły - Wtorek",
            "22 Tydzień zwykły - Środa",
            "22 Tydzień zwykły - Czwartek",
            "22 Tydzień zwykły - Piątek",
            "22 Tydzień zwykły - Sobota",
            "23 Niedziela zwykła rok A",
            "23 Niedziela zwykła rok B",
            "23 Niedziela zwykła rok C",
            "23 Tydzień zwykły - Poniedziałek",
            "23 Tydzień zwykły - Wtorek",
            "23 Tydzień zwykły - Środa",
            "23 Tydzień zwykły - Czwartek",
            "23 Tydzień zwykły - Piątek",
            "23 Tydzień zwykły - Sobota",
            "24 Niedziela zwykła rok A",
            "24 Niedziela zwykła rok B",
            "24 Niedziela zwykła rok C",
            "24 Tydzień zwykły - Poniedziałek",
            "24 Tydzień zwykły - Wtorek",
            "24 Tydzień zwykły - Środa",
            "24 Tydzień zwykły - Czwartek",
            "24 Tydzień zwykły - Piątek",
            "24 Tydzień zwykły - Sobota",
            "25 Niedziela zwykła rok A",
            "25 Niedziela zwykła rok B",
            "25 Niedziela zwykła rok C",
            "25 Tydzień zwykły - Poniedziałek",
            "25 Tydzień zwykły - Wtorek",
            "25 Tydzień zwykły - Środa",
            "25 Tydzień zwykły - Czwartek",
            "25 Tydzień zwykły - Piątek",
            "25 Tydzień zwykły - Sobota",
            "26 Niedziela zwykła rok A",
            "26 Niedziela zwykła rok B",
            "26 Niedziela zwykła rok C",
            "26 Tydzień zwykły - Poniedziałek",
            "26 Tydzień zwykły - Wtorek",
            "26 Tydzień zwykły - Środa",
            "26 Tydzień zwykły - Czwartek",
            "26 Tydzień zwykły - Piątek",
            "26 Tydzień zwykły - Sobota",
            "27 Niedziela zwykła rok A",
            "27 Niedziela zwykła rok B",
            "27 Niedziela zwykła rok C",
            "27 Tydzień zwykły - Poniedziałek",
            "27 Tydzień zwykły - Wtorek",
            "27 Tydzień zwykły - Środa",
            "27 Tydzień zwykły - Czwartek",
            "27 Tydzień zwykły - Piątek",
            "27 Tydzień zwykły - Sobota",
            "28 Niedziela zwykła rok A",
            "28 Niedziela zwykła rok B",
            "28 Niedziela zwykła rok C",
            "28 Tydzień zwykły - Poniedziałek",
            "28 Tydzień zwykły - Wtorek",
            "28 Tydzień zwykły - Środa",
            "28 Tydzień zwykły - Czwartek",
            "28 Tydzień zwykły - Piątek",
            "28 Tydzień zwykły - Sobota",
            "29 Niedziela zwykła rok A",
            "29 Niedziela zwykła rok B",
            "29 Niedziela zwykła rok C",
            "29 Tydzień zwykły - Poniedziałek",
            "29 Tydzień zwykły - Wtorek",
            "29 Tydzień zwykły - Środa",
            "29 Tydzień zwykły - Czwartek",
            "29 Tydzień zwykły - Piątek",
            "29 Tydzień zwykły - Sobota",
            "30 Niedziela zwykła rok A",
            "30 Niedziela zwykła rok B",
            "30 Niedziela zwykła rok C",
            "30 Tydzień zwykły - Poniedziałek",
            "30 Tydzień zwykły - Wtorek",
            "30 Tydzień zwykły - Środa",
            "30 Tydzień zwykły - Czwartek",
            "30 Tydzień zwykły - Piątek",
            "30 Tydzień zwykły - Sobota",
            "31 Niedziela zwykła rok A",
            "31 Niedziela zwykła rok B",
            "31 Niedziela zwykła rok C",
            "31 Tydzień zwykły - Poniedziałek",
            "31 Tydzień zwykły - Wtorek",
            "31 Tydzień zwykły - Środa",
            "31 Tydzień zwykły - Czwartek",
            "31 Tydzień zwykły - Piątek",
            "31 Tydzień zwykły - Sobota",
            "32 Niedziela zwykła rok A",
            "32 Niedziela zwykła rok B",
            "32 Niedziela zwykła rok C",
            "32 Tydzień zwykły - Poniedziałek",
            "32 Tydzień zwykły - Wtorek",
            "32 Tydzień zwykły - Środa",
            "32 Tydzień zwykły - Czwartek",
            "32 Tydzień zwykły - Piątek",
            "32 Tydzień zwykły - Sobota",
            "33 Niedziela zwykła rok A",
            "33 Niedziela zwykła rok B",
            "33 Niedziela zwykła rok C",
            "33 Tydzień zwykły - Poniedziałek",
            "33 Tydzień zwykły - Wtorek",
            "33 Tydzień zwykły - Środa",
            "33 Tydzień zwykły - Czwartek",
            "33 Tydzień zwykły - Piątek",
            "33 Tydzień zwykły - Sobota",
            "Uroczystość Chrystusa Króla rok A",
            "Uroczystość Chrystusa Króla rok B",
            "Uroczystość Chrystusa Króla rok C",
            "34 Tydzień zwykły - Poniedziałek",
            "34 Tydzień zwykły - Wtorek",
            "34 Tydzień zwykły - Środa",
            "34 Tydzień zwykły - Czwartek",
            "34 Tydzień zwykły - Piątek",
            "34 Tydzień zwykły - Sobota",
            "Uroczystość Wszystkich Świętych",
            "Uroczystość Bożego Narodzenia",
            "Święto św. Szczepana",
            "Święto Ofiarowania Pańskiego",
            "Święto Objawienia Pańskiego",
            "Uroczystość Najświętszego Ciała i Krwi Chrystusa",
            "Uroczystość Wniebowstąpienia Pana Jezusa",
            "Uroczystość Zesłania Ducha Świętego",
            "Uroczystość Wniebowzięcia NMP",
            "Uroczystość NMP Królowej Korony Polskiej",
            "Uroczystość NMP Częstochowskiej",
            "Uroczystość św. Wojciecha",
            "Święto św. Apostołów Filipa i Jakuba",
            "Święto rocznicy poświęcenia Bazyliki Archikatedralnej",
            "Uroczystość św. Stanisława",
            "Święto św. Kazimierza",
            "Święto św. Macieja  - Apostoła",
            "Święto NMP Matki Kościoła",
            "Święto Nawiedzenia NMP",
            "Utoczystość Najświętszego Serca Pana Jezusa",
            "Uroczystość Narodzenia św. Jana Chrzciciela",
            "Uroczystość św. Apostołów Piotra i Pawła",
            "Święto św. Tomasza - Apostoła",
            "Święto św. Marii Magdaleny",
            "Święto św. Brygidy",
            "Święto Przemienienia Pańskiego",
            "Święto św. Teresy Benedykty od Krzyża",
            "Święto św. Wawrzyńca",
            "Święto św. Bartłomieja - Apostoła",
            "Święto Narodzenia NMP",
            "Święto Podwyższenia Krzyża Świętego",
            "Święto św. Stanisława Kostki",
            "Święto św. Mateusza - Apostoła i Ewangelisty",
            "Święto św. Łukasza - Ewangelisty",
            "Święto św. Apostołów Szymona i Judy Tadeusza",
            "Święto rocznicy poświęcenia Bazyliki Laterańskiej",
            "Święto Nawrócenia św. Pawała - Apostoła",
            "Uroczystość bł. Bronisława Markiewicza",
            "Uroczystość św. MIchała Archanioła",
            "Święto Katedry św. Piotra - Apostoła",
            "Święto św. Katarzyny Sieneńskiej",
            "Święto św. Andrzeja - Apostoła",
            "Środa Popielcowa",
            "Święto św. Młodzianków",
            "1 Niedziela Wielkiego Postu rok A",
            "1 Niedziela Wielkiego Postu rok B",
            "1 Niedziela Wielkiego Postu rok C",
            "1 Tydzień Wielkiego Postu - Poniedziałek",
            "1 Tydzień Wielkiego Postu - Wtorek",
            "1 Tydzień Wielkiego Postu - Środa",
            "1 Tydzień Wielkiego Postu - Czwartek",
            "1 Tydzień Wielkiego Postu - Piątek",
            "1 Tydzień Wielkiego Postu - Sobota",
            "2 Niedziela Wielkiego Postu rok A",
            "2 Niedziela Wielkiego Postu rok B",
            "2 Niedziela Wielkiego Postu rok C",
            "2 Tydzień Wielkiego Postu - Poniedziałek",
            "2 Tydzień Wielkiego Postu - Wtorek",
            "2 Tydzień Wielkiego Postu - Środa",
            "2 Tydzień Wielkiego Postu - Czwartek",
            "2 Tydzień Wielkiego Postu - Piątek",
            "2 Tydzień Wielkiego Postu - Sobota",
            "3 Niedziela Wielkiego Postu rok A",
            "3 Niedziela Wielkiego Postu rok B",
            "3 Niedziela Wielkiego Postu rok C",
            "3 Tydzień Wielkiego Postu - Poniedziałek",
            "3 Tydzień Wielkiego Postu - Wtorek",
            "3 Tydzień Wielkiego Postu - Środa",
            "3 Tydzień Wielkiego Postu - Czwartek",
            "3 Tydzień Wielkiego Postu - Piątek",
            "3 Tydzień Wielkiego Postu - Sobota",
            "4 Niedziela Wielkiego Postu rok A",
            "4 Niedziela Wielkiego Postu rok B",
            "4 Niedziela Wielkiego Postu rok C",
            "4 Tydzień Wielkiego Postu - Poniedziałek",
            "4 Tydzień Wielkiego Postu - Wtorek",
            "4 Tydzień Wielkiego Postu - Środa",
            "4 Tydzień Wielkiego Postu - Czwartek",
            "4 Tydzień Wielkiego Postu - Piątek",
            "4 Tydzień Wielkiego Postu - Sobota",
            "5 Niedziela Wielkiego Postu rok A",
            "5 Niedziela Wielkiego Postu rok B",
            "5 Niedziela Wielkiego Postu rok C",
            "5 Tydzień Wielkiego Postu - Poniedziałek",
            "5 Tydzień Wielkiego Postu - Wtorek",
            "5 Tydzień Wielkiego Postu - Środa",
            "5 Tydzień Wielkiego Postu - Czwartek",
            "5 Tydzień Wielkiego Postu - Piątek",
            "5 Tydzień Wielkiego Postu - Sobota",
            "Niedziela Palmowa rok A",
            "Niedziela Palmowa rok B",
            "Niedziela Palmowa rok C",
            "6 Tydzień Wielkiego Postu - Poniedziałek",
            "6 Tydzień Wielkiego Postu - Wtorek",
            "6 Tydzień Wielkiego Postu - Środa",
            "Wielki Czwartek",
            "Msza wieczerzy Pańskiej",
            "Msza Krzyżma",
            "Liturgia na cześć Męki Pańskiej",
            "Wigilia Paschalna",
            "Niedziela Zmartwychwstania Pańskiego",
            "Poniedziałek w oktawie Wielkanocy",
            "Wtorek w oktawie Wielkanocy",
            "Środa w oktawie Wielkanocy",
            "Czwartek w oktawie Wielkanocy",
            "Piątek w oktawie Wielkanocy",
            "Sobota w oktawie Wielkanocy",
            "Niedziela Bożego Miłosierdzia rok A",
            "Niedziela Bożego Miłosierdzia rok B",
            "Niedziela Bożego Miłosierdzia rok C",
            "2 Tydzień Wielkanocny - Poniedziałek",
            "2 Tydzień Wielkanocny - Wtorek",
            "2 Tydzień Wielkanocny - Środa",
            "2 Tydzień Wielkanocny - Czwartek",
            "2 Tydzień Wielkanocny - Piątek",
            "2 Tydzień Wielkanocny - Sobota",
            "3 Niedziela Wielkanocy rok A",
            "3 Niedziela Wielkanocy rok B",
            "3 Niedziela Wielkanocy rok C",
            "3 Tydzień Wielkanocny - Poniedziałek",
            "3 Tydzień Wielkanocny - Wtorek",
            "3 Tydzień Wielkanocny - Środa",
            "3 Tydzień Wielkanocny - Czwartek",
            "3 Tydzień Wielkanocny - Piątek",
            "3 Tydzień Wielkanocny - Sobota",
            "4 Niedziela Wielkanocy rok A",
            "4 Niedziela Wielkanocy rok B",
            "4 Niedziela Wielkanocy rok C",
            "4 Tydzień Wielkanocny - Poniedziałek",
            "4 Tydzień Wielkanocny - Wtorek",
            "4 Tydzień Wielkanocny - Środa",
            "4 Tydzień Wielkanocny - Czwartek",
            "4 Tydzień Wielkanocny - Piątek",
            "4 Tydzień Wielkanocny - Sobota",
            "5 Niedziela Wielkanocy rok A",
            "5 Niedziela Wielkanocy rok B",
            "5 Niedziela Wielkanocy rok C",
            "5 Tydzień Wielkanocny - Poniedziałek",
            "5 Tydzień Wielkanocny - Wtorek",
            "5 Tydzień Wielkanocny - Środa",
            "5 Tydzień Wielkanocny - Czwartek",
            "5 Tydzień Wielkanocny - Piątek",
            "5 Tydzień Wielkanocny - Sobota",
            "6 Niedziela Wielkanocy rok A",
            "6 Niedziela Wielkanocy rok B",
            "6 Niedziela Wielkanocy rok C",
            "6 Tydzień Wielkanocny - Poniedziałek",
            "6 Tydzień Wielkanocny - Wtorek",
            "6 Tydzień Wielkanocny - Środa",
            "6 Tydzień Wielkanocny - Czwartek",
            "6 Tydzień Wielkanocny - Piątek",
            "6 Tydzień Wielkanocny - Sobota",
            "Uroczystość Niepokalanego Poczęcia  NMP",
            "Wigilia Narodzenia Pańskiego",
            "Uroczystość Narodzenia Pańskiego - msza w nocy",
            "Uroczystość Narodzenia Pańskiego - msza o świcie",
            "Uroczystość Narodzenia Pańskiego - msza w dzień",
            "Niedziela Świętej Rodziny",
            "Uroczystość Świętej Bożej Rodzicielki Maryi",
            "Niedziela Chrztu Pańskiego",
            "1 Niedziela Adwentu rok A",
            "1 Niedziela Adwentu rok B",
            "1 Niedziela Adwentu rok C",
            "1 Tydzień Adwentu - Poniedziałek",
            "1 Tydzień Adwentu - Wtorek",
            "1 Tydzień Adwentu - Środa",
            "1 Tydzień Adwentu - Czwartek",
            "1 Tydzień Adwentu - Piątek",
            "1 Tydzień Adwentu - Sobota",
            "2 Niedziela Adwentu rok A",
            "2 Niedziela Adwentu rok B",
            "2 Niedziela Adwentu rok C",
            "2 Tydzień Adwentu - Poniedziałek",
            "2 Tydzień Adwentu - Wtorek",
            "2 Tydzień Adwentu - Środa",
            "2 Tydzień Adwentu - Czwartek",
            "2 Tydzień Adwentu - Piątek",
            "2 Tydzień Adwentu - Sobota",
            "3 Niedziela Adwentu rok A",
            "3 Niedziela Adwentu rok B",
            "3 Niedziela Adwentu rok C",
            "3 Tydzień Adwentu - Poniedziałek",
            "3 Tydzień Adwentu - Wtorek",
            "3 Tydzień Adwentu - Środa",
            "3 Tydzień Adwentu - Czwartek",
            "3 Tydzień Adwentu - Piątek",
            "3 Tydzień Adwentu - Sobota",
            "4 Niedziela Adwentu rok A",
            "4 Niedziela Adwentu rok B",
            "4 Niedziela Adwentu rok C",
            "4 Tydzień Adwentu - Poniedziałek",
            "4 Tydzień Adwentu - Wtorek",
            "4 Tydzień Adwentu - Środa",
            "4 Tydzień Adwentu - Czwartek",
            "4 Tydzień Adwentu - Piątek",
            "4 Tydzień Adwentu - Sobota",
            "5 Dzień Oktawy Narodzenia Pańskiego",
            "6 Dzień Oktawy Narodzenia Pańskiego",
            "7 Dzień Oktawy Narodzenia Pańskiego",
            "2 Niedziela po Narodzeniu Pańskim rok A",
            "2 Niedziela po Narodzeniu Pańskim rok B",
            "2 Niedziela po Narodzeniu Pańskim rok C",
            "2 Tydzień po Narodzeniu Pańskim - Poniedziałek",
            "2 Tydzień po Narodzeniu Pańskim - Wtorek",
            "2 Tydzień po Narodzeniu Pańskim - Środa",
            "2 Tydzień po Narodzeniu Pańskim - Czwartek",
            "2 Tydzień po Narodzeniu Pańskim - Piątek",
            "2 Tydzień po Narodzeniu Pańskim - Sobota",
            ""});
            this.NazwaBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NazwaBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NazwaBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NazwaBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaBox.Location = new System.Drawing.Point(169, 5);
            this.NazwaBox.Name = "NazwaBox";
            this.NazwaBox.Size = new System.Drawing.Size(660, 37);
            this.NazwaBox.TabIndex = 47;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UtworzZestaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(832, 911);
            this.Controls.Add(this.PanelZestaw);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(848, 830);
            this.Name = "UtworzZestaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik pracy | utwórz zestaw";
            this.TopMost = true;
            this.PanelZestaw.ResumeLayout(false);
            this.PanelZestaw.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelZestaw;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CanceledButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel MainPanel;
        private UCPiesn ucPiesn1;
        private UCPiesn ucPiesn15;
        private UCPiesn ucPiesn14;
        private UCPiesn ucPiesn13;
        private UCPiesn ucPiesn12;
        private UCPiesn ucPiesn11;
        private UCPiesn ucPiesn10;
        private UCPiesn ucPiesn9;
        private UCPiesn ucPiesn8;
        private UCPiesn ucPiesn7;
        private UCPiesn ucPiesn6;
        private UCPiesn ucPiesn5;
        private UCPiesn ucPiesn4;
        private UCPiesn ucPiesn3;
        private UCPiesn ucPiesn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelNazwa;
        private System.Windows.Forms.TextBox NazwaBox;
    }
}
namespace Dziennik_Pracy
{
    partial class Sprawozdanie
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
            this.flowLayoutPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanelCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.poczatkowaData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.koncowaData = new System.Windows.Forms.DateTimePicker();
            this.SavePdfFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.flowLayoutPanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            this.flowLayoutPanelTop.Controls.Add(this.LogoBox);
            this.flowLayoutPanelTop.Controls.Add(this.button1);
            this.flowLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            this.flowLayoutPanelTop.Size = new System.Drawing.Size(334, 50);
            this.flowLayoutPanelTop.TabIndex = 0;
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBox.Image = global::Dziennik_Pracy.Properties.Resources.icon_32;
            this.LogoBox.InitialImage = null;
            this.LogoBox.Location = new System.Drawing.Point(3, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Padding = new System.Windows.Forms.Padding(7);
            this.LogoBox.Size = new System.Drawing.Size(262, 50);
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::Dziennik_Pracy.Properties.Resources.abort_32;
            this.button1.Location = new System.Drawing.Point(271, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.Controls.Add(this.button2);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 261);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(122, 0, 122, 0);
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(334, 50);
            this.flowLayoutPanelBottom.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Dziennik_Pracy.Properties.Resources.save_32;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Dziennik_Pracy.Properties.Resources.save_32;
            this.button2.Location = new System.Drawing.Point(125, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // flowLayoutPanelCenter
            // 
            this.flowLayoutPanelCenter.Controls.Add(this.label1);
            this.flowLayoutPanelCenter.Controls.Add(this.poczatkowaData);
            this.flowLayoutPanelCenter.Controls.Add(this.label2);
            this.flowLayoutPanelCenter.Controls.Add(this.koncowaData);
            this.flowLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCenter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCenter.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelCenter.Name = "flowLayoutPanelCenter";
            this.flowLayoutPanelCenter.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanelCenter.Size = new System.Drawing.Size(334, 211);
            this.flowLayoutPanelCenter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data początkowa sprawozdania";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poczatkowaData
            // 
            this.poczatkowaData.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poczatkowaData.Location = new System.Drawing.Point(23, 64);
            this.poczatkowaData.Name = "poczatkowaData";
            this.poczatkowaData.Size = new System.Drawing.Size(268, 23);
            this.poczatkowaData.TabIndex = 1;
            this.poczatkowaData.ValueChanged += new System.EventHandler(this.poczatkowaData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data końcowa sprawozdania";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // koncowaData
            // 
            this.koncowaData.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koncowaData.Location = new System.Drawing.Point(23, 134);
            this.koncowaData.Name = "koncowaData";
            this.koncowaData.Size = new System.Drawing.Size(268, 23);
            this.koncowaData.TabIndex = 3;
            this.koncowaData.ValueChanged += new System.EventHandler(this.koncowaData_ValueChanged);
            // 
            // SavePdfFileDialog
            // 
            this.SavePdfFileDialog.DefaultExt = "*.pdf";
            this.SavePdfFileDialog.Filter = "pliki PDF|*.pdf";
            this.SavePdfFileDialog.Title = "Zapis sprawozdania";
            // 
            // Sprawozdanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.flowLayoutPanelCenter);
            this.Controls.Add(this.flowLayoutPanelBottom);
            this.Controls.Add(this.flowLayoutPanelTop);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sprawozdanie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik pracy | Sprawozdanie";
            this.flowLayoutPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.flowLayoutPanelBottom.PerformLayout();
            this.flowLayoutPanelCenter.ResumeLayout(false);
            this.flowLayoutPanelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker poczatkowaData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker koncowaData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.SaveFileDialog SavePdfFileDialog;
    }
}
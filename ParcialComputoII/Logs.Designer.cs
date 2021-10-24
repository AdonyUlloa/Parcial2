
namespace ParcialComputoII
{
    partial class Logs
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
            this.mlbLogin = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dtgLogs = new System.Windows.Forms.DataGridView();
            this.rjToggleButton1 = new ParcialComputoII.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // mlbLogin
            // 
            this.mlbLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlbLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbLogin.ForeColor = System.Drawing.Color.Transparent;
            this.mlbLogin.Location = new System.Drawing.Point(12, 9);
            this.mlbLogin.Name = "mlbLogin";
            this.mlbLogin.Size = new System.Drawing.Size(55, 30);
            this.mlbLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlbLogin.TabIndex = 82;
            this.mlbLogin.Text = "Logs";
            this.mlbLogin.UseCustomBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(765, 1);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(34, 22);
            this.metroButton1.TabIndex = 85;
            this.metroButton1.Text = "X";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dtgLogs
            // 
            this.dtgLogs.AllowUserToAddRows = false;
            this.dtgLogs.AllowUserToDeleteRows = false;
            this.dtgLogs.AllowUserToResizeColumns = false;
            this.dtgLogs.AllowUserToResizeRows = false;
            this.dtgLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLogs.BackgroundColor = System.Drawing.Color.White;
            this.dtgLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgLogs.Location = new System.Drawing.Point(69, 80);
            this.dtgLogs.MultiSelect = false;
            this.dtgLogs.Name = "dtgLogs";
            this.dtgLogs.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgLogs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLogs.Size = new System.Drawing.Size(661, 263);
            this.dtgLogs.TabIndex = 86;
           
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(733, 416);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 84;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgLogs);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.mlbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbLogin;
        private RJToggleButton rjToggleButton1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dtgLogs;
    }
}
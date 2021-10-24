
namespace ParcialComputoII
{
    partial class MenuGeneral
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
            this.tileRegistros = new MetroFramework.Controls.MetroTile();
            this.tilePerfil = new MetroFramework.Controls.MetroTile();
            this.mlbLogin = new MetroFramework.Controls.MetroLabel();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tileRegistros
            // 
            this.tileRegistros.ActiveControl = null;
            this.tileRegistros.ForeColor = System.Drawing.Color.Black;
            this.tileRegistros.Location = new System.Drawing.Point(199, 128);
            this.tileRegistros.Name = "tileRegistros";
            this.tileRegistros.Size = new System.Drawing.Size(98, 99);
            this.tileRegistros.TabIndex = 88;
            this.tileRegistros.Text = "REGISTROS";
            this.tileRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileRegistros.TileImage = global::ParcialComputoII.Properties.Resources.registrado;
            this.tileRegistros.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileRegistros.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileRegistros.UseSelectable = true;
            this.tileRegistros.UseTileImage = true;
            this.tileRegistros.Click += new System.EventHandler(this.tileRegistros_Click);
            // 
            // tilePerfil
            // 
            this.tilePerfil.ActiveControl = null;
            this.tilePerfil.ForeColor = System.Drawing.Color.Black;
            this.tilePerfil.Location = new System.Drawing.Point(66, 128);
            this.tilePerfil.Name = "tilePerfil";
            this.tilePerfil.Size = new System.Drawing.Size(98, 99);
            this.tilePerfil.TabIndex = 87;
            this.tilePerfil.Text = "PERFIL";
            this.tilePerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePerfil.TileImage = global::ParcialComputoII.Properties.Resources.perfil__4_;
            this.tilePerfil.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePerfil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePerfil.UseSelectable = true;
            this.tilePerfil.UseTileImage = true;
            this.tilePerfil.Click += new System.EventHandler(this.tilePerfil_Click);
            // 
            // mlbLogin
            // 
            this.mlbLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlbLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbLogin.ForeColor = System.Drawing.Color.Transparent;
            this.mlbLogin.Location = new System.Drawing.Point(66, 63);
            this.mlbLogin.Name = "mlbLogin";
            this.mlbLogin.Size = new System.Drawing.Size(231, 27);
            this.mlbLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlbLogin.TabIndex = 86;
            this.mlbLogin.Text = "MENU ADMINISTRATIVO";
            this.mlbLogin.UseCustomBackColor = true;
            this.mlbLogin.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = global::ParcialComputoII.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(338, 290);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 44);
            this.btnCerrarSesion.TabIndex = 89;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 346);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.tileRegistros);
            this.Controls.Add(this.tilePerfil);
            this.Controls.Add(this.mlbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileRegistros;
        private MetroFramework.Controls.MetroTile tilePerfil;
        private MetroFramework.Controls.MetroLabel mlbLogin;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
    }
}

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
            this.mlbLogin = new MetroFramework.Controls.MetroLabel();
            this.tilePerfil = new MetroFramework.Controls.MetroTile();
            this.tileRegistros = new MetroFramework.Controls.MetroTile();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mlbLogin
            // 
            this.mlbLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlbLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbLogin.ForeColor = System.Drawing.Color.Transparent;
            this.mlbLogin.Location = new System.Drawing.Point(198, 99);
            this.mlbLogin.Name = "mlbLogin";
            this.mlbLogin.Size = new System.Drawing.Size(155, 27);
            this.mlbLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlbLogin.TabIndex = 83;
            this.mlbLogin.Text = "MENU USUARIO";
            this.mlbLogin.UseCustomBackColor = true;
            // 
            // tilePerfil
            // 
            this.tilePerfil.ActiveControl = null;
            this.tilePerfil.ForeColor = System.Drawing.Color.Black;
            this.tilePerfil.Location = new System.Drawing.Point(165, 187);
            this.tilePerfil.Name = "tilePerfil";
            this.tilePerfil.Size = new System.Drawing.Size(98, 99);
            this.tilePerfil.TabIndex = 84;
            this.tilePerfil.Text = "PERFIL";
            this.tilePerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePerfil.TileImage = global::ParcialComputoII.Properties.Resources.perfil__4_;
            this.tilePerfil.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePerfil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePerfil.UseSelectable = true;
            this.tilePerfil.UseTileImage = true;
            this.tilePerfil.Click += new System.EventHandler(this.tilePerfil_Click);
            // 
            // tileRegistros
            // 
            this.tileRegistros.ActiveControl = null;
            this.tileRegistros.ForeColor = System.Drawing.Color.Black;
            this.tileRegistros.Location = new System.Drawing.Point(303, 187);
            this.tileRegistros.Name = "tileRegistros";
            this.tileRegistros.Size = new System.Drawing.Size(98, 99);
            this.tileRegistros.TabIndex = 86;
            this.tileRegistros.Text = "REGISTROS";
            this.tileRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileRegistros.TileImage = global::ParcialComputoII.Properties.Resources.registrado;
            this.tileRegistros.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileRegistros.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileRegistros.UseSelectable = true;
            this.tileRegistros.UseTileImage = true;
            this.tileRegistros.Click += new System.EventHandler(this.tileRegistros_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = global::ParcialComputoII.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(528, 376);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 44);
            this.btnCerrarSesion.TabIndex = 88;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 432);
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

        private MetroFramework.Controls.MetroLabel mlbLogin;
        private MetroFramework.Controls.MetroTile tilePerfil;
        private MetroFramework.Controls.MetroTile tileRegistros;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
    }
}

namespace ParcialComputoII
{
    partial class MenuAdmin
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
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.tileTrabajos = new MetroFramework.Controls.MetroTile();
            this.tileRegistros = new MetroFramework.Controls.MetroTile();
            this.tileUsuarios = new MetroFramework.Controls.MetroTile();
            this.tilePerfil = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mlbLogin
            // 
            this.mlbLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlbLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbLogin.ForeColor = System.Drawing.Color.Transparent;
            this.mlbLogin.Location = new System.Drawing.Point(168, 100);
            this.mlbLogin.Name = "mlbLogin";
            this.mlbLogin.Size = new System.Drawing.Size(231, 27);
            this.mlbLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlbLogin.TabIndex = 82;
            this.mlbLogin.Text = "MENU ADMINISTRATIVO";
            this.mlbLogin.UseCustomBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = global::ParcialComputoII.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(541, 477);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 44);
            this.btnCerrarSesion.TabIndex = 87;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // tileTrabajos
            // 
            this.tileTrabajos.ActiveControl = null;
            this.tileTrabajos.ForeColor = System.Drawing.Color.Black;
            this.tileTrabajos.Location = new System.Drawing.Point(299, 289);
            this.tileTrabajos.Name = "tileTrabajos";
            this.tileTrabajos.Size = new System.Drawing.Size(98, 99);
            this.tileTrabajos.TabIndex = 86;
            this.tileTrabajos.Text = "TRABAJOS";
            this.tileTrabajos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileTrabajos.TileImage = global::ParcialComputoII.Properties.Resources.pila_de_libros;
            this.tileTrabajos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileTrabajos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileTrabajos.UseSelectable = true;
            this.tileTrabajos.UseTileImage = true;
            this.tileTrabajos.Click += new System.EventHandler(this.tileTrabajos_Click);
            // 
            // tileRegistros
            // 
            this.tileRegistros.ActiveControl = null;
            this.tileRegistros.ForeColor = System.Drawing.Color.Black;
            this.tileRegistros.Location = new System.Drawing.Point(168, 289);
            this.tileRegistros.Name = "tileRegistros";
            this.tileRegistros.Size = new System.Drawing.Size(98, 99);
            this.tileRegistros.TabIndex = 85;
            this.tileRegistros.Text = "REGISTROS";
            this.tileRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileRegistros.TileImage = global::ParcialComputoII.Properties.Resources.registrado;
            this.tileRegistros.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileRegistros.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileRegistros.UseSelectable = true;
            this.tileRegistros.UseTileImage = true;
            this.tileRegistros.Click += new System.EventHandler(this.tileRegistros_Click);
            // 
            // tileUsuarios
            // 
            this.tileUsuarios.ActiveControl = null;
            this.tileUsuarios.ForeColor = System.Drawing.Color.Black;
            this.tileUsuarios.Location = new System.Drawing.Point(299, 165);
            this.tileUsuarios.Name = "tileUsuarios";
            this.tileUsuarios.Size = new System.Drawing.Size(98, 99);
            this.tileUsuarios.TabIndex = 84;
            this.tileUsuarios.Text = "USUARIOS";
            this.tileUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileUsuarios.TileImage = global::ParcialComputoII.Properties.Resources.grupo;
            this.tileUsuarios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileUsuarios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileUsuarios.UseSelectable = true;
            this.tileUsuarios.UseTileImage = true;
            this.tileUsuarios.Click += new System.EventHandler(this.tileUsuarios_Click);
            // 
            // tilePerfil
            // 
            this.tilePerfil.ActiveControl = null;
            this.tilePerfil.ForeColor = System.Drawing.Color.Black;
            this.tilePerfil.Location = new System.Drawing.Point(168, 165);
            this.tilePerfil.Name = "tilePerfil";
            this.tilePerfil.Size = new System.Drawing.Size(98, 99);
            this.tilePerfil.TabIndex = 83;
            this.tilePerfil.Text = "PERFIL";
            this.tilePerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tilePerfil.TileImage = global::ParcialComputoII.Properties.Resources.perfil__4_;
            this.tilePerfil.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tilePerfil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePerfil.UseSelectable = true;
            this.tilePerfil.UseTileImage = true;
            this.tilePerfil.Click += new System.EventHandler(this.tilePerfil_Click_1);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 533);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.tileTrabajos);
            this.Controls.Add(this.tileRegistros);
            this.Controls.Add(this.tileUsuarios);
            this.Controls.Add(this.tilePerfil);
            this.Controls.Add(this.mlbLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlbLogin;
        private MetroFramework.Controls.MetroTile tilePerfil;
        private MetroFramework.Controls.MetroTile tileUsuarios;
        private MetroFramework.Controls.MetroTile tileRegistros;
        private MetroFramework.Controls.MetroTile tileTrabajos;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
    }
}
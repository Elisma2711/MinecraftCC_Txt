namespace MinecraftCC_Txt
{
    partial class Form1
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
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Z = new System.Windows.Forms.TextBox();
            this.Text_Y = new System.Windows.Forms.TextBox();
            this.Text_X = new System.Windows.Forms.TextBox();
            this.Text_Nombre = new System.Windows.Forms.TextBox();
            this.Dgv_Coordenadas = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Lbl_Mod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Coordenadas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.BackgroundImage = global::MinecraftCC_Txt.Properties.Resources.refresh;
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Segoe UI Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(438, 2);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(40, 35);
            this.Btn_Refresh.TabIndex = 23;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Segoe UI Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Modificar.Location = new System.Drawing.Point(174, 99);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(141, 33);
            this.Btn_Modificar.TabIndex = 17;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Segoe UI Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Eliminar.Location = new System.Drawing.Point(337, 99);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(141, 33);
            this.Btn_Eliminar.TabIndex = 19;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(421, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(316, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(211, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "NOMBRE";
            // 
            // Text_Z
            // 
            this.Text_Z.BackColor = System.Drawing.Color.White;
            this.Text_Z.Location = new System.Drawing.Point(384, 64);
            this.Text_Z.MaxLength = 10;
            this.Text_Z.Name = "Text_Z";
            this.Text_Z.Size = new System.Drawing.Size(93, 29);
            this.Text_Z.TabIndex = 15;
            this.Text_Z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // Text_Y
            // 
            this.Text_Y.BackColor = System.Drawing.Color.White;
            this.Text_Y.Location = new System.Drawing.Point(279, 64);
            this.Text_Y.MaxLength = 10;
            this.Text_Y.Name = "Text_Y";
            this.Text_Y.Size = new System.Drawing.Size(93, 29);
            this.Text_Y.TabIndex = 14;
            this.Text_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // Text_X
            // 
            this.Text_X.BackColor = System.Drawing.Color.White;
            this.Text_X.Location = new System.Drawing.Point(174, 64);
            this.Text_X.MaxLength = 10;
            this.Text_X.Name = "Text_X";
            this.Text_X.Size = new System.Drawing.Size(93, 29);
            this.Text_X.TabIndex = 13;
            this.Text_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // Text_Nombre
            // 
            this.Text_Nombre.BackColor = System.Drawing.Color.White;
            this.Text_Nombre.Location = new System.Drawing.Point(11, 64);
            this.Text_Nombre.MaxLength = 100;
            this.Text_Nombre.Name = "Text_Nombre";
            this.Text_Nombre.Size = new System.Drawing.Size(141, 29);
            this.Text_Nombre.TabIndex = 11;
            // 
            // Dgv_Coordenadas
            // 
            this.Dgv_Coordenadas.AllowUserToAddRows = false;
            this.Dgv_Coordenadas.AllowUserToDeleteRows = false;
            this.Dgv_Coordenadas.AllowUserToResizeRows = false;
            this.Dgv_Coordenadas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_Coordenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Coordenadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Coordenadas.Location = new System.Drawing.Point(0, 145);
            this.Dgv_Coordenadas.MultiSelect = false;
            this.Dgv_Coordenadas.Name = "Dgv_Coordenadas";
            this.Dgv_Coordenadas.ReadOnly = true;
            this.Dgv_Coordenadas.RowHeadersVisible = false;
            this.Dgv_Coordenadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Coordenadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Coordenadas.Size = new System.Drawing.Size(490, 175);
            this.Dgv_Coordenadas.TabIndex = 12;
            this.Dgv_Coordenadas.TabStop = false;
            this.Dgv_Coordenadas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Coordenadas_CellMouseClick);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.Green;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Segoe UI Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.Btn_Agregar.Location = new System.Drawing.Point(11, 99);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(141, 33);
            this.Btn_Agregar.TabIndex = 16;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Lbl_Mod
            // 
            this.Lbl_Mod.AutoSize = true;
            this.Lbl_Mod.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Mod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lbl_Mod.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_Mod.Location = new System.Drawing.Point(7, 12);
            this.Lbl_Mod.Name = "Lbl_Mod";
            this.Lbl_Mod.Size = new System.Drawing.Size(425, 19);
            this.Lbl_Mod.TabIndex = 24;
            this.Lbl_Mod.Text = "¤ Para modificar una coordenada reescríbla y haga click en modificar";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(490, 320);
            this.Controls.Add(this.Lbl_Mod);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Z);
            this.Controls.Add(this.Text_Y);
            this.Controls.Add(this.Text_X);
            this.Controls.Add(this.Text_Nombre);
            this.Controls.Add(this.Dgv_Coordenadas);
            this.Controls.Add(this.Btn_Agregar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "INGRESAR COORDENADAS";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Coordenadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Z;
        private System.Windows.Forms.TextBox Text_Y;
        private System.Windows.Forms.TextBox Text_X;
        private System.Windows.Forms.TextBox Text_Nombre;
        private System.Windows.Forms.DataGridView Dgv_Coordenadas;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label Lbl_Mod;
    }
}
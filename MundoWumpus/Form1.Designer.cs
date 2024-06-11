namespace MundoWumpus
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnSur;
        private System.Windows.Forms.Button btnEste;
        private System.Windows.Forms.Button btnOeste;
        private System.Windows.Forms.Button btnDispararNorte;
        private System.Windows.Forms.Button btnDispararSur;
        private System.Windows.Forms.Button btnDispararEste;
        private System.Windows.Forms.Button btnDispararOeste;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblFlecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnSur = new System.Windows.Forms.Button();
            this.btnEste = new System.Windows.Forms.Button();
            this.btnOeste = new System.Windows.Forms.Button();
            this.btnDispararNorte = new System.Windows.Forms.Button();
            this.btnDispararSur = new System.Windows.Forms.Button();
            this.btnDispararEste = new System.Windows.Forms.Button();
            this.btnDispararOeste = new System.Windows.Forms.Button();
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(213, 452);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(75, 23);
            this.btnNorte.TabIndex = 1;
            this.btnNorte.Tag = "Norte";
            this.btnNorte.Text = "Norte";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnSur
            // 
            this.btnSur.Location = new System.Drawing.Point(213, 510);
            this.btnSur.Name = "btnSur";
            this.btnSur.Size = new System.Drawing.Size(75, 23);
            this.btnSur.TabIndex = 2;
            this.btnSur.Tag = "Sur";
            this.btnSur.Text = "Sur";
            this.btnSur.UseVisualStyleBackColor = true;
            this.btnSur.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnEste
            // 
            this.btnEste.Location = new System.Drawing.Point(303, 481);
            this.btnEste.Name = "btnEste";
            this.btnEste.Size = new System.Drawing.Size(66, 23);
            this.btnEste.TabIndex = 3;
            this.btnEste.Tag = "Este";
            this.btnEste.Text = "Este";
            this.btnEste.UseVisualStyleBackColor = true;
            this.btnEste.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnOeste
            // 
            this.btnOeste.Location = new System.Drawing.Point(132, 482);
            this.btnOeste.Name = "btnOeste";
            this.btnOeste.Size = new System.Drawing.Size(75, 23);
            this.btnOeste.TabIndex = 4;
            this.btnOeste.Tag = "Oeste";
            this.btnOeste.Text = "Oeste";
            this.btnOeste.UseVisualStyleBackColor = true;
            this.btnOeste.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnDispararNorte
            // 
            this.btnDispararNorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispararNorte.Location = new System.Drawing.Point(213, 481);
            this.btnDispararNorte.Name = "btnDispararNorte";
            this.btnDispararNorte.Size = new System.Drawing.Size(84, 23);
            this.btnDispararNorte.TabIndex = 1;
            this.btnDispararNorte.Tag = "Norte";
            this.btnDispararNorte.Text = "Disparar N";
            this.btnDispararNorte.UseVisualStyleBackColor = true;
            this.btnDispararNorte.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // btnDispararSur
            // 
            this.btnDispararSur.Location = new System.Drawing.Point(213, 539);
            this.btnDispararSur.Name = "btnDispararSur";
            this.btnDispararSur.Size = new System.Drawing.Size(75, 23);
            this.btnDispararSur.TabIndex = 2;
            this.btnDispararSur.Tag = "Sur";
            this.btnDispararSur.Text = "Disparar Sur";
            this.btnDispararSur.UseVisualStyleBackColor = true;
            this.btnDispararSur.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // btnDispararEste
            // 
            this.btnDispararEste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispararEste.Location = new System.Drawing.Point(294, 510);
            this.btnDispararEste.Name = "btnDispararEste";
            this.btnDispararEste.Size = new System.Drawing.Size(80, 23);
            this.btnDispararEste.TabIndex = 3;
            this.btnDispararEste.Tag = "Este";
            this.btnDispararEste.Text = "Disparar E";
            this.btnDispararEste.UseVisualStyleBackColor = true;
            this.btnDispararEste.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // btnDispararOeste
            // 
            this.btnDispararOeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispararOeste.Location = new System.Drawing.Point(132, 510);
            this.btnDispararOeste.Name = "btnDispararOeste";
            this.btnDispararOeste.Size = new System.Drawing.Size(75, 23);
            this.btnDispararOeste.TabIndex = 4;
            this.btnDispararOeste.Tag = "Oeste";
            this.btnDispararOeste.Text = "Disparar O";
            this.btnDispararOeste.UseVisualStyleBackColor = true;
            this.btnDispararOeste.Click += new System.EventHandler(this.btnDisparar_Click);
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Location = new System.Drawing.Point(459, 46);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(45, 16);
            this.lblVidas.TabIndex = 5;
            this.lblVidas.Text = "Vidas:";
            // 
            // lblFlecha
            // 
            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Location = new System.Drawing.Point(459, 69);
            this.lblFlecha.Name = "lblFlecha";
            this.lblFlecha.Size = new System.Drawing.Size(51, 16);
            this.lblFlecha.TabIndex = 6;
            this.lblFlecha.Text = "Flecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrada y Salida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFlecha);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.btnDispararOeste);
            this.Controls.Add(this.btnOeste);
            this.Controls.Add(this.btnDispararEste);
            this.Controls.Add(this.btnEste);
            this.Controls.Add(this.btnDispararSur);
            this.Controls.Add(this.btnSur);
            this.Controls.Add(this.btnDispararNorte);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Wumpus Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}

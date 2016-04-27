namespace HelpdeskTool
{
    partial class Eraser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eraser));
            this.button1 = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.operacionLabel = new System.Windows.Forms.Label();
            this.ClaimNumberLabel = new System.Windows.Forms.Label();
            this.claimNumber = new System.Windows.Forms.TextBox();
            this.MensajeLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.ChekBoxMensaje = new System.Windows.Forms.CheckBox();
            this.checkBoxOoperacion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridVista = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.checkBoxClaimNumber = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.verificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(313, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operacion
            // 
            this.operacion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operacion.FormattingEnabled = true;
            this.operacion.Location = new System.Drawing.Point(155, 128);
            this.operacion.Margin = new System.Windows.Forms.Padding(4);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(160, 24);
            this.operacion.TabIndex = 3;
            this.operacion.SelectedIndexChanged += new System.EventHandler(this.operacion_SelectedIndexChanged);
            // 
            // operacionLabel
            // 
            this.operacionLabel.AutoSize = true;
            this.operacionLabel.Location = new System.Drawing.Point(51, 128);
            this.operacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operacionLabel.Name = "operacionLabel";
            this.operacionLabel.Size = new System.Drawing.Size(74, 16);
            this.operacionLabel.TabIndex = 4;
            this.operacionLabel.Text = "Operacion";
            // 
            // ClaimNumberLabel
            // 
            this.ClaimNumberLabel.AutoSize = true;
            this.ClaimNumberLabel.Location = new System.Drawing.Point(51, 173);
            this.ClaimNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClaimNumberLabel.Name = "ClaimNumberLabel";
            this.ClaimNumberLabel.Size = new System.Drawing.Size(91, 16);
            this.ClaimNumberLabel.TabIndex = 5;
            this.ClaimNumberLabel.Text = "ClaimNumber";
            this.ClaimNumberLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // claimNumber
            // 
            this.claimNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.claimNumber.Location = new System.Drawing.Point(155, 167);
            this.claimNumber.Margin = new System.Windows.Forms.Padding(4);
            this.claimNumber.Name = "claimNumber";
            this.claimNumber.Size = new System.Drawing.Size(160, 23);
            this.claimNumber.TabIndex = 6;
            // 
            // MensajeLabel
            // 
            this.MensajeLabel.AutoSize = true;
            this.MensajeLabel.Location = new System.Drawing.Point(51, 282);
            this.MensajeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MensajeLabel.Name = "MensajeLabel";
            this.MensajeLabel.Size = new System.Drawing.Size(62, 16);
            this.MensajeLabel.TabIndex = 7;
            this.MensajeLabel.Text = "Mensaje";
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.HighlightText;
            this.message.Location = new System.Drawing.Point(155, 260);
            this.message.Margin = new System.Windows.Forms.Padding(4);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.message.Size = new System.Drawing.Size(436, 68);
            this.message.TabIndex = 8;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Info;
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(194, 336);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info.Size = new System.Drawing.Size(340, 59);
            this.info.TabIndex = 9;
            // 
            // ChekBoxMensaje
            // 
            this.ChekBoxMensaje.AutoSize = true;
            this.ChekBoxMensaje.Location = new System.Drawing.Point(598, 282);
            this.ChekBoxMensaje.Name = "ChekBoxMensaje";
            this.ChekBoxMensaje.Size = new System.Drawing.Size(55, 20);
            this.ChekBoxMensaje.TabIndex = 11;
            this.ChekBoxMensaje.Text = "Fijar";
            this.ChekBoxMensaje.UseVisualStyleBackColor = true;
            // 
            // checkBoxOoperacion
            // 
            this.checkBoxOoperacion.AutoSize = true;
            this.checkBoxOoperacion.Location = new System.Drawing.Point(322, 130);
            this.checkBoxOoperacion.Name = "checkBoxOoperacion";
            this.checkBoxOoperacion.Size = new System.Drawing.Size(55, 20);
            this.checkBoxOoperacion.TabIndex = 12;
            this.checkBoxOoperacion.Text = "Fijar";
            this.checkBoxOoperacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "version 1.1.3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridVista
            // 
            this.gridVista.AllowUserToAddRows = false;
            this.gridVista.AllowUserToDeleteRows = false;
            this.gridVista.AllowUserToResizeColumns = false;
            this.gridVista.AllowUserToResizeRows = false;
            this.gridVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridVista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVista.Location = new System.Drawing.Point(155, 197);
            this.gridVista.Name = "gridVista";
            this.gridVista.ReadOnly = true;
            this.gridVista.Size = new System.Drawing.Size(494, 48);
            this.gridVista.TabIndex = 15;
            this.gridVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(51, 215);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(58, 16);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Estatus";
            // 
            // checkBoxClaimNumber
            // 
            this.checkBoxClaimNumber.AutoSize = true;
            this.checkBoxClaimNumber.Location = new System.Drawing.Point(322, 169);
            this.checkBoxClaimNumber.Name = "checkBoxClaimNumber";
            this.checkBoxClaimNumber.Size = new System.Drawing.Size(55, 20);
            this.checkBoxClaimNumber.TabIndex = 17;
            this.checkBoxClaimNumber.Text = "Fijar";
            this.checkBoxClaimNumber.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(541, 347);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // verificar
            // 
            this.verificar.BackColor = System.Drawing.Color.White;
            this.verificar.Image = ((System.Drawing.Image)(resources.GetObject("verificar.Image")));
            this.verificar.Location = new System.Drawing.Point(655, 207);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(38, 24);
            this.verificar.TabIndex = 14;
            this.verificar.UseVisualStyleBackColor = false;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 91);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(54, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 41);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadingGif
            // 
            this.loadingGif.Image = ((System.Drawing.Image)(resources.GetObject("loadingGif.Image")));
            this.loadingGif.Location = new System.Drawing.Point(312, 173);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(101, 101);
            this.loadingGif.TabIndex = 20;
            this.loadingGif.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Eraser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 455);
            this.Controls.Add(this.loadingGif);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBoxClaimNumber);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.gridVista);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOoperacion);
            this.Controls.Add(this.ChekBoxMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.message);
            this.Controls.Add(this.MensajeLabel);
            this.Controls.Add(this.claimNumber);
            this.Controls.Add(this.ClaimNumberLabel);
            this.Controls.Add(this.operacionLabel);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Eraser";
            this.Text = "Transnetwork Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Label operacionLabel;
        private System.Windows.Forms.Label ClaimNumberLabel;
        private System.Windows.Forms.TextBox claimNumber;
        private System.Windows.Forms.Label MensajeLabel;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChekBoxMensaje;
        private System.Windows.Forms.CheckBox checkBoxOoperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridVista;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox checkBoxClaimNumber;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox loadingGif;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


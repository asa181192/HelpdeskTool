namespace HelpdeskTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.claimNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChekBoxMensaje = new System.Windows.Forms.CheckBox();
            this.checkBoxOoperacion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operacion
            // 
            this.operacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operacion.FormattingEnabled = true;
            this.operacion.Location = new System.Drawing.Point(199, 145);
            this.operacion.Margin = new System.Windows.Forms.Padding(4);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(160, 24);
            this.operacion.TabIndex = 3;
            this.operacion.SelectedIndexChanged += new System.EventHandler(this.operacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ClaimNumber";
            // 
            // claimNumber
            // 
            this.claimNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.claimNumber.Location = new System.Drawing.Point(197, 185);
            this.claimNumber.Margin = new System.Windows.Forms.Padding(4);
            this.claimNumber.Name = "claimNumber";
            this.claimNumber.Size = new System.Drawing.Size(160, 23);
            this.claimNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mensaje";
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.message.Location = new System.Drawing.Point(197, 229);
            this.message.Margin = new System.Windows.Forms.Padding(4);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.message.Size = new System.Drawing.Size(477, 68);
            this.message.TabIndex = 8;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Info;
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(197, 305);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(340, 101);
            this.info.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 91);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ChekBoxMensaje
            // 
            this.ChekBoxMensaje.AutoSize = true;
            this.ChekBoxMensaje.Location = new System.Drawing.Point(101, 268);
            this.ChekBoxMensaje.Name = "ChekBoxMensaje";
            this.ChekBoxMensaje.Size = new System.Drawing.Size(55, 20);
            this.ChekBoxMensaje.TabIndex = 11;
            this.ChekBoxMensaje.Text = "Fijar";
            this.ChekBoxMensaje.UseVisualStyleBackColor = true;
            // 
            // checkBoxOoperacion
            // 
            this.checkBoxOoperacion.AutoSize = true;
            this.checkBoxOoperacion.Location = new System.Drawing.Point(101, 149);
            this.checkBoxOoperacion.Name = "checkBoxOoperacion";
            this.checkBoxOoperacion.Size = new System.Drawing.Size(55, 20);
            this.checkBoxOoperacion.TabIndex = 12;
            this.checkBoxOoperacion.Text = "Fijar";
            this.checkBoxOoperacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "version .02";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOoperacion);
            this.Controls.Add(this.ChekBoxMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.claimNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Transnetwork Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox claimNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChekBoxMensaje;
        private System.Windows.Forms.CheckBox checkBoxOoperacion;
        private System.Windows.Forms.Label label1;
    }
}


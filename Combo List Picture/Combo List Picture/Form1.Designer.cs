namespace Combo_List_Picture
{
    partial class Lenguajes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLenguajes = new System.Windows.Forms.ComboBox();
            this.listBoxLenguajes = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLenguajes = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLenguajes
            // 
            this.comboBoxLenguajes.FormattingEnabled = true;
            this.comboBoxLenguajes.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#"});
            this.comboBoxLenguajes.Location = new System.Drawing.Point(607, 29);
            this.comboBoxLenguajes.Name = "comboBoxLenguajes";
            this.comboBoxLenguajes.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLenguajes.TabIndex = 0;
            // 
            // listBoxLenguajes
            // 
            this.listBoxLenguajes.FormattingEnabled = true;
            this.listBoxLenguajes.ItemHeight = 20;
            this.listBoxLenguajes.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#"});
            this.listBoxLenguajes.Location = new System.Drawing.Point(134, 29);
            this.listBoxLenguajes.Name = "listBoxLenguajes";
            this.listBoxLenguajes.Size = new System.Drawing.Size(120, 84);
            this.listBoxLenguajes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(478, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblLenguajes
            // 
            this.lblLenguajes.AutoSize = true;
            this.lblLenguajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenguajes.Location = new System.Drawing.Point(345, 29);
            this.lblLenguajes.Name = "lblLenguajes";
            this.lblLenguajes.Size = new System.Drawing.Size(164, 37);
            this.lblLenguajes.TabIndex = 4;
            this.lblLenguajes.Text = "Lenguajes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(334, 464);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(197, 59);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Lenguajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 552);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblLenguajes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxLenguajes);
            this.Controls.Add(this.comboBoxLenguajes);
            this.Name = "Lenguajes";
            this.Text = "Lenguajes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLenguajes;
        private System.Windows.Forms.ListBox listBoxLenguajes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLenguajes;
        private System.Windows.Forms.Button btnActualizar;
    }
}


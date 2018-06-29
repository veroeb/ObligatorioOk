namespace Obligatorio.Views
{
    partial class NuevoInmueble
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnApartment = new System.Windows.Forms.Button();
            this.btnhouse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnApartment);
            this.panel1.Controls.Add(this.btnhouse);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1632, 913);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 40);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "<-- Atras";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnApartment
            // 
            this.btnApartment.AutoEllipsis = true;
            this.btnApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnApartment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnApartment.FlatAppearance.BorderSize = 0;
            this.btnApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartment.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApartment.Location = new System.Drawing.Point(830, 287);
            this.btnApartment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnApartment.Name = "btnApartment";
            this.btnApartment.Size = new System.Drawing.Size(552, 277);
            this.btnApartment.TabIndex = 3;
            this.btnApartment.Text = "Apartamento";
            this.btnApartment.UseVisualStyleBackColor = false;
            this.btnApartment.Click += new System.EventHandler(this.btnApartment_Click);
            // 
            // btnhouse
            // 
            this.btnhouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnhouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnhouse.FlatAppearance.BorderSize = 0;
            this.btnhouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhouse.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhouse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhouse.Location = new System.Drawing.Point(272, 310);
            this.btnhouse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnhouse.Name = "btnhouse";
            this.btnhouse.Size = new System.Drawing.Size(392, 231);
            this.btnhouse.TabIndex = 2;
            this.btnhouse.Text = "Casa";
            this.btnhouse.UseVisualStyleBackColor = false;
            this.btnhouse.Click += new System.EventHandler(this.btnhouse_Click);
            // 
            // NuevoInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevoInmueble_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnApartment;
        private System.Windows.Forms.Button btnhouse;
    }
}
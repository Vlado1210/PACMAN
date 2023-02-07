
namespace LAB2
{
    partial class Nivel2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.FANTASMA5 = new System.Windows.Forms.PictureBox();
            this.FANTASMA4 = new System.Windows.Forms.PictureBox();
            this.FANTASMA3 = new System.Windows.Forms.PictureBox();
            this.FANTASMA2 = new System.Windows.Forms.PictureBox();
            this.FANTASMA = new System.Windows.Forms.PictureBox();
            this.TROFEO = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TROFEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 9000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FANTASMA5
            // 
            this.FANTASMA5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FANTASMA5.Image = global::LAB2.Properties.Resources.yellow_guy;
            this.FANTASMA5.Location = new System.Drawing.Point(152, 94);
            this.FANTASMA5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FANTASMA5.Name = "FANTASMA5";
            this.FANTASMA5.Size = new System.Drawing.Size(14, 16);
            this.FANTASMA5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FANTASMA5.TabIndex = 7;
            this.FANTASMA5.TabStop = false;
            // 
            // FANTASMA4
            // 
            this.FANTASMA4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FANTASMA4.Image = global::LAB2.Properties.Resources.red_guy;
            this.FANTASMA4.Location = new System.Drawing.Point(186, 142);
            this.FANTASMA4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FANTASMA4.Name = "FANTASMA4";
            this.FANTASMA4.Size = new System.Drawing.Size(7, 6);
            this.FANTASMA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FANTASMA4.TabIndex = 6;
            this.FANTASMA4.TabStop = false;
            // 
            // FANTASMA3
            // 
            this.FANTASMA3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FANTASMA3.Image = global::LAB2.Properties.Resources.red_guy;
            this.FANTASMA3.Location = new System.Drawing.Point(61, 204);
            this.FANTASMA3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FANTASMA3.Name = "FANTASMA3";
            this.FANTASMA3.Size = new System.Drawing.Size(7, 6);
            this.FANTASMA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FANTASMA3.TabIndex = 5;
            this.FANTASMA3.TabStop = false;
            // 
            // FANTASMA2
            // 
            this.FANTASMA2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FANTASMA2.Image = global::LAB2.Properties.Resources.pink_guy;
            this.FANTASMA2.Location = new System.Drawing.Point(23, 196);
            this.FANTASMA2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FANTASMA2.Name = "FANTASMA2";
            this.FANTASMA2.Size = new System.Drawing.Size(14, 14);
            this.FANTASMA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FANTASMA2.TabIndex = 4;
            this.FANTASMA2.TabStop = false;
            this.FANTASMA2.Click += new System.EventHandler(this.FANTASMA2_Click);
            // 
            // FANTASMA
            // 
            this.FANTASMA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FANTASMA.Image = global::LAB2.Properties.Resources.pink_guy;
            this.FANTASMA.Location = new System.Drawing.Point(126, 37);
            this.FANTASMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FANTASMA.Name = "FANTASMA";
            this.FANTASMA.Size = new System.Drawing.Size(7, 6);
            this.FANTASMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FANTASMA.TabIndex = 3;
            this.FANTASMA.TabStop = false;
            // 
            // TROFEO
            // 
            this.TROFEO.Image = global::LAB2.Properties.Resources.copa_y_trofeo_imagen_animada_0012;
            this.TROFEO.Location = new System.Drawing.Point(102, 8);
            this.TROFEO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TROFEO.Name = "TROFEO";
            this.TROFEO.Size = new System.Drawing.Size(31, 25);
            this.TROFEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TROFEO.TabIndex = 2;
            this.TROFEO.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(69, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 11);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(123, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 19);
            this.button1.TabIndex = 13;
            this.button1.Text = "Siguente Nivel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Nivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FANTASMA5);
            this.Controls.Add(this.FANTASMA4);
            this.Controls.Add(this.FANTASMA3);
            this.Controls.Add(this.FANTASMA2);
            this.Controls.Add(this.FANTASMA);
            this.Controls.Add(this.TROFEO);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Nivel2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MAIN_FORM_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MAIN_FORM_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FANTASMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TROFEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox TROFEO;
        private System.Windows.Forms.PictureBox FANTASMA;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox FANTASMA2;
        private System.Windows.Forms.PictureBox FANTASMA3;
        private System.Windows.Forms.PictureBox FANTASMA4;
        private System.Windows.Forms.PictureBox FANTASMA5;
        private System.Windows.Forms.Button button1;
    }
}


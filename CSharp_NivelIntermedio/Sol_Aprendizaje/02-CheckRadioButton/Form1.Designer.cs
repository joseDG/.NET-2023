namespace _02_CheckRadioButton
{
    partial class Form
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
            this.chk_vfp = new System.Windows.Forms.CheckBox();
            this.chk_net = new System.Windows.Forms.CheckBox();
            this.chk_csharp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_java = new System.Windows.Forms.CheckBox();
            this.textBReultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.rb_presencial = new System.Windows.Forms.RadioButton();
            this.rb_virtual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_vfp
            // 
            this.chk_vfp.AutoSize = true;
            this.chk_vfp.Location = new System.Drawing.Point(122, 148);
            this.chk_vfp.Name = "chk_vfp";
            this.chk_vfp.Size = new System.Drawing.Size(132, 24);
            this.chk_vfp.TabIndex = 0;
            this.chk_vfp.Text = "Visual FoxPro";
            this.chk_vfp.UseVisualStyleBackColor = true;
            // 
            // chk_net
            // 
            this.chk_net.AutoSize = true;
            this.chk_net.Location = new System.Drawing.Point(122, 287);
            this.chk_net.Name = "chk_net";
            this.chk_net.Size = new System.Drawing.Size(92, 24);
            this.chk_net.TabIndex = 1;
            this.chk_net.Text = "VB.NET";
            this.chk_net.UseVisualStyleBackColor = true;
            // 
            // chk_csharp
            // 
            this.chk_csharp.AutoSize = true;
            this.chk_csharp.Location = new System.Drawing.Point(122, 215);
            this.chk_csharp.Name = "chk_csharp";
            this.chk_csharp.Size = new System.Drawing.Size(117, 24);
            this.chk_csharp.TabIndex = 2;
            this.chk_csharp.Text = "C Sharp C#";
            this.chk_csharp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(118, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cursos Disponibles en promocion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chk_java
            // 
            this.chk_java.AutoSize = true;
            this.chk_java.Location = new System.Drawing.Point(123, 364);
            this.chk_java.Name = "chk_java";
            this.chk_java.Size = new System.Drawing.Size(68, 24);
            this.chk_java.TabIndex = 4;
            this.chk_java.Text = "Java";
            this.chk_java.UseVisualStyleBackColor = true;
            // 
            // textBReultado
            // 
            this.textBReultado.Location = new System.Drawing.Point(518, 397);
            this.textBReultado.Multiline = true;
            this.textBReultado.Name = "textBReultado";
            this.textBReultado.ReadOnly = true;
            this.textBReultado.Size = new System.Drawing.Size(603, 214);
            this.textBReultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado de los Cursos Seleccionados:";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_procesar.Location = new System.Drawing.Point(109, 486);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(217, 125);
            this.btn_procesar.TabIndex = 7;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // rb_presencial
            // 
            this.rb_presencial.AutoSize = true;
            this.rb_presencial.Location = new System.Drawing.Point(536, 264);
            this.rb_presencial.Name = "rb_presencial";
            this.rb_presencial.Size = new System.Drawing.Size(107, 24);
            this.rb_presencial.TabIndex = 8;
            this.rb_presencial.TabStop = true;
            this.rb_presencial.Text = "Presencial";
            this.rb_presencial.UseVisualStyleBackColor = true;
            // 
            // rb_virtual
            // 
            this.rb_virtual.AutoSize = true;
            this.rb_virtual.Location = new System.Drawing.Point(739, 264);
            this.rb_virtual.Name = "rb_virtual";
            this.rb_virtual.Size = new System.Drawing.Size(79, 24);
            this.rb_virtual.TabIndex = 9;
            this.rb_virtual.TabStop = true;
            this.rb_virtual.Text = "Virtual";
            this.rb_virtual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(531, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "En que ecenario de aprendizaje te gustaria?:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_virtual);
            this.Controls.Add(this.rb_presencial);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBReultado);
            this.Controls.Add(this.chk_java);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_csharp);
            this.Controls.Add(this.chk_net);
            this.Controls.Add(this.chk_vfp);
            this.Name = "Form";
            this.Text = "ENCUESTAS DE CURSOS DISPONIBLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_vfp;
        private System.Windows.Forms.CheckBox chk_net;
        private System.Windows.Forms.CheckBox chk_csharp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_java;
        private System.Windows.Forms.TextBox textBReultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.RadioButton rb_presencial;
        private System.Windows.Forms.RadioButton rb_virtual;
        private System.Windows.Forms.Label label3;
    }
}


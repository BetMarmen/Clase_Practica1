namespace ConvertirToMayusculas
{
    partial class frmConvertidorMayuscula
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
            label1 = new Label();
            label2 = new Label();
            txtTexto = new TextBox();
            lstOriginal = new ListBox();
            lstMayusculas = new ListBox();
            btnConvertir = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 30);
            label1.TabIndex = 0;
            label1.Text = "Convertirdor de Texto a Mayuscula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el texto=>";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(140, 67);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 2;
            // 
            // lstOriginal
            // 
            lstOriginal.FormattingEnabled = true;
            lstOriginal.ItemHeight = 15;
            lstOriginal.Location = new Point(48, 217);
            lstOriginal.Name = "lstOriginal";
            lstOriginal.Size = new Size(120, 94);
            lstOriginal.TabIndex = 3;
            // 
            // lstMayusculas
            // 
            lstMayusculas.FormattingEnabled = true;
            lstMayusculas.ItemHeight = 15;
            lstMayusculas.Location = new Point(281, 217);
            lstMayusculas.Name = "lstMayusculas";
            lstMayusculas.Size = new Size(120, 94);
            lstMayusculas.TabIndex = 4;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(165, 132);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += this.btnConvertir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 186);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Original";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 180);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Mayusculas";
            // 
            // frmConvertidorMayuscula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnConvertir);
            Controls.Add(lstMayusculas);
            Controls.Add(lstOriginal);
            Controls.Add(txtTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConvertidorMayuscula";
            Text = "frmConvertidorMayuscula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTexto;
        private ListBox lstOriginal;
        private ListBox lstMayusculas;
        private Button btnConvertir;
        private Label label3;
        private Label label4;
    }
}
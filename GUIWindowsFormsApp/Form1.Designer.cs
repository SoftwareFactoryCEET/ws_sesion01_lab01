namespace GUIWindowsFormsApp
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabalRadio = new System.Windows.Forms.Label();
            this.TextBoxRadio = new System.Windows.Forms.TextBox();
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.GroupBoxOperacion = new System.Windows.Forms.GroupBox();
            this.RadioButtonPerimetro = new System.Windows.Forms.RadioButton();
            this.RadioButtonArea = new System.Windows.Forms.RadioButton();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.GroupBoxOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelTitulo.Location = new System.Drawing.Point(344, 53);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(111, 20);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Circunferencia";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabalRadio
            // 
            this.LabalRadio.AutoSize = true;
            this.LabalRadio.Location = new System.Drawing.Point(69, 143);
            this.LabalRadio.Name = "LabalRadio";
            this.LabalRadio.Size = new System.Drawing.Size(135, 20);
            this.LabalRadio.TabIndex = 1;
            this.LabalRadio.Text = "Ingrese Radio > 0";
            // 
            // TextBoxRadio
            // 
            this.TextBoxRadio.Location = new System.Drawing.Point(348, 143);
            this.TextBoxRadio.Name = "TextBoxRadio";
            this.TextBoxRadio.Size = new System.Drawing.Size(364, 26);
            this.TextBoxRadio.TabIndex = 2;
            this.TextBoxRadio.Text = "0";
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.Location = new System.Drawing.Point(69, 321);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(192, 37);
            this.ButtonCalcular.TabIndex = 3;
            this.ButtonCalcular.Text = "Calcular";
            this.ButtonCalcular.UseVisualStyleBackColor = true;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // GroupBoxOperacion
            // 
            this.GroupBoxOperacion.Controls.Add(this.RadioButtonPerimetro);
            this.GroupBoxOperacion.Controls.Add(this.RadioButtonArea);
            this.GroupBoxOperacion.Location = new System.Drawing.Point(69, 189);
            this.GroupBoxOperacion.Name = "GroupBoxOperacion";
            this.GroupBoxOperacion.Size = new System.Drawing.Size(196, 112);
            this.GroupBoxOperacion.TabIndex = 4;
            this.GroupBoxOperacion.TabStop = false;
            this.GroupBoxOperacion.Text = "Seleccione Operación";
            // 
            // RadioButtonPerimetro
            // 
            this.RadioButtonPerimetro.AutoSize = true;
            this.RadioButtonPerimetro.Location = new System.Drawing.Point(25, 73);
            this.RadioButtonPerimetro.Name = "RadioButtonPerimetro";
            this.RadioButtonPerimetro.Size = new System.Drawing.Size(102, 24);
            this.RadioButtonPerimetro.TabIndex = 1;
            this.RadioButtonPerimetro.TabStop = true;
            this.RadioButtonPerimetro.Text = "Perímetro";
            this.RadioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // RadioButtonArea
            // 
            this.RadioButtonArea.AutoSize = true;
            this.RadioButtonArea.Location = new System.Drawing.Point(25, 34);
            this.RadioButtonArea.Name = "RadioButtonArea";
            this.RadioButtonArea.Size = new System.Drawing.Size(68, 24);
            this.RadioButtonArea.TabIndex = 0;
            this.RadioButtonArea.TabStop = true;
            this.RadioButtonArea.Text = "Área";
            this.RadioButtonArea.UseVisualStyleBackColor = true;
            // 
            // LabelResultado
            // 
            this.LabelResultado.Location = new System.Drawing.Point(344, 202);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(368, 99);
            this.LabelResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.GroupBoxOperacion);
            this.Controls.Add(this.ButtonCalcular);
            this.Controls.Add(this.TextBoxRadio);
            this.Controls.Add(this.LabalRadio);
            this.Controls.Add(this.LabelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBoxOperacion.ResumeLayout(false);
            this.GroupBoxOperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabalRadio;
        private System.Windows.Forms.TextBox TextBoxRadio;
        private System.Windows.Forms.Button ButtonCalcular;
        private System.Windows.Forms.GroupBox GroupBoxOperacion;
        private System.Windows.Forms.RadioButton RadioButtonPerimetro;
        private System.Windows.Forms.RadioButton RadioButtonArea;
        private System.Windows.Forms.Label LabelResultado;
    }
}


namespace JsonEmpresa
{
    partial class FrmEmpresa
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
            txtEmpresa = new TextBox();
            txtMunicipio = new TextBox();
            label2 = new Label();
            txtDepartamento = new TextBox();
            label3 = new Label();
            dgvResultado = new DataGridView();
            btnInsertar = new Button();
            btnSerializar = new Button();
            btnDeserializar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(161, 40);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(222, 23);
            txtEmpresa.TabIndex = 1;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(161, 79);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(222, 23);
            txtMunicipio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Municipio:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(161, 121);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(222, 23);
            txtDepartamento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Departamento:";
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Dock = DockStyle.Bottom;
            dgvResultado.Location = new Point(0, 215);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.Size = new Size(637, 199);
            dgvResultado.TabIndex = 6;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(81, 163);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += this.btnInsertar_Click;
            // 
            // btnSerializar
            // 
            btnSerializar.Location = new Point(186, 163);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(138, 23);
            btnSerializar.TabIndex = 8;
            btnSerializar.Text = "SERIALIZAR LISTA";
            btnSerializar.UseVisualStyleBackColor = true;
            // 
            // btnDeserializar
            // 
            btnDeserializar.Location = new Point(353, 163);
            btnDeserializar.Name = "btnDeserializar";
            btnDeserializar.Size = new Size(138, 23);
            btnDeserializar.TabIndex = 9;
            btnDeserializar.Text = "DESERIALIZAR LISTA";
            btnDeserializar.UseVisualStyleBackColor = true;
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 414);
            Controls.Add(btnDeserializar);
            Controls.Add(btnSerializar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvResultado);
            Controls.Add(txtDepartamento);
            Controls.Add(label3);
            Controls.Add(txtMunicipio);
            Controls.Add(label2);
            Controls.Add(txtEmpresa);
            Controls.Add(label1);
            Name = "FrmEmpresa";
            Text = "Empresa";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpresa;
        private TextBox txtMunicipio;
        private Label label2;
        private TextBox txtDepartamento;
        private Label label3;
        private DataGridView dgvResultado;
        private Button btnInsertar;
        private Button btnSerializar;
        private Button btnDeserializar;
    }
}
namespace Vista
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDniCliente = new TextBox();
            lblSeleccionarHamburguesa = new Label();
            lblGuarnicion = new Label();
            grpIngredientes = new GroupBox();
            btnAgregarIngredientes = new Button();
            cmbIngredientes = new ComboBox();
            lblIngredientes = new Label();
            rdbGuarnicion = new RadioButton();
            rdbHamburguesa = new RadioButton();
            lstHamburguesas = new ListBox();
            cmbGuarnicion = new ComboBox();
            btnAgregarGuarnicion = new Button();
            rchTicket = new RichTextBox();
            grpIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(28, 33);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(100, 23);
            txtDniCliente.TabIndex = 0;
            txtDniCliente.Text = "DNI del cliente";
            txtDniCliente.TextChanged += txtDniClietne_TextChanged;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // lblSeleccionarHamburguesa
            // 
            lblSeleccionarHamburguesa.AutoSize = true;
            lblSeleccionarHamburguesa.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionarHamburguesa.Location = new Point(21, 76);
            lblSeleccionarHamburguesa.Name = "lblSeleccionarHamburguesa";
            lblSeleccionarHamburguesa.Size = new Size(278, 28);
            lblSeleccionarHamburguesa.TabIndex = 1;
            lblSeleccionarHamburguesa.Text = "Seleccione su hamburguesa:";
            // 
            // lblGuarnicion
            // 
            lblGuarnicion.AutoSize = true;
            lblGuarnicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuarnicion.Location = new Point(28, 191);
            lblGuarnicion.Name = "lblGuarnicion";
            lblGuarnicion.Size = new Size(251, 28);
            lblGuarnicion.TabIndex = 2;
            lblGuarnicion.Text = "Seleccione su guarnición:";
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(btnAgregarIngredientes);
            grpIngredientes.Controls.Add(cmbIngredientes);
            grpIngredientes.Controls.Add(lblIngredientes);
            grpIngredientes.Controls.Add(rdbGuarnicion);
            grpIngredientes.Controls.Add(rdbHamburguesa);
            grpIngredientes.Location = new Point(394, 67);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(300, 201);
            grpIngredientes.TabIndex = 3;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes";
            // 
            // btnAgregarIngredientes
            // 
            btnAgregarIngredientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarIngredientes.Location = new Point(245, 168);
            btnAgregarIngredientes.Name = "btnAgregarIngredientes";
            btnAgregarIngredientes.Size = new Size(39, 23);
            btnAgregarIngredientes.TabIndex = 7;
            btnAgregarIngredientes.Text = "+";
            btnAgregarIngredientes.UseVisualStyleBackColor = true;
            btnAgregarIngredientes.Click += btnAgregarIngredientes_Click;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(18, 168);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(174, 23);
            cmbIngredientes.TabIndex = 6;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngredientes.Location = new Point(18, 124);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(135, 28);
            lblIngredientes.TabIndex = 4;
            lblIngredientes.Text = "Ingredientes:";
            // 
            // rdbGuarnicion
            // 
            rdbGuarnicion.AutoSize = true;
            rdbGuarnicion.Location = new Point(18, 73);
            rdbGuarnicion.Name = "rdbGuarnicion";
            rdbGuarnicion.Size = new Size(83, 19);
            rdbGuarnicion.TabIndex = 1;
            rdbGuarnicion.TabStop = true;
            rdbGuarnicion.Text = "Guarnición";
            rdbGuarnicion.UseVisualStyleBackColor = true;
            // 
            // rdbHamburguesa
            // 
            rdbHamburguesa.AutoSize = true;
            rdbHamburguesa.Location = new Point(18, 35);
            rdbHamburguesa.Name = "rdbHamburguesa";
            rdbHamburguesa.Size = new Size(100, 19);
            rdbHamburguesa.TabIndex = 0;
            rdbHamburguesa.TabStop = true;
            rdbHamburguesa.Text = "Hamburguesa";
            rdbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 15;
            lstHamburguesas.Location = new Point(33, 109);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(266, 79);
            lstHamburguesas.TabIndex = 4;
            lstHamburguesas.DoubleClick += lstHamburguesas_DoubleClick;
            // 
            // cmbGuarnicion
            // 
            cmbGuarnicion.FormattingEnabled = true;
            cmbGuarnicion.Location = new Point(33, 235);
            cmbGuarnicion.Name = "cmbGuarnicion";
            cmbGuarnicion.Size = new Size(234, 23);
            cmbGuarnicion.TabIndex = 5;
            cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
            // 
            // btnAgregarGuarnicion
            // 
            btnAgregarGuarnicion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarGuarnicion.Location = new Point(292, 238);
            btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
            btnAgregarGuarnicion.Size = new Size(39, 23);
            btnAgregarGuarnicion.TabIndex = 6;
            btnAgregarGuarnicion.Text = "+";
            btnAgregarGuarnicion.UseVisualStyleBackColor = true;
            btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
            // 
            // rchTicket
            // 
            rchTicket.Location = new Point(30, 279);
            rchTicket.Name = "rchTicket";
            rchTicket.Size = new Size(664, 132);
            rchTicket.TabIndex = 7;
            rchTicket.Text = "";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rchTicket);
            Controls.Add(btnAgregarGuarnicion);
            Controls.Add(cmbGuarnicion);
            Controls.Add(lstHamburguesas);
            Controls.Add(grpIngredientes);
            Controls.Add(lblGuarnicion);
            Controls.Add(lblSeleccionarHamburguesa);
            Controls.Add(txtDniCliente);
            Name = "FrmView";
            Text = "Form1";
            Load += FrmView_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniCliente;
        private Label lblSeleccionarHamburguesa;
        private Label lblGuarnicion;
        private GroupBox grpIngredientes;
        private RadioButton rdbGuarnicion;
        private RadioButton rdbHamburguesa;
        private Label lblIngredientes;
        private ListBox lstHamburguesas;
        private Button btnAgregarIngredientes;
        private ComboBox cmbIngredientes;
        private ComboBox cmbGuarnicion;
        private Button btnAgregarGuarnicion;
        private RichTextBox rchTicket;
    }
}
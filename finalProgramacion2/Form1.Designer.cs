namespace finalProgramacion2
{
    partial class Form1
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
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            txtSueldo = new TextBox();
            txtHora = new TextBox();
            listView1 = new ListView();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtCodArea = new TextBox();
            txtCantHoras = new TextBox();
            btnAgregar2 = new Button();
            btnEliminar = new Button();
            btnLimpiar2 = new Button();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(112, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(112, 100);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 2;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(112, 136);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 23);
            txtHora.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(298, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(559, 143);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(47, 184);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(163, 184);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Sueldo de area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 139);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "$ Hora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 227);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 11;
            label5.Text = "Dni empleado";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 256);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre empleado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 282);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 13;
            label7.Text = "Codigo de area";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 313);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "Cant horas extras";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(163, 224);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 256);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 16;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodArea
            // 
            txtCodArea.Location = new Point(163, 282);
            txtCodArea.Name = "txtCodArea";
            txtCodArea.Size = new Size(100, 23);
            txtCodArea.TabIndex = 17;
            // 
            // txtCantHoras
            // 
            txtCantHoras.Location = new Point(163, 313);
            txtCantHoras.Name = "txtCantHoras";
            txtCantHoras.Size = new Size(100, 23);
            txtCantHoras.TabIndex = 18;
            // 
            // btnAgregar2
            // 
            btnAgregar2.Location = new Point(27, 350);
            btnAgregar2.Name = "btnAgregar2";
            btnAgregar2.Size = new Size(75, 23);
            btnAgregar2.TabIndex = 19;
            btnAgregar2.Text = "Agregar";
            btnAgregar2.UseVisualStyleBackColor = true;
            btnAgregar2.Click += btnAgregar2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(112, 350);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar2
            // 
            btnLimpiar2.Location = new Point(193, 350);
            btnLimpiar2.Name = "btnLimpiar2";
            btnLimpiar2.Size = new Size(75, 23);
            btnLimpiar2.TabIndex = 21;
            btnLimpiar2.Text = "Limpiar";
            btnLimpiar2.UseVisualStyleBackColor = true;
            btnLimpiar2.Click += btnLimpiar2_Click;
            // 
            // listView2
            // 
            listView2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.GridLines = true;
            listView2.Location = new Point(298, 224);
            listView2.Name = "listView2";
            listView2.Size = new Size(559, 149);
            listView2.TabIndex = 22;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.Click += listView2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(listView2);
            Controls.Add(btnLimpiar2);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar2);
            Controls.Add(txtCantHoras);
            Controls.Add(txtCodArea);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(listView1);
            Controls.Add(txtHora);
            Controls.Add(txtSueldo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private TextBox txtSueldo;
        private TextBox txtHora;
        private ListView listView1;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtCodArea;
        private TextBox txtCantHoras;
        private Button btnAgregar2;
        private Button btnEliminar;
        private Button btnLimpiar2;
        private ListView listView2;
    }
}
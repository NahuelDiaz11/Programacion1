namespace finalProgramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double cantidad, hora, resultado, total;
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Codigo de Area", 100);
            listView1.Columns.Add("Descripcion", 100);
            listView1.Columns.Add("Area", 100);
            listView1.Columns.Add("$ Hora trabajo", 100);


            listView2.Columns.Add("Dni del empleado", 80);
            listView2.Columns.Add("Nombre", 80);
            listView2.Columns.Add("Codigo de Area", 80);
            listView2.Columns.Add("Nombre de Area", 80);
            listView2.Columns.Add("Sueldo basico", 80);

            listView2.Columns.Add("$ Hora extra", 80);
            listView2.Columns.Add("Cant horas extras", 80);
            listView2.Columns.Add("Total de Horas", 80);
            listView2.Columns.Add("Sueldo total", 80);



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(txtCodigo.Text);
            newitem.SubItems.Add(txtDescripcion.Text);
            newitem.SubItems.Add(txtSueldo.Text);
            newitem.SubItems.Add(txtHora.Text);
            listView1.Items.Add(newitem);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {


            ListViewItem newitem = new ListViewItem(txtDni.Text);





            newitem.SubItems.Add(txtNombre.Text);

            newitem.SubItems.Add(txtCodArea.Text);



            if (txtCodArea.Text == txtCodigo.Text)
            {
                newitem.SubItems.Add(txtDescripcion.Text);
                newitem.SubItems.Add(txtSueldo.Text);
                newitem.SubItems.Add(txtHora.Text);
                if (double.TryParse(txtCantHoras.Text, out cantidad) && double.TryParse(txtHora.Text, out hora)) ;
                resultado = cantidad * hora;
            }
            double.TryParse(txtSueldo.Text, out total);
            total = total + resultado;

            newitem.SubItems.Add(txtCantHoras.Text);
            newitem.SubItems.Add(resultado.ToString());
            newitem.SubItems.Add(total.ToString());

            listView2.Items.Add(newitem);


        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtCodigo.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtCodigo.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtCodigo.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtCodigo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void listView2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                txtDni.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtNombre.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtCodArea.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtCantHoras.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtSueldo.Text = "";
            txtHora.Text = "";

        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtCodArea.Text = "";
            txtCantHoras.Text = "";

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
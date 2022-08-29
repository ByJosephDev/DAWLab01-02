namespace Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtName.Text;
            string lastname = txtLastName.Text;
            string address = txtAddress.Text;
            string tel = txtTel.Text;
            string email = txtEmail.Text;
            string fecNac = dtpFecNac.Text;
            string departamento = comboDep.Text;

            dgvUsuarios.Rows.Add("",dni,nombre,lastname,address,tel,email,fecNac,departamento);

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogindeAcesso
{
    public partial class TeladeLogin : Form
    {
        //Conexão
        SqlConnection Conexao = new SqlConnection(@"Data Source = DESKTOP - 48SU0S9\SQLEXPRESS; Initial Catalog = loginserver; Integrated Security = True");

        public TeladeLogin()
        {
            InitializeComponent();
            textboxusuario.Select();

        }

        private void btacessar_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "select * from LoginScreen where usuario = '" + textboxusuario.Text + "' and senha = '" + textboxsenha.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if
                (dt.Rows.Count == 1)
            {
                PosLogin PosLogin = new PosLogin();
                this.Hide();
                PosLogin.Show();
                Conexao.Close();
            }
            
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxsenha.Text = "";
                textboxusuario.Text = "";
            }
        }
    }
}

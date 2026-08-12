using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T1B3Livraria.Desktop.Services;
using T1B3Livraria.Desktop.Helpers;

namespace T1B3Livraria.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private AuthApiService _authService = null!;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de design
            if (DesignMode) return;

            _authService = new AuthApiService();

            lblStatus.Text = $"Versão {AppConfig.Version} | ©️ {DateTime.Now.Year} SENAC-SMP";
            label1.Text = $"API: {AppConfig.ApiBaseUrl}";

            txtUsername.Text = "admin@livraira.com";
            txtPassword.Text = "Admin@123";
        }
    }
}

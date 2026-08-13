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
using T1B_3Library.Desktop.Forms;

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

        private void ExibirErro(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                lblStatus.Visible = false;
                lblStatus.Text = string.Empty;
            }
            else
            {
                lblStatus.Text = mensagem;
                lblStatus.Visible = true;
            }
        }

        private void SetCarregando(bool carregando)
        {
            btnSubmit.Enabled = !carregando;
            txtUsername.Enabled = !carregando;
            txtPassword.Enabled = !carregando;

            if (carregando)
            {
                btnSubmit.Text = "Aguarde...";
                lblStatus.Visible = false;
            }
            else
            {
                btnSubmit.Text = "Entrar";
            }

        }

        private async void btnSubmit_Click(
            object sender,
            EventArgs e)
        {
            //Limpa erros anteriores
            lblStatus.Text = string.Empty;

            //Validação dos campos
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblStatus.Text = "⚠️ Informe seu e-mail!";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblStatus.Text = "⚠️ Informe sua senha!";
                txtPassword.Focus();
                return;
            }
            // ===================== Estado de carregamento ======================
            SetCarregando(true);

            try
            {
                // Chamada da API
                var (success, user, errorMessage) = await _authService.LoginAsync(
                    txtUsername.Text.Trim(),
                    txtPassword.Text);

                if (success && user != null)
                {
                    // Armazena os dados do usuário na sessão (Singleton)
                    SessionManager.Instance.SetUser(user);

                    // Esconde a tela de login
                    this.Hide();

                    //Abrir a tela principal da aplicação
                    using var mainform = new MainForm();
                    mainform.ShowDialog();

                    // quando o MainForm fechar. fecha o LoginForm também
                    this.Close();
                }
                else
                {
                    lblStatus.Text = $"❌ {errorMessage}";
                    MessageBox.Show($"❌ {errorMessage}");
                }

            }
            catch (HttpRequestException exHttp)
            {
                lblStatus.Text = $"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}";
                MessageBox.Show($"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"❌ Erro inesperado: {ex.Message}";
                MessageBox.Show($"❌ Erro inesperado: {ex.Message}");
            }
            finally
            {
                SetCarregando(false);
            }
        }
    }
}

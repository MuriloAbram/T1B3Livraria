using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using T1B3Livraria.Desktop.DTOs;
using T1B3Livraria.Desktop.Helpers;

namespace T1B_3Library.Desktop.Forms
{
    public partial class BookFormDialog : Form
    {
        public CreateBookDto? BookDto { get; private set; }
        public UpdateBookDto? UpdateDto { get; private set; }

        private List<CategoriaResponseDto> _categorias = new();
        private readonly BookResponseDto? _bookExistente;

        public BookFormDialog()
        {
            InitializeComponent();
        }

        public BookFormDialog(List<CategoriaResponseDto> categorias, BookResponseDto? book)
        {
            InitializeComponent();
            _categorias = categorias ?? new List<CategoriaResponseDto>();
            _bookExistente = book;
        }

        private async void BookFormDialog_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            this.Text = _bookExistente == null ? "Novo Livro" : "Editar Livro";
            lblTituloForm.Text = _bookExistente == null ? "➕ Novo Livro" : "✏️ Editar Livro";

            // Se a lista veio vazia, busca direto da API
            if (_categorias == null || _categorias.Count == 0)
            {
                await CarregarCategoriasDaApiAsync();
            }
            else
            {
                PopularComboBox();
            }

            PreencherCampos();
        }

        private async Task CarregarCategoriasDaApiAsync()
        {
            try
            {
                var baseUrl = ApiEndpointResolver.Resolve();
                using var client = new HttpClient { BaseAddress = new Uri(baseUrl) };

                var response = await client.GetAsync("api/Categories");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<List<CategoriaResponseDto>>();
                    if (result != null) _categorias = result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao carregar categorias: {ex.Message}");
            }
            finally
            {
                PopularComboBox();
            }
        }

        private void PopularComboBox()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");

            if (_categorias != null)
            {
                foreach (var cat in _categorias)
                {
                    cmbCategoria.Items.Add(cat.Name);
                }
            }

            cmbCategoria.SelectedIndex = 0;
        }

        private void PreencherCampos()
        {
            if (_bookExistente == null) return;

            txtTitulo.Text = _bookExistente.Title;
            txtAutor.Text = _bookExistente.Autor;
            txtEditora.Text = _bookExistente.Editora;
            txtAno.Text = _bookExistente.AnoPublicacao.ToString();
            chkDestaque.Checked = _bookExistente.IsFeatured;

            if (_categorias.Count > 0)
            {
                var idx = _categorias.FindIndex(c => c.Id == _bookExistente.CategoryId);
                if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Informe o título do Livro.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1500 || ano > DateTime.Now.Year + 2)
            {
                MessageBox.Show("Informe um ano válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0 || _categorias.Count == 0)
            {
                MessageBox.Show("Selecione uma categoria.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var categoriaIdx = cmbCategoria.SelectedIndex - 1;
            var categoriaId = _categorias[categoriaIdx].Id;

            if (_bookExistente == null)
            {
                BookDto = new CreateBookDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    AnoPublicacao = ano,
                    Editora = txtEditora.Text.Trim(),
                    CategoryId = categoriaId,
                    IsFeatured = chkDestaque.Checked
                };
            }
            else
            {
                UpdateDto = new UpdateBookDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    AnoPublicacao = ano,
                    Editora = txtEditora.Text.Trim(),
                    CategoryId = categoriaId,
                    IsFeatured = chkDestaque.Checked
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
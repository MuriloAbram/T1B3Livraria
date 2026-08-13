using System;
using System.Windows.Forms;
using T1B3Livraria.Desktop.DTOs;

namespace T1B_3Library.Desktop.Forms
{
    public partial class BookFormDialog : Form
    {
        // ============================================================
        // PROPRIEDADES
        // ============================================================
        public CreateBookDto? BookDto { get; private set; }
        public UpdateBookDto? UpdateDto { get; private set; }

        // ============================================================
        // CONTROLE DO MODO DO FORMULÁRIO E DTOS
        // ============================================================
        private List<CategoriaResponseDto> _categorias = new();
        private BookResponseDto? _bookExistente;

        // ============================================================
        // CONSTRUTOR - NOVO CADASTRO
        // ============================================================
        public BookFormDialog()
        {
            InitializeComponent();
        }

        public BookFormDialog(List<CategoriaResponseDto> categorias, BookResponseDto? book)
        {
            _categorias = categorias ?? new List<CategoriaResponseDto>();
            _bookExistente = book;
            InitializeComponent();
        }
        // ============================================================
        // CONSTRUTOR - EDIÇÃO
        // ============================================================

        private void PreencherCampos()
        {
            if (_bookExistente == null) return;

            txtTitulo.Text = _bookExistente.Title;
            txtAutor.Text = _bookExistente.Autor;
            txtEditora.Text = _bookExistente.Editora;
            txtAno.Text = _bookExistente.AnoPublicacao.ToString();
            chkDestaque.Checked = _bookExistente.IsFeatured;

            var idx = _categorias.FindIndex(c => c.Id == _bookExistente.CategoryId);
            if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1;

        }

        // ============================================================
        // CARREGAMENTO DO FORMULÁRIO E CATEGORIAS
        // ============================================================
        private void BookFormDialog_Load(object sender, EventArgs e)
        {
            //Guard
            if (DesignMode) return;

            // Configura título baseado no modo (criação/edição)
            this.Text = _bookExistente == null ? "Novo Livro" : "Editar Livro";
            lblTituloForm.Text = _bookExistente == null ? "➕ Novo Livro" : "✏️ Editar Livro";

            //Popula o ComboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Name);
            cmbCategoria.SelectedIndex = 0;

            //Preenche campos se estiver no modo edição
            PreencherCampos();
        }

        // ============================================================
        // BOTÃO SALVAR
        // ============================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show(
                    "Informe o título do Livro.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1970 || ano > DateTime.Now.Year + 2)
            {
                MessageBox.Show(
                 "Informe um ano válido.",
                 "Validação",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show(
                 "Selecione uma categoria",
                 "Validação",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
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
                    Editora = txtEditora.Text,
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

        // ============================================================
        // BOTÃO CANCELAR
        // ============================================================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
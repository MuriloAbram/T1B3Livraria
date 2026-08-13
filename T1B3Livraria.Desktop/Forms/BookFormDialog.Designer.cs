namespace T1B_3Library.Desktop.Forms
{
    partial class BookFormDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            lblTituloForm = new Label();
            lblTitle = new Label();
            txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            lblAuthor = new Label();
            txtAutor = new Guna.UI2.WinForms.Guna2TextBox();
            lblCategory = new Label();
            cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            lblYear = new Label();
            txtAno = new Guna.UI2.WinForms.Guna2TextBox();
            lblEditora = new Label();
            txtEditora = new Guna.UI2.WinForms.Guna2TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            borderForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            chkDestaque = new CheckBox();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblTituloForm);
            pnlHeader.CustomizableEdges = customizableEdges21;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.FromArgb(24, 30, 54);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges22;
            pnlHeader.Size = new Size(480, 50);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.CustomizableEdges = customizableEdges19;
            btnClose.FillColor = Color.Transparent;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(435, 10);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnClose.Size = new Size(35, 30);
            btnClose.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.BackColor = Color.Transparent;
            lblTituloForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(20, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(213, 37);
            lblTituloForm.TabIndex = 1;
            lblTituloForm.Text = "Cadastrar Livro";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 28);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Título do Livro";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderRadius = 8;
            txtTitulo.CustomizableEdges = customizableEdges23;
            txtTitulo.DefaultText = "";
            txtTitulo.FillColor = Color.FromArgb(37, 42, 64);
            txtTitulo.Font = new Font("Segoe UI", 9F);
            txtTitulo.Location = new Point(20, 90);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtTitulo.Size = new Size(200, 36);
            txtTitulo.TabIndex = 23;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.White;
            lblAuthor.Location = new Point(268, 66);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(66, 28);
            lblAuthor.TabIndex = 22;
            lblAuthor.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.BorderRadius = 8;
            txtAutor.CustomizableEdges = customizableEdges25;
            txtAutor.DefaultText = "";
            txtAutor.FillColor = Color.FromArgb(37, 42, 64);
            txtAutor.Font = new Font("Segoe UI", 9F);
            txtAutor.Location = new Point(268, 90);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.PlaceholderText = "";
            txtAutor.SelectedText = "";
            txtAutor.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtAutor.Size = new Size(200, 36);
            txtAutor.TabIndex = 21;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(20, 243);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(103, 28);
            lblCategory.TabIndex = 18;
            lblCategory.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.Transparent;
            cmbCategoria.BorderRadius = 8;
            cmbCategoria.CustomizableEdges = customizableEdges27;
            cmbCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FillColor = Color.FromArgb(37, 42, 64);
            cmbCategoria.FocusedColor = Color.Empty;
            cmbCategoria.Font = new Font("Segoe UI", 9.5F);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.ItemHeight = 30;
            cmbCategoria.Location = new Point(20, 267);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.ShadowDecoration.CustomizableEdges = customizableEdges28;
            cmbCategoria.Size = new Size(200, 36);
            cmbCategoria.TabIndex = 17;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblYear.ForeColor = Color.White;
            lblYear.Location = new Point(268, 161);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(187, 28);
            lblYear.TabIndex = 16;
            lblYear.Text = "Ano de Publicação";
            // 
            // txtAno
            // 
            txtAno.BorderRadius = 8;
            txtAno.CustomizableEdges = customizableEdges29;
            txtAno.DefaultText = "";
            txtAno.FillColor = Color.FromArgb(37, 42, 64);
            txtAno.Font = new Font("Segoe UI", 9F);
            txtAno.Location = new Point(268, 185);
            txtAno.Margin = new Padding(3, 4, 3, 4);
            txtAno.Name = "txtAno";
            txtAno.PlaceholderText = "";
            txtAno.SelectedText = "";
            txtAno.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txtAno.Size = new Size(200, 36);
            txtAno.TabIndex = 15;
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditora.ForeColor = Color.White;
            lblEditora.Location = new Point(69, 153);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(80, 28);
            lblEditora.TabIndex = 14;
            lblEditora.Text = "Editora";
            // 
            // txtEditora
            // 
            txtEditora.BorderRadius = 8;
            txtEditora.CustomizableEdges = customizableEdges31;
            txtEditora.DefaultText = "";
            txtEditora.FillColor = Color.FromArgb(37, 42, 64);
            txtEditora.Font = new Font("Segoe UI", 9F);
            txtEditora.Location = new Point(20, 185);
            txtEditora.Margin = new Padding(3, 4, 3, 4);
            txtEditora.Name = "txtEditora";
            txtEditora.PlaceholderText = "";
            txtEditora.SelectedText = "";
            txtEditora.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtEditora.Size = new Size(200, 36);
            txtEditora.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 8;
            btnSave.CustomizableEdges = customizableEdges33;
            btnSave.FillColor = Color.FromArgb(0, 126, 249);
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(268, 390);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges34;
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Salvar";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 8;
            btnCancel.CustomizableEdges = customizableEdges35;
            btnCancel.FillColor = Color.FromArgb(108, 117, 125);
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(120, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges36;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // borderForm
            // 
            borderForm.BorderRadius = 15;
            borderForm.ContainerControl = this;
            borderForm.DockIndicatorTransparencyValue = 0.6D;
            borderForm.TransparentWhileDrag = true;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlHeader;
            dragControl.UseTransparentDrag = true;
            // 
            // chkDestaque
            // 
            chkDestaque.AutoSize = true;
            chkDestaque.ForeColor = SystemColors.ButtonFace;
            chkDestaque.Location = new Point(22, 328);
            chkDestaque.Name = "chkDestaque";
            chkDestaque.Size = new Size(184, 24);
            chkDestaque.TabIndex = 25;
            chkDestaque.Text = "Marcar como destaque";
            chkDestaque.UseVisualStyleBackColor = true;
            // 
            // BookFormDialog
            // 
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(480, 455);
            Controls.Add(chkDestaque);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtEditora);
            Controls.Add(lblEditora);
            Controls.Add(txtAno);
            Controls.Add(lblYear);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategory);
            Controls.Add(txtAutor);
            Controls.Add(lblAuthor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookFormDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookFormDialog";
            Load += BookFormDialog_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureTextBox(Guna.UI2.WinForms.Guna2TextBox txt, string placeholder, int left, int top, int width)
        {
            txt.BorderRadius = 8;
            txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.ForeColor = System.Drawing.Color.White;
            txt.Location = new System.Drawing.Point(left, top);
            txt.Name = txt.Name;
            txt.PlaceholderForeColor = System.Drawing.Color.Gray;
            txt.PlaceholderText = placeholder;
            txt.Size = new System.Drawing.Size(width, 36);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtAutor;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblYear;
        private Guna.UI2.WinForms.Guna2TextBox txtAno;
        private System.Windows.Forms.Label lblEditora;
        private Guna.UI2.WinForms.Guna2TextBox txtEditora;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private CheckBox chkDestaque;
    }
}
namespace CAIQUEGOMES_3A1_08
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id do produto";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(90, 70);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(78, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(266, 70);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(213, 20);
            this.txt_produto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do produto";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(570, 70);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(125, 20);
            this.txt_preco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preco do produto";
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cadastro.Location = new System.Drawing.Point(90, 144);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(119, 39);
            this.btn_cadastro.TabIndex = 6;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_alterar.Location = new System.Drawing.Point(327, 144);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(129, 39);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.Red;
            this.btn_apagar.Location = new System.Drawing.Point(564, 144);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(131, 39);
            this.btn_apagar.TabIndex = 8;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_produtos.Location = new System.Drawing.Point(90, 211);
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.Size = new System.Drawing.Size(605, 102);
            this.dtg_produtos.TabIndex = 9;
            this.dtg_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_produtos);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.DataGridView dtg_produtos;
    }
}


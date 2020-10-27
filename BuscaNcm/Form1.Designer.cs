namespace BuscaNcm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNcm = new System.Windows.Forms.TextBox();
            this.txtncm2 = new System.Windows.Forms.TextBox();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCest1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNcm
            // 
            this.txtNcm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNcm.Location = new System.Drawing.Point(13, 99);
            this.txtNcm.Name = "txtNcm";
            this.txtNcm.Size = new System.Drawing.Size(111, 20);
            this.txtNcm.TabIndex = 0;
            this.txtNcm.Text = "4 N° ncm : 2106";
            this.txtNcm.Enter += new System.EventHandler(this.ncmEnter);
            // 
            // txtncm2
            // 
            this.txtncm2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtncm2.Location = new System.Drawing.Point(146, 99);
            this.txtncm2.Name = "txtncm2";
            this.txtncm2.Size = new System.Drawing.Size(35, 20);
            this.txtncm2.TabIndex = 1;
            this.txtncm2.Text = "00";
            this.txtncm2.Enter += new System.EventHandler(this.ncm2Enter);
            // 
            // boxEstado
            // 
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Location = new System.Drawing.Point(348, 98);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(121, 21);
            this.boxEstado.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Location = new System.Drawing.Point(475, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.result,
            this.result2,
            this.result3,
            this.result4,
            this.result5,
            this.result6,
            this.result7});
            this.dataGridViewResultados.Location = new System.Drawing.Point(13, 160);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewResultados.Size = new System.Drawing.Size(732, 264);
            this.dataGridViewResultados.TabIndex = 5;
            // 
            // result
            // 
            this.result.HeaderText = "1";
            this.result.Name = "result";
            // 
            // result2
            // 
            this.result2.HeaderText = "2";
            this.result2.Name = "result2";
            // 
            // result3
            // 
            this.result3.HeaderText = "3";
            this.result3.Name = "result3";
            // 
            // result4
            // 
            this.result4.HeaderText = "4";
            this.result4.Name = "result4";
            // 
            // result5
            // 
            this.result5.HeaderText = "5";
            this.result5.Name = "result5";
            // 
            // result6
            // 
            this.result6.HeaderText = "6";
            this.result6.Name = "result6";
            // 
            // result7
            // 
            this.result7.HeaderText = "7";
            this.result7.Name = "result7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NCM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "os 4n° Ncm. EX :2106";
            // 
            // txtCest1
            // 
            this.txtCest1.Location = new System.Drawing.Point(217, 98);
            this.txtCest1.Mask = "00,000,00";
            this.txtCest1.Name = "txtCest1";
            this.txtCest1.Size = new System.Drawing.Size(111, 20);
            this.txtCest1.TabIndex = 12;
            // 
            // txtCest
            // 
            this.txtCest.Location = new System.Drawing.Point(634, 430);
            this.txtCest.Name = "txtCest";
            this.txtCest.Size = new System.Drawing.Size(111, 20);
            this.txtCest.TabIndex = 2;
            this.txtCest.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.txtCest1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.boxEstado);
            this.Controls.Add(this.txtCest);
            this.Controls.Add(this.txtncm2);
            this.Controls.Add(this.txtNcm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNcm;
        private System.Windows.Forms.TextBox txtncm2;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn result2;
        private System.Windows.Forms.DataGridViewTextBoxColumn result3;
        private System.Windows.Forms.DataGridViewTextBoxColumn result4;
        private System.Windows.Forms.DataGridViewTextBoxColumn result5;
        private System.Windows.Forms.DataGridViewTextBoxColumn result6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn result7;
        private System.Windows.Forms.MaskedTextBox txtCest1;
        private System.Windows.Forms.TextBox txtCest;
    }
}


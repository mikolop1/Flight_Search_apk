﻿namespace apk_user
{
    partial class zabukowaneuser
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.projektDataSet = new apk_user.projektDataSet();
            this.zabukowaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabukowaneTableAdapter = new apk_user.projektDataSetTableAdapters.zabukowaneTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idlotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejsceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenabagazuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenabiletuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabukowaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // projektDataSet
            // 
            this.projektDataSet.DataSetName = "projektDataSet";
            this.projektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zabukowaneBindingSource
            // 
            this.zabukowaneBindingSource.DataMember = "zabukowane";
            this.zabukowaneBindingSource.DataSource = this.projektDataSet;
            // 
            // zabukowaneTableAdapter
            // 
            this.zabukowaneTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlotu,
            this.miejsceDataGridViewTextBoxColumn,
            this.userid,
            this.cenabagazuDataGridViewTextBoxColumn,
            this.cenabiletuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.zabukowaneBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(810, 585);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idlotu
            // 
            this.idlotu.DataPropertyName = "idlotu";
            this.idlotu.HeaderText = "ID Flight";
            this.idlotu.MinimumWidth = 6;
            this.idlotu.Name = "idlotu";
            this.idlotu.ReadOnly = true;
            // 
            // miejsceDataGridViewTextBoxColumn
            // 
            this.miejsceDataGridViewTextBoxColumn.DataPropertyName = "miejsce";
            this.miejsceDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.miejsceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miejsceDataGridViewTextBoxColumn.Name = "miejsceDataGridViewTextBoxColumn";
            this.miejsceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "ID User";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // cenabagazuDataGridViewTextBoxColumn
            // 
            this.cenabagazuDataGridViewTextBoxColumn.DataPropertyName = "cenabagazu";
            this.cenabagazuDataGridViewTextBoxColumn.HeaderText = "Luggage Price";
            this.cenabagazuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenabagazuDataGridViewTextBoxColumn.Name = "cenabagazuDataGridViewTextBoxColumn";
            this.cenabagazuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenabiletuDataGridViewTextBoxColumn
            // 
            this.cenabiletuDataGridViewTextBoxColumn.DataPropertyName = "cenabiletu";
            this.cenabiletuDataGridViewTextBoxColumn.HeaderText = "Flight Price";
            this.cenabiletuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenabiletuDataGridViewTextBoxColumn.Name = "cenabiletuDataGridViewTextBoxColumn";
            this.cenabiletuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zabukowaneuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "zabukowaneuser";
            this.Size = new System.Drawing.Size(810, 585);
            this.Load += new System.EventHandler(this.zabukowaneuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabukowaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private projektDataSet projektDataSet;
        private System.Windows.Forms.BindingSource zabukowaneBindingSource;
        private projektDataSetTableAdapters.zabukowaneTableAdapter zabukowaneTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejsceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenabagazuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenabiletuDataGridViewTextBoxColumn;
    }
}

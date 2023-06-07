namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.Label();
            this.txtFillSexe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView = new System.Windows.Forms.ListView();
            this.cbxSexe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Box4 = new System.Windows.Forms.TextBox();
            this.btnListView = new System.Windows.Forms.Button();
            this.bntSwap = new System.Windows.Forms.Button();
            this.bntFill_DropList = new System.Windows.Forms.Button();
            this.bntFillgrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(61, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 20);
            this.txtNom.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.AutoSize = true;
            this.txtPrenom.Location = new System.Drawing.Point(291, 37);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(43, 13);
            this.txtPrenom.TabIndex = 2;
            this.txtPrenom.Text = "Prénom";
            this.txtPrenom.Click += new System.EventHandler(this.txtPrenom_Click);
            // 
            // txtFillSexe
            // 
            this.txtFillSexe.Location = new System.Drawing.Point(604, 34);
            this.txtFillSexe.Name = "txtFillSexe";
            this.txtFillSexe.Size = new System.Drawing.Size(151, 20);
            this.txtFillSexe.TabIndex = 5;
            this.txtFillSexe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fill DropDown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexe";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(344, 81);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(153, 20);
            this.txtAdress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adress";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(61, 81);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(169, 20);
            this.txtAge.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Age";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(768, 36);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(56, 17);
            this.txtStatus.TabIndex = 12;
            this.txtStatus.Text = "Status";
            this.txtStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Age,
            this.Adress,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 143);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(626, 199);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(243, 122);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // cbxSexe
            // 
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.Location = new System.Drawing.Point(604, 84);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(151, 21);
            this.cbxSexe.TabIndex = 15;
            this.cbxSexe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Item";
            // 
            // txt_Box4
            // 
            this.txt_Box4.Location = new System.Drawing.Point(659, 173);
            this.txt_Box4.Name = "txt_Box4";
            this.txt_Box4.Size = new System.Drawing.Size(119, 20);
            this.txt_Box4.TabIndex = 17;
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(784, 173);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(79, 19);
            this.btnListView.TabIndex = 18;
            this.btnListView.Text = "Fill List View";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // bntSwap
            // 
            this.bntSwap.Location = new System.Drawing.Point(36, 369);
            this.bntSwap.Name = "bntSwap";
            this.bntSwap.Size = new System.Drawing.Size(77, 26);
            this.bntSwap.TabIndex = 19;
            this.bntSwap.Text = "SWAP";
            this.bntSwap.UseVisualStyleBackColor = true;
            this.bntSwap.Click += new System.EventHandler(this.bntSwap_Click);
            // 
            // bntFill_DropList
            // 
            this.bntFill_DropList.Location = new System.Drawing.Point(239, 369);
            this.bntFill_DropList.Name = "bntFill_DropList";
            this.bntFill_DropList.Size = new System.Drawing.Size(77, 26);
            this.bntFill_DropList.TabIndex = 20;
            this.bntFill_DropList.Text = "Fill DropList";
            this.bntFill_DropList.UseVisualStyleBackColor = true;
            this.bntFill_DropList.Click += new System.EventHandler(this.bntFill_DropList_Click);
            // 
            // bntFillgrid
            // 
            this.bntFillgrid.Location = new System.Drawing.Point(435, 369);
            this.bntFillgrid.Name = "bntFillgrid";
            this.bntFillgrid.Size = new System.Drawing.Size(77, 26);
            this.bntFillgrid.TabIndex = 21;
            this.bntFillgrid.Text = "Fill Grid";
            this.bntFillgrid.UseVisualStyleBackColor = true;
            this.bntFillgrid.Click += new System.EventHandler(this.bntFillgrid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntFillgrid);
            this.Controls.Add(this.bntFill_DropList);
            this.Controls.Add(this.bntSwap);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.txt_Box4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSexe);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFillSexe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtPrenom;
        private System.Windows.Forms.TextBox txtFillSexe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox txtStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox cbxSexe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Box4;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button bntSwap;
        private System.Windows.Forms.Button bntFill_DropList;
        private System.Windows.Forms.Button bntFillgrid;
        private System.Windows.Forms.Label label2;
    }
}


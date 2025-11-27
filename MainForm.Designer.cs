using System;

namespace MachineMaintenanceApp
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.machineName = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.cbMaintenanceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMaintenance = new System.Windows.Forms.Button();
            this.btnLoadMaintenance = new System.Windows.Forms.Button();
            this.btnDeleteMaintenance = new System.Windows.Forms.Button();
            this.lblMachines = new System.Windows.Forms.Label();
            this.cbMachines = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(228, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(408, 23);
            this.txtName.TabIndex = 0;
            // 
            // machineName
            // 
            this.machineName.AutoSize = true;
            this.machineName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.machineName.Location = new System.Drawing.Point(12, 12);
            this.machineName.Name = "machineName";
            this.machineName.Size = new System.Drawing.Size(118, 16);
            this.machineName.TabIndex = 1;
            this.machineName.Text = "Machine Name:";
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtDate.Location = new System.Drawing.Point(228, 111);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(408, 23);
            this.dtDate.TabIndex = 2;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.Location = new System.Drawing.Point(13, 111);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(178, 16);
            this.date.TabIndex = 3;
            this.date.Text = "Last Maintenance Date:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotes.Location = new System.Drawing.Point(228, 141);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(408, 81);
            this.txtNotes.TabIndex = 4;
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notes.Location = new System.Drawing.Point(13, 141);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(54, 16);
            this.notes.TabIndex = 5;
            this.notes.Text = "Notes:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(228, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(330, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(432, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoad.Location = new System.Drawing.Point(534, 228);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 47);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load Machines";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Location = new System.Drawing.Point(16, 281);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            this.dgvMachines.RowHeadersWidth = 51;
            this.dgvMachines.RowTemplate.Height = 24;
            this.dgvMachines.Size = new System.Drawing.Size(620, 205);
            this.dgvMachines.TabIndex = 10;
            // 
            // cbMaintenanceType
            // 
            this.cbMaintenanceType.FormattingEnabled = true;
            this.cbMaintenanceType.Location = new System.Drawing.Point(228, 73);
            this.cbMaintenanceType.Name = "cbMaintenanceType";
            this.cbMaintenanceType.Size = new System.Drawing.Size(408, 24);
            this.cbMaintenanceType.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Maintenance Type:";
            // 
            // btnAddMaintenance
            // 
            this.btnAddMaintenance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnAddMaintenance.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMaintenance.Location = new System.Drawing.Point(12, 175);
            this.btnAddMaintenance.Name = "btnAddMaintenance";
            this.btnAddMaintenance.Size = new System.Drawing.Size(210, 47);
            this.btnAddMaintenance.TabIndex = 14;
            this.btnAddMaintenance.Text = "Add Maintenance";
            this.btnAddMaintenance.UseVisualStyleBackColor = false;
            this.btnAddMaintenance.Click += new System.EventHandler(this.btnAddMaintenance_Click);
            // 
            // btnLoadMaintenance
            // 
            this.btnLoadMaintenance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnLoadMaintenance.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadMaintenance.Location = new System.Drawing.Point(120, 228);
            this.btnLoadMaintenance.Name = "btnLoadMaintenance";
            this.btnLoadMaintenance.Size = new System.Drawing.Size(102, 47);
            this.btnLoadMaintenance.TabIndex = 15;
            this.btnLoadMaintenance.Text = "Load M";
            this.btnLoadMaintenance.UseVisualStyleBackColor = false;
            this.btnLoadMaintenance.Click += new System.EventHandler(this.btnLoadMaintenance_Click);
            // 
            // btnDeleteMaintenance
            // 
            this.btnDeleteMaintenance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnDeleteMaintenance.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMaintenance.Location = new System.Drawing.Point(12, 228);
            this.btnDeleteMaintenance.Name = "btnDeleteMaintenance";
            this.btnDeleteMaintenance.Size = new System.Drawing.Size(102, 47);
            this.btnDeleteMaintenance.TabIndex = 16;
            this.btnDeleteMaintenance.Text = "Delete M";
            this.btnDeleteMaintenance.UseVisualStyleBackColor = false;
            this.btnDeleteMaintenance.Click += new System.EventHandler(this.btnDeleteMaintenance_Click);
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblMachines.Location = new System.Drawing.Point(12, 41);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(111, 16);
            this.lblMachines.TabIndex = 18;
            this.lblMachines.Text = "Machine Type:";
            // 
            // cbMachines
            // 
            this.cbMachines.FormattingEnabled = true;
            this.cbMachines.Location = new System.Drawing.Point(228, 41);
            this.cbMachines.Name = "cbMachines";
            this.cbMachines.Size = new System.Drawing.Size(408, 24);
            this.cbMachines.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 516);
            this.Controls.Add(this.lblMachines);
            this.Controls.Add(this.cbMachines);
            this.Controls.Add(this.btnDeleteMaintenance);
            this.Controls.Add(this.btnLoadMaintenance);
            this.Controls.Add(this.btnAddMaintenance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaintenanceType);
            this.Controls.Add(this.dgvMachines);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.machineName);
            this.Controls.Add(this.txtName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label machineName;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.ComboBox cbMaintenanceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMaintenance;
        private System.Windows.Forms.Button btnLoadMaintenance;
        private System.Windows.Forms.Button btnDeleteMaintenance;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.ComboBox cbMachines;
    }
}


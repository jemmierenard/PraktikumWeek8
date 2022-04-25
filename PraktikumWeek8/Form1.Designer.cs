namespace PraktikumWeek8
{
    partial class FormHasilPertandingan
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
            this.cBoxHome = new System.Windows.Forms.ComboBox();
            this.cBoxLawan = new System.Windows.Forms.ComboBox();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblManagHome = new System.Windows.Forms.Label();
            this.lblCaptHome = new System.Windows.Forms.Label();
            this.lblManagHomeIsi = new System.Windows.Forms.Label();
            this.lblCaptHomeIsi = new System.Windows.Forms.Label();
            this.lblCaptLawanIsi = new System.Windows.Forms.Label();
            this.lblManagLawanIsi = new System.Windows.Forms.Label();
            this.lblCaptLawan = new System.Windows.Forms.Label();
            this.lblManagLawan = new System.Windows.Forms.Label();
            this.lblCapacityIsi = new System.Windows.Forms.Label();
            this.lblStadiumIsi = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblTgl = new System.Windows.Forms.Label();
            this.lblIsiSkor = new System.Windows.Forms.Label();
            this.lblIsiTgl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxHome
            // 
            this.cBoxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxHome.FormattingEnabled = true;
            this.cBoxHome.Location = new System.Drawing.Point(45, 46);
            this.cBoxHome.Name = "cBoxHome";
            this.cBoxHome.Size = new System.Drawing.Size(198, 28);
            this.cBoxHome.TabIndex = 0;
            this.cBoxHome.SelectedIndexChanged += new System.EventHandler(this.cBoxHome_SelectedIndexChanged);
            // 
            // cBoxLawan
            // 
            this.cBoxLawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLawan.FormattingEnabled = true;
            this.cBoxLawan.Location = new System.Drawing.Point(510, 46);
            this.cBoxLawan.Name = "cBoxLawan";
            this.cBoxLawan.Size = new System.Drawing.Size(198, 28);
            this.cBoxLawan.TabIndex = 1;
            this.cBoxLawan.SelectedIndexChanged += new System.EventHandler(this.cBoxLawan_SelectedIndexChanged);
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.Location = new System.Drawing.Point(360, 50);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(31, 20);
            this.lblVs.TabIndex = 2;
            this.lblVs.Text = "VS";
            // 
            // lblManagHome
            // 
            this.lblManagHome.AutoSize = true;
            this.lblManagHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagHome.Location = new System.Drawing.Point(40, 109);
            this.lblManagHome.Name = "lblManagHome";
            this.lblManagHome.Size = new System.Drawing.Size(84, 20);
            this.lblManagHome.TabIndex = 3;
            this.lblManagHome.Text = "Manager :";
            // 
            // lblCaptHome
            // 
            this.lblCaptHome.AutoSize = true;
            this.lblCaptHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptHome.Location = new System.Drawing.Point(48, 154);
            this.lblCaptHome.Name = "lblCaptHome";
            this.lblCaptHome.Size = new System.Drawing.Size(76, 20);
            this.lblCaptHome.TabIndex = 4;
            this.lblCaptHome.Text = "Captain :";
            // 
            // lblManagHomeIsi
            // 
            this.lblManagHomeIsi.AutoSize = true;
            this.lblManagHomeIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagHomeIsi.Location = new System.Drawing.Point(177, 109);
            this.lblManagHomeIsi.Name = "lblManagHomeIsi";
            this.lblManagHomeIsi.Size = new System.Drawing.Size(0, 20);
            this.lblManagHomeIsi.TabIndex = 5;
            // 
            // lblCaptHomeIsi
            // 
            this.lblCaptHomeIsi.AutoSize = true;
            this.lblCaptHomeIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptHomeIsi.Location = new System.Drawing.Point(177, 170);
            this.lblCaptHomeIsi.Name = "lblCaptHomeIsi";
            this.lblCaptHomeIsi.Size = new System.Drawing.Size(0, 20);
            this.lblCaptHomeIsi.TabIndex = 6;
            // 
            // lblCaptLawanIsi
            // 
            this.lblCaptLawanIsi.AutoSize = true;
            this.lblCaptLawanIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptLawanIsi.Location = new System.Drawing.Point(642, 170);
            this.lblCaptLawanIsi.Name = "lblCaptLawanIsi";
            this.lblCaptLawanIsi.Size = new System.Drawing.Size(0, 20);
            this.lblCaptLawanIsi.TabIndex = 10;
            // 
            // lblManagLawanIsi
            // 
            this.lblManagLawanIsi.AutoSize = true;
            this.lblManagLawanIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagLawanIsi.Location = new System.Drawing.Point(642, 109);
            this.lblManagLawanIsi.Name = "lblManagLawanIsi";
            this.lblManagLawanIsi.Size = new System.Drawing.Size(0, 20);
            this.lblManagLawanIsi.TabIndex = 9;
            // 
            // lblCaptLawan
            // 
            this.lblCaptLawan.AutoSize = true;
            this.lblCaptLawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptLawan.Location = new System.Drawing.Point(508, 154);
            this.lblCaptLawan.Name = "lblCaptLawan";
            this.lblCaptLawan.Size = new System.Drawing.Size(81, 20);
            this.lblCaptLawan.TabIndex = 8;
            this.lblCaptLawan.Text = "Captain : ";
            // 
            // lblManagLawan
            // 
            this.lblManagLawan.AutoSize = true;
            this.lblManagLawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagLawan.Location = new System.Drawing.Point(505, 109);
            this.lblManagLawan.Name = "lblManagLawan";
            this.lblManagLawan.Size = new System.Drawing.Size(84, 20);
            this.lblManagLawan.TabIndex = 7;
            this.lblManagLawan.Text = "Manager :";
            // 
            // lblCapacityIsi
            // 
            this.lblCapacityIsi.AutoSize = true;
            this.lblCapacityIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityIsi.Location = new System.Drawing.Point(393, 224);
            this.lblCapacityIsi.Name = "lblCapacityIsi";
            this.lblCapacityIsi.Size = new System.Drawing.Size(0, 25);
            this.lblCapacityIsi.TabIndex = 14;
            // 
            // lblStadiumIsi
            // 
            this.lblStadiumIsi.AutoSize = true;
            this.lblStadiumIsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadiumIsi.Location = new System.Drawing.Point(394, 186);
            this.lblStadiumIsi.Name = "lblStadiumIsi";
            this.lblStadiumIsi.Size = new System.Drawing.Size(0, 20);
            this.lblStadiumIsi.TabIndex = 13;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(282, 224);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(84, 20);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "Capacity :";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.Location = new System.Drawing.Point(286, 186);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(80, 20);
            this.lblStadium.TabIndex = 11;
            this.lblStadium.Text = "Stadium :";
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(12, 390);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 51;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.Size = new System.Drawing.Size(776, 334);
            this.dgvMatch.TabIndex = 15;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(315, 263);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(105, 33);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(311, 351);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(53, 20);
            this.lblSkor.TabIndex = 18;
            this.lblSkor.Text = "Skor :";
            // 
            // lblTgl
            // 
            this.lblTgl.AutoSize = true;
            this.lblTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgl.Location = new System.Drawing.Point(282, 311);
            this.lblTgl.Name = "lblTgl";
            this.lblTgl.Size = new System.Drawing.Size(78, 20);
            this.lblTgl.TabIndex = 17;
            this.lblTgl.Text = "Tanggal :";
            // 
            // lblIsiSkor
            // 
            this.lblIsiSkor.AutoSize = true;
            this.lblIsiSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsiSkor.Location = new System.Drawing.Point(391, 351);
            this.lblIsiSkor.Name = "lblIsiSkor";
            this.lblIsiSkor.Size = new System.Drawing.Size(0, 20);
            this.lblIsiSkor.TabIndex = 20;
            // 
            // lblIsiTgl
            // 
            this.lblIsiTgl.AutoSize = true;
            this.lblIsiTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsiTgl.Location = new System.Drawing.Point(391, 311);
            this.lblIsiTgl.Name = "lblIsiTgl";
            this.lblIsiTgl.Size = new System.Drawing.Size(0, 20);
            this.lblIsiTgl.TabIndex = 19;
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.lblIsiSkor);
            this.Controls.Add(this.lblIsiTgl);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblTgl);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.lblCapacityIsi);
            this.Controls.Add(this.lblStadiumIsi);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblCaptLawanIsi);
            this.Controls.Add(this.lblManagLawanIsi);
            this.Controls.Add(this.lblCaptLawan);
            this.Controls.Add(this.lblManagLawan);
            this.Controls.Add(this.lblCaptHomeIsi);
            this.Controls.Add(this.lblManagHomeIsi);
            this.Controls.Add(this.lblCaptHome);
            this.Controls.Add(this.lblManagHome);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.cBoxLawan);
            this.Controls.Add(this.cBoxHome);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxHome;
        private System.Windows.Forms.ComboBox cBoxLawan;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblManagHome;
        private System.Windows.Forms.Label lblCaptHome;
        private System.Windows.Forms.Label lblManagHomeIsi;
        private System.Windows.Forms.Label lblCaptHomeIsi;
        private System.Windows.Forms.Label lblCaptLawanIsi;
        private System.Windows.Forms.Label lblManagLawanIsi;
        private System.Windows.Forms.Label lblCaptLawan;
        private System.Windows.Forms.Label lblManagLawan;
        private System.Windows.Forms.Label lblCapacityIsi;
        private System.Windows.Forms.Label lblStadiumIsi;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblTgl;
        private System.Windows.Forms.Label lblIsiSkor;
        private System.Windows.Forms.Label lblIsiTgl;
    }
}


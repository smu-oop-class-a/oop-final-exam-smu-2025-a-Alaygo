namespace OOP.FinalTerm.Exam.Views
{
    partial class DirectorForm
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
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numTotalMovies = new NumericUpDown();
            txtGenres = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalMovies).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 50);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Director";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 60);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 60, 60);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(270, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(221, 0, 0);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(130, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numTotalMovies);
            panel3.Controls.Add(txtGenres);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(txtFirstName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(500, 360);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans Ultra Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(18, 39);
            label5.Name = "label5";
            label5.Size = new Size(181, 42);
            label5.TabIndex = 8;
            label5.Text = "Welcome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(353, 85);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Total Movies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(54, 191);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Genres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(37, 150);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 108);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // numTotalMovies
            // 
            numTotalMovies.BackColor = Color.White;
            numTotalMovies.ForeColor = SystemColors.MenuText;
            numTotalMovies.Location = new Point(351, 103);
            numTotalMovies.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTotalMovies.Name = "numTotalMovies";
            numTotalMovies.Size = new Size(120, 23);
            numTotalMovies.TabIndex = 3;
            // 
            // txtGenres
            // 
            txtGenres.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGenres.Location = new Point(104, 188);
            txtGenres.Name = "txtGenres";
            txtGenres.Size = new Size(221, 21);
            txtGenres.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(104, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 21);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(104, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(221, 21);
            txtFirstName.TabIndex = 0;
            // 
            // DirectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            CancelButton = btnCancel;
            ClientSize = new Size(500, 470);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DirectorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Director";
            Load += DirectorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel3;
        private NumericUpDown numTotalMovies;
        private TextBox txtGenres;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
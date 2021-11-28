
namespace OnlineSchool
{
    partial class FrmTeacherSection
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
            this.GridList = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TEACHER_ID_NO = new System.Windows.Forms.TextBox();
            this.REC_NO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SECTION_NO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridList
            // 
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridList.Location = new System.Drawing.Point(316, 0);
            this.GridList.Name = "GridList";
            this.GridList.Size = new System.Drawing.Size(484, 450);
            this.GridList.TabIndex = 5;
            this.GridList.DoubleClick += new System.EventHandler(this.GridList_DoubleClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.SteelBlue;
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.SECTION_NO);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.TEACHER_ID_NO);
            this.panel.Controls.Add(this.REC_NO);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(316, 450);
            this.panel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 56);
            this.panel2.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(212, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 56);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(105, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 56);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNew.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.Location = new System.Drawing.Point(0, 0);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(105, 56);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "Refresh";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher ID No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rec No";
            // 
            // TEACHER_ID_NO
            // 
            this.TEACHER_ID_NO.Location = new System.Drawing.Point(140, 72);
            this.TEACHER_ID_NO.Name = "TEACHER_ID_NO";
            this.TEACHER_ID_NO.Size = new System.Drawing.Size(158, 20);
            this.TEACHER_ID_NO.TabIndex = 1;
            // 
            // REC_NO
            // 
            this.REC_NO.Enabled = false;
            this.REC_NO.Location = new System.Drawing.Point(140, 37);
            this.REC_NO.Name = "REC_NO";
            this.REC_NO.Size = new System.Drawing.Size(158, 20);
            this.REC_NO.TabIndex = 0;
            this.REC_NO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.REC_NO_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Section No";
            // 
            // SECTION_NO
            // 
            this.SECTION_NO.Location = new System.Drawing.Point(140, 110);
            this.SECTION_NO.Name = "SECTION_NO";
            this.SECTION_NO.Size = new System.Drawing.Size(158, 20);
            this.SECTION_NO.TabIndex = 6;
            this.SECTION_NO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.REC_NO_KeyPress);
            // 
            // FrmTeacherSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridList);
            this.Controls.Add(this.panel);
            this.Name = "FrmTeacherSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Section";
            this.Load += new System.EventHandler(this.FrmTeacherSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridList;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEACHER_ID_NO;
        private System.Windows.Forms.TextBox REC_NO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SECTION_NO;
    }
}
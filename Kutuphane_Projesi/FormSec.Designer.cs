namespace Kutuphane_Projesi
{
    partial class FormSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSec));
            this.dataGridViewSec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSec)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSec
            // 
            this.dataGridViewSec.AllowUserToDeleteRows = false;
            this.dataGridViewSec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSec.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSec.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewSec.MultiSelect = false;
            this.dataGridViewSec.Name = "dataGridViewSec";
            this.dataGridViewSec.ReadOnly = true;
            this.dataGridViewSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSec.Size = new System.Drawing.Size(591, 300);
            this.dataGridViewSec.TabIndex = 2;
            this.dataGridViewSec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSec_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim:";
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIsim.Location = new System.Drawing.Point(72, 7);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(155, 26);
            this.textBoxIsim.TabIndex = 1;
            this.textBoxIsim.TextChanged += new System.EventHandler(this.textBoxIsim_TextChanged);
            // 
            // FormSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 351);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(631, 390);
            this.Name = "FormSec";
            this.Text = "Seç";
            this.Load += new System.EventHandler(this.FormSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIsim;
    }
}
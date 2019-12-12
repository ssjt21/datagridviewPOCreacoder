namespace PocExpRecoder
{
    partial class FormSQLiteConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQLiteConfig));
            this.labelSQLiteConfig = new System.Windows.Forms.Label();
            this.txtBoxSQLiteConfig = new System.Windows.Forms.TextBox();
            this.btnChangeSQLite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSQLiteConfig
            // 
            this.labelSQLiteConfig.AutoSize = true;
            this.labelSQLiteConfig.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSQLiteConfig.Location = new System.Drawing.Point(12, 22);
            this.labelSQLiteConfig.Name = "labelSQLiteConfig";
            this.labelSQLiteConfig.Size = new System.Drawing.Size(230, 21);
            this.labelSQLiteConfig.TabIndex = 0;
            this.labelSQLiteConfig.Text = "当前SQLite文件配置：";
            // 
            // txtBoxSQLiteConfig
            // 
            this.txtBoxSQLiteConfig.Enabled = false;
            this.txtBoxSQLiteConfig.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSQLiteConfig.Location = new System.Drawing.Point(16, 58);
            this.txtBoxSQLiteConfig.Name = "txtBoxSQLiteConfig";
            this.txtBoxSQLiteConfig.Size = new System.Drawing.Size(972, 28);
            this.txtBoxSQLiteConfig.TabIndex = 1;
            this.txtBoxSQLiteConfig.TextChanged += new System.EventHandler(this.txtBoxSQLiteConfig_TextChanged);
            // 
            // btnChangeSQLite
            // 
            this.btnChangeSQLite.Location = new System.Drawing.Point(812, 108);
            this.btnChangeSQLite.Name = "btnChangeSQLite";
            this.btnChangeSQLite.Size = new System.Drawing.Size(176, 35);
            this.btnChangeSQLite.TabIndex = 2;
            this.btnChangeSQLite.Text = "修改";
            this.btnChangeSQLite.UseVisualStyleBackColor = true;
            this.btnChangeSQLite.Click += new System.EventHandler(this.btnChangeSQLite_Click);
            // 
            // FormSQLiteConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 174);
            this.Controls.Add(this.btnChangeSQLite);
            this.Controls.Add(this.txtBoxSQLiteConfig);
            this.Controls.Add(this.labelSQLiteConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSQLiteConfig";
            this.Text = "SQLite文件路径配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSQLiteConfig;
        private System.Windows.Forms.TextBox txtBoxSQLiteConfig;
        private System.Windows.Forms.Button btnChangeSQLite;
    }
}
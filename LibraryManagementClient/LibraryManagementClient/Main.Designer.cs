namespace LibraryManagementClient
{
    partial class Main
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
            this.manageBooks_btn = new System.Windows.Forms.Button();
            this.manageCategories_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageBooks_btn
            // 
            this.manageBooks_btn.Location = new System.Drawing.Point(168, 214);
            this.manageBooks_btn.Name = "manageBooks_btn";
            this.manageBooks_btn.Size = new System.Drawing.Size(200, 53);
            this.manageBooks_btn.TabIndex = 0;
            this.manageBooks_btn.Text = "Manage Books";
            this.manageBooks_btn.UseVisualStyleBackColor = true;
            this.manageBooks_btn.Click += new System.EventHandler(this.manageBooks_btn_Click);
            // 
            // manageCategories_btn
            // 
            this.manageCategories_btn.Location = new System.Drawing.Point(168, 341);
            this.manageCategories_btn.Name = "manageCategories_btn";
            this.manageCategories_btn.Size = new System.Drawing.Size(200, 53);
            this.manageCategories_btn.TabIndex = 1;
            this.manageCategories_btn.Text = "Manage Categories";
            this.manageCategories_btn.UseVisualStyleBackColor = true;
            this.manageCategories_btn.Click += new System.EventHandler(this.manageCategories_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 563);
            this.Controls.Add(this.manageCategories_btn);
            this.Controls.Add(this.manageBooks_btn);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageBooks_btn;
        private System.Windows.Forms.Button manageCategories_btn;
    }
}
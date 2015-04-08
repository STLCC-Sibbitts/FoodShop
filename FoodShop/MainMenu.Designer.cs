namespace FoodShop
{
    partial class MainMenu
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1026, 506);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // btn_products
            // 
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Location = new System.Drawing.Point(471, 248);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(194, 59);
            this.btn_products.TabIndex = 9;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            // 
            // btn_store
            // 
            this.btn_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store.Location = new System.Drawing.Point(471, 387);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(194, 59);
            this.btn_store.TabIndex = 10;
            this.btn_store.Text = "Stores";
            this.btn_store.UseVisualStyleBackColor = true;
            // 
            // btn_employees
            // 
            this.btn_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employees.Location = new System.Drawing.Point(471, 119);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(194, 59);
            this.btn_employees.TabIndex = 11;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 564);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_employees;
    }
}
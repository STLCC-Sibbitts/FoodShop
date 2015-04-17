namespace Kitchen_App
{
    partial class Kichen
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
            this.components = new System.ComponentModel.Container();
            this.treeOrders = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.CompletedOrders = new System.Windows.Forms.TreeView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // treeOrders
            // 
            this.treeOrders.BackColor = System.Drawing.SystemColors.Window;
            this.treeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeOrders.Location = new System.Drawing.Point(12, 39);
            this.treeOrders.Name = "treeOrders";
            this.treeOrders.Size = new System.Drawing.Size(393, 465);
            this.treeOrders.TabIndex = 0;
            this.treeOrders.DoubleClick += new System.EventHandler(this.treeViewOrder_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(119, 510);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(101, 33);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // CompletedOrders
            // 
            this.CompletedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.CompletedOrders.Location = new System.Drawing.Point(411, 39);
            this.CompletedOrders.Name = "CompletedOrders";
            this.CompletedOrders.Size = new System.Drawing.Size(393, 465);
            this.CompletedOrders.TabIndex = 3;
            this.CompletedOrders.DoubleClick += new System.EventHandler(this.CompletedOrders_DoubleClick);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 555);
            this.Controls.Add(this.CompletedOrders);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeOrders);
            this.Name = "Form1";
            this.Text = "Kitichen Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TreeView CompletedOrders;
        private System.Windows.Forms.Timer refreshTimer;
    }
}


namespace CoffeeShopBilling
{
    partial class Home
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
            this.AddOrdersBtn1 = new System.Windows.Forms.Button();
            this.viewOrdersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOrdersBtn1
            // 
            this.AddOrdersBtn1.Location = new System.Drawing.Point(41, 55);
            this.AddOrdersBtn1.Name = "AddOrdersBtn1";
            this.AddOrdersBtn1.Size = new System.Drawing.Size(153, 47);
            this.AddOrdersBtn1.TabIndex = 0;
            this.AddOrdersBtn1.Text = "ADD ORDERS";
            this.AddOrdersBtn1.UseVisualStyleBackColor = true;
            this.AddOrdersBtn1.Click += new System.EventHandler(this.AddOrdersBtn1_Click);
            // 
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.Location = new System.Drawing.Point(266, 55);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.Size = new System.Drawing.Size(153, 47);
            this.viewOrdersBtn.TabIndex = 1;
            this.viewOrdersBtn.Text = "VIEW ORDERS";
            this.viewOrdersBtn.UseVisualStyleBackColor = true;
            this.viewOrdersBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopBilling.Properties.Resources.Coffee_backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 554);
            this.Controls.Add(this.viewOrdersBtn);
            this.Controls.Add(this.AddOrdersBtn1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddOrdersBtn1;
        private System.Windows.Forms.Button viewOrdersBtn;
    }
}
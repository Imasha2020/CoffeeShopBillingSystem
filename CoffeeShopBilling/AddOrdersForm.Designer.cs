namespace CoffeeShopBilling
{
    partial class AddOrdersForm
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
            this.addOrderBtn2 = new System.Windows.Forms.Button();
            this.backHomeBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOrderBtn2
            // 
            this.addOrderBtn2.Location = new System.Drawing.Point(153, 494);
            this.addOrderBtn2.Name = "addOrderBtn2";
            this.addOrderBtn2.Size = new System.Drawing.Size(150, 23);
            this.addOrderBtn2.TabIndex = 0;
            this.addOrderBtn2.Text = "ADD ORDER";
            this.addOrderBtn2.UseVisualStyleBackColor = true;
            // 
            // backHomeBtn1
            // 
            this.backHomeBtn1.Location = new System.Drawing.Point(421, 494);
            this.backHomeBtn1.Name = "backHomeBtn1";
            this.backHomeBtn1.Size = new System.Drawing.Size(150, 23);
            this.backHomeBtn1.TabIndex = 1;
            this.backHomeBtn1.Text = "BACK TO HOME";
            this.backHomeBtn1.UseVisualStyleBackColor = true;
            this.backHomeBtn1.Click += new System.EventHandler(this.backHomeBtn1_Click);
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 687);
            this.Controls.Add(this.backHomeBtn1);
            this.Controls.Add(this.addOrderBtn2);
            this.Name = "AddOrdersForm";
            this.Text = "AddOrdersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addOrderBtn2;
        private System.Windows.Forms.Button backHomeBtn1;
    }
}
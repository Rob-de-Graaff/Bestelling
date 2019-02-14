namespace Bestelling
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.buttonRemoveOrder = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxArticles = new System.Windows.Forms.ListBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.buttonRemoveOrder);
            this.panelLayout.Controls.Add(this.numericUpDownAmount);
            this.panelLayout.Controls.Add(this.buttonReset);
            this.panelLayout.Controls.Add(this.listBoxArticles);
            this.panelLayout.Controls.Add(this.buttonAddOrder);
            this.panelLayout.Controls.Add(this.listBoxOrders);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(776, 387);
            this.panelLayout.TabIndex = 29;
            // 
            // buttonRemoveOrder
            // 
            this.buttonRemoveOrder.Location = new System.Drawing.Point(3, 218);
            this.buttonRemoveOrder.Name = "buttonRemoveOrder";
            this.buttonRemoveOrder.Size = new System.Drawing.Size(115, 23);
            this.buttonRemoveOrder.TabIndex = 62;
            this.buttonRemoveOrder.Text = "Remove Order";
            this.buttonRemoveOrder.UseVisualStyleBackColor = true;
            this.buttonRemoveOrder.Click += new System.EventHandler(this.ButtonRemoveOrder_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(3, 77);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.ReadOnly = true;
            this.numericUpDownAmount.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownAmount.TabIndex = 61;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(698, 351);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 33);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listBoxArticles
            // 
            this.listBoxArticles.FormattingEnabled = true;
            this.listBoxArticles.ItemHeight = 16;
            this.listBoxArticles.Location = new System.Drawing.Point(3, 3);
            this.listBoxArticles.Name = "listBoxArticles";
            this.listBoxArticles.Size = new System.Drawing.Size(173, 68);
            this.listBoxArticles.TabIndex = 59;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(3, 115);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(89, 23);
            this.buttonAddOrder.TabIndex = 57;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(3, 144);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(770, 68);
            this.listBoxOrders.TabIndex = 57;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(10, 351);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(7, 314);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(7, 331);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxArticles;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonRemoveOrder;
    }
}


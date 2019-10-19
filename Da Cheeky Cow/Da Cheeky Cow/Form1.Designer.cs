namespace Da_Cheeky_Cow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.typeListbox = new System.Windows.Forms.ListBox();
            this.QtyTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.addOrderbutton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.summaryListbox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.displaylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListbox
            // 
            this.itemListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.ItemHeight = 22;
            this.itemListbox.Items.AddRange(new object[] {
            "Full Irish",
            "Irish Grill",
            "Belmullet Grill",
            "Curry Special",
            "Irish Stew\t",
            "Student Stew",
            "Bacon & Cabbage",
            "Colcannon",
            "Boxty Special",
            "Atlantic Way",
            "Coddle",
            "Snack Box"});
            this.itemListbox.Location = new System.Drawing.Point(174, 28);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(236, 202);
            this.itemListbox.TabIndex = 0;
            this.itemListbox.SelectedIndexChanged += new System.EventHandler(this.itemListbox_SelectedIndexChanged);
            // 
            // typeListbox
            // 
            this.typeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeListbox.FormattingEnabled = true;
            this.typeListbox.ItemHeight = 22;
            this.typeListbox.Items.AddRange(new object[] {
            "Leprechaun",
            "Child",
            "Adult",
            "Student",
            "Cúchulainn"});
            this.typeListbox.Location = new System.Drawing.Point(1009, 32);
            this.typeListbox.Name = "typeListbox";
            this.typeListbox.Size = new System.Drawing.Size(201, 180);
            this.typeListbox.TabIndex = 1;
            this.typeListbox.SelectedIndexChanged += new System.EventHandler(this.typeListbox_SelectedIndexChanged);
            // 
            // QtyTextbox
            // 
            this.QtyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTextbox.Location = new System.Drawing.Point(174, 375);
            this.QtyTextbox.Name = "QtyTextbox";
            this.QtyTextbox.Size = new System.Drawing.Size(236, 28);
            this.QtyTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(56, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity:";
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextbox.Location = new System.Drawing.Point(174, 304);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(236, 28);
            this.PriceTextbox.TabIndex = 5;
            // 
            // addOrderbutton
            // 
            this.addOrderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderbutton.Location = new System.Drawing.Point(60, 441);
            this.addOrderbutton.Name = "addOrderbutton";
            this.addOrderbutton.Size = new System.Drawing.Size(141, 39);
            this.addOrderbutton.TabIndex = 9;
            this.addOrderbutton.Text = "&Add Order";
            this.toolTip1.SetToolTip(this.addOrderbutton, "Displays the running total of the price and quantity selected");
            this.addOrderbutton.UseVisualStyleBackColor = true;
            this.addOrderbutton.Click += new System.EventHandler(this.addOrderbutton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(174, 610);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(142, 39);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "&Order Confirm";
            this.toolTip1.SetToolTip(this.confirmButton, "Displays the details of all the user orders and shows the overall order costs");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1054, 486);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 39);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Close the application and writes all the values in a text output file");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(556, 621);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(180, 25);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Total Order Cost:";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalLabel.Location = new System.Drawing.Point(807, 621);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(0, 25);
            this.finalLabel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(561, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 234);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // summaryListbox
            // 
            this.summaryListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryListbox.FormattingEnabled = true;
            this.summaryListbox.ItemHeight = 25;
            this.summaryListbox.Location = new System.Drawing.Point(471, 349);
            this.summaryListbox.Name = "summaryListbox";
            this.summaryListbox.Size = new System.Drawing.Size(541, 229);
            this.summaryListbox.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(273, 441);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 39);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Resets all the orders made by the users");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.04082F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.95918F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(472, 307);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(540, 43);
            this.tableLayoutPanel.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(429, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 34);
            this.label13.TabIndex = 4;
            this.label13.Text = "Price of each item";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Meal Size";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(199, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Meal Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Location = new System.Drawing.Point(105, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Transaction No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displaylabel
            // 
            this.displaylabel.AutoSize = true;
            this.displaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaylabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displaylabel.Location = new System.Drawing.Point(113, 541);
            this.displaylabel.Name = "displaylabel";
            this.displaylabel.Size = new System.Drawing.Size(0, 20);
            this.displaylabel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Meal Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(884, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Meal Type:";
            // 
            // transactLabel
            // 
            this.transactLabel.AutoSize = true;
            this.transactLabel.Location = new System.Drawing.Point(1162, 45);
            this.transactLabel.Name = "transactLabel";
            this.transactLabel.Size = new System.Drawing.Size(0, 17);
            this.transactLabel.TabIndex = 20;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(1054, 363);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(134, 39);
            this.submitButton.TabIndex = 21;
            this.submitButton.Text = "&Submit";
            this.toolTip1.SetToolTip(this.submitButton, "Confirmation message that order has been processed");
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1248, 728);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.transactLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displaylabel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.summaryListbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.addOrderbutton);
            this.Controls.Add(this.QtyTextbox);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeListbox);
            this.Controls.Add(this.itemListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.ListBox typeListbox;
        private System.Windows.Forms.TextBox QtyTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Button addOrderbutton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox summaryListbox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label displaylabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label transactLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


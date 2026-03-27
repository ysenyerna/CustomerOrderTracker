namespace CustomerOrderTracker
{
    partial class OrderForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbTotalAmount = new TextBox();
            lblDate = new Label();
            lblTotalAmount = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnConfirm = new Button();
            btnCancel = new Button();
            dtpDate = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(425, 148);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tbTotalAmount, 1, 1);
            tableLayoutPanel2.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel2.Controls.Add(lblTotalAmount, 0, 1);
            tableLayoutPanel2.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(419, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tbTotalAmount
            // 
            tbTotalAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbTotalAmount.Location = new Point(94, 59);
            tbTotalAmount.Name = "tbTotalAmount";
            tbTotalAmount.Size = new Size(322, 23);
            tbTotalAmount.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(85, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date: ";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(3, 63);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(85, 15);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Total Amount: ";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnConfirm, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 103);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(419, 44);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.Location = new Point(3, 10);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(203, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(212, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(204, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Location = new Point(94, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(322, 23);
            dtpDate.TabIndex = 4;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 148);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderForm";
            Text = "Order";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbTotalAmount;
        private Label lblDate;
        private Label lblTotalAmount;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnConfirm;
        private Button btnCancel;
        private DateTimePicker dtpDate;
    }
}
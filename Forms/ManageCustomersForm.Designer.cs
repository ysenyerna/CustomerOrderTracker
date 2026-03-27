namespace CustomerOrderTracker;

partial class ManageCustomersForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        btnDeleteCustomer = new Button();
        btnManageOrders = new Button();
        btnUpdateCustomer = new Button();
        btnAddCustomer = new Button();
        lblStatus = new Label();
        grpCustomerList = new GroupBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        lblSearchCustomer = new Label();
        tbSearchName = new TextBox();
        dgvCustomers = new DataGridView();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        grpCustomerList.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(lblStatus, 0, 1);
        tableLayoutPanel1.Controls.Add(grpCustomerList, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(664, 395);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.Controls.Add(btnDeleteCustomer, 3, 0);
        tableLayoutPanel2.Controls.Add(btnManageOrders, 2, 0);
        tableLayoutPanel2.Controls.Add(btnUpdateCustomer, 1, 0);
        tableLayoutPanel2.Controls.Add(btnAddCustomer, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(658, 34);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // btnDeleteCustomer
        // 
        btnDeleteCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnDeleteCustomer.Location = new Point(495, 5);
        btnDeleteCustomer.Name = "btnDeleteCustomer";
        btnDeleteCustomer.Size = new Size(160, 23);
        btnDeleteCustomer.TabIndex = 3;
        btnDeleteCustomer.Text = "Delete Customer";
        btnDeleteCustomer.UseVisualStyleBackColor = true;
        // 
        // btnManageOrders
        // 
        btnManageOrders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnManageOrders.Location = new Point(331, 5);
        btnManageOrders.Name = "btnManageOrders";
        btnManageOrders.Size = new Size(158, 23);
        btnManageOrders.TabIndex = 2;
        btnManageOrders.Text = "Manage Orders";
        btnManageOrders.UseVisualStyleBackColor = true;
        // 
        // btnUpdateCustomer
        // 
        btnUpdateCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnUpdateCustomer.Location = new Point(167, 5);
        btnUpdateCustomer.Name = "btnUpdateCustomer";
        btnUpdateCustomer.Size = new Size(158, 23);
        btnUpdateCustomer.TabIndex = 1;
        btnUpdateCustomer.Text = "Update Customer";
        btnUpdateCustomer.UseVisualStyleBackColor = true;
        // 
        // btnAddCustomer
        // 
        btnAddCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnAddCustomer.Location = new Point(3, 5);
        btnAddCustomer.Name = "btnAddCustomer";
        btnAddCustomer.Size = new Size(158, 23);
        btnAddCustomer.TabIndex = 0;
        btnAddCustomer.Text = "Add Customer";
        btnAddCustomer.UseVisualStyleBackColor = true;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(3, 52);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(658, 15);
        lblStatus.TabIndex = 1;
        lblStatus.Text = "Status: ";
        // 
        // grpCustomerList
        // 
        grpCustomerList.Controls.Add(tableLayoutPanel3);
        grpCustomerList.Dock = DockStyle.Fill;
        grpCustomerList.Location = new Point(3, 83);
        grpCustomerList.Name = "grpCustomerList";
        grpCustomerList.Size = new Size(658, 309);
        grpCustomerList.TabIndex = 2;
        grpCustomerList.TabStop = false;
        grpCustomerList.Text = "Customer List";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel3.Controls.Add(dgvCustomers, 0, 1);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 19);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(652, 287);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(lblSearchCustomer, 0, 0);
        tableLayoutPanel4.Controls.Add(tbSearchName, 1, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new Size(646, 44);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // lblSearchCustomer
        // 
        lblSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblSearchCustomer.AutoSize = true;
        lblSearchCustomer.Location = new Point(3, 14);
        lblSearchCustomer.Name = "lblSearchCustomer";
        lblSearchCustomer.Size = new Size(159, 15);
        lblSearchCustomer.TabIndex = 0;
        lblSearchCustomer.Text = "Search Customers by Name: ";
        // 
        // tbSearchName
        // 
        tbSearchName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        tbSearchName.Location = new Point(168, 10);
        tbSearchName.Name = "tbSearchName";
        tbSearchName.Size = new Size(475, 23);
        tbSearchName.TabIndex = 1;
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.AllowUserToDeleteRows = false;
        dgvCustomers.AllowUserToResizeColumns = false;
        dgvCustomers.AllowUserToResizeRows = false;
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCustomers.BackgroundColor = SystemColors.ControlLight;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Dock = DockStyle.Fill;
        dgvCustomers.Location = new Point(3, 53);
        dgvCustomers.MultiSelect = false;
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCustomers.Size = new Size(646, 231);
        dgvCustomers.TabIndex = 1;
        // 
        // ManageCustomersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(664, 395);
        Controls.Add(tableLayoutPanel1);
        Name = "ManageCustomersForm";
        Text = "Customer Manager";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        grpCustomerList.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btnDeleteCustomer;
    private Button btnManageOrders;
    private Button btnUpdateCustomer;
    private Button btnAddCustomer;
    private Label lblStatus;
    private GroupBox grpCustomerList;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
    private Label lblSearchCustomer;
    private TextBox tbSearchName;
    private DataGridView dgvCustomers;
}

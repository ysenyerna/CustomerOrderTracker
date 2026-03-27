namespace CustomerOrderTracker;

partial class ManageOrdersForm
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
        btnDeleteOrder = new Button();
        btnUpdateOrder = new Button();
        btnAddOrder = new Button();
        lblStatus = new Label();
        grpOrderList = new GroupBox();
        dgvOrders = new DataGridView();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        grpOrderList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(lblStatus, 0, 1);
        tableLayoutPanel1.Controls.Add(grpOrderList, 0, 2);
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
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel2.Controls.Add(btnDeleteOrder, 2, 0);
        tableLayoutPanel2.Controls.Add(btnUpdateOrder, 1, 0);
        tableLayoutPanel2.Controls.Add(btnAddOrder, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(658, 34);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // btnDeleteOrder
        // 
        btnDeleteOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnDeleteOrder.Location = new Point(441, 5);
        btnDeleteOrder.Name = "btnDeleteOrder";
        btnDeleteOrder.Size = new Size(214, 23);
        btnDeleteOrder.TabIndex = 2;
        btnDeleteOrder.Text = "Delete Order";
        btnDeleteOrder.UseVisualStyleBackColor = true;
        // 
        // btnUpdateOrder
        // 
        btnUpdateOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnUpdateOrder.Location = new Point(222, 5);
        btnUpdateOrder.Name = "btnUpdateOrder";
        btnUpdateOrder.Size = new Size(213, 23);
        btnUpdateOrder.TabIndex = 1;
        btnUpdateOrder.Text = "Update Order";
        btnUpdateOrder.UseVisualStyleBackColor = true;
        // 
        // btnAddOrder
        // 
        btnAddOrder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnAddOrder.Location = new Point(3, 5);
        btnAddOrder.Name = "btnAddOrder";
        btnAddOrder.Size = new Size(213, 23);
        btnAddOrder.TabIndex = 0;
        btnAddOrder.Text = "Add Order";
        btnAddOrder.UseVisualStyleBackColor = true;
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
        // grpOrderList
        // 
        grpOrderList.Controls.Add(dgvOrders);
        grpOrderList.Dock = DockStyle.Fill;
        grpOrderList.Location = new Point(3, 83);
        grpOrderList.Name = "grpOrderList";
        grpOrderList.Size = new Size(658, 309);
        grpOrderList.TabIndex = 2;
        grpOrderList.TabStop = false;
        grpOrderList.Text = "Order List";
        // 
        // dgvOrders
        // 
        dgvOrders.AllowUserToAddRows = false;
        dgvOrders.AllowUserToDeleteRows = false;
        dgvOrders.AllowUserToResizeColumns = false;
        dgvOrders.AllowUserToResizeRows = false;
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrders.BackgroundColor = SystemColors.ControlLight;
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrders.Dock = DockStyle.Fill;
        dgvOrders.Location = new Point(3, 19);
        dgvOrders.MultiSelect = false;
        dgvOrders.Name = "dgvOrders";
        dgvOrders.ReadOnly = true;
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrders.Size = new Size(652, 287);
        dgvOrders.TabIndex = 2;
        // 
        // ManageOrdersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(664, 395);
        Controls.Add(tableLayoutPanel1);
        Name = "ManageOrdersForm";
        Text = "Order Manager for Customer {}";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        grpOrderList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btnDeleteOrder;
    private Button btnUpdateOrder;
    private Button btnAddOrder;
    private Label lblStatus;
    private GroupBox grpOrderList;
    private DataGridView dgvOrders;
}

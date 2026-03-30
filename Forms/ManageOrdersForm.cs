namespace CustomerOrderTracker;

public partial class ManageOrdersForm : Form
{
	public Customer customer;
    public ManageOrdersForm(Customer c)
    {
		// Initialize values
        InitializeComponent();
		customer = c;

		Text = $"Manage Orders for Customer [{customer.CustomerId}] ({customer.Name})";

		DisplayDb();
		SelectionChanged(null, null);

		// Events
		btnAddOrder.Click += AddOrder;
		btnUpdateOrder.Click += UpdateOrder;
		btnDeleteOrder.Click += DeleteOrder;
		dgvOrders.SelectionChanged += SelectionChanged;

		var count = dgvOrders.Rows.Count;
		if (count > 0)
			UpdateStatus($"{count} orders were successfully loaded.", Color.Green);

	}

	// Events
	private void AddOrder(object? sender, EventArgs e)
	{
		var orderForm = new OrderForm(false) {Text = "Add a New Order"};

		var result = orderForm.ShowDialog();
		if (result != DialogResult.OK) 
			return;
		
		// Add the order
		var date = orderForm.InputDate;
		var totalAmount = orderForm.InputAmount;

		Order o = new() { OrderDate = date, TotalAmount = totalAmount, CustomerId = customer.CustomerId};
		using TrackerContext ctx = new();
		try {
			ctx.Orders.Add(o);
			ctx.SaveChanges();
		}
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}
		DisplayDb();
		UpdateStatus("Order successfully added!", Color.Green);
	}

	private void UpdateOrder(object? sender, EventArgs e)
	{
		var order = GetSelectedOrder();
		if (order is null)
		{
			UpdateStatus("Error! Failed to update order because no order is selected!", Color.Red);
			return;
		}

		var orderForm = new OrderForm(true) { 
			Text = "Update an Order", 
		};
		orderForm.SetInputBoxes(order.OrderDate, order.TotalAmount);
		var result = orderForm.ShowDialog();
		if (result != DialogResult.OK) 
			return;
		
		// Get new values
		var newDate = orderForm.InputDate;
		var newAmount = orderForm.InputAmount;

		// Update the order
		using var ctx = new TrackerContext();
		try {
			order = ctx.Orders.First(o => o.OrderId == order.OrderId);
			order.OrderDate = newDate;
			order.TotalAmount = newAmount;
			ctx.SaveChanges();
		}
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}
		
		UpdateStatus("Order successfully updated!", Color.Green);
		DisplayDb();
	}

	private void DeleteOrder(object? sender, EventArgs e)
	{
		var order = GetSelectedOrder();
		if (order is null)
		{
			UpdateStatus("Error! Failed to delete order because no order is selected!", Color.Red);
			return;
		}
		if (!PromptConfirmation("Are you sure you wish to delete the order?"))
			return;

		using var ctx = new TrackerContext();
		try {
			ctx.Orders.Remove(order);
			ctx.SaveChanges();
		}
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}

		UpdateStatus("Order successfully deleted!", Color.Green);
		DisplayDb();
	}


	private void SelectionChanged(object? sender, EventArgs? e)
	{
		bool hasSelection = dgvOrders.SelectedRows.Count != 0;

		btnUpdateOrder.Enabled = hasSelection;
		btnDeleteOrder.Enabled = hasSelection;

	}


	// Helper methods

	private void UpdateStatus(string msg, Color? color = null)
	{
		lblStatus.ForeColor = color ?? Color.Black;
		lblStatus.Text = "Status: " + msg;
	}

	// Displays orders from the database in the data grid view
	private void DisplayDb()
	{
		using TrackerContext ctx = new();
		dgvOrders.DataSource = ctx.Orders.ToList().Where(o => o.CustomerId == customer.CustomerId).ToList();

		if (dgvOrders.Columns.Count == 4)
		{
			dgvOrders.Columns["OrderId"]?.HeaderText = "ID";
			dgvOrders.Columns["CustomerId"]?.Visible = false;

			dgvOrders.Columns["OrderId"]?.FillWeight = 10;

		}

	}

	// Gets the order in the selected row, returns null if no order is selected
	private Order? GetSelectedOrder()
	{
		if (dgvOrders.SelectedRows.Count == 0)
			return null;

		var row = dgvOrders.SelectedRows[0];
		int id = Convert.ToInt32(row.Cells[0].Value?.ToString());
		
		using var ctx = new TrackerContext();
		var order = ctx.Orders.FirstOrDefault(o => o.OrderId == id);

		return order;
	}

	private static bool PromptConfirmation(string message)
		=> MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK;


}


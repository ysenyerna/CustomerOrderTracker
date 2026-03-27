using System.Data;
using Microsoft.EntityFrameworkCore;

namespace CustomerOrderTracker;

public partial class ManageCustomersForm : Form
{
    public ManageCustomersForm()
    {
        InitializeComponent();

		// Connect events
		btnAddCustomer.Click += AddCustomer;
		btnUpdateCustomer.Click += UpdateCustomer;
		btnDeleteCustomer.Click += DeleteCustomer;
		btnManageOrders.Click += OpenOrders;
		dgvCustomers.SelectionChanged += SelectionChanged;
		tbSearchName.TextChanged += SearchUpdated;

		// Initialize DB
		using var ctx = new TrackerContext();
		ctx.Database.Migrate();
		DisplayDb();
		SelectionChanged(null, null);

		var list = ctx.Customers.ToList();
		if (list.Count == 0)
			UpdateStatus(
				"Initialized CustomerOrders.db database.", Color.Green);
		else
			UpdateStatus(
				$"Loaded {list.Count} customers from CustomerOrders.db", Color.Green);

	}

	// Events
	private void AddCustomer(object? sender, EventArgs e)
	{
		var customerForm = new CustomerForm(false) {Text = "Add a New Customer"};

		var result = customerForm.ShowDialog();
		if (result != DialogResult.OK) 
			return;
		
		// Add the customer
		var name = customerForm.InputName;
		var email = customerForm.InputEmail;

		Customer c = new() { Name = name, Email = email};
		using TrackerContext ctx = new();
		try
		{
			ctx.Customers.Add(c);
			ctx.SaveChanges();
		} 
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}

		DisplayDb();
		UpdateStatus("Customer successfully added!", Color.Green);
	}

	private void UpdateCustomer(object? sender, EventArgs e)
	{
		var customer = GetSelectedCustomer();
		if (customer is null)
		{
			UpdateStatus("Error! Failed to update customer because no customer is selected!", Color.Red);
			return;
		}

		var customerForm = new CustomerForm(true) { 
			Text = "Update a Customer", 
		};
		customerForm.SetTextBoxes(customer.Name, customer.Email);
		var result = customerForm.ShowDialog();
		if (result != DialogResult.OK) 
			return;
		
		// Get new values
		var newName = customerForm.InputName;
		var newEmail = customerForm.InputEmail;

		// Update the customer
		using var ctx = new TrackerContext();
		try {
			customer = ctx.Customers.First(c => c.CustomerId == customer.CustomerId);
			customer.Name = newName;
			customer.Email = newEmail;
			ctx.SaveChanges();
		}
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}
		
		UpdateStatus("Customer successfully updated!", Color.Green);
		DisplayDb();
		
	}

	private void OpenOrders(object? sender, EventArgs e)
	{
		var customer = GetSelectedCustomer();
		if (customer is null)
		{
			UpdateStatus("Error! Failed to open orders because no customer is selected!");
			return;
		}

		var ordersForm = new ManageOrdersForm(customer);
		ordersForm.Show();


	}

	private void DeleteCustomer(object? sender, EventArgs e)
	{
		var customer = GetSelectedCustomer();
		if (customer is null)
		{
			UpdateStatus("Error! Failed to delete customer because no customer is selected.", Color.Red);
			return;
		}

		if (!PromptConfirmation("Are you sure you wish to delete this customer and all of their orders?"))
			return;

		using TrackerContext ctx = new();
		try {
			ctx.Customers.Remove(customer);
			ctx.SaveChanges();
		}
		catch (Exception ex)
		{
			UpdateStatus("Error! Database operation failed - " + ex.Message);
			return;
		}

		UpdateStatus("Customer successfully deleted!", Color.Green);
		DisplayDb();
	}


	private void SelectionChanged(object? sender, EventArgs? e)
	{
		bool hasSelection = dgvCustomers.SelectedRows.Count != 0;

		btnUpdateCustomer.Enabled = hasSelection;
		btnManageOrders.Enabled = hasSelection;
		btnDeleteCustomer.Enabled = hasSelection;

	}

	private void SearchUpdated(object? sender, EventArgs e)
	{
		var nameQuery = tbSearchName.Text;
		if (nameQuery == "")
		{
			DisplayDb();
			return;
		}

		DisplayDb(c => c.Name.Contains(nameQuery, StringComparison.OrdinalIgnoreCase));
	}


	// Helper methods

	private void UpdateStatus(string msg, Color? color = null)
	{
		lblStatus.ForeColor = color ?? Color.Black;
		lblStatus.Text = "Status: " + msg;
	}

	// Refreshes the list with data from the database. Specify a selector to select only items that match a condition
	private void DisplayDb(Func<Customer, bool>? selector = null)
	{
		using TrackerContext ctx = new();
		var list = ctx.Customers.ToList();
		if (selector is not null)
		{
			list = [.. list.Where(selector)];
		}
		
		dgvCustomers.DataSource = list;

		if (dgvCustomers.Columns.Count == 3)
		{
			dgvCustomers.Columns["CustomerId"]?.HeaderText = "ID";
			dgvCustomers.Columns["CustomerId"]?.FillWeight = 10;

		}
	}


	// Gets the customer in the selected row, returns null if no customer is selected
	private Customer? GetSelectedCustomer()
	{
		if (dgvCustomers.SelectedRows.Count == 0)
			return null;

		var row = dgvCustomers.SelectedRows[0];
		int id = Convert.ToInt32(row.Cells[0].Value?.ToString());
		
		using var ctx = new TrackerContext();
		var customer = ctx.Customers.FirstOrDefault(c => c.CustomerId == id);

		return customer;
	}

	private static bool PromptConfirmation(string message)
		=> MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK;

}


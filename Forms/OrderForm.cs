

namespace CustomerOrderTracker;

public partial class OrderForm : Form
{
	public DateTime InputDate;
	public double InputAmount;
	public OrderForm(bool updating)
	{
		InitializeComponent();
		
		btnConfirm.Text = updating ? "Save Changes" : "Add";

		btnConfirm.Click += OnConfirm;
		btnCancel.Click += OnCancel;
	}

	public void SetInputBoxes(DateTime date, double amount)
	{
		dtpDate.Value = date;
		tbTotalAmount.Text = amount.ToString();
	}

	private void OnConfirm(object? sender, EventArgs e)
	{
		// Validate
		if (!double.TryParse(tbTotalAmount.Text, out double amt))
		{
			MessageBox.Show("Total amount must be a number", "Invalid Input");
			return;
		}
		if (amt < 0)
		{
			MessageBox.Show("Total amount cannot be less than zero", "Invalid Input");
			return;
		}

		// Assign values
		InputDate = dtpDate.Value;
		InputAmount = amt;

		DialogResult = DialogResult.OK;
		Close();
	}

	private void OnCancel(object? sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}



}

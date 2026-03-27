

namespace CustomerOrderTracker;

public partial class CustomerForm : Form
{
	public string InputName = "";
	public string InputEmail = "";
	public CustomerForm(bool updating)
	{
		InitializeComponent();
		
		btnConfirm.Text = updating ? "Save Changes" : "Add";

		btnConfirm.Click += OnConfirm;
		btnCancel.Click += OnCancel;
	}

	public void SetTextBoxes(string name, string email)
	{
		tbName.Text = name;
		tbEmail.Text = email;
	}

	private void OnConfirm(object? sender, EventArgs e)
	{
		// Validate
		if (string.IsNullOrWhiteSpace(tbName.Text))
		{
			MessageBox.Show("Name cannot be empty!", "Invalid Input");
			return;
		}
		if (string.IsNullOrWhiteSpace(tbEmail.Text))
		{
			MessageBox.Show("Email cannot be empty", "Invalid Input");
			return;
		}

		// Assign values
		InputName = tbName.Text.Trim();
		InputEmail = tbEmail.Text.Trim();

		DialogResult = DialogResult.OK;
		Close();
	}

	private void OnCancel(object? sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}



}

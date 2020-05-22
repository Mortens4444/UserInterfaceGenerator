using System;
using System.Windows.Forms;
using UserInterfaceGenerator.Attributes;

namespace UserInterfaceGenerator.Forms
{
	public partial class AddControlForm : Form
	{
		public string ControlDescriptor { get; private set; }

		public AddControlForm()
		{
			InitializeComponent();
			cbControlType.DataSource = Enum.GetValues(typeof(ControlType));
			cbControlType.SelectedIndex = 0;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var selectedControlType = (ControlType)cbControlType.SelectedItem;

			ControlDescriptor = $"{selectedControlType} ";
			if (CustomAttributeChecker.HasCustomAttribute<HasTextAttribute>(selectedControlType))
			{
				ControlDescriptor += $"(Text: {tbText.Text})";
			}
			if (CustomAttributeChecker.HasCustomAttribute<HasTargetAttribute>(selectedControlType))
			{
				ControlDescriptor += $" (Target: {tbTarget.Text})";
			}
			if (CustomAttributeChecker.HasCustomAttribute<IsCheckableAttribute>(selectedControlType) && chkIsChecked.Checked)
			{
				ControlDescriptor += $" (Checked)";
			}
			ControlDescriptor = ControlDescriptor.TrimEnd();
		}

		private void ToggleButtonDescriptor()
		{
			ControlDescriptor += $"(Text: {tbText.Text})";
			if (chkIsChecked.Checked)
			{
				ControlDescriptor += " (Checked)";
			}
		}
	}
}

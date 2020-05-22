using UserInterfaceGenerator.Attributes;

namespace UserInterfaceGenerator
{
	enum ControlType
	{
		[HasText]
		Button,

		[HasText]
		[IsCheckable]
		CheckBox,

		ComboBox,

		[HasText]
		GroupBox,

		[HasText]
		Label,

		[HasText]
		[HasTarget]
		Link,

		ListView,

		NumericUpDown,

		Panel,

		[HasText]
		[HasTarget]
		PictureBox,

		[HasText]
		[HasTarget]
		[IsCheckable]
		RadioButton,

		Table,

		[HasText]
		TextBox,

		TreeView
	}
}

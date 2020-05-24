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
		LabelWithTextBox,

		[HasText]
		[HasTarget]
		LabelWithRichTextBox,

		[HasText]
		[HasTarget]
		Link,

		[HasText]
		[HasTarget]
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

		[HasText]
		[HasTarget]
		RichTextBox,

		Table,

		[HasText]
		TextBox,

		TreeView
	}
}

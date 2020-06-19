Property is not saving on Designer.cs when type is List

This project shows how to fix problem in which property is not saving on Designer.cs when the properties type is a List.

Example:
public List<int> Numbers
{
	get { return _Numbers; }
	set { _Numbers = value; }
}
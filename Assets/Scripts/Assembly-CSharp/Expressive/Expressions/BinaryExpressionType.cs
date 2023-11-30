namespace Expressive.Expressions
{
	internal enum BinaryExpressionType
	{
		Unknown = 0,
		And = 1,
		Or = 2,
		NotEqual = 3,
		LessThanOrEqual = 4,
		GreaterThanOrEqual = 5,
		LessThan = 6,
		GreaterThan = 7,
		Equal = 8,
		Subtract = 9,
		Add = 10,
		Modulus = 11,
		Divide = 12,
		Multiply = 13,
		BitwiseOr = 14,
		BitwiseAnd = 15,
		BitwiseXOr = 16,
		LeftShift = 17,
		RightShift = 18,
		NullCoalescing = 19
	}
}

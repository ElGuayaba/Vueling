using System;

public class VuelingException : Exception
{
	public VuelingException()
	{
	}

	public VuelingException(string message)
		: base(message)
	{
	}

	public VuelingException(string message, Exception inner)
		: base(message, inner)
	{
	}
}
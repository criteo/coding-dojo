namespace BrainfuckInterpreterTest
{
	public class BrainfuckInterpreterTests
	{
		// The first test case is already green since the implementation returns empty string
		// What you should do is to uncomment the following test cases one by one and to make them pass.

		[TestCase("", ExpectedResult = "", Description = "can return empty string for empty program")]
		//[TestCase(".", ExpectedResult = "0", Description = "can print current cell with dot")]
		//[TestCase("..", ExpectedResult = "00", Description = "can print several times")]
		//[TestCase(".+.", ExpectedResult = "01", Description = "can increment after printing")]
		//[TestCase("++.", ExpectedResult = "2", Description = "can increment twice")]
		//[TestCase("+.", ExpectedResult = "1", Description = "can increment then print")]
		//[TestCase("-.", ExpectedResult = "-1", Description = "can decrement byte with minus operator")]
		//[TestCase("->.", ExpectedResult = "0", Description = "can shift byte with right operator")]
		//[TestCase("-<.", ExpectedResult = "0", Description = "can shift byte with left operator")]
		//[TestCase("+<>.", ExpectedResult = "1", Description = "can memorize byte state after shift")]
		//[TestCase("[+].", ExpectedResult = "0", Description = "can skip loop body")]
		//[TestCase("+[>].", ExpectedResult = "0", Description = "can exit loop body")]
		public string ShouldHandleProgram(string program)
		{
			return BrainfuckInterpreter.BrainfuckInterpreter.Run(program);
		}

	}
}

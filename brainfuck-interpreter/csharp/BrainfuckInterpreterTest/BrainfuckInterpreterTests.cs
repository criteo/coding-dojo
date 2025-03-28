namespace BrainfuckInterpreterTest
{
	public class BrainfuckInterpreterTests
	{
		// The first test case is already green since the implementation returns empty string
		// What you should do is to uncomment the following test cases one by one and to make them pass.

		[TestCase("", "", Description = "can return empty string for empty program")]
		//[TestCase(".", "0", Description = "can print current cell with dot")]
		//[TestCase("..", "0,0", Description = "can print several times")]
		//[TestCase(".+.", "0,1", Description = "can increment after printing")]
		//[TestCase("++.", "2", Description = "can increment twice")]
		//[TestCase("+.", "1", Description = "can increment then print")]
		//[TestCase("++-.", "1", Description = "can decrement byte with minus operator")]
		//[TestCase("->.", "0", Description = "can shift byte with right operator")]
		//[TestCase("-<.", "0", Description = "can shift byte with left operator")]
		//[TestCase("+<>.", "1", Description = "can memorize byte state after shift")]
		//[TestCase("[+].", "0", Description = "can skip loop body")]
		//[TestCase("+[>].", "0", Description = "can exit loop body")]
		public void ShouldHandleProgram(string program, string expectedStringRepresentationOfTheByteArray)
        {
            Assert.That(BrainfuckInterpreter.BrainfuckInterpreter.Run(program), Is.EqualTo(StringRepresentationToByteArray(expectedStringRepresentationOfTheByteArray)));
        }

        // This is the final test: it requires a support of all 7 commands, as well as a support for nested loop
        [Test]
        public void HelloWorldTest()
        {
            var program = "++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.";
            Assert.That(BrainfuckInterpreter.BrainfuckInterpreter.RunAndGetString(program), Is.EqualTo("Hello World!\n"));
        }

        private static IEnumerable<byte> StringRepresentationToByteArray(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return [];
            }
            return data.Split(',').Select(byte.Parse);
        }
    }
}

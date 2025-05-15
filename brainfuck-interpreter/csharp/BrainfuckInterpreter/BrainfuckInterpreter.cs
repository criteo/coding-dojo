namespace BrainfuckInterpreter
{
    public class BrainfuckInterpreter
    {
        public static IEnumerable<byte> Run(string program)
        {
            // TODO: write an actual implementation
            return new byte[] { };
        }

        public static string RunAndGetString(string program) =>
            System.Text.Encoding.Default.GetString(Run(program).ToArray());
    }
}
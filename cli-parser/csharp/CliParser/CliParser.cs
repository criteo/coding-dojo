namespace CliParser;

public class CliParser
{
    public ParsedArguments Parse(String[] args)
    {
        throw new NotImplementedException();
    }

    // To register options without associated value. Eg: "--help" or "-h".
    // To configure such "help" flag the user would call:
    // cliParser.RegisterFlag("hasUserRequestedHelp", "help", 'h');
    public void RegisterFlag(string optionName, string? longOption = null, char? shortOption = null)
    {
        throw new NotImplementedException();
    }

    // To register options associated with a value. Eg: "--type f".
    // To configure such option the user would call:
    // cliParser.RegisterOption("typeOption", "type");
    public void RegisterOption(string optionName, string option)
    {
        throw new NotImplementedException();
    }
}

public class ParsedArguments
{
    public bool GetBool(string optionName)
    {
        throw new NotImplementedException();
    }

    public string? GetString(string optionName)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GetUnflaggedOptions()
    {
        throw new NotImplementedException();
    }
}
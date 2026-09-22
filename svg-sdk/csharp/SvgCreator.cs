namespace svgSdk;

public class SvgCreator
{
    public SvgCreator(int width, int height /* or perhaps we want to take or parameters? */)
    {
        // TODO
    }
    
    public void /* or perhaps you'll want to return something? */ AddRect(/* Or perhaps we want to take some arguments? */)
    {
        // TODO
    }

    public string SerializeAsXml()
    {
        // TODO
        return "";
    }

    public void WriteToFile(string path)
    {
        File.WriteAllText(path, SerializeAsXml());
    }
}
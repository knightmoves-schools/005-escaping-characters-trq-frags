namespace Tests;
using knightmoves;
using Xunit;
using System.Text.RegularExpressions;

public class AutogradingTest
{
    [Fact]
    public void Should_Define_A_Class_Level_String_Variable_Named_Introduction(){
        var email = new Email();
        Assert.True(email.Introduction != null, "Should define a class-level string variable named introduction");
    }

    [Fact]
    public void Should_Include_A_New_Line_Within_Introduction()
    {
        string filePath = Path.GetDirectoryName(typeof(Email).Assembly.Location) + "/../../../Email.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);

        Assert.True(content.Contains(@"\n"), "Should include a `new line` within `introduction`");
    }

    [Fact]
    public void Should_Include_A_Tab_Within_Introduction()
    {
        string filePath = Path.GetDirectoryName(typeof(Email).Assembly.Location) + "/../../../Email.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);

        Assert.True(content.Contains(@"\t"), "Should include a `tab` within `introduction`");
    }

    [Fact]
    public void Should_Include_A_Single_Quote_Within_Introduction()
    {
        string filePath = Path.GetDirectoryName(typeof(Email).Assembly.Location) + "/../../../Email.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);

        Assert.True(content.Contains(@"\'"), "Should include a `single quote` within `introduction`");
    }

    [Fact]
    public void Should_Include_A_Double_Quote_Within_Introduction()
    {
        string filePath = Path.GetDirectoryName(typeof(Email).Assembly.Location) + "/../../../Email.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);

        Assert.True(content.Contains(@"\"""), "Should include a `double quote` within `introduction`");
    }

    [Fact]
    public void Should_Include_A_Backslash_Within_Introduction()
    {
        string filePath = Path.GetDirectoryName(typeof(Email).Assembly.Location) + "/../../../Email.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);

        Assert.True(content.Contains(@"\\"), "Should include a `backslash` within `introduction`");
    }
}
using System.Net.Sockets;
using NUnit.Framework.Constraints;

namespace MasterMindTest;

using CliParser;

public class CliParserTests
{
    [Test]
    public void DoesNotThrowOnEmptyCli()
    {
        Assert.DoesNotThrow(() => new CliParser().Parse([]));
    }

    //[TestCase(true)]
    //[TestCase(false)]
    //public void CanRegisterFlag(bool flagActivated)
    //{
    //    // Arrange
    //    const string userRequestedHelp = "help";
    //    var sut  = new CliParser();
    //    sut.RegisterFlag(userRequestedHelp, shortOption:'h');

    //    // Act
    //    var args = flagActivated ? new[] { "-h" } : [];
    //    var parsed = sut.Parse(args);

    //    // Assert
    //    Assert.That(parsed.GetBool(userRequestedHelp), Is.EqualTo(flagActivated));
    //}

    //[TestCase(true)]
    //[TestCase(false)]
    //public void CanRegisterFlagWithALongName(bool flagActivated)
    //{
    //    // Arrange
    //    const string userRequestedHelp = "help";
    //    var sut  = new CliParser();
    //    sut.RegisterFlag(userRequestedHelp, longOption: "help");

    //    // Act
    //    var args = flagActivated ? new[] { "--help" } : [];
    //    var parsed = sut.Parse(args);

    //    // Assert
    //    Assert.That(parsed.GetBool(userRequestedHelp), Is.EqualTo(flagActivated));
    //}

    //[Test]
    //public void CanRegisterFlagWithBothALongNameAndAShortOne()
    //{
    //    // Arrange
    //    const string userRequestedHelp = "help";
    //    var sut  = new CliParser();
    //    sut.RegisterFlag(userRequestedHelp, longOption: "help", shortOption: 'h');

    //    // Act & assert
    //    Assert.That(sut.Parse(["help"]).GetBool(userRequestedHelp), Is.True);
    //    Assert.That(sut.Parse(["h"]).GetBool(userRequestedHelp), Is.True);
    //    Assert.That(sut.Parse([]).GetBool(userRequestedHelp), Is.False);
    //}

    //[Test]
    //public void CanConcatenateSeveralFlags()
    //{
    //    // Arrange
    //    var sut  = new CliParser();
    //    const string allFlag = "all";
    //    sut.RegisterFlag(allFlag, shortOption:'a');
    //    const string longListingFlag = "longListing";
    //    sut.RegisterFlag(longListingFlag, shortOption:'l');
    //    const string dereferenceFlag = "dereference";
    //    sut.RegisterFlag(dereferenceFlag, shortOption:'L');

    //    // Act
    //    var parsed = sut.Parse(["-la"]);

    //    // Assert
    //    Assert.That(parsed.GetBool(allFlag), Is.True);
    //    Assert.That(parsed.GetBool(longListingFlag), Is.True);
    //    Assert.That(parsed.GetBool(dereferenceFlag), Is.False);
    //}


    //[Test]
    //public void CanRegisterOptionWithStringValue()
    //{
    //    // Arrange
    //    var sut = new CliParser();
    //    const string typeOption = "type";
    //    sut.RegisterOption(typeOption, "type");
    //    const string depthOption = "depth";
    //    sut.RegisterOption(depthOption, "depth");

    //    // Act
    //    var parsed = sut.Parse(["--type", "f"]);

    //    // Assert
    //    Assert.That(parsed.GetString(typeOption), Is.EqualTo("f"));
    //    Assert.That(parsed.GetString(depthOption), Is.Null);
    //}

    //[Test]
    //public void CanGetUnflaggedOptions()
    //{
    //    // Arrange
    //    var sut = new CliParser();
    //    sut.RegisterOption("placeholder", "type");
    //    sut.RegisterFlag("placeholder2", longOption: "help");

    //    // Act
    //    var parsed = sut.Parse(["--type", "f", "/some/path", "/other/path"]);

    //    // Assert
    //    Assert.That(parsed.GetUnflaggedOptions(), Is.EqualTo(new[]{"/some/path", "/other/path"}));

    //}
}
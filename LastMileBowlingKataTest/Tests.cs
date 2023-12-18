

using LastMileBowlingKata;

namespace LastMileBowlingKataTest;

[TestClass]
public class Tests
{
    [TestMethod]
    public void AGame_HasTenFrames()
    {
        var game = new Game();
        Assert.AreEqual(10, game.getNumberOfFrames());
    }

    [TestMethod]
    public void AFrame_HasTwoTries()
    {
        var frame = new Frame();
        Assert.AreEqual(2, frame.getNumberOfTries());
    }
}
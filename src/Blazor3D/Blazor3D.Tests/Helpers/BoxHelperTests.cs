using Blazor3D.Objects;

namespace Blazor3D.Tests.Helpers;

[TestClass]
public class BoxHelperTests
{
    [TestMethod]
    public void DefaultConstructorShouldCreateWithPredefinedValues()
    {
        var helper = new BoxHelper();
        Assert.AreEqual("BoxHelper", helper.Type);
        Assert.IsNull(helper.Object3D);
        Assert.AreEqual("0xffff00", helper.Color);
    }

    [TestMethod]
    public void ConstructorWithParamsShouldCreateWithSpecifiedValues()
    {
        var mesh = new Mesh();
        var helper = new BoxHelper(mesh, "red");
        Assert.AreEqual("BoxHelper", helper.Type);
        Assert.IsNotNull(helper.Object3D);
        Assert.AreEqual("red", helper.Color);
    }
}
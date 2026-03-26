using Xunit;
using Game.Vector;

public class VectorTests
{
    [Fact]
    public void Add_OppositeVectors_ReturnsZeroVector()
    {
        Vector vec1 = new Vector(1, -1, 2);
        Vector vec2 = new Vector(-1, 1, -2);

        Vector res = vec1 + vec2;

        Assert.Equal(res, new Vector(0, 0, 0));
    }

    [Fact]
    public void Add_DifferentDimensionVector_ThrowsExceptionFirstLonger()
    {
        Vector vec1 = new Vector(1, 2, 3);
        Vector vec2 = new Vector(1, 2);

        Assert.Throws<ArgumentException>(() => vec1 + vec2);
    }

    [Fact]
    public void Add_DifferentDimensionVector_ThrowsExceptionSecondLonger()
    {
        Vector vec1 = new Vector(1, 2);
        Vector vec2 = new Vector(1, 2, 3);

        Assert.Throws<ArgumentException>(() => vec1 + vec2);
    }

    [Fact]
    public void EqualsMethod_TwoEqualVectors_ReturnsTrue()
    {
        Vector vec1 = new Vector(1, 2, 3);
        Vector vec2 = new Vector(1, 2, 3);

        bool res = vec1.Equals(vec2);

        Assert.True(res);
    }

    [Fact]
    public void EqualsOperator_TwoEqualVectors_ReturnsFalse()
    {
        Vector vec1 = new Vector(1, 2, 3);
        Vector vec2 = new Vector(1, 2, 3);

        bool res = vec1 == vec2;

        Assert.True(res);
    }

    [Fact]
    public void EqualsMethod_TwoDifferentVectors_ReturnsFalse()
    {
        Vector vec1 = new Vector(1, 2, 3);
        Vector vec2 = new Vector(1, 2, 4);

        bool res = vec1.Equals(vec2);

        Assert.False(res);
    }

    [Fact]
    public void NotEqualsOperator_TwoDifferentVectors_ReturnsTrue()
    {
        Vector vec1 = new Vector(1, 2, 3);
        Vector vec2 = new Vector(1, 2, 4);

        bool res = vec1 != vec2;

        Assert.True(res);
    }

    [Fact]
    public void GetHashCode_Vector_ReturnsNotZero()
    {
        var vector = new Vector(1, 2, 3);

        Assert.NotEqual(0, vector.GetHashCode());
    }
}

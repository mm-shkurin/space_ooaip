namespace Game.Vector;

public class Vector
{
    int[] coords { get; }

    public Vector(params int[] coords)
    {
        this.coords = coords;
    }

    public static Vector operator +(Vector vec1, Vector vec2)
    {
        if (vec1.coords.Length != vec2.coords.Length)
        {
            throw new ArgumentException("Векторы разной размерности");
        }

        return new Vector(vec1.coords.Zip(vec2.coords, (x, y) => x + y).ToArray());
    }

    public override bool Equals(object? ob)
    {
        if (ob is not Vector other) return false;

        if (coords.Length != other.coords.Length) return false;

        return coords.SequenceEqual(other.coords);
    }

    public override int GetHashCode()
    {
        return coords.GetHashCode();
    }

    public static bool operator ==(Vector? vec1, Vector? vec2)
    {
        if (vec1 is null || vec2 is null) return false;
        return vec1.Equals(vec2);
    }

    public static bool operator !=(Vector? vec1, Vector? vec2)
    {
        return !(vec1 == vec2);
    }
}

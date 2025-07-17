namespace Blazor3D.Geometires.Lines;

public class LineGeometry : BufferGeometry
{
    public LineGeometry() : base("LineGeometry")
    {
    }

    public List<Vector3> Points { get; set; } = [];
}
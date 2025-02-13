﻿namespace HomagGroup.Blazor3D.Geometires;

/// <summary>
/// <para>Class for a capsule with given radus and height. It is constructed using a lathe.</para>
/// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/CapsuleGeometry">CapsuleGeometry</a></para>
/// </summary>
public sealed class CapsuleGeometry : BufferGeometry
{
    public CapsuleGeometry() : base("CapsuleGeometry")
    {
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="radius">Radius of the capsule. Default is 1.</param>
    /// <param name="length">Length of the middle section. Default is 1.</param>
    /// <param name="capSegments">Number of curve segments used to build the caps. Default is 4.</param>
    /// <param name="radialSegments">Number of segmented faces around the circumference of the capsule. Default is 8.</param>
    public CapsuleGeometry(double radius = 1, double length = 1, int capSegments = 4, int radialSegments = 8) : this()
    {
        Radius = radius;
        Length = length;
        CapSegments = capSegments;
        RadialSegments = radialSegments;
    }

    /// <summary>
    /// Radius of the capsule. Default is 1.
    /// </summary>
    public double Radius { get; set; } = 1;

    /// <summary>
    /// Length of the middle section. Default is 1.
    /// </summary>
    public double Length { get; set; } = 1;

    /// <summary>
    /// Number of curve segments used to build the caps. Default is 4.
    /// </summary>
    public int CapSegments { get; set; } = 4;

    /// <summary>
    /// Number of segmented faces around the circumference of the capsule. Default is 8.
    /// </summary>
    public int RadialSegments { get; set; } = 8;
}
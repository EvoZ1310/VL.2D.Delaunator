# VL.2D.Delaunator
A VL wrapper for the Delaunator:
https://mapbox.github.io/delaunator/

Using this Delaunator C# Wrapper:
https://github.com/nol1fe/delaunator-sharp

# Usage
Just reference the VL.2D.Delaunator Patch in your Patch to use the Delaunator

Currently implemented Methods are
GetTriangles (returned as Vector2 Spread)
GetTrianglePointsByIndex (returned as Vector2 Spread)

For the use with Stride there is also a small helper class implemented which allowes to take the triangles generated from the Delaunator (Vector2) and convert it to a 3D model using random or passed z values

see VL.2D.Delaunator.Playground Patch for examples and usage!

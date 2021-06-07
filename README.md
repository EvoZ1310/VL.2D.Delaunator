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

For the use with Stride there is also a small helper class implemented which takes the triangles generated from the Delaunator (Vector2) and convert it to a 3D model using random or passed z values
Just reference the Vl.2D.Delaunator.dll.

It includes the DelaunayUtils class:
CreateRandomVector3ValuesWithDelaunay
CreateVector8ValuesWithDelaunay

see VL.2D.Delaunator.Playground Patch for examples and usage!

![image](https://user-images.githubusercontent.com/56681157/120983493-08a68380-c77a-11eb-906d-6db025468404.png)
![image](https://user-images.githubusercontent.com/56681157/120983572-1cea8080-c77a-11eb-9504-babe058e8f8b.png)

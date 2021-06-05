using Stride.Core.Mathematics;
using System;
using System.Collections.Generic;

namespace VL.Delauny.Utils
{
    public class DelaunyUtils
    {
        public static Vector3[] CreateVector3ValuesWithDelaunay(Vector2[] delaunayArray, float[] zValues)
        {
            var groups = CreateGroupsFormDelaunayArray(delaunayArray);

            if (groups.Count != zValues.Length)
                throw new Exception("zValues have the wrong count!");

            return JoinZValuesToGroups(delaunayArray.Length, groups, zValues);
        }

        public static Vector3[] CreateRandomVector3ValuesWithDelaunay(Vector2[] delaunayArray, float zRandomizer)
        {
            var groups = CreateGroupsFormDelaunayArray(delaunayArray);

            var random = new Random();
            var zValues = new float[groups.Count];

            int i = 0;
            foreach (var group in groups)
            {
                zValues[i] = (float)random.NextDouble() * zRandomizer;
                i++;
            }

            return JoinZValuesToGroups(delaunayArray.Length, groups, zValues);
        }

        private static Vector3[] JoinZValuesToGroups(int delaunyArrayLenght, Dictionary<Vector2, List<Tuple<int, Vector2>>> groups, float[] zValues)
        {
            var vec3array = new Vector3[delaunyArrayLenght];

            int i = 0;
            foreach (var group in groups)
            {
                var z = zValues[i];
                foreach (var tuple in group.Value)
                {
                    var vec2 = tuple.Item2;
                    var index = tuple.Item1;
                    var vec3 = new Vector3(vec2.X, vec2.Y, z);
                    vec3array[index] = vec3;
                }
                i++;
            }

            return vec3array;
        }

        private static Dictionary<Vector2, List<Tuple<int, Vector2>>> CreateGroupsFormDelaunayArray(Vector2[] delaunayArray)
        {
            var groups = new Dictionary<Vector2, List<Tuple<int, Vector2>>>();

            for (int i = 0; i < delaunayArray.Length; i++)
            {
                var vec2 = delaunayArray[i];
                bool newKey = true;
                foreach (var groupKey in groups.Keys)
                {
                    if (groupKey.Y == vec2.Y && groupKey.X == vec2.X)
                    {
                        groups[groupKey].Add(new Tuple<int, Vector2>(i, vec2));
                        newKey = false;
                    }
                }

                if (newKey)
                {
                    groups.Add(vec2, new List<Tuple<int, Vector2>> { new Tuple<int, Vector2>(i, vec2) });
                }
            }

            return groups;
        }
    }
}

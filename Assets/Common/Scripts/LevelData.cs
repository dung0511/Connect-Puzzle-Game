using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Connect.Common
{
    [CreateAssetMenu(fileName = "Level", menuName ="ScriptableObject/Level")]
    public class LevelData : ScriptableObject
    {
        public string levelName;
        public List<Edge> edges;

    }

    [System.Serializable]
    public struct Edge
    {
        public List<Vector2Int> points;
        public Vector2Int startPoint
        {
            get
            {
                if (points != null &&points.Count > 0)
                {
                    return points[0];
                }
                return new Vector2Int(-1, -1);
            }
        }
        public Vector2Int endPoint
        {
            get
            {
                if (points != null && points.Count > 0)
                {
                    return points[points.Count - 1];
                }
                return new Vector2Int(-1, -1);
            }
        }
    }
}


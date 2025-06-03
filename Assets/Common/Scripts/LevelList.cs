using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Connect.Common
{
    [CreateAssetMenu(fileName = "Level", menuName = "ScriptableObject/All Levels")]
    public class LevelList : ScriptableObject
    {
        public List<LevelData> levels;
    }
}


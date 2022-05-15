using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    [CreateAssetMenu(fileName = "New Characters Data", menuName = "Project/Characters")]
    [System.Serializable]
    public class GameCharactersData: ScriptableObject
    {

        public bool canUse;
        
        public string _name;
        
        [TextArea]
        public string description;
        
        public int cost;

    }
}

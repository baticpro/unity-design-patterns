using UnityEngine;

namespace Flyweight
{
    [CreateAssetMenu(menuName = "Game Preferences")]
    public class GamePreferences : ScriptableObject
    {
        public float TimeSpeed;
        public int SpawnItems;
    }
}

using UnityEngine;

namespace Flyweight
{
    [CreateAssetMenu(menuName = "Game Preferences")]
    public class GamePreferences : ScriptableObject
    {
        public float ScaleFactor;
        public int GravityPower;
        public Color CircleColor;
    }
}

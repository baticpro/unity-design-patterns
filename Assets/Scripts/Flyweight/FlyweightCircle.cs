using UnityEngine;

namespace Flyweight
{
    public class FlyweightCircle: MonoBehaviour
    {
        public GamePreferences GamePreferences;

        private void Start()
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = GamePreferences.GravityPower;
            transform.localScale = Vector3.one * GamePreferences.ScaleFactor;
            gameObject.GetComponent<SpriteRenderer>().color = GamePreferences.CircleColor;
        }
    }
}
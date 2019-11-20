using UnityEngine;

namespace ObjectPool
{
    public class Bullet: MonoBehaviour
    {
        public IBulletPool BulletPoolList;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.GetComponent<Bullet>() == null)
                BulletPoolList.ReturnBulletToPool(gameObject);
        }
    }
}
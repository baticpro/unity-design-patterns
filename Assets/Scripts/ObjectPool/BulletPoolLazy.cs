using System.Collections.Generic;
using UnityEngine;

namespace ObjectPool
{
    public class BulletPoolLazy : MonoBehaviour, IBulletPool
    {
        public GameObject BulletPrefab;
        private Queue<GameObject> _pool;

        public void InitPool(int poolSize)
        {
            _pool = new Queue<GameObject>();
            for (int i = 0; i < poolSize; i++)
            {
                var bullet = Instantiate(BulletPrefab);
                bullet.GetComponent<Bullet>().BulletPoolList = this;
                bullet.SetActive(false);
                _pool.Enqueue(bullet);
            }
        }

        public GameObject GetBulletFromPool(Vector3 position, Quaternion rotation)
        {
            if (_pool.Count <= 0)
            {
                var bullet = Instantiate(BulletPrefab);
                bullet.GetComponent<Bullet>().BulletPoolList = this;
                bullet.SetActive(false);
                _pool.Enqueue(bullet);
            }
            
            var newBullet = _pool.Dequeue();
            newBullet.SetActive(true);
            newBullet.transform.position = position;
            newBullet.transform.rotation = rotation;
            return newBullet;
        }

        public void ReturnBulletToPool(GameObject bullet)
        {
            bullet.SetActive(false);
            _pool.Enqueue(bullet);
        }
    }
}

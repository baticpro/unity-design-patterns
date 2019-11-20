using System.Collections.Generic;
using UnityEngine;

namespace ObjectPool
{
    public class BulletPoolList : MonoBehaviour, IBulletPool
    {
        public GameObject BulletPrefab;
        private List<GameObject> _pool;

        public void InitPool(int poolSize)
        {
            _pool = new List<GameObject>();
            for (int i = 0; i < poolSize; i++)
            {
                var bullet = Instantiate(BulletPrefab);
                bullet.GetComponent<Bullet>().BulletPoolList = this;
                _pool.Add(bullet);
                _pool[i].SetActive(false);
            }
        }

        public GameObject GetBulletFromPool(Vector3 position, Quaternion rotation)
        {
            var newBullet = _pool[_pool.Count - 1];
            newBullet.SetActive(true);
            newBullet.transform.position = position;
            newBullet.transform.rotation = rotation;
            
            _pool.RemoveAt(_pool.Count - 1);

            return newBullet;
        }

        public void ReturnBulletToPool(GameObject bullet)
        {
            bullet.SetActive(false);
            _pool.Add(bullet);
        }
    }
}

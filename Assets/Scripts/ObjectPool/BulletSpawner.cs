using UnityEngine;

namespace ObjectPool
{
    public class BulletSpawner: MonoBehaviour
    {
        private IBulletPool _bulletPoolList;

        private void Start()
        {
            _bulletPoolList = gameObject.GetComponent<IBulletPool>();
            _bulletPoolList.InitPool(5);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SpawnBullet();
            }
        }

        private void SpawnBullet()
        {
            _bulletPoolList.GetBulletFromPool(transform.position, gameObject.transform.rotation);
        }
    }
}
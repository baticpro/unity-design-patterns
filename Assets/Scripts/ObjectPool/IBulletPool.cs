using UnityEngine;

namespace ObjectPool
{
    public interface IBulletPool
    {
        void InitPool(int n);
        
        void ReturnBulletToPool(GameObject bullet);

        GameObject GetBulletFromPool(Vector3 position, Quaternion rotation);
    }
}
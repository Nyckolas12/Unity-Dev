using UnityEngine;

public class DamageSource : MonoBehaviour
{
    [SerializeField] float damage = 1;
    [SerializeField] bool destoryOnHit = true;

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.TryGetComponent(out IDamagable damagable))
        {
            damagable.ApplyDamage(damage);
        }

     if(destoryOnHit)
        {
            Destroy(gameObject);
        }
    }
}

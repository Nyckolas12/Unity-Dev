using UnityEngine;

public class Destructable : MonoBehaviour, IDamagable
{
    [SerializeField] float health = 20;
    [SerializeField] GameObject destoryFx;
    bool destoryed = false;
    public void ApplyDamage(float damage)
    {
        health -= damage;
        if (destoryed) return;
        if(health <= 0)
        {
            destoryed = true;
            if( destoryFx != null) Instantiate(destoryFx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

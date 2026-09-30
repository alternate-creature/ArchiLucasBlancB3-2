using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Projectile has no target or direction
    public float projectileSpeed = 1f;
    int projectileDmg = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
            enemy.TakeDMG(projectileDmg);
    }

    private void Hit()
    {

    }

    private void DoDamage()
    {
        
    }
}

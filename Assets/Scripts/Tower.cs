using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] public int towerCost; //originally private
    [SerializeField] int towerRange;       //range as an int?
    [SerializeField] int attackSpeed;      //speed as an int?
    //tower has no attack?
    [SerializeField] Enemy target;
    List<Projectile> projectiles = new();

    float timeKeeper;

    //I assume it should have a collider to detect enemies but then I don't know what the towerRange is for
    //because I assume the tower won't target a single enemy during its entire lifetime...

    private void Update()
    {
        Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, towerRange);
        if (hitCollider.gameObject.TryGetComponent(out Enemy enemy)) target = enemy;

        if (target == null)
        {
            Debug.Log("No target.");
            return;
        }

        timeKeeper += Time.deltaTime;

        foreach (var projectile in projectiles)
        {
            Debug.Log("Shooting");
            Vector3 dir = target.transform.position - projectile.transform.position;

            projectile.transform.position = projectile.transform.position + dir.normalized *
                                            projectile.projectileSpeed * Time.deltaTime;
        }

        if (timeKeeper < attackSpeed) return;
        Attack();
        timeKeeper = 0;
    }

    private void Attack()
    {
        Projectile newProjectile = Instantiate(projectilePrefab.gameObject).GetComponent<Projectile>();
        newProjectile.transform.position = transform.position;
        projectiles.Add(newProjectile);
    }
}

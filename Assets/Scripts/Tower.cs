using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] public int towerCost; //originally private
    [SerializeField] int towerRange;       //range as an int?
    [SerializeField] int attackSpeed;      //speed as an int?
    //tower has no attack?
    [SerializeField] Enemy target;

    //I assume it should have a collider to detect enemies but then I don't know what the towerRange is for
    //because I assume the tower won't target a single enemy during its entire lifetime...

    private void Update()
    {
        Attack();
    }

    private void Attack()
    {
        Instantiate(projectilePrefab.gameObject);


    }
}

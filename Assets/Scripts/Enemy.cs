using UnityEngine;

public class Enemy : MonoBehaviour
{
    //no need to write "enemy" everywhere on the enemy script
    //enemy and base both can be damaged, code duplication
    //enemies do not have a currentHP/maxHP distinction
    [SerializeField] int enemyHp;
    [SerializeField] int enemySpeed; //speed should be a float
    [SerializeField] int enemyDmg;   //"attack" would be a more accurate term
    [SerializeField] int enemyMoneyDrop;
    //no range to attack

    public Base _base;
    public EconomyManager economy;
    //variable name is unavailable, added an underscore
    //(originally) EnemySpawner does not have a reference to the base and cannot set the variable
    //(originally) and it's private anyway

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 dir = _base.transform.position - transform.position;
        transform.position = transform.position + (dir.normalized * enemySpeed * Time.deltaTime);
    }

    public void TakeDMG(int amount)
    {
        enemyHp = Mathf.Clamp(enemyHp - amount, 0, enemyHp);

        if (enemyHp <= 0) Die();
    }

    private void ApplyDMG(int amount)
    {
        //_base.TakeDmg(enemyDmg); //base's TakeDmg is set to private...

        //this function is never called, as there is no way to detect range

        //it uses an amount as parameter instead of the enemyDmg variable which I assume is meant to be the attack
            //however, it is unclear and i am not sure
    }
    private void Die()
    {
        economy.AddMoney(enemyMoneyDrop);
        gameObject.SetActive(false);
    }
}

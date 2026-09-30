using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] int baseMaxHp;
    int baseCurrentHp;

    private void Start()
    {
        baseCurrentHp = baseMaxHp;
    }

    private void TakeDMG(int amount)
    {
        baseCurrentHp = Mathf.Clamp(baseCurrentHp - amount, 0, baseCurrentHp);

        if (baseCurrentHp <= 0) IsDestroy();
    }

    private void IsDestroy() //IsSomething naming conventions should be used when returning a bool
    {
        //this function is essentially a Die() function, I don't know why the name is different
        //although it does force me to use Destroy() instead of being able to disable the gameobject
        // --> null ref risk

        Destroy(gameObject);
    }
}

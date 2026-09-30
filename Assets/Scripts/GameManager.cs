using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Victory()
    {
        Debug.Log("Player Won.");
        //access modifier is private, this function cannot be called elsewhere
    }

    private void Defeat()
    {
        Debug.Log("Player Lost.");
        //access modifier is private, this function cannot be called elsewhere
    }
}

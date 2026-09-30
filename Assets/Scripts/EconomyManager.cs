using System;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    private int currentMoney; //variable had no type on the diagram
    [SerializeField] private Tower towerPrefab;

    private void BuyTower() //never called
    {
        Instantiate(towerPrefab.gameObject);
        currentMoney -= towerPrefab.towerCost;

        Debug.Log($"CurrentMoney: {currentMoney}");
    }

    public void AddMoney(int enemyMoneyDrop) //originally private
    {
        currentMoney += enemyMoneyDrop;
        Debug.Log($"CurrentMoney: {currentMoney}");
    }
}

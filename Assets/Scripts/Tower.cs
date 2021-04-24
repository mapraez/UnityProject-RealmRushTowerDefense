using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int cost = 75;

    public bool CreateTower(Tower ballistaPrefab, Vector3 clickLocation)
    {
        Bank bank = FindObjectOfType<Bank>();
        if (bank == null)
        {
            return false;
        }
        if (bank.CurrentBalance >= cost)
        {
            Instantiate(ballistaPrefab, clickLocation, Quaternion.identity);
            bank.Withdraw(cost);
            return true;
        }

        return false;

    }
}

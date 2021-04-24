using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] Tower ballistaPrefab;


    [SerializeField] bool isPlacable;
    public bool IsPlacable { get { return isPlacable; } }




    void OnMouseDown()
    {
        if (isPlacable)
        {

            bool isPlaced = ballistaPrefab.CreateTower(ballistaPrefab, transform.position);

            isPlacable = !isPlaced;
        }


    }
    public bool GetIsPlacable()
    {
        return isPlacable;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSpawner : MonoBehaviour
{
    public GameObject EndPlace;

    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            PlaceSpawn();
        }
    }

    public void PlaceSpawn()
    {
       Vector3 direction;
        if (Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        EndPlace = Instantiate(EndPlace, EndPlace.transform.position + direction,EndPlace.transform.rotation);
    }
}

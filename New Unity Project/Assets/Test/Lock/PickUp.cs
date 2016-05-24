using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{

    public GameObject Item;


    void Start()
    {
        Item.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        Item.SetActive(true);

    }
}

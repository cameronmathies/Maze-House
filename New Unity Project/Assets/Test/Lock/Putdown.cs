using UnityEngine;
using System.Collections;

public class Putdown : MonoBehaviour {

    public GameObject Item;

    void OnTriggerEnter(Collider other)
    {
        Item.SetActive(false);

    }
}

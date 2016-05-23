using UnityEngine;
using System.Collections;

public class Light : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        Debug.Log("I'm blind!!!!!!");
    }
}

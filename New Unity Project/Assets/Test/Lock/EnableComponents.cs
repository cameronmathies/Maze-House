using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour
{
    public GameObject Door;
    public GameObject Key;
    void AnimationTurnOff()
    {
        Door.GetComponent<Animator>().enabled = false;
        Door.GetComponent<Collider>().enabled = false;
    }

    void Start()
    {
        Door.GetComponent<Animator>().enabled = false;
    }
    void OnTriggerEnter()
    {
        if (Key.tag == "Key")
        {
            Door.GetComponent<Animator>().enabled = true;
        Invoke("AnimationTurnOff", 1.9f);
    }
        }
    
}
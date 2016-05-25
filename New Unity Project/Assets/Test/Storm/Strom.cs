using UnityEngine;
using System.Collections;

public class Strom : MonoBehaviour {
    public float myCoolTimer;
    public float restart = 0f;
    public Light stormlight;
    public AudioSource thunder;

    void Start()
    {
        stormlight.GetComponent<Light>().enabled = false; ;
    }
    void Update()
    {
       

        myCoolTimer -= Time.deltaTime;
        if (myCoolTimer < 0)
        {
            Storm();
            myCoolTimer += restart + Random.Range(10, 60);
            
        }
      
    }

    void Timer()
    {
        myCoolTimer -= Time.deltaTime;
    }

    void Storm() {
        stormlight.enabled = true;
        thunder = GetComponent<AudioSource>();
        thunder.Play ();
        Invoke("Stormoff", .9f);

    }

    void Stormoff()
    {
        stormlight.enabled = false;
    }
}

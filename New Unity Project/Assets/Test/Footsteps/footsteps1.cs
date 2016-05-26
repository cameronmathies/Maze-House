using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(CharacterController))]
public class footsteps1 : MonoBehaviour {

    public AudioClip[] soundCarpet;
    public AudioClip[] soundOut;
    public AudioClip[] soundWater;
    public AudioClip[] soundMetal;
    private CharacterController _controller;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Use this for initialization
    IEnumerator Start()
    {
        while (true)
        {
            float vel = _controller.velocity.magnitude;
            RaycastHit hit = new RaycastHit();
            string floortag;
            if (_controller.isGrounded == true && vel > 0.2f)
            {
                if (Physics.Raycast(transform.position, Vector3.down, out hit))
                {
                    floortag = hit.collider.gameObject.tag;
                    if (floortag == "carpet")
                    {
                        GetComponent<AudioSource>().clip = soundCarpet[Random.Range(0, soundCarpet.Length)];
                    }
                    else if (floortag == "out")
                    {
                        GetComponent<AudioSource>().clip = soundOut[Random.Range(0, soundOut.Length)];
                    }
                    else if (floortag == "water")
                    {
                        GetComponent<AudioSource>().clip = soundWater[Random.Range(0, soundWater.Length)];
                    }
                    else if (floortag == "metal")
                    {
                        GetComponent<AudioSource>().clip = soundMetal[Random.Range(0, soundMetal.Length)];
                    }
                }


                //audio.clip = sounds[Random.Range(0, sounds.Length)];
                Debug.Log("sound");
                GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
                float interval = GetComponent<AudioSource>().clip.length;
                yield return new WaitForSeconds(interval);
            }
            else
            {
                yield return 0;
            }
        }


    }
}

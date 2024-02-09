using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTVOn2 : MonoBehaviour
{

    public AudioClip tvOn;
    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter TV Trigger");
        if (other.gameObject.tag == "Player")
        {
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit TV Trigger");
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
        }
    }
}

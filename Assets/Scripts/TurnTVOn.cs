using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTVOn : MonoBehaviour
{
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
            gameObject.SetActive(false);
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

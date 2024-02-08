using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTVOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Screen Trigger");

        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}

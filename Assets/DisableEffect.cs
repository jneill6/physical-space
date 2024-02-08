using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEffect : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}

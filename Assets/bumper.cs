using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    public GameObject chicken;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("groundCheck"))
        {
            chicken.GetComponent<agentRayCast>().setFrontCollide(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("groundCheck"))
        {
            chicken.GetComponent<agentRayCast>().setFrontCollide(false);
        }
    }
}

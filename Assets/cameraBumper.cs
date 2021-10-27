using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBumper : MonoBehaviour
{
    public GameObject player;
    string BumperName;
    private void Start()
    {
        BumperName = transform.gameObject.name;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("groundCheck"))
        {
            switch (BumperName)
            {
                case "ray1":
                    player.GetComponent<SwitchCamera>().setBumper1(true);
                    break;
                case "ray2":
                    player.GetComponent<SwitchCamera>().setBumper2(true);
                    break;
                case "ray3":
                    player.GetComponent<SwitchCamera>().setBumper3(true);
                    break;
                case "ray4":
                    player.GetComponent<SwitchCamera>().setBumper4(true);
                    break;
                case "ray5":
                    player.GetComponent<SwitchCamera>().setBumper5(true);
                    break;
                case "ray6":
                    player.GetComponent<SwitchCamera>().setBumper6(true);
                    break;
                case "ray7":
                    player.GetComponent<SwitchCamera>().setBumper7(true);
                    break;
                case "ray8":
                    player.GetComponent<SwitchCamera>().setBumper8(true);
                    break;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("groundCheck"))
        {
            switch (BumperName)
            {
                case "ray1":
                    player.GetComponent<SwitchCamera>().setBumper1(false);
                    break;
                case "ray2":
                    player.GetComponent<SwitchCamera>().setBumper2(false);
                    break;
                case "ray3":
                    player.GetComponent<SwitchCamera>().setBumper3(false);
                    break;
                case "ray4":
                    player.GetComponent<SwitchCamera>().setBumper4(false);
                    break;
                case "ray5":
                    player.GetComponent<SwitchCamera>().setBumper5(false);
                    break;
                case "ray6":
                    player.GetComponent<SwitchCamera>().setBumper6(false);
                    break;
                case "ray7":
                    player.GetComponent<SwitchCamera>().setBumper7(false);
                    break;
                case "ray8":
                    player.GetComponent<SwitchCamera>().setBumper8(false);
                    break;
            }
        }
    }
}

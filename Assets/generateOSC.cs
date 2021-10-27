using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;
public class generateOSC: MonoBehaviour
{
    public GameObject player;
    OSCReceiver receiver;

    private void Start()
    {
        receiver = player.AddComponent<OSCReceiver>();
        receiver.LocalPort = 7001;
    }

    public OSCReceiver GetReceiver()
    {
        return receiver;
    }
}

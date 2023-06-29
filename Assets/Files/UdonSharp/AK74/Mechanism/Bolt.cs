using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Bolt : UdonSharpBehaviour
{
    public GameObject BOLT_SAFE;
    public GameObject BOLT_AUTO;
    public GameObject BOLT_SEMI;
    public GameObject AK_CHARGED;
    public GameObject AK_NOTCHARGED;
    public Animator AK74;
    public override void Interact()
    {
        if (BOLT_SAFE.activeSelf == true)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "isSafe");
        }
        else if (BOLT_AUTO.activeSelf == true)
        {
            AK_CHARGED.SetActive(true);
            AK_NOTCHARGED.SetActive(false);
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "canFire");
        }
        else if (BOLT_SEMI.activeSelf == true)
        {
            AK_CHARGED.SetActive(true);
            AK_NOTCHARGED.SetActive(false);
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "canFire");
        }
    }
    public void isSafe()
    {
        AK74.SetInteger("bolt", 1);
        //Invoke("reset", 0.5f);
        SendCustomEventDelayedSeconds("reset", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void canFire()
    {
        AK74.SetInteger("bolt", 2);
        //Invoke("reset", 0.5f);
        SendCustomEventDelayedSeconds("reset", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void reset()
    {
        AK74.SetInteger("bolt", 0);
        //Invoke("reset", 0.5f);
        SendCustomEventDelayedSeconds("reset", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
}

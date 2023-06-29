using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Selector : UdonSharpBehaviour
{

    public UdonBehaviour Weapon;
    public GameObject SF_SAFE;
    public GameObject SF_AUTO;
    public GameObject SF_SEMI;
    public Animator ANIMATOR_AK74;
    public UnityEngine.UI.Text FIREMODE;
    public override void Interact()
    {
        if (SF_SAFE.activeSelf)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "isSafe");
            FIREMODE.text = "連発";
        }
        else if (SF_AUTO.activeSelf)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "isAuto");
            FIREMODE.text = "単発";
        }
        else if (SF_SEMI.activeSelf)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "isSemi");
            FIREMODE.text = "安全";
        }
    }
    public void isSafe()
    {
        ANIMATOR_AK74.SetInteger("selectFire", 1);
    }
    public void isAuto()
    {
        ANIMATOR_AK74.SetInteger("selectFire", 3);
    }
    public void isSemi()
    {
        ANIMATOR_AK74.SetInteger("selectFire", 6);
    }
}

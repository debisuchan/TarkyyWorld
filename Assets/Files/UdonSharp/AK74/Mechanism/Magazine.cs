using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Magazine : UdonSharpBehaviour
{
    public GameObject AMMO_10RND;
    public GameObject AMMO_30RND;
    public GameObject AMMO_45RND;
    public GameObject AMMO_60RND;
    public GameObject AMMO_95RND;
    public Animator ANIMATOR_AK74;
    public UdonBehaviour AK74;
    public override void Interact()
    {
        if (AMMO_10RND.activeSelf)
        {
            AK74.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RND10");
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "reload");
        }
        else
        {
            if (AMMO_30RND.activeSelf)
            {
                AK74.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RND30");
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "reload");
            }
            else
            {
                if (AMMO_45RND.activeSelf)
                {
                    AK74.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RND45");
                    SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "reload");
                }
                else
                {
                    if (AMMO_60RND.activeSelf)
                    {
                        AK74.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RND60");
                        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "reload");
                    }
                    else
                    {
                        if (AMMO_95RND.activeSelf)
                        {
                            AK74.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RND95");
                            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "reload");
                        }
                        else {}
                    }
                }
            }
        }
    }
    public void reload()
    {
        ANIMATOR_AK74.SetInteger("magazine", 1);
        //Invoke("reset", 0.4f);
        SendCustomEventDelayedSeconds("reset", 0.4f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void reset()
    {
        ANIMATOR_AK74.SetInteger("magazine", 0);
    }
}

using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Muzzle : UdonSharpBehaviour
{
    public PanelColor PanelColor;
    public Detachments Detachments;
    public Parts Parts;
    public Settings Settings;

    public GameObject muzzle_default1; //AK-74 5.45x39 muzzle brake-compensator (6P20 0-20)
    public GameObject muzzle_cqb74; //AK-74 PWS CQB 74 5.45x39 muzzle brake
    public GameObject muzzle_rrd; //AK-74 thread type JMac Customs RRD-4C multi-caliber muzzle brake
    public GameObject muzzle_srvv; //AK-74 SRVV 5.45x39 muzzle brake
    public GameObject muzzle_dtk; //AK Zenit DTK-1 7.62x39/5.45x39 muzzle brake-compensator
    public GameObject muzzle_default2; //AK-74M 5.45x39 muzzle brake-compensator (6P20 0-20)
    public GameObject muzzle_default3; //AKS-74U 5.45x39 muzzle brake-compensator (6P26 0-20)
    public GameObject muzzle_default4; //AK-105 5.45x39 muzzle brake-compensator (6P44 0-20)
    public GameObject muzzle_reactor; //AK Hexagon Reactor 5.45x39 muzzle brake
    public GameObject muzzle_dtMount; //SilencerCo Hybrid 46 Direct Thread Mount adapter
    public GameObject muzzle_pbs4; //AKS-74U PBS-4 5.45x39 sound suppressor
    public GameObject muzzle_hexagon; //AK-74 Hexagon 5.45x39 sound suppressor
    public GameObject muzzle_tgpA; //AK-74 TGP-A 5.45x39 sound suppressor
    public GameObject muzzle_waffle; //AK-74 Hexagon Wafflemaker 5.45x39 sound suppressor
    public GameObject muzzle_hybrid46; //SilencerCo Hybrid 46 multi-caliber sound suppressor

    public void attachDefault1()
    {
        SendCustomEvent("disableAll");
        muzzle_default1.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_default1 = true;
        SendCustomEvent("check");
    }
    public void attachDefault2()
    {
        SendCustomEvent("disableAll");
        muzzle_default2.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_default2 = true;
        SendCustomEvent("check");
    }
    public void attachDefault3()
    {
        SendCustomEvent("disableAll");
        muzzle_default3.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_default3 = true;
        SendCustomEvent("check");
    }
    public void attachDefault4()
    {
        SendCustomEvent("disableAll");
        muzzle_default4.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_default4 = true;
        SendCustomEvent("check");
    }
    public void attachCQB74()
    {
        SendCustomEvent("disableAll");
        muzzle_cqb74.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_cqb74 = true;
        SendCustomEvent("check");
    }
    public void attachRRD()
    {
        SendCustomEvent("disableAll");
        muzzle_rrd.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_rrd = true;
        SendCustomEvent("check");
    }
    public void attachSRVV()
    {
        SendCustomEvent("disableAll");
        muzzle_srvv.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_srvv = true;
        SendCustomEvent("check");
    }
    public void attachDTK()
    {
        SendCustomEvent("disableAll");
        muzzle_dtk.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_dtk = true;
        SendCustomEvent("check");
    }
    public void attachReactor()
    {
        SendCustomEvent("disableAll");
        muzzle_reactor.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_reactor = true;
        SendCustomEvent("check");
    }
    public void attachDTMount()
    {
        SendCustomEvent("disableAll");
        muzzle_dtMount.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_dtMount = true;
        SendCustomEvent("check");
    }
    public void attachPBS4()
    {
        SendCustomEvent("disableAll");
        muzzle_pbs4.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_pbs4 = true;
        SendCustomEvent("check");
    }
    public void attachHexagon()
    {
        SendCustomEvent("disableAll");
        muzzle_hexagon.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_hexagon = true;
        SendCustomEvent("check");
    }
    public void attachTGPA()
    {
        SendCustomEvent("disableAll");
        muzzle_tgpA.SetActive(true);

        Parts.reset1_muzzle();
        Parts.parts1_muzzle_tgpA = true;
        SendCustomEvent("check");
    }
    public void attachWaffle()
    {
        if (muzzle_reactor.activeSelf)
        {
            SendCustomEvent("disableAll");
            muzzle_waffle.SetActive(true);

            Parts.reset1_muzzle();
            Parts.parts1_muzzle_reactor = true;
            Parts.parts1_muzzle_waffle = true;
            SendCustomEvent("check");
        }
        if (!muzzle_reactor.activeSelf)
        {}
    }
    public void attachHybrid46()
    {
        if (muzzle_dtMount.activeSelf)
        {
            SendCustomEvent("disableAll");
            muzzle_hybrid46.SetActive(true);

            Parts.reset1_muzzle();
            Parts.parts1_muzzle_dtMount = true;
            Parts.parts1_muzzle_hybrid46 = true;
            SendCustomEvent("check");
        }
        if (!muzzle_dtMount.activeSelf)
        {}
    }

    public void disableAll()
    {
        muzzle_default1.SetActive(false);
        muzzle_cqb74.SetActive(false);
        muzzle_rrd.SetActive(false);
        muzzle_srvv.SetActive(false);
        muzzle_dtk.SetActive(false);
        muzzle_default2.SetActive(false);
        muzzle_default3.SetActive(false);
        muzzle_default4.SetActive(false);
        muzzle_reactor.SetActive(false);
        muzzle_dtMount.SetActive(false);
        muzzle_pbs4.SetActive(false);
        muzzle_hexagon.SetActive(false);
        muzzle_tgpA.SetActive(false);
        muzzle_waffle.SetActive(false);
        muzzle_hybrid46.SetActive(false);
    }

    public void check()
    {
        Settings.playerApi = Networking.LocalPlayer;
        string checkedPlayer = Settings.playerApi.displayName;
        if (Settings.playerName == checkedPlayer)
        {}
        else
        {
            Parts.SendCustomEventDelayedSeconds("checkParts", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
    }
}

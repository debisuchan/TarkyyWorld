using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Muzzle : UdonSharpBehaviour
{
    public PanelColor PanelColor;
    public Detachments Detachments;
    public Parts Parts;

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

    public void attachDefault()
    {
        
    }
}

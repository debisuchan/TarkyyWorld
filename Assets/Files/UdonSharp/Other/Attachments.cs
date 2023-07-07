
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Attachments : UdonSharpBehaviour
{
    public PanelColor PanelColor;
    public Muzzle Muzzle;
    public Parts Parts;

    public bool attach1Reactor;
    public bool attach1DTMount;

    public GameObject error;
    public UnityEngine.UI.Text errorPartText;
    public void errorYes()
    {
        PanelColor.check();

        if (attach1Reactor)
        {
            Parts.reset1_muzzle();
            Muzzle.muzzle_reactor.SetActive(true);
            Parts.parts1_muzzle_reactor = true;
            Muzzle.SendCustomEvent("check");
        }
        if (attach1DTMount)
        {
            Parts.reset1_muzzle();
            Muzzle.muzzle_dtMount.SetActive(true);
            Parts.parts1_muzzle_dtMount = true;
            Muzzle.SendCustomEvent("check");
        }

        SendCustomEvent("allAttachIsFalse");
        error.SetActive(false);
        PanelColor.SendCustomEvent("check");
    }
    public void allAttachIsFalse()
    {
        attach1DTMount = false;
        attach1Reactor = false;
    }
    public void closeError()
    {
        allAttachIsFalse();
        errorPartText.text = "";
        error.SetActive(false);
    }
}

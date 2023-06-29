using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class RearSight : UdonSharpBehaviour
{
    public Parts Parts;
    public Settings Settings;
    public Detachments Detachments;

    public int language = 0;

    public GameObject TT01Rear;
    public GameObject defaultRear;
    public GameObject handguardX47;
    public GameObject handguardOVGP;
    public GameObject coverPDC;
    public GameObject coverB33;
    public GameObject coverDogLeg;
    public GameObject coverBastion;
    public GameObject error;

    public UnityEngine.UI.Text errorPartText;

    public UdonBehaviour panel;
    public UdonBehaviour cover;
    public UdonBehaviour handguard;

    public void attachDefaultRear()
    {
        if (!coverPDC.activeSelf && !coverB33.activeSelf && !coverBastion.activeSelf)
        {
            TT01Rear.SetActive(false);
            defaultRear.SetActive(true);

            Parts.reset1_rs();
            Parts.parts1_rs_default = true;
            SendCustomEvent("check");
        }
        if (coverBastion.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_bastion_text;
            Detachments.detach1Bastion = true;
        }
        if (coverB33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
        if (coverPDC.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_pdc_text;
            Detachments.detach1PDC = true;
        }
    }
    public void attachTT01Rear()
    {
        if (!coverB33.activeSelf && !coverDogLeg.activeSelf && !coverBastion.activeSelf && !coverPDC.activeSelf && !handguardX47.activeSelf && !handguardOVGP.activeSelf)
        {
            defaultRear.SetActive(false);
            TT01Rear.SetActive(true);

            Parts.reset1_rs();
            Parts.parts1_rs_tt01 = true;
            SendCustomEvent("check");
        }
        if (handguardOVGP.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_keymod3_text;
            Detachments.detach1OVGP = true;
        }
        if (handguardX47.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_quadRail3_text;
            Detachments.detach1TDX47 = true;
        }
        if (coverPDC.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_pdc_text;
            Detachments.detach1PDC = true;
        }
        if (coverBastion.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_bastion_text;
            Detachments.detach1Bastion = true;
        }
        if (coverDogLeg.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_dogLeg_text;
            Detachments.detach1DogLeg = true;
        }
    }
    public void disableAll()
    {
        defaultRear.SetActive(true);
        TT01Rear.SetActive(true);
    }
    public void check()
    {
        Settings.playerApi = Networking.LocalPlayer;
        string checkedPlayer = Settings.playerApi.displayName;
        if (Settings.playerName == checkedPlayer)
        { }
        else
        {
            Parts.SendCustomEventDelayedSeconds("checkParts", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
    }
}

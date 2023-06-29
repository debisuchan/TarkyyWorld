using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class RearSight : UdonSharpBehaviour
{
    public Parts Parts;
    public Settings Settings;
    public Detachments Detachments;
    public Cover Cover;
    public Handguard Handguard;

    public int language = 0;

    public GameObject TT01Rear;
    public GameObject defaultRear;
    public GameObject error;
    public UnityEngine.UI.Text errorPartText;

    public UdonBehaviour panel;
    public UdonBehaviour cover;
    public UdonBehaviour handguard;

    public void attachDefaultRear()
    {
        if (!Cover.coverPDC.activeSelf && !Cover.coverZenit.activeSelf && !Cover.coverBastion.activeSelf)
        {
            TT01Rear.SetActive(false);
            defaultRear.SetActive(true);

            Parts.reset1_rs();
            Parts.parts1_rs_default = true;
            SendCustomEvent("check");
        }
        if (Cover.coverBastion.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_bastion_text;
            Detachments.detach1Bastion = true;
        }
        if (Cover.coverZenit.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
        if (Cover.coverPDC.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_pdc_text;
            Detachments.detach1PDC = true;
        }
    }
    public void attachTT01Rear()
    {
        if (!Cover.coverZenit.activeSelf && !Cover.coverDogLeg.activeSelf && !Cover.coverBastion.activeSelf && !Cover.coverPDC.activeSelf && !Handguard.hg_quadRail3.activeSelf && !Handguard.hg_keymod3.activeSelf)
        {
            defaultRear.SetActive(false);
            TT01Rear.SetActive(true);

            Parts.reset1_rs();
            Parts.parts1_rs_tt01 = true;
            SendCustomEvent("check");
        }
        if (Handguard.hg_keymod3.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_keymod3_text;
            Detachments.detach1OVGP = true;
        }
        if (Handguard.hg_quadRail3.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_quadRail3_text;
            Detachments.detach1TDX47 = true;
        }
        if (Cover.coverPDC.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_pdc_text;
            Detachments.detach1PDC = true;
        }
        if (Cover.coverBastion.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_bastion_text;
            Detachments.detach1Bastion = true;
        }
        if (Cover.coverDogLeg.activeSelf)
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

using UdonSharp;
using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.Events;
using VRC.SDKBase;
using VRC.Udon;
public class Cover : UdonSharpBehaviour
{
    public UdonBehaviour rearSight;
    public UdonBehaviour panel;
    public UdonBehaviour handguard;
    public Parts Parts;
    public Detachments Detachments;
    public Settings Settings;
    public Handguard Handguard;
    public RearSight RearSight;
    public PanelColor PanelColor;

    public int language = 0;

    public GameObject coverDefault;
    public GameObject coverBastion;
    public GameObject coverDogLeg;
    public GameObject coverZenit;
    public GameObject coverPDC;

    public GameObject error;
    public UnityEngine.UI.Text errorPartText;

    public string topCover = "";
    public string defaultText = "";
    public string l_rearSight = "";
    public string handGuard = "";

    //ここから　言語設定
    public void langJP()
    {
        language = 0;
    }
    public void langEN()
    {
        language = 1;
    }
    public void langKR()
    {
        language = 2;
    }
    public void setLang()
    {
        if (language == 0)
        {
            topCover = "トップカバー";
            defaultText = "基本";
            l_rearSight = "リアサイト";
            handGuard = "ハンドガード";
        }
        if (language == 1)
        {
            topCover = "Dust Cover";
            defaultText = "Default";
            l_rearSight = "Rear Sight";
            handGuard = "Handguard";
        }
        if (language == 2)
        {
            topCover = "탑커버";
            defaultText = "기본";
            l_rearSight = "가늠자";
            handGuard = "핸드가드";
        }
    }
    //ここまで　言語設定
    public void attachDefault()
    {
        Parts.checkLang();
        SendCustomEvent("disableAll");
        coverDefault.SetActive(true);

        Parts.parts1_cover_default = true;

        PanelColor.SendCustomEvent("newChecking");
    }
    public void attachBastion()
    {
        Parts.checkLang();
        if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf && !Handguard.hg_quadRail3.activeSelf && !Handguard.hg_keymod3.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverBastion.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_bastion = true;
            SendCustomEvent("check");

            PanelColor.SendCustomEvent("newChecking");
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
        if (RearSight.TT01Rear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_tt01_text;
            Detachments.detach1TT01 = true;
        }
        if (RearSight.defaultRear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_default_text;
            Detachments.detach1Default = true;
        }
    }
    public void attachPDC()
    {
        if (!RearSight.TT01Rear.activeSelf && !Handguard.hg_quadRail3.activeSelf && !Handguard.hg_keymod3.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverPDC.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_pdc = true;
            SendCustomEvent("check");

            PanelColor.SendCustomEvent("newChecking");
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
        if (RearSight.TT01Rear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_tt01_text;
            Detachments.detach1TT01 = true;
        }
    }
    public void attachB33()
    {
        Parts.checkLang();
        if (!RearSight.TT01Rear.activeSelf)
        {
            if (Handguard.hg_zenit2.activeSelf 
            || Handguard.hg_zenit3.activeSelf 
            || !Handguard.hg_quadRail3.activeSelf 
            && !Handguard.hg_default.activeSelf
            && !Handguard.hg_polymer1.activeSelf 
            && !Handguard.hg_polymer2.activeSelf 
            && !Handguard.hg_magpulA1.activeSelf 
            && !Handguard.hg_magpulA2.activeSelf 
            && !Handguard.hg_magpulA3.activeSelf 
            && !Handguard.hg_magpulA4.activeSelf 
            && !Handguard.hg_magpulA5.activeSelf 
            && !Handguard.hg_wooden1.activeSelf 
            && !Handguard.hg_wooden2.activeSelf 
            && !Handguard.hg_wooden3.activeSelf 
            && !Handguard.hg_keymod1.activeSelf 
            && !Handguard.hg_keymod2.activeSelf 
            && !Handguard.hg_keymod3.activeSelf 
            && !Handguard.hg_hexagon1.activeSelf 
            && !Handguard.hg_hexagon2.activeSelf 
            && !Handguard.hg_keymod1.activeSelf 
            && !Handguard.hg_zenit1.activeSelf 
            && !Handguard.hg_magpulB1.activeSelf 
            && !Handguard.hg_magpulB2.activeSelf 
            && !Handguard.hg_magpulB3.activeSelf 
            && !Handguard.hg_polymerRail.activeSelf 
            && !Handguard.hg_quadRail1.activeSelf 
            && !Handguard.hg_quadRail2.activeSelf 
            && !Handguard.hg_quadRail3.activeSelf 
            && !Handguard.hg_mlok1.activeSelf 
            && !Handguard.hg_mlok2.activeSelf 
            && !Handguard.hg_mlok3.activeSelf 
            && !Handguard.hg_woodenGrip.activeSelf 
            && !Handguard.hg_gasBlock1.activeSelf 
            && !Handguard.hg_gasBlock2.activeSelf 
            && !Handguard.hg_gasBlock3.activeSelf 
            && !Handguard.hg_gasBlock4.activeSelf)
            {
                SendCustomEvent("disableAll");
                coverZenit.SetActive(true);

                Parts.reset1_cover();
                Parts.parts1_cover_b33 = true;
                SendCustomEvent("check");

                PanelColor.SendCustomEvent("newChecking");
            }
            if (Handguard.hg_quadRail2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail2_text;
                Detachments.detach1RS47 = true;
            }
            if (Handguard.hg_default.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_default_text;
                Detachments.detach1DefaultHG = true;
            }
            if (Handguard.hg_polymer1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymer1_text;
                Detachments.detach1DefaultPoly = true;
            }
            if (Handguard.hg_polymer2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymer2_text;
                Detachments.detach1DefaultPlum = true;
            }
            if (Handguard.hg_magpulA1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA1_text;
                Detachments.detach1MOEBLK = true;
            }
            if (Handguard.hg_magpulA2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA2_text;
                Detachments.detach1MOEFDE = true;
            }
            if (Handguard.hg_magpulA3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA3_text;
                Detachments.detach1MOEOD = true;
            }
            if (Handguard.hg_magpulA4.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA4_text;
                Detachments.detach1MOEPlum = true;
            }
            if (Handguard.hg_magpulA5.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA5_text;
                Detachments.detach1MOESG = true;
            }
            if (Handguard.hg_wooden1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden1_text;
                Detachments.detach1Wooden1 = true;
            }
            if (Handguard.hg_wooden2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden2_text;
                Detachments.detach1Wooden2 = true;
            }
            if (Handguard.hg_wooden3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden3_text;
                Detachments.detach1Wooden3 = true;
            }
            if (Handguard.hg_keymod1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod1_text;
                Detachments.detach1Trax1 = true;
            }
            if (Handguard.hg_hexagon1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_hexagon1_text;
                Detachments.detach1HexBlk = true;
            }
            if (Handguard.hg_hexagon2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_hexagon2_text;
                Detachments.detach1HexRed = true;
            }
            if (Handguard.hg_keymod2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod2_text;
                Detachments.detach1Cmrd = true;
            }
            if (Handguard.hg_zenit1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_zenit1_text;
                Detachments.detach1B10 = true;
            }
            if (Handguard.hg_magpulB1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB1_text;
                Detachments.detach1ZhukovBlk = true;
            }
            if (Handguard.hg_magpulB2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB2_text;
                Detachments.detach1ZhukovFde = true;
            }
            if (Handguard.hg_magpulB3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB3_text;
                Detachments.detach1ZhukovPlum = true;
            }
            if (Handguard.hg_polymerRail.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymerRail_text;
                Detachments.detach1Ak100 = true;
            }
            if (Handguard.hg_quadRail1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail1_text;
                Detachments.detach1Aggressor = true;
            }
            if (Handguard.hg_mlok1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok1_text;
                Detachments.detach1AkmLBlk = true;
            }
            if (Handguard.hg_mlok2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok2_text;
                Detachments.detach1AkmLRed = true;
            }
            if (Handguard.hg_mlok3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok3_text;
                Detachments.detach1AkmLBr = true;
            }
            if (Handguard.hg_woodenGrip.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_woodenGrip_text;
                Detachments.detach1Wasr = true;
            }
            if (Handguard.hg_quadRail3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail3_text;
                Detachments.detach1TDX47 = true;
            }
            if (Handguard.hg_keymod3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod3_text;
                Detachments.detach1OVGP = true;
            }
            if (Handguard.hg_keymod4.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod4_text;
                Detachments.detach1UFM = true;
            }
            if (Handguard.hg_gasBlock4.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock4_text;
                Detachments.detach1m1b = true;
            }
            if (Handguard.hg_gasBlock1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock1_text;
                Detachments.detach1Troy = true;
            }
            if (Handguard.hg_gasBlock2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock2_text;
                Detachments.detach1VSCombo = true;
            }
            if (Handguard.hg_gasBlock3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock3_text;
                Detachments.detach1VSComboW = true;
            }
        }
    }
    public void attachDogLeg()
    {
        Parts.checkLang();
        if (!RearSight.TT01Rear.activeSelf && !RearSight.defaultRear.activeSelf && !Handguard.hg_quadRail3.activeSelf && !Handguard.hg_keymod3.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverDogLeg.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_dogLeg = true;
            SendCustomEvent("check");

            PanelColor.SendCustomEvent("newChecking");
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
        if (RearSight.defaultRear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_default_text;
            Detachments.detach1Default = true;

            Debug.Log(Parts.parts1_rs_default_text + " is a name of error object.");
        }
        if (RearSight.TT01Rear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_tt01_text;
            Detachments.detach1TT01 = true;
        }
    }
    public void disableAll()
    {
        coverDefault.SetActive(false);
        coverBastion.SetActive(false);
        coverPDC.SetActive(false);
        coverDogLeg.SetActive(false);
        coverZenit.SetActive(false);
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

using UdonSharp;
using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.Events;
using VRC.SDKBase;
using VRC.Udon;
public class Cover : UdonSharpBehaviour
{

    public Parts Parts;
    public Detachments Detachments;
    public Settings Settings;
    public int language = 0;

    public GameObject coverDefault;
    public GameObject coverBastion;
    public GameObject coverPDC;
    public GameObject coverDogLeg;
    public GameObject coverZenit;
    public GameObject defaultRear;
    public GameObject tt01;
    public GameObject error;
    public GameObject HGtdiX47;
    public GameObject HGovgp;
    public UnityEngine.UI.Text errorPartText;
    public UdonBehaviour rearSight;
    public UdonBehaviour panel;
    public UdonBehaviour handguard;
    public string topCover = "";
    public string defaultText = "";
    public string l_rearSight = "";
    public string handGuard = "";
    public GameObject HGb10m;
    public GameObject HGb30;
    public GameObject HGrs47;
    public GameObject HGdefault;
    public GameObject HGdefaultPoly;
    public GameObject HGmoeBlk;
    public GameObject HGmoeFde;
    public GameObject HGmoeOd;
    public GameObject HGmoePlum;
    public GameObject HGmoeSg;
    public GameObject HGwooden1; //AKM Wooden Handguard
    public GameObject HGwooden2; //VPO-136 Wooden Handguard
    public GameObject HGwooden3; //VPO-209 Wooden Handguard
    public GameObject HGtrax1;
    public GameObject HGhexagonBlk;
    public GameObject HGhexagonRed;
    public GameObject HGcmrd;
    public GameObject HGb10;
    public GameObject HGzhukovBlk;
    public GameObject HGzhukovFde;
    public GameObject HGZhukovPlum;
    public GameObject HGak100Poly;
    public GameObject HGdefaultPlum;
    public GameObject HGaggressor;
    public GameObject HGakmLBlk; //TDI AKM-L Handguard Black
    public GameObject HGwasr; //WASR-10/63 CAF Wooden Handguard
    public GameObject HGakmLRed; //TDI AKM-L Handguard Red
    public GameObject HGakmLBr; //TDI AKM-L Handguard Bronze
    public GameObject HGUFM; //Krebs Custom UFM KeyMod Handguard
    public GameObject HGm1b; //UltiMAK M1-B Handguard
    public GameObject HGtroy; //TROY Full Length Rail Handguard
    public GameObject HGVSCombo; //Vezhlivyy Strelok Handguard
    public GameObject HGVSComboW; //Vezhlivyy Strelok White Handguard
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
        SendCustomEvent("disableAll");
        coverDefault.SetActive(true);

        Parts.parts1_cover_default = true;
    }
    public void attachBastion()
    {
        if (!defaultRear.activeSelf && !tt01.activeSelf && !HGtdiX47.activeSelf && !HGovgp.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverBastion.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_bastion = true;
            SendCustomEvent("check");
        }
        if (HGovgp.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_keymod3_text;
            Detachments.detach1OVGP = true;
        }
        if (HGtdiX47.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_quadRail3_text;
            Detachments.detach1TDX47 = true;
        }
        if (tt01.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_tt01_text;
            Detachments.detach1TT01 = true;
        }
        if (defaultRear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_default_text;
            Detachments.detach1Default = true;
        }
    }
    public void attachPDC()
    {
        if (!tt01.activeSelf && !HGtdiX47.activeSelf && !HGovgp.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverPDC.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_pdc = true;
            SendCustomEvent("check");
        }
        if (HGovgp.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = "CNC Guns OV GP Handguard";
            panel.SendCustomEvent("detachHGOVGPIsTrue");
        }
        if (HGtdiX47.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = "TDI X47 Tactical Handguard";
            panel.SendCustomEvent("detachHGTDIX47IsTrue");
        }
        if (tt01.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = "Taktika Tula TT01 Rear Sight Rail";
            panel.SendCustomEvent("detachRearTT01IsTrue");
        }
    }
    public void attachB33()
    {
        if (!tt01.activeSelf)
        {
            if (HGb10m.activeSelf)
            {
                SendCustomEvent("disableAll");
                coverZenit.SetActive(true);

                Parts.reset1_cover();
                Parts.parts1_cover_b33 = true;
                SendCustomEvent("check");
            }
            if (HGb30.activeSelf)
            {
                SendCustomEvent("disableAll");
                coverZenit.SetActive(true);

                Parts.reset1_cover();
                Parts.parts1_cover_b33 = true;
                SendCustomEvent("check");
            }
            if (HGrs47.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail2_text;
                Detachments.detach1RS47 = true;
            }
            if (HGdefault.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_default_text;
                Detachments.detach1DefaultHG = true;
            }
            if (HGdefaultPoly.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymer1_text;
                Detachments.detach1DefaultPoly = true;
            }
            if (HGdefaultPlum.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymer2_text;
                Detachments.detach1DefaultPlum = true;
            }
            if (HGmoeBlk.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA1_text;
                Detachments.detach1MOEBLK = true;
            }
            if (HGmoeFde.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA2_text;
                Detachments.detach1MOEFDE = true;
            }
            if (HGmoeOd.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA3_text;
                Detachments.detach1MOEOD = true;
            }
            if (HGmoePlum.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA4_text;
                Detachments.detach1MOEPlum = true;
            }
            if (HGmoeSg.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulA5_text;
                Detachments.detach1MOESG = true;
            }
            if (HGwooden1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden1_text;
                Detachments.detach1Wooden1 = true;
            }
            if (HGwooden2.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden2_text;
                Detachments.detach1Wooden2 = true;
            }
            if (HGwooden3.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_wooden3_text;
                Detachments.detach1Wooden3 = true;
            }
            if (HGtrax1.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod1_text;
                Detachments.detach1Trax1 = true;
            }
            if (HGhexagonBlk.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_hexagon1_text;
                Detachments.detach1HexBlk = true;
            }
            if (HGhexagonRed.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_hexagon2_text;
                Detachments.detach1HexRed = true;
            }
            if (HGcmrd.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod2_text;
                Detachments.detach1Cmrd = true;
            }
            if (HGb10.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_zenit1_text;
                Detachments.detach1B10 = true;
            }
            if (HGzhukovBlk.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB1_text;
                Detachments.detach1ZhukovBlk = true;
            }
            if (HGzhukovFde.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB2_text;
                Detachments.detach1ZhukovFde = true;
            }
            if (HGZhukovPlum.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_magpulB3_text;
                Detachments.detach1ZhukovPlum = true;
            }
            if (HGak100Poly.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_polymerRail_text;
                Detachments.detach1Ak100 = true;
            }
            if (HGaggressor.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail1_text;
                Detachments.detach1Aggressor = true;
            }
            if (HGakmLBlk.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok1_text;
                Detachments.detach1AkmLBlk = true;
            }
            if (HGakmLRed.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok2_text;
                Detachments.detach1AkmLRed = true;
            }
            if (HGakmLBr.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_mlok3_text;
                Detachments.detach1AkmLBr = true;
            }
            if (HGwasr.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_woodenGrip_text;
                Detachments.detach1Wasr = true;
            }
            if (HGtdiX47.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_quadRail3_text;
                Detachments.detach1TDX47 = true;
            }
            if (HGovgp.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod3_text;
                Detachments.detach1OVGP = true;
            }
            if (HGUFM.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_keymod4_text;
                Detachments.detach1UFM = true;
            }
            if (HGm1b.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock4_text;
                Detachments.detach1m1b = true;
            }
            if (HGtroy.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock1_text;
                Detachments.detach1Troy = true;
            }
            if (HGVSCombo.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock2_text;
                Detachments.detach1VSCombo = true;
            }
            if (HGVSComboW.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_hg_gasBlock3_text;
                Detachments.detach1VSComboW = true;
            }
        }
    }
    public void attachDogLeg()
    {
        if (!tt01.activeSelf && !defaultRear.activeSelf && !HGtdiX47.activeSelf && !HGovgp.activeSelf)
        {
            SendCustomEvent("disableAll");
            coverDogLeg.SetActive(true);

            Parts.reset1_cover();
            Parts.parts1_cover_dogLeg = true;
            SendCustomEvent("check");
        }
        if (HGovgp.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_keymod3_text;
            Detachments.detach1OVGP = true;
        }
        if (HGtdiX47.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_hg_quadRail3_text;
            Detachments.detach1TDX47 = true;
        }
        if (defaultRear.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_rs_default_text;
            Detachments.detach1Default = true;
        }
        if (tt01.activeSelf)
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

//This is weapon parts handler for late joined players
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Detachments : UdonSharpBehaviour
{
    VRCPlayerApi playerApi;

    public Settings Settings;
    public Cover Cover;
    public RearSight RearSight;
    public Handguard Handguard;
    public Parts Parts;
    public Panel Panel;
    public PanelColor PanelColor;

    public UnityEngine.UI.Text errorPartText;
    public GameObject error;

    //AK-74専用パーツまとめて整理
    public bool detach1Default; //基本リアサイト
    public bool detach1TT01;
    public bool detach1TDX47;
    public bool detach1OVGP;
    public bool detach1RS47;
    public bool detach1DefaultHG;
    public bool detach1DefaultPoly;
    public bool detach1DefaultPlum;
    public bool detach1MOEBLK;
    public bool detach1MOEFDE;
    public bool detach1MOEOD;
    public bool detach1MOEPlum;
    public bool detach1MOESG;
    public bool detach1Wooden1;
    public bool detach1Wooden2;
    public bool detach1Wooden3;
    public bool detach1Trax1;
    public bool detach1HexBlk;
    public bool detach1HexRed;
    public bool detach1Cmrd;
    public bool detach1B10;
    public bool detach1ZhukovBlk;
    public bool detach1ZhukovFde;
    public bool detach1ZhukovPlum;
    public bool detach1Ak100;
    public bool detach1Aggressor;
    public bool detach1AkmLBlk;
    public bool detach1AkmLRed;
    public bool detach1AkmLBr;
    public bool detach1Wasr;
    public bool detach1UFM;
    public bool detach1m1b;
    public bool detach1Troy;
    public bool detach1VSCombo;
    public bool detach1VSComboW;
    public bool detach1Bastion;
    public bool detach1PDC;
    public bool detach1B33;
    public bool detach1DogLeg;


    //ERROR
    //  エラー画面のためにコードされたメソッド
    public void errorYes()
    {
        PanelColor.newChecking();

        //WEAPON 1 REAR SIGHT
        if (detach1Default == true)
        {
            RearSight.defaultRear.SetActive(false);
            Parts.parts1_rs_default = false;
            RearSight.SendCustomEvent("check");
        }
        if (detach1TT01 == true)
        {
            RearSight.TT01Rear.SetActive(false);
            Parts.parts1_rs_tt01 = false;
            RearSight.SendCustomEvent("check");
        }
        //WEAPON 1 HANDGUARDS
        if (detach1OVGP == true)
        {
            Handguard.hg_keymod3.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_keymod3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1RS47 == true)
        {
            Handguard.hg_quadRail2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_quadRail2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1DefaultHG == true)
        {
            Handguard.hg_default.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_default = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1DefaultPoly == true)
        {
            Handguard.hg_polymer1.SetActive(false);
            Handguard.hg_polymerBase.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_polymer1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1DefaultPlum == true)
        {
            Handguard.hg_polymer2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_polymer2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1MOEBLK == true)
        {
            Handguard.hg_magpulA1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulA1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1MOEFDE == true)
        {
            Handguard.hg_magpulA2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulA2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1MOEOD == true)
        {
            Handguard.hg_magpulA3.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulA3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1MOEPlum == true)
        {
            Handguard.hg_magpulA4.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulA4 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1MOESG == true)
        {
            Handguard.hg_magpulA5.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulA5 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Wooden1 == true)
        {
            Handguard.hg_wooden1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_wooden1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Wooden2 == true)
        {
            Handguard.hg_wooden2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_wooden2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Wooden3 == true)
        {
            Handguard.hg_wooden3.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_wooden3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Trax1 == true)
        {
            Handguard.hg_keymod1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_keymod1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1HexBlk == true)
        {
            Handguard.hg_hexagon1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_hexagon1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1HexRed == true)
        {
            Handguard.hg_hexagon2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_hexagon2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Cmrd == true)
        {
            Handguard.hg_keymod2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_keymod2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1B10 == true)
        {
            Handguard.hg_zenit1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_zenit1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1ZhukovBlk == true)
        {
            Handguard.hg_magpulB1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulB1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1ZhukovFde == true)
        {
            Handguard.hg_magpulB2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulB2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1ZhukovPlum == true)
        {
            Handguard.hg_magpulB3.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_magpulB3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Ak100 == true)
        {
            Handguard.hg_polymerRail.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_polymerRail = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Aggressor == true)
        {
            Handguard.hg_quadRail1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_polymerRail = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1AkmLBlk == true)
        {
            Handguard.hg_mlok1.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_mlok1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1AkmLRed == true)
        {
            Handguard.hg_mlok2.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_mlok2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1AkmLBr == true)
        {
            Handguard.hg_mlok3.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_mlok3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Wasr == true)
        {
            Handguard.hg_woodenGrip.SetActive(false);
            Handguard.gb_default.SetActive(false);
            Parts.parts1_hg_woodenGrip = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1UFM == true)
        {
            Handguard.hg_keymod4.SetActive(false);
            Handguard.gb_vdm.SetActive(false);
            Parts.parts1_hg_keymod4 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1m1b == true)
        {
            Handguard.hg_gasBlock4.SetActive(false);
            Parts.parts1_hg_gasBlock4 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Troy == true)
        {
            Handguard.hg_gasBlock1.SetActive(false);
            Parts.parts1_hg_gasBlock1 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1VSCombo == true)
        {
            Handguard.hg_gasBlock2.SetActive(false);
            Handguard.hg_vsGasBlock.SetActive(false);
            Parts.parts1_hg_gasBlock2 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1VSComboW == true)
        {
            Handguard.hg_gasBlock3.SetActive(false);
            Handguard.hg_vsGasBlock.SetActive(false);
            Parts.parts1_hg_gasBlock3 = false;
            Handguard.SendCustomEvent("check");
        }
        if (detach1Bastion == true)
        {
            RearSight.SendCustomEvent("detachBastion");
            RearSight.SendCustomEvent("check");
        }
        if (detach1B33 == true)
        {
            RearSight.defaultRear.SetActive(false);
            Parts.parts1_rs_default = false;
            RearSight.SendCustomEvent("check");
        }
        if (detach1PDC == true)
        {
            RearSight.TT01Rear.SetActive(false);
            Parts.parts1_rs_tt01 = false;
            RearSight.SendCustomEvent("check");
        }

        SendCustomEvent("allDetachIsFalse");
        error.SetActive(false);
        PanelColor.SendCustomEvent("newChecking");

    }
    public void allDetachIsFalse()
    {
        detach1Default = false;
        detach1TT01 = false;
        detach1TDX47 = false;
        detach1OVGP = false;
        detach1RS47 = false;
        detach1DefaultHG = false;
        detach1DefaultPoly = false;
        detach1DefaultPlum = false;
        detach1MOEBLK = false;
        detach1MOEFDE = false;
        detach1MOEOD = false;
        detach1MOEPlum = false;
        detach1MOESG = false;
        detach1Wooden1 = false;
        detach1Wooden2 = false;
        detach1Wooden3 = false;
        detach1Trax1 = false;
        detach1HexBlk = false;
        detach1HexRed = false;
        detach1Cmrd = false;
        detach1B10 = false;
        detach1ZhukovBlk = false;
        detach1ZhukovFde = false;
        detach1ZhukovPlum = false;
        detach1Ak100 = false;
        detach1Aggressor = false;
        detach1AkmLBlk = false;
        detach1AkmLRed = false;
        detach1AkmLBr = false;
        detach1Wasr = false;
        detach1UFM = false;
        detach1m1b = false;
        detach1Troy = false;
        detach1VSCombo = false;
        detach1VSComboW = false;
        detach1Bastion = false;
        detach1B33 = false;
        detach1PDC = false;
    }
    public void closeError()
    {
        allDetachIsFalse();
        errorPartText.text = "";
        error.SetActive(false);
    }
}

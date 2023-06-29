//This is weapon parts handler for late joined players
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Detachments : UdonSharpBehaviour
{

    public Cover Cover;
    public RearSight RearSight;
    public Handguard Handguard;
    public Parts Parts;
    public Panel Panel;

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
        if (detach1Default == true)
        {
            Cover.SendCustomEvent("detachRearDefault");
            SendCustomEvent("allDetachIsFalse");
            Parts.parts1_rs_default = false;
        }
        if (detach1TT01 == true)
        {
            Cover.SendCustomEvent("detachRearTT01");
            SendCustomEvent("allDetachIsFalse");
            Parts.parts1_rs_tt01 = false;
        }
        if (detach1OVGP == true)
        {
            Cover.SendCustomEvent("detachOVGP");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1RS47 == true)
        {
            Cover.SendCustomEvent("detachRS47");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1DefaultHG == true)
        {
            Cover.SendCustomEvent("detachDefaultHG");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1DefaultPoly == true)
        {
            Cover.SendCustomEvent("detachDefaultPoly");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1DefaultPlum == true)
        {
            Cover.SendCustomEvent("detachDefaultPlum");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1MOEBLK == true)
        {
            Cover.SendCustomEvent("detachMOEBLK");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1MOEFDE == true)
        {
            Cover.SendCustomEvent("detachMOEFDE");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1MOEOD == true)
        {
            Cover.SendCustomEvent("detachMOEOD");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1MOEPlum == true)
        {
            Cover.SendCustomEvent("detachMOEPlum");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1MOESG == true)
        {
            Cover.SendCustomEvent("detachMOESG");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Wooden1 == true)
        {
            Cover.SendCustomEvent("detachWooden1");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Wooden2 == true)
        {
            Cover.SendCustomEvent("detachWooden2");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Wooden3 == true)
        {
            Cover.SendCustomEvent("detachWooden3");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Trax1 == true)
        {
            Cover.SendCustomEvent("detachTrax1");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1HexBlk == true)
        {
            Cover.SendCustomEvent("detachHexBlk");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1HexRed == true)
        {
            Cover.SendCustomEvent("detachHexRed");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Cmrd == true)
        {
            Cover.SendCustomEvent("detachCmrd");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1B10 == true)
        {
            Cover.SendCustomEvent("detachB10");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1ZhukovBlk == true)
        {
            Cover.SendCustomEvent("detachZhukovBlk");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1ZhukovFde == true)
        {
            Cover.SendCustomEvent("detachZhukovFde");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1ZhukovPlum == true)
        {
            Cover.SendCustomEvent("detachZhukovPlum");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Ak100 == true)
        {
            Cover.SendCustomEvent("detachAk100");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Aggressor == true)
        {
            Cover.SendCustomEvent("detachAggressor");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1AkmLBlk == true)
        {
            Cover.SendCustomEvent("detachAkmLBlk");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1AkmLRed == true)
        {
            Cover.SendCustomEvent("detachAkmLRed");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1AkmLBr == true)
        {
            Cover.SendCustomEvent("detachAkmLBr");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Wasr == true)
        {
            Cover.SendCustomEvent("detachWasr");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1UFM == true)
        {
            Cover.SendCustomEvent("detachUFM");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1m1b == true)
        {
            Cover.SendCustomEvent("detachm1b");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Troy == true)
        {
            Cover.SendCustomEvent("detachTroy");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1VSCombo == true)
        {
            Cover.SendCustomEvent("detachVSCombo");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1VSComboW == true)
        {
            Cover.SendCustomEvent("detachVSComboW");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1Bastion == true)
        {
            RearSight.SendCustomEvent("detachBastion");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1B33 == true)
        {
            RearSight.SendCustomEvent("detachB33");
            SendCustomEvent("allDetachIsFalse");
        }
        if (detach1PDC == true)
        {
            RearSight.SendCustomEvent("detachPDC");
            SendCustomEvent("allDetachIsFalse");
        }
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


using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PanelColor : UdonSharpBehaviour
{
    //イメージ
    public UnityEngine.UI.Image img_coverDefault;
    public UnityEngine.UI.Image img_coverBastion;
    public UnityEngine.UI.Image img_coverDogLeg;
    public UnityEngine.UI.Image img_coverPDC;
    public UnityEngine.UI.Image img_coverB33;
    
    public UnityEngine.UI.Image img_rearDefault;
    public UnityEngine.UI.Image img_rearTT01;

    public UnityEngine.UI.Image img_hgDefault;
    public UnityEngine.UI.Image img_hgWooden1;
    public UnityEngine.UI.Image img_hgWooden2;
    public UnityEngine.UI.Image img_hgWooden3;
    public UnityEngine.UI.Image img_hgWoodenGrip;
    public UnityEngine.UI.Image img_hgPolymer1;
    public UnityEngine.UI.Image img_hgPolymer2;
    public UnityEngine.UI.Image img_hgPolymerRail;
    public UnityEngine.UI.Image img_hgMagpulA1;
    public UnityEngine.UI.Image img_hgMagpulA2;
    public UnityEngine.UI.Image img_hgMagpulA3;
    public UnityEngine.UI.Image img_hgMagpulA4;
    public UnityEngine.UI.Image img_hgMagpulA5;
    public UnityEngine.UI.Image img_hgMagpulB1;
    public UnityEngine.UI.Image img_hgMagpulB2;
    public UnityEngine.UI.Image img_hgMagpulB3;
    public UnityEngine.UI.Image img_hgQuadRail1;
    public UnityEngine.UI.Image img_hgQuadRail2;
    public UnityEngine.UI.Image img_hgQuadRail3;
    public UnityEngine.UI.Image img_hgHexagon1;
    public UnityEngine.UI.Image img_hgHexagon2;
    public UnityEngine.UI.Image img_hgKeymod1;
    public UnityEngine.UI.Image img_hgKeymod2;
    public UnityEngine.UI.Image img_hgKeymod3;
    public UnityEngine.UI.Image img_hgKeymod4;
    public UnityEngine.UI.Image img_hgMlok1;
    public UnityEngine.UI.Image img_hgMlok2;
    public UnityEngine.UI.Image img_hgMlok3;
    public UnityEngine.UI.Image img_hgZenit1;
    public UnityEngine.UI.Image img_hgZenit2;
    public UnityEngine.UI.Image img_hgZenit3;
    public UnityEngine.UI.Image img_hgGasBlock1;
    public UnityEngine.UI.Image img_hgGasBlock2;
    public UnityEngine.UI.Image img_hgGasBlock3; 
    public UnityEngine.UI.Image img_hgGasBlock4;

    //オブジェクト
    public GameObject hg_default; //Default Handguard
    public GameObject hg_wooden1; //AKM Wooden Handguard
    public GameObject hg_wooden2; //VPO-136 Wooden Handguard
    public GameObject hg_wooden3; //VPO-209 Wooden Handguard
    public GameObject hg_woodenGrip; //WASR-10/63 CAF Handguard
    public GameObject hg_polymer1; //AK-74 Polymer Handguard
    public GameObject hg_polymer2; //AK-74 Plum Polymer Handguard
    public GameObject hg_polymerBase; //!Polymer BASE!
    public GameObject hg_polymerRail1; //AK-74 Polymer Handguard with Rails
    public GameObject hg_polymerRail2; //AK 100 Series Polymer Handguard
    public GameObject hg_magpulA1; //Magpul MOE AKM Handguard Black
    public GameObject hg_magpulA2; //Magpul MOE AKM Handguard FDE
    public GameObject hg_magpulA3; //Magpul MOE AKM Handguard OD
    public GameObject hg_magpulA4; //Magpul MOE AKM Handguard Plum
    public GameObject hg_magpulA5; //Magpul MOE AKM Handguard SG
    public GameObject hg_magpulB1; //Magpul Zhukov-U Black Handguard
    public GameObject hg_magpulB2; //Magpul Zhukov-U FDE Handguard
    public GameObject hg_magpulB3; //Magpul Zhukov-U Plum Handguard
    public GameObject hg_quadRail1; //5.45 Design Aggressor Handguard
    public GameObject hg_quadRail2; //CAA RS47 Handguard
    public GameObject hg_quadRail3; //TDI X47 Tactical Handguard
    public GameObject hg_hexagon1; //Hexagon Tubular Black Handguard
    public GameObject hg_hexagon2; //Hexagon Tubular Red Handguard
    public GameObject hg_keymod1; //Strike Industries TRAX 1 Handguard
    public GameObject hg_keymod2; //Vltor CMRD Handguard
    public GameObject hg_keymod3; //CNC Guns OV GP Handguard
    public GameObject hg_keymod4; //Krebs Custom UFM KeyMod Handguard
    public GameObject hg_mlok1; //TDI AKM-L Black Handguard
    public GameObject hg_mlok2; //TDI AKM-L Red Handguard
    public GameObject hg_mlok3; //TDI AKM-L Bronze Handguard
    public GameObject hg_tdiAttach; //Attachment for TDI AKM-L Handguards
    public GameObject hg_zenit1; //Zenit B-10 Handguard
    public GameObject hg_zenit2; //Zenit B-10M Handguard
    public GameObject hg_zenit3; //Zenit B-30 Handguard
    public GameObject hg_gasBlock1; //Troy Full Lenght Rail Handguard
    public GameObject hg_gasBlock2; //Vezhlivyy Strelok Handguard
    public GameObject hg_gasBlock3; //Vezhlivyy Strelok White Handguard
    public GameObject hg_gasBlock4; //UltiMAK M1-B Handguard
    public GameObject hg_vsGasBlock; //Handguard Gas Block for VS

    //チェック用トップカバー変数
    public GameObject cover_default;
    public GameObject cover_bastion;
    public GameObject cover_pdc;
    public GameObject cover_dogLeg;
    public GameObject cover_b33;

    //チェック用リアサイト変数
    public GameObject rs_default;
    public GameObject rs_tt01;

    //チェック用ガスブロック変数
    public GameObject gb_vdm;
    public GameObject gb_default;
    

    //ハンドガード
    public void Execute1()
    {
        Reset2();
        Reset3();

        SendCustomEventDelayedSeconds("first", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    //
    public void Execute2()
    {
        Reset1();

        SendCustomEventDelayedSeconds("second", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void Execute3()
    {
        Reset1();
        Reset3();

        SendCustomEventDelayedSeconds("third", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    //ハンドガードの場合
    public void first()
    {
        if (hg_default.activeSelf || hg_wooden1.activeSelf || hg_wooden2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_wooden3.activeSelf || hg_woodenGrip.activeSelf || hg_polymer1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_polymer2.activeSelf || hg_polymerRail2.activeSelf || hg_magpulA1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }if (hg_magpulA2.activeSelf || hg_magpulA3.activeSelf || hg_magpulA4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_magpulA5.activeSelf || hg_magpulB1.activeSelf || hg_magpulB2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_magpulB3.activeSelf || hg_quadRail1.activeSelf || hg_quadRail2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_hexagon1.activeSelf || hg_hexagon2.activeSelf || hg_keymod1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_keymod2.activeSelf || hg_keymod4.activeSelf || hg_keymod4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_mlok1.activeSelf || hg_mlok2.activeSelf || hg_mlok3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_zenit1.activeSelf || hg_gasBlock1.activeSelf || hg_gasBlock2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_gasBlock3.activeSelf || hg_gasBlock4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (hg_keymod3.activeSelf || hg_quadRail3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 150, 150, 255);
            Handguard2();
        }
        if (hg_zenit2.activeSelf || hg_zenit3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard3();
        }
        else
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            
            if (rs_default.activeSelf == true)
            {
                img_coverBastion.color = new Color32(255, 255, 255, 255);
                img_coverDogLeg.color = new Color32(255, 255, 255, 255);
                img_coverB33.color = new Color32(255, 255, 255, 255);
                img_coverPDC.color = new Color32(255, 255, 255, 255);
            }
            if (rs_tt01.activeSelf == true)
            {
                img_coverBastion.color = new Color32(255, 150, 150, 255);
                img_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img_coverB33.color = new Color32(255, 150, 150, 255);
                img_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            if (!rs_default.activeSelf && !rs_tt01.activeSelf)
            {
                img_coverBastion.color = new Color32(255, 255, 255, 255);
                img_coverDogLeg.color = new Color32(255, 255, 255, 255);
                img_coverB33.color = new Color32(255, 255, 255, 255);
                img_coverPDC.color = new Color32(255, 255, 255, 255);
            }
        }
    }
    public void second()
    {
        if (rs_default.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            if (cover_pdc.activeSelf)
            {
                img_hgKeymod3.color = new Color32(255, 150, 150, 255);
                img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            }
            if (cover_default.activeSelf)
            {
            }
            if (hg_quadRail3.activeSelf || hg_keymod3.activeSelf)
            {
                img_coverB33.color = new Color32(255, 150, 150, 255);
                img_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            else
            {
                
            }
        }
        if (rs_tt01.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverPDC.color = new Color32(255, 150, 150, 255);

            img_hgKeymod3.color = new Color32(255, 150, 150, 255);
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
        }
    }
    //普通のハンドガードが付いてあるんでリアサイトのボタンの色が基本
    public void Handguard1()
    {
        if (rs_default.activeSelf)
        {
            img_coverPDC.color = new Color32(255, 255, 255, 255);
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
        }
        if (rs_tt01.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!rs_default.activeSelf && !rs_tt01.activeSelf)
        {
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverBastion.color = new Color32(255, 255, 255, 255);
            img_coverDogLeg.color = new Color32(255, 255, 255, 255);
            img_coverPDC.color = new Color32(255, 255, 255, 255);
        }
    }
    //トップカバーまで包むハンドガード向け
    public void Handguard2()
    {
        img_coverBastion.color = new Color32(255, 150, 150, 255);
        img_coverDogLeg.color = new Color32(255, 150, 150, 255);
        img_coverB33.color = new Color32(255, 150, 150, 255);
        img_coverPDC.color = new Color32(255, 150, 150, 255);
    }
    public void Handguard3()
    {
        if (rs_default.activeSelf == true)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 255, 255, 255);
            img_coverPDC.color = new Color32(255, 255, 255, 255);
        }
        if (rs_tt01.activeSelf == true)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!rs_default.activeSelf && !rs_tt01.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 255, 255, 255);
            img_coverDogLeg.color = new Color32(255, 255, 255, 255);
            img_coverB33.color = new Color32(255, 255, 255, 255);
            img_coverPDC.color = new Color32(255, 255, 255, 255);
        }
    }
    public void third()
    {
        if (cover_default.activeSelf)
        {}
        if (cover_b33.activeSelf)
        {
            img_hgDefault.color = new Color32(255, 150, 150, 255);
            img_hgWooden1.color = new Color32(255, 150, 150, 255);
            img_hgWooden2.color = new Color32(255, 150, 150, 255);
            img_hgWooden3.color = new Color32(255, 150, 150, 255);
            img_hgWoodenGrip.color = new Color32(255, 150, 255, 255);
            img_hgPolymer1.color = new Color32(255, 150, 150, 255);
            img_hgPolymer2.color = new Color32(255, 150, 150, 255);
            img_hgPolymerRail.color = new Color32(255, 150, 150, 255);
            img_hgMagpulA1.color = new Color32(255, 150, 150, 255);
            img_hgMagpulA2.color = new Color32(255, 150, 150, 255);
            img_hgMagpulA3.color = new Color32(255, 150, 150, 255);
            img_hgMagpulA4.color = new Color32(255, 150, 150, 255);
            img_hgMagpulA5.color = new Color32(255, 150, 150, 255);
            img_hgMagpulB1.color = new Color32(255, 150, 150, 255);
            img_hgMagpulB2.color = new Color32(255, 150, 150, 255);
            img_hgMagpulB3.color = new Color32(255, 150, 150, 255);
            img_hgQuadRail1.color = new Color32(255, 150, 150, 255);
            img_hgQuadRail2.color = new Color32(255, 150, 150, 255);
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img_hgHexagon1.color = new Color32(255, 150, 150, 255);
            img_hgHexagon2.color = new Color32(255, 150, 150, 255);
            img_hgKeymod1.color = new Color32(255, 150, 150, 255);
            img_hgKeymod2.color = new Color32(255, 150, 150, 255);
            img_hgKeymod3.color = new Color32(255, 150, 150, 255);
            img_hgKeymod4.color = new Color32(255, 150, 150, 255);
            img_hgMlok1.color = new Color32(255, 150, 150, 255);
            img_hgMlok2.color = new Color32(255, 150, 150, 255);
            img_hgMlok3.color = new Color32(255, 150, 150, 255);
            img_hgZenit1.color = new Color32(255, 150, 150, 255);
            img_hgGasBlock1.color = new Color32(255, 150, 150, 255);
            img_hgGasBlock2.color = new Color32(255, 150, 150, 255);
            img_hgGasBlock3.color = new Color32(255, 150, 150, 255);
            img_hgGasBlock4.color = new Color32(255, 150, 150, 255);

            img_rearTT01.color = new Color32(255, 150, 150, 255);
        }
        if (cover_bastion.activeSelf || cover_dogLeg.activeSelf)
        {
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img_rearDefault.color = new Color32(255, 150, 150, 255);
            img_rearTT01.color = new Color32(255, 150, 150, 255);
        }
        if (cover_pdc.activeSelf)
        {
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img_rearTT01.color = new Color32(255, 150, 150, 255);
        }
    }
    public void fourth()
    {

    }

    //new Color32(255, 150, 150, 255); //FF9696
    //new Color32(255, 255, 255, 255); //FFFFFF

    //ハンドガードボタン
    public void Reset1()
    {
        img_hgDefault.color = new Color32(255, 255, 255, 255);
        img_hgWooden1.color = new Color32(255, 255, 255, 255);
        img_hgWooden2.color = new Color32(255, 255, 255, 255);
        img_hgWooden3.color = new Color32(255, 255, 255, 255);
        img_hgWoodenGrip.color = new Color32(255, 255, 255, 255);
        img_hgPolymer1.color = new Color32(255, 255, 255, 255);
        img_hgPolymer2.color = new Color32(255, 255, 255, 255);
        img_hgPolymerRail.color = new Color32(255, 255, 255, 255);
        img_hgMagpulA1.color = new Color32(255, 255, 255, 255);
        img_hgMagpulA2.color = new Color32(255, 255, 255, 255);
        img_hgMagpulA3.color = new Color32(255, 255, 255, 255);
        img_hgMagpulA4.color = new Color32(255, 255, 255, 255);
        img_hgMagpulA5.color = new Color32(255, 255, 255, 255);
        img_hgMagpulB1.color = new Color32(255, 255, 255, 255);
        img_hgMagpulB2.color = new Color32(255, 255, 255, 255);
        img_hgMagpulB3.color = new Color32(255, 255, 255, 255);
        img_hgQuadRail1.color = new Color32(255, 255, 255, 255);
        img_hgQuadRail2.color = new Color32(255, 255, 255, 255);
        img_hgQuadRail3.color = new Color32(255, 255, 255, 255);
        img_hgHexagon1.color = new Color32(255, 255, 255, 255);
        img_hgHexagon2.color = new Color32(255, 255, 255, 255);
        img_hgKeymod1.color = new Color32(255, 255, 255, 255);
        img_hgKeymod2.color = new Color32(255, 255, 255, 255);
        img_hgKeymod3.color = new Color32(255, 255, 255, 255);
        img_hgKeymod4.color = new Color32(255, 255, 255, 255);
        img_hgMlok1.color = new Color32(255, 255, 255, 255);
        img_hgMlok2.color = new Color32(255, 255, 255, 255);
        img_hgMlok3.color = new Color32(255, 255, 255, 255);
        img_hgZenit1.color = new Color32(255, 255, 255, 255);
        img_hgZenit2.color = new Color32(255, 255, 255, 255);
        img_hgZenit3.color = new Color32(255, 255, 255, 255);
        img_hgGasBlock1.color = new Color32(255, 255, 255, 255);
        img_hgGasBlock2.color = new Color32(255, 255, 255, 255);
        img_hgGasBlock3.color = new Color32(255, 255, 255, 255);
        img_hgGasBlock4.color = new Color32(255, 255, 255, 255);
    }
    //トップカバーボタン
    public void Reset2()
    {
        img_coverDefault.color = new Color32(255, 255, 255, 255);
        img_coverBastion.color = new Color32(255, 255, 255, 255);
        img_coverDogLeg.color = new Color32(255, 255, 255, 255);
        img_coverPDC.color = new Color32(255, 255, 255, 255);
        img_coverB33.color = new Color32(255, 255, 255, 255);
    }
    //リアサイトボタン
    public void Reset3()
    {
        img_rearDefault.color = new Color32(255, 255, 255, 255);
        img_rearTT01.color = new Color32(255, 255, 255, 255);
    }
}
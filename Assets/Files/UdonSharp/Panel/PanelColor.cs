
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PanelColor : UdonSharpBehaviour
{
    public Handguard Handguard;
    public RearSight RearSight;
    public Cover Cover;
    public Panel Panel;
    
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
    
    //ハンドガード
    public void check()
    {
        Reset1();
        Reset2();
        Reset3();

        SendCustomEventDelayedSeconds("first", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        SendCustomEventDelayedSeconds("second", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        SendCustomEventDelayedSeconds("third", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    
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
        if (Handguard.hg_default.activeSelf || Handguard.hg_wooden1.activeSelf || Handguard.hg_wooden2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_wooden3.activeSelf || Handguard.hg_woodenGrip.activeSelf || Handguard.hg_polymer1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        /*
        if (Handguard.hg_polymer2.activeSelf || Handguard.hg_polymerRail2.activeSelf || Handguard.hg_magpulA1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        */
        if (Handguard.hg_magpulA2.activeSelf || Handguard.hg_magpulA3.activeSelf || Handguard.hg_magpulA4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_magpulA5.activeSelf || Handguard.hg_magpulB1.activeSelf || Handguard.hg_magpulB2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_magpulB3.activeSelf || Handguard.hg_quadRail1.activeSelf || Handguard.hg_quadRail2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_hexagon1.activeSelf || Handguard.hg_hexagon2.activeSelf || Handguard.hg_keymod1.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_keymod2.activeSelf || Handguard.hg_keymod4.activeSelf || Handguard.hg_keymod4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_mlok1.activeSelf || Handguard.hg_mlok2.activeSelf || Handguard.hg_mlok3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_zenit1.activeSelf || Handguard.hg_gasBlock1.activeSelf || Handguard.hg_gasBlock2.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_gasBlock3.activeSelf || Handguard.hg_gasBlock4.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_keymod3.activeSelf || Handguard.hg_quadRail3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 150, 150, 255);
            Handguard2();
        }
        if (Handguard.hg_zenit2.activeSelf || Handguard.hg_zenit3.activeSelf)
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard3();
        }
        else
        {
            img_rearDefault.color = new Color32(255, 255, 255, 255);
            img_rearTT01.color = new Color32(255, 255, 255, 255);
            
            if (RearSight.defaultRear.activeSelf == true)
            {
                img_coverBastion.color = new Color32(255, 255, 255, 255);
                img_coverDogLeg.color = new Color32(255, 255, 255, 255);
                img_coverB33.color = new Color32(255, 255, 255, 255);
                img_coverPDC.color = new Color32(255, 255, 255, 255);
            }
            if (RearSight.TT01Rear.activeSelf == true)
            {
                img_coverBastion.color = new Color32(255, 150, 150, 255);
                img_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img_coverB33.color = new Color32(255, 150, 150, 255);
                img_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
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
        if (RearSight.defaultRear.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            if (Cover.coverPDC.activeSelf)
            {
                img_hgKeymod3.color = new Color32(255, 150, 150, 255);
                img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            }
            if (Cover.coverDefault.activeSelf)
            {
            }
            if (Handguard.hg_quadRail3.activeSelf || Handguard.hg_keymod3.activeSelf)
            {
                img_coverB33.color = new Color32(255, 150, 150, 255);
                img_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            else
            {
                
            }
        }
        if (RearSight.TT01Rear.activeSelf)
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
        if (RearSight.defaultRear.activeSelf)
        {
            img_coverPDC.color = new Color32(255, 255, 255, 255);
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
        }
        if (RearSight.TT01Rear.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
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
        if (RearSight.defaultRear.activeSelf == true)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 255, 255, 255);
            img_coverPDC.color = new Color32(255, 255, 255, 255);
        }
        if (RearSight.TT01Rear.activeSelf == true)
        {
            img_coverBastion.color = new Color32(255, 150, 150, 255);
            img_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img_coverB33.color = new Color32(255, 150, 150, 255);
            img_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
        {
            img_coverBastion.color = new Color32(255, 255, 255, 255);
            img_coverDogLeg.color = new Color32(255, 255, 255, 255);
            img_coverB33.color = new Color32(255, 255, 255, 255);
            img_coverPDC.color = new Color32(255, 255, 255, 255);
        }
    }
    public void third()
    {
        if (Cover.coverDefault.activeSelf)
        {}
        if (Cover.coverZenit.activeSelf)
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
        if (Cover.coverBastion.activeSelf || Cover.coverDogLeg.activeSelf)
        {
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img_rearDefault.color = new Color32(255, 150, 150, 255);
            img_rearTT01.color = new Color32(255, 150, 150, 255);
        }
        if (Cover.coverPDC.activeSelf)
        {
            img_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img_rearTT01.color = new Color32(255, 150, 150, 255);
        }
    }
    public void fourth()
    {

    }

    //new Color32(255, 150, 150, 255); //FF9696 - X
    //new Color32(255, 255, 255, 255); //FFFFFF - O

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
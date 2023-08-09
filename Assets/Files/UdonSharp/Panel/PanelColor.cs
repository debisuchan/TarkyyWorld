
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
    public Muzzle Muzzle;
    
    public UnityEngine.UI.Image img1_coverDefault;
    public UnityEngine.UI.Image img1_coverBastion;
    public UnityEngine.UI.Image img1_coverDogLeg;
    public UnityEngine.UI.Image img1_coverPDC;
    public UnityEngine.UI.Image img1_coverB33;
    
    public UnityEngine.UI.Image img1_rearDefault;
    public UnityEngine.UI.Image img1_rearTT01;

    public UnityEngine.UI.Image img1_hgDefault;
    public UnityEngine.UI.Image img1_hgWooden1;
    public UnityEngine.UI.Image img1_hgWooden2;
    public UnityEngine.UI.Image img1_hgWooden3;
    public UnityEngine.UI.Image img1_hgWoodenGrip;
    public UnityEngine.UI.Image img1_hgPolymer1;
    public UnityEngine.UI.Image img1_hgPolymer2;
    public UnityEngine.UI.Image img1_hgPolymerRail;
    public UnityEngine.UI.Image img1_hgMagpulA1;
    public UnityEngine.UI.Image img1_hgMagpulA2;
    public UnityEngine.UI.Image img1_hgMagpulA3;
    public UnityEngine.UI.Image img1_hgMagpulA4;
    public UnityEngine.UI.Image img1_hgMagpulA5;
    public UnityEngine.UI.Image img1_hgMagpulB1;
    public UnityEngine.UI.Image img1_hgMagpulB2;
    public UnityEngine.UI.Image img1_hgMagpulB3;
    public UnityEngine.UI.Image img1_hgQuadRail1;
    public UnityEngine.UI.Image img1_hgQuadRail2;
    public UnityEngine.UI.Image img1_hgQuadRail3;
    public UnityEngine.UI.Image img1_hgHexagon1;
    public UnityEngine.UI.Image img1_hgHexagon2;
    public UnityEngine.UI.Image img1_hgKeymod1;
    public UnityEngine.UI.Image img1_hgKeymod2;
    public UnityEngine.UI.Image img1_hgKeymod3;
    public UnityEngine.UI.Image img1_hgKeymod4;
    public UnityEngine.UI.Image img1_hgMlok1;
    public UnityEngine.UI.Image img1_hgMlok2;
    public UnityEngine.UI.Image img1_hgMlok3;
    public UnityEngine.UI.Image img1_hgZenit1;
    public UnityEngine.UI.Image img1_hgZenit2;
    public UnityEngine.UI.Image img1_hgZenit3;
    public UnityEngine.UI.Image img1_hgGasBlock1;
    public UnityEngine.UI.Image img1_hgGasBlock2;
    public UnityEngine.UI.Image img1_hgGasBlock3; 
    public UnityEngine.UI.Image img1_hgGasBlock4;

    public UnityEngine.UI.Image img1_muzzleWaffle;
    public UnityEngine.UI.Image img1_muzzleHyb46;
    
    
    //ハンドガード

    /* 新たなメソッドで全体的にチェックするメソッド導入「newChecking」
    public void check()
    {
        Reset1();
        Reset2();
        Reset3();

        SendCustomEventDelayedSeconds("first", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        SendCustomEventDelayedSeconds("second", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        SendCustomEventDelayedSeconds("third", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    */
    
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
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_wooden3.activeSelf || Handguard.hg_woodenGrip.activeSelf || Handguard.hg_polymer1.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_polymer2.activeSelf || Handguard.hg_polymerRail.activeSelf || Handguard.hg_magpulA1.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_magpulA2.activeSelf || Handguard.hg_magpulA3.activeSelf || Handguard.hg_magpulA4.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_magpulA5.activeSelf || Handguard.hg_magpulB1.activeSelf || Handguard.hg_magpulB2.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_magpulB3.activeSelf || Handguard.hg_quadRail1.activeSelf || Handguard.hg_quadRail2.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_hexagon1.activeSelf || Handguard.hg_hexagon2.activeSelf || Handguard.hg_keymod1.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_keymod2.activeSelf || Handguard.hg_keymod4.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_mlok1.activeSelf || Handguard.hg_mlok2.activeSelf || Handguard.hg_mlok3.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_zenit1.activeSelf || Handguard.hg_gasBlock1.activeSelf || Handguard.hg_gasBlock2.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_gasBlock3.activeSelf || Handguard.hg_gasBlock4.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard1();
        }
        if (Handguard.hg_keymod3.activeSelf || Handguard.hg_quadRail3.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 150, 150, 255);
            Handguard2();
        }
        if (Handguard.hg_zenit2.activeSelf || Handguard.hg_zenit3.activeSelf)
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            Handguard3();
        }
        else
        {
            img1_rearDefault.color = new Color32(255, 255, 255, 255);
            img1_rearTT01.color = new Color32(255, 255, 255, 255);
            
            if (RearSight.defaultRear.activeSelf == true)
            {
                img1_coverBastion.color = new Color32(255, 255, 255, 255);
                img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
                img1_coverB33.color = new Color32(255, 255, 255, 255);
                img1_coverPDC.color = new Color32(255, 255, 255, 255);
            }
            if (RearSight.TT01Rear.activeSelf == true)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img1_coverB33.color = new Color32(255, 150, 150, 255);
                img1_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 255, 255, 255);
                img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
                img1_coverB33.color = new Color32(255, 255, 255, 255);
                img1_coverPDC.color = new Color32(255, 255, 255, 255);
            }
        }
    }
    public void second()
    {
        if (RearSight.defaultRear.activeSelf)
        {
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            if (Cover.coverPDC.activeSelf)
            {
                img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
                img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            }
            if (Cover.coverDefault.activeSelf)
            {
            }
            if (Handguard.hg_quadRail3.activeSelf || Handguard.hg_keymod3.activeSelf)
            {
                img1_coverB33.color = new Color32(255, 150, 150, 255);
                img1_coverPDC.color = new Color32(255, 150, 150, 255);
            }
            else
            {
                
            }
        }
        if (RearSight.TT01Rear.activeSelf)
        {
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            img1_coverPDC.color = new Color32(255, 150, 150, 255);

            img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
            img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
        }
    }
    //普通のハンドガードが付いてあるんでリアサイトのボタンの色が基本
    public void Handguard1()
    {
        if (RearSight.defaultRear.activeSelf)
        {
            img1_coverPDC.color = new Color32(255, 255, 255, 255);
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 150, 150, 255);
        }
        if (RearSight.TT01Rear.activeSelf)
        {
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            img1_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
        {
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            img1_coverBastion.color = new Color32(255, 255, 255, 255);
            img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
            img1_coverPDC.color = new Color32(255, 255, 255, 255);
        }
    }
    //トップカバーまで包むハンドガード向け
    public void Handguard2()
    {
        img1_coverBastion.color = new Color32(255, 150, 150, 255);
        img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
        img1_coverB33.color = new Color32(255, 150, 150, 255);
        img1_coverPDC.color = new Color32(255, 150, 150, 255);
    }
    public void Handguard3()
    {
        if (RearSight.defaultRear.activeSelf == true)
        {
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 255, 255, 255);
            img1_coverPDC.color = new Color32(255, 255, 255, 255);
        }
        if (RearSight.TT01Rear.activeSelf == true)
        {
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            img1_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
        {
            img1_coverBastion.color = new Color32(255, 255, 255, 255);
            img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
            img1_coverB33.color = new Color32(255, 255, 255, 255);
            img1_coverPDC.color = new Color32(255, 255, 255, 255);
        }
    }
    public void third()
    {
        if (Cover.coverDefault.activeSelf)
        {}
        if (Cover.coverZenit.activeSelf)
        {
            img1_hgDefault.color = new Color32(255, 150, 150, 255);
            img1_hgWooden1.color = new Color32(255, 150, 150, 255);
            img1_hgWooden2.color = new Color32(255, 150, 150, 255);
            img1_hgWooden3.color = new Color32(255, 150, 150, 255);
            img1_hgWoodenGrip.color = new Color32(255, 150, 150, 255);
            img1_hgPolymer1.color = new Color32(255, 150, 150, 255);
            img1_hgPolymer2.color = new Color32(255, 150, 150, 255);
            img1_hgPolymerRail.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulA1.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulA2.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulA3.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulA4.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulA5.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulB1.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulB2.color = new Color32(255, 150, 150, 255);
            img1_hgMagpulB3.color = new Color32(255, 150, 150, 255);
            img1_hgQuadRail1.color = new Color32(255, 150, 150, 255);
            img1_hgQuadRail2.color = new Color32(255, 150, 150, 255);
            img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img1_hgHexagon1.color = new Color32(255, 150, 150, 255);
            img1_hgHexagon2.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod1.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod2.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod4.color = new Color32(255, 150, 150, 255);
            img1_hgMlok1.color = new Color32(255, 150, 150, 255);
            img1_hgMlok2.color = new Color32(255, 150, 150, 255);
            img1_hgMlok3.color = new Color32(255, 150, 150, 255);
            img1_hgZenit1.color = new Color32(255, 150, 150, 255);
            img1_hgGasBlock1.color = new Color32(255, 150, 150, 255);
            img1_hgGasBlock2.color = new Color32(255, 150, 150, 255);
            img1_hgGasBlock3.color = new Color32(255, 150, 150, 255);
            img1_hgGasBlock4.color = new Color32(255, 150, 150, 255);

            img1_rearTT01.color = new Color32(255, 150, 150, 255);
        }
        if (Cover.coverBastion.activeSelf || Cover.coverDogLeg.activeSelf)
        {
            img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img1_rearDefault.color = new Color32(255, 150, 150, 255);
            img1_rearTT01.color = new Color32(255, 150, 150, 255);
        }
        if (Cover.coverPDC.activeSelf)
        {
            img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
            img1_hgKeymod3.color = new Color32(255, 150, 150, 255);

            img1_rearTT01.color = new Color32(255, 150, 150, 255);
        }
    }
    
    //new Color32(255, 150, 150, 255); //FF9696 - X
    //new Color32(255, 255, 255, 255); //FFFFFF - O

    //ハンドガードボタン
    public void Reset1()
    {
        img1_hgDefault.color = new Color32(255, 255, 255, 255);
        img1_hgWooden1.color = new Color32(255, 255, 255, 255);
        img1_hgWooden2.color = new Color32(255, 255, 255, 255);
        img1_hgWooden3.color = new Color32(255, 255, 255, 255);
        img1_hgWoodenGrip.color = new Color32(255, 255, 255, 255);
        img1_hgPolymer1.color = new Color32(255, 255, 255, 255);
        img1_hgPolymer2.color = new Color32(255, 255, 255, 255);
        img1_hgPolymerRail.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA1.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA2.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA3.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA4.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA5.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB1.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB2.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB3.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail1.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail2.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail3.color = new Color32(255, 255, 255, 255);
        img1_hgHexagon1.color = new Color32(255, 255, 255, 255);
        img1_hgHexagon2.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod1.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod2.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod3.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod4.color = new Color32(255, 255, 255, 255);
        img1_hgMlok1.color = new Color32(255, 255, 255, 255);
        img1_hgMlok2.color = new Color32(255, 255, 255, 255);
        img1_hgMlok3.color = new Color32(255, 255, 255, 255);
        img1_hgZenit1.color = new Color32(255, 255, 255, 255);
        img1_hgZenit2.color = new Color32(255, 255, 255, 255);
        img1_hgZenit3.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock1.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock2.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock3.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock4.color = new Color32(255, 255, 255, 255);
    }
    //トップカバーボタン
    public void Reset2()
    {
        img1_coverDefault.color = new Color32(255, 255, 255, 255);
        img1_coverBastion.color = new Color32(255, 255, 255, 255);
        img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
        img1_coverPDC.color = new Color32(255, 255, 255, 255);
        img1_coverB33.color = new Color32(255, 255, 255, 255);
    }
    //リアサイトボタン
    public void Reset3()
    {
        img1_rearDefault.color = new Color32(255, 255, 255, 255);
        img1_rearTT01.color = new Color32(255, 255, 255, 255);
    }

    public void resetAll()
    {
        img1_hgDefault.color = new Color32(255, 255, 255, 255);
        img1_hgWooden1.color = new Color32(255, 255, 255, 255);
        img1_hgWooden2.color = new Color32(255, 255, 255, 255);
        img1_hgWooden3.color = new Color32(255, 255, 255, 255);
        img1_hgWoodenGrip.color = new Color32(255, 255, 255, 255);
        img1_hgPolymer1.color = new Color32(255, 255, 255, 255);
        img1_hgPolymer2.color = new Color32(255, 255, 255, 255);
        img1_hgPolymerRail.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA1.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA2.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA3.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA4.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulA5.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB1.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB2.color = new Color32(255, 255, 255, 255);
        img1_hgMagpulB3.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail1.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail2.color = new Color32(255, 255, 255, 255);
        img1_hgQuadRail3.color = new Color32(255, 255, 255, 255);
        img1_hgHexagon1.color = new Color32(255, 255, 255, 255);
        img1_hgHexagon2.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod1.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod2.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod3.color = new Color32(255, 255, 255, 255);
        img1_hgKeymod4.color = new Color32(255, 255, 255, 255);
        img1_hgMlok1.color = new Color32(255, 255, 255, 255);
        img1_hgMlok2.color = new Color32(255, 255, 255, 255);
        img1_hgMlok3.color = new Color32(255, 255, 255, 255);
        img1_hgZenit1.color = new Color32(255, 255, 255, 255);
        img1_hgZenit2.color = new Color32(255, 255, 255, 255);
        img1_hgZenit3.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock1.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock2.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock3.color = new Color32(255, 255, 255, 255);
        img1_hgGasBlock4.color = new Color32(255, 255, 255, 255);

        img1_coverDefault.color = new Color32(255, 255, 255, 255);
        img1_coverBastion.color = new Color32(255, 255, 255, 255);
        img1_coverDogLeg.color = new Color32(255, 255, 255, 255);
        img1_coverPDC.color = new Color32(255, 255, 255, 255);
        img1_coverB33.color = new Color32(255, 255, 255, 255);

        img1_rearDefault.color = new Color32(255, 255, 255, 255);
        img1_rearTT01.color = new Color32(255, 255, 255, 255);

        img1_muzzleHyb46.color = new Color32(255, 255, 255, 255);
        img1_muzzleWaffle.color = new Color32(255, 255, 255, 255);
    }
    public void newChecking()
    {
        if (Handguard.hg_default.activeSelf 
        || Handguard.hg_wooden1.activeSelf 
        || Handguard.hg_wooden2.activeSelf 
        || Handguard.hg_wooden3.activeSelf 
        || Handguard.hg_woodenGrip.activeSelf 
        || Handguard.hg_polymer1.activeSelf 
        || Handguard.hg_polymer2.activeSelf 
        || Handguard.hg_polymerRail.activeSelf 
        || Handguard.hg_magpulA1.activeSelf 
        || Handguard.hg_magpulA2.activeSelf 
        || Handguard.hg_magpulA3.activeSelf 
        || Handguard.hg_magpulA4.activeSelf 
        || Handguard.hg_magpulA5.activeSelf 
        || Handguard.hg_magpulB1.activeSelf 
        || Handguard.hg_magpulB2.activeSelf 
        || Handguard.hg_magpulB3.activeSelf 
        || Handguard.hg_quadRail1.activeSelf 
        || Handguard.hg_quadRail2.activeSelf 
        || Handguard.hg_hexagon1.activeSelf 
        || Handguard.hg_hexagon2.activeSelf 
        || Handguard.hg_keymod1.activeSelf 
        || Handguard.hg_keymod2.activeSelf 
        || Handguard.hg_keymod4.activeSelf 
        || Handguard.hg_mlok1.activeSelf 
        || Handguard.hg_mlok2.activeSelf 
        || Handguard.hg_mlok3.activeSelf 
        || Handguard.hg_zenit1.activeSelf 
        || Handguard.hg_gasBlock1.activeSelf 
        || Handguard.hg_gasBlock2.activeSelf 
        || Handguard.hg_gasBlock3.activeSelf 
        || Handguard.hg_gasBlock4.activeSelf)
        {
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            if (RearSight.defaultRear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                if (Cover.coverPDC.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                    img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
                }
            }
            if (RearSight.TT01Rear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
                img1_hgKeymod3.color = new Color32(255, 150, 150, 255);

            }
            if (!RearSight.defaultRear.activeSelf && !RearSight.TT01Rear.activeSelf)
            {
                if (Cover.coverDogLeg.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                    img1_rearDefault.color = new Color32(255, 150, 150, 255);
                }
                if (Cover.coverBastion.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                    img1_rearDefault.color = new Color32(255, 150, 150, 255);
                }
                if (Cover.coverPDC.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                }
            }
            if (Handguard.hg_hexagon1.activeSelf || Handguard.hg_hexagon2.activeSelf)
            {
                img1_muzzleWaffle.color = new Color32(255, 150, 150, 255);
            }
        }
        if (Handguard.hg_quadRail3.activeSelf || Handguard.hg_keymod3.activeSelf)
        {
            img1_rearTT01.color = new Color32(255, 150, 150, 255);
            img1_coverB33.color = new Color32(255, 150, 150, 255);
            img1_coverBastion.color = new Color32(255, 150, 150, 255);
            img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            img1_coverPDC.color = new Color32(255, 150, 150, 255);
        }
        if (Handguard.hg_zenit2.activeSelf || Handguard.hg_zenit3.activeSelf)
        {
            if (RearSight.defaultRear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                if (Cover.coverPDC.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                    img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
                }
                if (Cover.coverZenit.activeSelf)
                {
                    img1_rearTT01.color = new Color32(255, 150, 150, 255);
                    img1_hgDefault.color = new Color32(255, 150, 150, 255);
                    img1_hgWooden1.color = new Color32(255, 150, 150, 255);
                    img1_hgWooden2.color = new Color32(255, 150, 150, 255);
                    img1_hgWooden3.color = new Color32(255, 150, 150, 255);
                    img1_hgWoodenGrip.color = new Color32(255, 150, 150, 255);
                    img1_hgPolymer1.color = new Color32(255, 150, 150, 255);
                    img1_hgPolymer2.color = new Color32(255, 150, 150, 255);
                    img1_hgPolymerRail.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulA1.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulA2.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulA3.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulA4.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulA5.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulB1.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulB2.color = new Color32(255, 150, 150, 255);
                    img1_hgMagpulB3.color = new Color32(255, 150, 150, 255);
                    img1_hgQuadRail1.color = new Color32(255, 150, 150, 255);
                    img1_hgQuadRail2.color = new Color32(255, 150, 150, 255);
                    img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
                    img1_hgHexagon1.color = new Color32(255, 150, 150, 255);
                    img1_hgHexagon2.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod1.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod2.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
                    img1_hgKeymod4.color = new Color32(255, 150, 150, 255);
                    img1_hgMlok1.color = new Color32(255, 150, 150, 255);
                    img1_hgMlok2.color = new Color32(255, 150, 150, 255);
                    img1_hgMlok3.color = new Color32(255, 150, 150, 255);
                    img1_hgZenit1.color = new Color32(255, 150, 150, 255);
                    img1_hgGasBlock1.color = new Color32(255, 150, 150, 255);
                    img1_hgGasBlock2.color = new Color32(255, 150, 150, 255);
                    img1_hgGasBlock3.color = new Color32(255, 150, 150, 255);
                    img1_hgGasBlock4.color = new Color32(255, 150, 150, 255);
                }
            }
            if (RearSight.TT01Rear.activeSelf)
            {
                img1_coverB33.color = new Color32(255, 150, 150, 255);
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img1_coverPDC.color = new Color32(255, 150, 150, 255);
            }
        }
        if (Handguard.hg_default.activeSelf 
        && Handguard.hg_wooden1.activeSelf 
        && Handguard.hg_wooden2.activeSelf 
        && Handguard.hg_wooden3.activeSelf 
        && Handguard.hg_woodenGrip.activeSelf 
        && Handguard.hg_polymer1.activeSelf 
        && Handguard.hg_polymer2.activeSelf 
        && Handguard.hg_polymerRail.activeSelf 
        && Handguard.hg_magpulA1.activeSelf 
        && Handguard.hg_magpulA2.activeSelf 
        && Handguard.hg_magpulA3.activeSelf 
        && Handguard.hg_magpulA4.activeSelf 
        && Handguard.hg_magpulA5.activeSelf 
        && Handguard.hg_magpulB1.activeSelf 
        && Handguard.hg_magpulB2.activeSelf 
        && Handguard.hg_magpulB3.activeSelf 
        && Handguard.hg_quadRail1.activeSelf 
        && Handguard.hg_quadRail2.activeSelf 
        && Handguard.hg_quadRail3.activeSelf 
        && Handguard.hg_hexagon1.activeSelf 
        && Handguard.hg_hexagon2.activeSelf 
        && Handguard.hg_keymod1.activeSelf 
        && Handguard.hg_keymod2.activeSelf 
        && Handguard.hg_keymod3.activeSelf 
        && Handguard.hg_keymod4.activeSelf 
        && Handguard.hg_mlok1.activeSelf 
        && Handguard.hg_mlok2.activeSelf 
        && Handguard.hg_mlok3.activeSelf 
        && Handguard.hg_zenit1.activeSelf 
        && Handguard.hg_zenit2.activeSelf 
        && Handguard.hg_zenit3.activeSelf 
        && Handguard.hg_gasBlock1.activeSelf 
        && Handguard.hg_gasBlock2.activeSelf 
        && Handguard.hg_gasBlock3.activeSelf 
        && Handguard.hg_gasBlock4.activeSelf)
        {
            if (RearSight.defaultRear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
            }
            if (RearSight.TT01Rear.activeSelf)
            {
                img1_coverBastion.color = new Color32(255, 150, 150, 255);
                img1_coverDogLeg.color = new Color32(255, 150, 150, 255);
                img1_coverPDC.color = new Color32(255, 150, 150, 255);
                img1_coverB33.color = new Color32(255, 150, 150, 255);
                img1_hgQuadRail3.color = new Color32(255, 150, 150, 255);
                img1_hgKeymod3.color = new Color32(255, 150, 150, 255);
            }
        }
        if (Muzzle.muzzle_default1.activeSelf 
        || Muzzle.muzzle_default2.activeSelf 
        || Muzzle.muzzle_default3.activeSelf 
        || Muzzle.muzzle_default4.activeSelf 
        || Muzzle.muzzle_cqb74.activeSelf 
        || Muzzle.muzzle_rrd.activeSelf 
        || Muzzle.muzzle_srvv.activeSelf 
        || Muzzle.muzzle_dtk.activeSelf 
        || Muzzle.muzzle_pbs4.activeSelf 
        || Muzzle.muzzle_hexagon.activeSelf 
        || Muzzle.muzzle_tgpA.activeSelf)
        {
            img1_muzzleHyb46.color = new Color32(255, 150, 150, 255);
            img1_muzzleWaffle.color = new Color32(255, 150, 150, 255);
        }
        if (Muzzle.muzzle_dtMount.activeSelf)
        {
            img1_muzzleWaffle.color = new Color32(255, 150, 150, 255);
        }
        if (Muzzle.muzzle_reactor.activeSelf)
        {
            img1_muzzleHyb46.color = new Color32(255, 150, 150, 255);
        }
        if (!Muzzle.muzzle_default1.activeSelf 
        && !Muzzle.muzzle_default2.activeSelf 
        && !Muzzle.muzzle_default3.activeSelf 
        && !Muzzle.muzzle_default4.activeSelf 
        && !Muzzle.muzzle_cqb74.activeSelf 
        && !Muzzle.muzzle_rrd.activeSelf 
        && !Muzzle.muzzle_srvv.activeSelf 
        && !Muzzle.muzzle_dtk.activeSelf 
        && !Muzzle.muzzle_pbs4.activeSelf 
        && !Muzzle.muzzle_hexagon.activeSelf 
        && !Muzzle.muzzle_tgpA.activeSelf 
        && !Muzzle.muzzle_dtMount.activeSelf 
        && !Muzzle.muzzle_reactor.activeSelf)
        {
            img1_muzzleHyb46.color = new Color32(255, 150, 150, 255);
            img1_muzzleWaffle.color = new Color32(255, 150, 150, 255);
        }
    }
}
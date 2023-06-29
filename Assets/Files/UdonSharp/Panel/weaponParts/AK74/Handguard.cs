
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Handguard : UdonSharpBehaviour
{
    public int language = 0;

    public Parts Parts;
    //public Panel Panel;
    public Settings Settings;
    public Detachments Detachments;

    public UdonBehaviour cover;
    public UdonBehaviour rearSight;
    public UdonBehaviour panel;

    //ハンドガードGameObject
    public GameObject hg_default; //Default Handguard
    public GameObject hg_wooden1; //AKM Wooden Handguard
    public GameObject hg_wooden2; //VPO-136 Wooden Handguard
    public GameObject hg_wooden3; //VPO-209 Wooden Handguard
    public GameObject hg_woodenGrip; //WASR-10/63 CAF Handguard
    public GameObject hg_polymer1; //AK-74 Polymer Handguard
    public GameObject hg_polymer2; //AK-74 Plum Polymer Handguard
    public GameObject hg_polymerBase; //!Polymer BASE!
    //public GameObject hg_polymerRail1; //AK-74 Polymer Handguard with Rails
    public GameObject hg_polymerRail; //AK 100 Series Polymer Handguard
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

    //他の変数
    public GameObject error;
    //public GameObject error2;
    public UnityEngine.UI.Text errorPartText;

    public void attachDefault()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_default.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_default = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachWooden1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_wooden1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_wooden1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachWooden2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_wooden2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_wooden2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachWooden3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_wooden3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_wooden3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachWoodenGrip()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_woodenGrip.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_woodenGrip = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachPolymer1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_polymer1.SetActive(true);
            hg_polymerBase.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_polymer1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachPolymer2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_polymer2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_polymer2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachPolymerRail()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_polymerRail.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_polymerRail = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulA1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulA1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulA1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulA2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulA2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulA2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulA3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulA3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulA3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulA4()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulA4.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulA4 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulA5()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulA5.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulA5 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulB1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulB1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulB1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulB2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulB2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulB2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMagpulB3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_magpulB3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_magpulB3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachQuadRail1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_quadRail1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_quadRail1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachQuadRail2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_quadRail2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_quadRail2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachQuadRail3()
    {
        if (!cover_b33.activeSelf)
        {
            if (!cover_bastion.activeSelf)
            {
                if (!cover_dogLeg.activeSelf)
                {
                    if (!cover_pdc.activeSelf)
                    {
                        if (!rs_tt01.activeSelf)
                        {
                            SendCustomEvent("disableAll");
                            hg_quadRail3.SetActive(true);
                            gb_default.SetActive(true);

                            Parts.reset1_hg();
                            Parts.parts1_hg_quadRail3 = true;
                            SendCustomEvent("check");
                        }
                        if (rs_tt01.activeSelf)
                        {
                            error.SetActive(true);
                            errorPartText.text = Parts.parts1_rs_tt01_text;
                            Detachments.detach1TT01 = true;
                        }
                    }
                    if (cover_pdc.activeSelf)
                    {
                        error.SetActive(true);
                        errorPartText.text = Parts.parts1_cover_pdc_text;
                        Detachments.detach1PDC = true;
                    }
                }
                if (cover_dogLeg.activeSelf)
                {
                    error.SetActive(true);
                    errorPartText.text = Parts.parts1_cover_dogLeg_text;
                    Detachments.detach1DogLeg = true;
                }
            }
            if (cover_bastion.activeSelf)
            {
                error.SetActive(true);
                errorPartText.text = Parts.parts1_cover_bastion_text;
                Detachments.detach1Bastion = true;
            }
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachHexagon1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_hexagon1.SetActive(true);
            hg_polymerBase.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_hexagon1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachHexagon2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_hexagon2.SetActive(true);
            hg_polymerBase.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_hexagon2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachKeymod1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_keymod1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_keymod1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachKeymod2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_keymod2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_keymod2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachKeymod3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_keymod3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_keymod3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;

            Detachments.detach1B33 = true;
        }
    }
    public void attachKeymod4()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_keymod4.SetActive(true);
            gb_vdm.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_keymod4 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMlok1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_mlok1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_mlok1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMlok2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_mlok2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_mlok2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachMlok3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_mlok3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_mlok3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachZenit1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_zenit1.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_zenit1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachZenit2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_zenit2.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_zenit2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachZenit3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_zenit3.SetActive(true);
            gb_default.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_zenit3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachGasBlock1()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_gasBlock1.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_gasBlock1 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachGasBlock2()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_gasBlock2.SetActive(true);
            hg_vsGasBlock.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_gasBlock2 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachGasBlock3()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_gasBlock3.SetActive(true);
            hg_vsGasBlock.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_gasBlock3 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }
    public void attachGasBlock4()
    {
        if (!cover_b33.activeSelf)
        {
            SendCustomEvent("disableAll");
            hg_gasBlock4.SetActive(true);
            hg_polymerBase.SetActive(true);

            Parts.reset1_hg();
            Parts.parts1_hg_gasBlock4 = true;
            SendCustomEvent("check");
        }
        if (cover_b33.activeSelf)
        {
            error.SetActive(true);
            errorPartText.text = Parts.parts1_cover_b33_text;
            Detachments.detach1B33 = true;
        }
    }


    public void disableAll()
    {
        hg_default.SetActive(false);
        hg_wooden1.SetActive(false);
        hg_wooden2.SetActive(false);
        hg_wooden3.SetActive(false);
        hg_woodenGrip.SetActive(false);
        hg_polymer1.SetActive(false);
        hg_polymer2.SetActive(false);
        hg_polymerBase.SetActive(false);
        hg_polymerRail.SetActive(false);
        hg_magpulA1.SetActive(false);
        hg_magpulA2.SetActive(false);
        hg_magpulA3.SetActive(false);
        hg_magpulA4.SetActive(false);
        hg_magpulA5.SetActive(false);
        hg_magpulB1.SetActive(false);
        hg_magpulB2.SetActive(false);
        hg_magpulB3.SetActive(false);
        hg_quadRail1.SetActive(false);
        hg_quadRail2.SetActive(false);
        hg_quadRail3.SetActive(false);
        hg_hexagon1.SetActive(false);
        hg_hexagon2.SetActive(false);
        hg_keymod1.SetActive(false);
        hg_keymod2.SetActive(false);
        hg_keymod3.SetActive(false);
        hg_keymod4.SetActive(false);
        hg_mlok1.SetActive(false);
        hg_mlok2.SetActive(false);
        hg_mlok3.SetActive(false);
        hg_tdiAttach.SetActive(false);
        hg_zenit1.SetActive(false);
        hg_zenit2.SetActive(false);
        hg_zenit3.SetActive(false);
        hg_gasBlock1.SetActive(false);
        hg_gasBlock2.SetActive(false);
        hg_gasBlock3.SetActive(false);
        hg_gasBlock4.SetActive(false);
        hg_vsGasBlock.SetActive(false);
        gb_default.SetActive(false);
        gb_vdm.SetActive(false);
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

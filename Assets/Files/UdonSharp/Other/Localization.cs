
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Localization : UdonSharpBehaviour
{

    public Parts Parts;
    public World World;
    public Panel Panel;

    //ハンドガード１
    public UnityEngine.UI.Text parts1_hg_default;
    public UnityEngine.UI.Text parts1_hg_wooden1;
    public UnityEngine.UI.Text parts1_hg_wooden2;
    public UnityEngine.UI.Text parts1_hg_wooden3;
    public UnityEngine.UI.Text parts1_hg_woodenGrip;
    public UnityEngine.UI.Text parts1_hg_polymer1;
    public UnityEngine.UI.Text parts1_hg_polymer2;
    public UnityEngine.UI.Text parts1_hg_polymerRail;
    public UnityEngine.UI.Text parts1_hg_magpulA1;
    public UnityEngine.UI.Text parts1_hg_magpulA2;
    public UnityEngine.UI.Text parts1_hg_magpulA3;
    public UnityEngine.UI.Text parts1_hg_magpulA4;
    public UnityEngine.UI.Text parts1_hg_magpulA5;
    public UnityEngine.UI.Text parts1_hg_magpulB1;
    public UnityEngine.UI.Text parts1_hg_magpulB2;
    public UnityEngine.UI.Text parts1_hg_magpulB3;
    public UnityEngine.UI.Text parts1_hg_quadRail1;
    public UnityEngine.UI.Text parts1_hg_quadRail2;
    public UnityEngine.UI.Text parts1_hg_quadRail3;
    public UnityEngine.UI.Text parts1_hg_hexagon1;
    public UnityEngine.UI.Text parts1_hg_hexagon2;
    public UnityEngine.UI.Text parts1_hg_keymod1;
    public UnityEngine.UI.Text parts1_hg_keymod2;
    public UnityEngine.UI.Text parts1_hg_keymod3;
    public UnityEngine.UI.Text parts1_hg_keymod4;
    public UnityEngine.UI.Text parts1_hg_mlok1;
    public UnityEngine.UI.Text parts1_hg_mlok2;
    public UnityEngine.UI.Text parts1_hg_mlok3;
    public UnityEngine.UI.Text parts1_hg_zenit1;
    public UnityEngine.UI.Text parts1_hg_zenit2;
    public UnityEngine.UI.Text parts1_hg_zenit3;
    public UnityEngine.UI.Text parts1_hg_gasBlock1;
    public UnityEngine.UI.Text parts1_hg_gasBlock2;
    public UnityEngine.UI.Text parts1_hg_gasBlock3;
    public UnityEngine.UI.Text parts1_hg_gasBlock4;

    //トップカバー１
    public UnityEngine.UI.Text parts1_cover_b33;
    public UnityEngine.UI.Text parts1_cover_bastion;
    public UnityEngine.UI.Text parts1_cover_default;
    public UnityEngine.UI.Text parts1_cover_dogLeg;
    public UnityEngine.UI.Text parts1_cover_pdc;

    //リアサイト１
    public UnityEngine.UI.Text parts1_rs_default;
    public UnityEngine.UI.Text parts1_rs_tt01;

    public void localization()
    {
        parts1_hg_default.text = Parts.parts1_hg_default_text;
        parts1_hg_wooden1.text = Parts.parts1_hg_wooden1_text;
        parts1_hg_wooden2.text = Parts.parts1_hg_wooden2_text;
        parts1_hg_wooden3.text = Parts.parts1_hg_wooden3_text;
        parts1_hg_woodenGrip.text = Parts.parts1_hg_woodenGrip_text;
        parts1_hg_polymer1.text = Parts.parts1_hg_polymer1_text;
        parts1_hg_polymer2.text = Parts.parts1_hg_polymer2_text;
        parts1_hg_polymerRail.text = Parts.parts1_hg_polymerRail_text;
        parts1_hg_magpulA1.text = Parts.parts1_hg_magpulA1_text;
        parts1_hg_magpulA2.text = Parts.parts1_hg_magpulA2_text;
        parts1_hg_magpulA3.text = Parts.parts1_hg_magpulA3_text;
        parts1_hg_magpulA4.text = Parts.parts1_hg_magpulA4_text;
        parts1_hg_magpulA5.text = Parts.parts1_hg_magpulA5_text;
        parts1_hg_magpulB1.text = Parts.parts1_hg_magpulB1_text;
        parts1_hg_magpulB2.text = Parts.parts1_hg_magpulB2_text;
        parts1_hg_magpulB3.text = Parts.parts1_hg_magpulB3_text;
        parts1_hg_quadRail1.text = Parts.parts1_hg_quadRail1_text;
        parts1_hg_quadRail2.text = Parts.parts1_hg_quadRail2_text;
        parts1_hg_quadRail3.text = Parts.parts1_hg_quadRail3_text;
        parts1_hg_hexagon1.text = Parts.parts1_hg_hexagon1_text;
        parts1_hg_hexagon2.text = Parts.parts1_hg_hexagon2_text;
        parts1_hg_keymod1.text = Parts.parts1_hg_keymod1_text;
        parts1_hg_keymod2.text = Parts.parts1_hg_keymod2_text;
        parts1_hg_keymod3.text = Parts.parts1_hg_keymod3_text;
        parts1_hg_keymod4.text = Parts.parts1_hg_keymod4_text;
        parts1_hg_mlok1.text = Parts.parts1_hg_mlok1_text;
        parts1_hg_mlok2.text = Parts.parts1_hg_mlok2_text;
        parts1_hg_mlok3.text = Parts.parts1_hg_mlok3_text;
        parts1_hg_zenit1.text = Parts.parts1_hg_zenit1_text;
        parts1_hg_zenit2.text = Parts.parts1_hg_zenit2_text;
        parts1_hg_zenit3.text = Parts.parts1_hg_zenit3_text;
        parts1_hg_gasBlock1.text = Parts.parts1_hg_gasBlock1_text;
        parts1_hg_gasBlock2.text = Parts.parts1_hg_gasBlock2_text;
        parts1_hg_gasBlock3.text = Parts.parts1_hg_gasBlock3_text;
        parts1_hg_gasBlock4.text = Parts.parts1_hg_gasBlock4_text;

        parts1_cover_b33.text = Parts.parts1_cover_b33_text;
        parts1_cover_bastion.text = Parts.parts1_cover_bastion_text;
        parts1_cover_default.text = Parts.parts1_cover_default_text;
        parts1_cover_dogLeg.text = Parts.parts1_cover_dogLeg_text;
        parts1_cover_pdc.text = Parts.parts1_cover_pdc_text;

        parts1_rs_default.text = Parts.parts1_rs_default_text;
        parts1_rs_tt01.text = Parts.parts1_rs_tt01_text;
    }
}

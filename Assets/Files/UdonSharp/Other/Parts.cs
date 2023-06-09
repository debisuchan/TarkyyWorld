//This is weapon parts handler
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Parts : UdonSharpBehaviour
{
    public Localization Localization;

    public int language = 0;

    //変数
    //AK74のハンドガード
    [UdonSynced] public bool parts1_hg_default = true;
    [UdonSynced] public bool parts1_hg_wooden1;
    [UdonSynced] public bool parts1_hg_wooden2;
    [UdonSynced] public bool parts1_hg_wooden3;
    [UdonSynced] public bool parts1_hg_woodenGrip;
    [UdonSynced] public bool parts1_hg_polymer1;
    [UdonSynced] public bool parts1_hg_polymer2;
    [UdonSynced] public bool parts1_hg_polymerRail;
    [UdonSynced] public bool parts1_hg_magpulA1;
    [UdonSynced] public bool parts1_hg_magpulA2;
    [UdonSynced] public bool parts1_hg_magpulA3;
    [UdonSynced] public bool parts1_hg_magpulA4;
    [UdonSynced] public bool parts1_hg_magpulA5;
    [UdonSynced] public bool parts1_hg_magpulB1;
    [UdonSynced] public bool parts1_hg_magpulB2;
    [UdonSynced] public bool parts1_hg_magpulB3;
    [UdonSynced] public bool parts1_hg_quadRail1;
    [UdonSynced] public bool parts1_hg_quadRail2;
    [UdonSynced] public bool parts1_hg_quadRail3;
    [UdonSynced] public bool parts1_hg_hexagon1;
    [UdonSynced] public bool parts1_hg_hexagon2;
    [UdonSynced] public bool parts1_hg_keymod1;
    [UdonSynced] public bool parts1_hg_keymod2;
    [UdonSynced] public bool parts1_hg_keymod3;
    [UdonSynced] public bool parts1_hg_keymod4;
    [UdonSynced] public bool parts1_hg_mlok1;
    [UdonSynced] public bool parts1_hg_mlok2;
    [UdonSynced] public bool parts1_hg_mlok3;
    [UdonSynced] public bool parts1_hg_zenit1;
    [UdonSynced] public bool parts1_hg_zenit2;
    [UdonSynced] public bool parts1_hg_zenit3;
    [UdonSynced] public bool parts1_hg_gasBlock1;
    [UdonSynced] public bool parts1_hg_gasBlock2;
    [UdonSynced] public bool parts1_hg_gasBlock3;
    [UdonSynced] public bool parts1_hg_gasBlock4;
    public string parts1_hg_default_text;
    public string parts1_hg_wooden1_text;
    public string parts1_hg_wooden2_text;
    public string parts1_hg_wooden3_text;
    public string parts1_hg_woodenGrip_text;
    public string parts1_hg_polymer1_text;
    public string parts1_hg_polymer2_text;
    public string parts1_hg_polymerRail_text;
    public string parts1_hg_magpulA1_text;
    public string parts1_hg_magpulA2_text;
    public string parts1_hg_magpulA3_text;
    public string parts1_hg_magpulA4_text;
    public string parts1_hg_magpulA5_text;
    public string parts1_hg_magpulB1_text;
    public string parts1_hg_magpulB2_text;
    public string parts1_hg_magpulB3_text;
    public string parts1_hg_quadRail1_text;
    public string parts1_hg_quadRail2_text;
    public string parts1_hg_quadRail3_text;
    public string parts1_hg_hexagon1_text;
    public string parts1_hg_hexagon2_text;
    public string parts1_hg_keymod1_text;
    public string parts1_hg_keymod2_text;
    public string parts1_hg_keymod3_text;
    public string parts1_hg_keymod4_text;
    public string parts1_hg_mlok1_text;
    public string parts1_hg_mlok2_text;
    public string parts1_hg_mlok3_text;
    public string parts1_hg_zenit1_text;
    public string parts1_hg_zenit2_text;
    public string parts1_hg_zenit3_text;
    public string parts1_hg_gasBlock1_text;
    public string parts1_hg_gasBlock2_text;
    public string parts1_hg_gasBlock3_text;
    public string parts1_hg_gasBlock4_text;

    //AK74のトップカバー
    [UdonSynced] public bool parts1_cover_b33;
    [UdonSynced] public bool parts1_cover_bastion;
    [UdonSynced] public bool parts1_cover_default = true;
    [UdonSynced] public bool parts1_cover_dogLeg;
    [UdonSynced] public bool parts1_cover_pdc;
    public string parts1_cover_b33_text;
    public string parts1_cover_bastion_text;
    public string parts1_cover_default_text;
    public string parts1_cover_dogLeg_text;
    public string parts1_cover_pdc_text;

    //AK74のリアサイト
    [UdonSynced] public bool parts1_rs_default = true;
    [UdonSynced] public bool parts1_rs_tt01;
    public string parts1_rs_default_text;
    public string parts1_rs_tt01_text;

    //AK74のマズル
    [UdonSynced] public bool parts1_muzzle_default1 = true;
    [UdonSynced] public bool parts1_muzzle_cqb74;
    [UdonSynced] public bool parts1_muzzle_rrd;
    [UdonSynced] public bool parts1_muzzle_srvv;
    [UdonSynced] public bool parts1_muzzle_dtk;
    [UdonSynced] public bool parts1_muzzle_default2;
    [UdonSynced] public bool parts1_muzzle_default3;
    [UdonSynced] public bool parts1_muzzle_default4;
    [UdonSynced] public bool parts1_muzzle_reactor;
    [UdonSynced] public bool parts1_muzzle_dtMount;
    [UdonSynced] public bool parts1_muzzle_pbs4;
    [UdonSynced] public bool parts1_muzzle_hexagon;
    [UdonSynced] public bool parts1_muzzle_tgpA;
    [UdonSynced] public bool parts1_muzzle_waffle;
    [UdonSynced] public bool parts1_muzzle_hybrid46;
    public string parts1_muzzle_default1_text;
    public string parts1_muzzle_default2_text;
    public string parts1_muzzle_default3_text;
    public string parts1_muzzle_default4_text;
    public string parts1_muzzle_cqb74_text;
    public string parts1_muzzle_rrd_text;
    public string parts1_muzzle_srvv_text;
    public string parts1_muzzle_dtk_text;
    public string parts1_muzzle_reactor_text;
    public string parts1_muzzle_dtMount_text;
    public string parts1_muzzle_pbs4_text;
    public string parts1_muzzle_hexagon_text;
    public string parts1_muzzle_tgpA_text;
    public string parts1_muzzle_waffle_text;
    public string parts1_muzzle_hybrid46_text;

    //オブジェクト
    //AK74のハンドガード
    public GameObject w1hg_default;
    public GameObject w1hg_wooden1;
    public GameObject w1hg_wooden2;
    public GameObject w1hg_wooden3;
    public GameObject w1hg_woodenGrip;
    public GameObject w1hg_polymer1;
    public GameObject w1hg_polymer2;
    public GameObject w1hg_polymerRail;
    public GameObject w1hg_magpulA1;
    public GameObject w1hg_magpulA2;
    public GameObject w1hg_magpulA3;
    public GameObject w1hg_magpulA4;
    public GameObject w1hg_magpulA5;
    public GameObject w1hg_magpulB1;
    public GameObject w1hg_magpulB2;
    public GameObject w1hg_magpulB3;
    public GameObject w1hg_quadRail1;
    public GameObject w1hg_quadRail2;
    public GameObject w1hg_quadRail3;
    public GameObject w1hg_hexagon1;
    public GameObject w1hg_hexagon2;
    public GameObject w1hg_keymod1;
    public GameObject w1hg_keymod2;
    public GameObject w1hg_keymod3;
    public GameObject w1hg_keymod4;
    public GameObject w1hg_mlok1;
    public GameObject w1hg_mlok2;
    public GameObject w1hg_mlok3;
    public GameObject w1hg_zenit1;
    public GameObject w1hg_zenit2;
    public GameObject w1hg_zenit3;
    public GameObject w1hg_gasBlock1;
    public GameObject w1hg_gasBlock2;
    public GameObject w1hg_gasBlock3;
    public GameObject w1hg_gasBlock4;
    public GameObject w1gb_default;
    public GameObject w1gb_custom;
    public GameObject w1hg_polymerBase;
    public GameObject w1hg_akmlBase;
    public GameObject w1gb_vs;

    //トップカバー
    public GameObject w1cover_b33;
    public GameObject w1cover_bastion;
    public GameObject w1cover_default;
    public GameObject w1cover_dogLeg;
    public GameObject w1cover_pdc;

    //リアサイト
    public GameObject w1rs_default;
    public GameObject w1rs_tt01;

    //マズル
    public GameObject w1muzzle_default1;
    public GameObject w1muzzle_default2;
    public GameObject w1muzzle_default3;
    public GameObject w1muzzle_default4;
    public GameObject w1muzzle_cqb74;
    public GameObject w1muzzle_rrd;
    public GameObject w1muzzle_srvv;
    public GameObject w1muzzle_dtk;
    public GameObject w1muzzle_reactor;
    public GameObject w1muzzle_dtMount;
    public GameObject w1muzzle_pbs4;
    public GameObject w1muzzle_hexagon;
    public GameObject w1muzzle_tgpA;
    public GameObject w1muzzle_waffle;
    public GameObject w1muzzle_hybrid46;

    public void checkLang()
    {
        if (language == 0)
        {
            langJP();
        }
        if (language == 1)
        {
            langEN();
        }
        if (language == 2)
        {
            langKR();
        }
    }

    public void langJP()
    {
        parts1_hg_default_text = "基本木材ハンドガード";
        parts1_hg_wooden1_text = "木材ハンドガード１";
        parts1_hg_wooden2_text = "木材ハンドガード２";
        parts1_hg_wooden3_text = "木材ハンドガード３";
        parts1_hg_woodenGrip_text = "木材グリップハンドガード";
        parts1_hg_polymer1_text = "ポリマーハンドガード１";
        parts1_hg_polymer2_text = "ポリマーハンドガード２";
        parts1_hg_polymerRail_text = "レイル付きポリマーハンドガード";
        parts1_hg_magpulA1_text = "AK用Magpul MOE 黒色";
        parts1_hg_magpulA2_text = "AK用Magpul MOE FDE";
        parts1_hg_magpulA3_text = "AK用Magpul MOE Oliver";
        parts1_hg_magpulA4_text = "AK用Magpul MOE Plum";
        parts1_hg_magpulA5_text = "AK用Magpul MOE 灰色";
        parts1_hg_magpulB1_text = "Magpul Zhukov-U 黒色";
        parts1_hg_magpulB2_text = "Magpul Zhukov-U FDE";
        parts1_hg_magpulB3_text = "Magpul Zhukov-U Plum";
        parts1_hg_quadRail1_text = "レイル付きAggressorハンドガード";
        parts1_hg_quadRail2_text = "レイル付きRS47ハンドガード";
        parts1_hg_quadRail3_text = "レイル付きX47ハンドガード";
        parts1_hg_hexagon1_text = "Hexagonハンドガード黒色";
        parts1_hg_hexagon2_text = "Hexagonハンドガード赤色";
        parts1_hg_keymod1_text = "TRAX 1ハンドガード";
        parts1_hg_keymod2_text = "CMRDハンドガード";
        parts1_hg_keymod3_text = "OV GPハンドガード";
        parts1_hg_keymod4_text = "UFMハンドガード";
        parts1_hg_mlok1_text = "AKM-Lハンドガード黒色";
        parts1_hg_mlok2_text = "AKM-Lハンドガード赤色";
        parts1_hg_mlok3_text = "AKM-Lハンドガードブロンズ色";
        parts1_hg_zenit1_text = "レイル付きB-10ハンドガード";
        parts1_hg_zenit2_text = "レイル付きB-10Mハンドガード";
        parts1_hg_zenit3_text = "レイル付きB-30ハンドガード";
        parts1_hg_gasBlock1_text = "Troyガスブロックハンドガード";
        parts1_hg_gasBlock2_text = "VSガスブロックハンドガード";
        parts1_hg_gasBlock3_text = "VSガスブロックハンドガード白色";
        parts1_hg_gasBlock4_text = "レイル付きガスブロックハンドガード";

        parts1_cover_b33_text = "Zenit B-33 トップカバー";
        parts1_cover_bastion_text = "Bastion トップカバー";
        parts1_cover_default_text = "基本トップカバー";
        parts1_cover_dogLeg_text = "Dog Leg トップカバー";
        parts1_cover_pdc_text = "FAB PDC トップカバー";

        parts1_rs_default_text = "AK基本リアサイト";
        parts1_rs_tt01_text = "AK用レイル付きリアサイト";

        parts1_muzzle_default1_text = "AK-74基本マズル";
        parts1_muzzle_default2_text = "AK-74M基本マズル";
        parts1_muzzle_default3_text = "AKS-74U基本マズル";
        parts1_muzzle_default4_text = "AK-105基本マズル";
        parts1_muzzle_cqb74_text = "PWS CQB 74 マズルブレーキ";
        parts1_muzzle_rrd_text = "JMac RRD-4C マルチキャリバーマズルブレーキ";
        parts1_muzzle_srvv_text = "SRVV マズルブレーキ";
        parts1_muzzle_dtk_text = "Zenit DTK-1 マズルブレーキ";
        parts1_muzzle_reactor_text = "Hexagon Reactor マズルブレーキ";
        parts1_muzzle_dtMount_text = "SilencerCo マルチキャリバーアダプター";
        parts1_muzzle_pbs4_text = "AKS-74Uサプレッサー";
        parts1_muzzle_hexagon_text = "Hexagonサプレッサー";
        parts1_muzzle_tgpA_text = "TGP-Aサプレッサー";
        parts1_muzzle_waffle_text = "Hexagon Wafflemaker サプレッサー";
        parts1_muzzle_hybrid46_text = "SilencerCo マルチキャリバーサプレッサー";

        Localization.SendCustomEventDelayedSeconds("localization", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void langEN()
    {
        parts1_hg_default_text = "AK-74 Wooden Handguard";
        parts1_hg_wooden1_text = "AKM Wooden Handguard";
        parts1_hg_wooden2_text = "VPO-136 Wooden Handguard";
        parts1_hg_wooden3_text = "VPO-209 Wooden Handguard";
        parts1_hg_woodenGrip_text = "WASR-10/63 CAF Handguard";
        parts1_hg_polymer1_text = "AK-74 Polymer Handguard";
        parts1_hg_polymer2_text = "AK-74 Plum Polymer Handguard";
        parts1_hg_polymerRail_text = "AK 100 Series Polymer Handguard";
        parts1_hg_magpulA1_text = "Magpul MOE AKM Handguard Black";
        parts1_hg_magpulA2_text = "Magpul MOE AKM Handguard FDE";
        parts1_hg_magpulA3_text = "Magpul MOE AKM Handguard OD";
        parts1_hg_magpulA4_text = "Magpul MOE AKM Handguard Plum";
        parts1_hg_magpulA5_text = "Magpul MOE AKM Handguard SG";
        parts1_hg_magpulB1_text = "Magpul Zhukov-U Black Handguard";
        parts1_hg_magpulB2_text = "Magpul Zhukov-U FDE Handguard";
        parts1_hg_magpulB3_text = "Magpul Zhukov-U Plum Handguard";
        parts1_hg_quadRail1_text = "5.45 Design Aggressor Handguard";
        parts1_hg_quadRail2_text = "CAA RS47 Handguard";
        parts1_hg_quadRail3_text = "TDI X47 Tactical Handguard";
        parts1_hg_hexagon1_text = "Hexagon Tubular Black Handguard";
        parts1_hg_hexagon2_text = "Hexagon Tubular Red Handguard";
        parts1_hg_keymod1_text = "Strike Industries TRAX 1 Handguard";
        parts1_hg_keymod2_text = "Vltor CMRD Handguard";
        parts1_hg_keymod3_text = "CNC Guns OV GP Handguard";
        parts1_hg_keymod4_text = "Krebs Custom UFM KeyMod Handguard";
        parts1_hg_mlok1_text = "TDI AKM-L Black Handguard";
        parts1_hg_mlok2_text = "TDI AKM-L Red Handguard";
        parts1_hg_mlok3_text = "TDI AKM-L Bronze Handguard";
        parts1_hg_zenit1_text = "Zenit B-10 Handguard";
        parts1_hg_zenit2_text = "Zenit B-10M Handguard";
        parts1_hg_zenit3_text = "Zenit B-30 Handguard";
        parts1_hg_gasBlock1_text = "Troy Full Lenght Rail Handguard";
        parts1_hg_gasBlock2_text = "Vezhlivyy Strelok Handguard";
        parts1_hg_gasBlock3_text = "Vezhlivyy Strelok White Handguard";
        parts1_hg_gasBlock4_text = "UltiMAK M1-B Handguard";

        parts1_cover_b33_text = "Zenit B-33";
        parts1_cover_bastion_text = "AKademia Bastion";
        parts1_cover_default_text = "AK Default Dust Cover";
        parts1_cover_dogLeg_text = "TWS Dog Leg Rail";
        parts1_cover_pdc_text = "FAB Defense PDC";

        parts1_rs_default_text = "AK-74 Default Rear Sight";
        parts1_rs_tt01_text = "Taktika Tula TT01 Rear Sight Rail";

        parts1_muzzle_default1_text = "AK-74 Default Muzzle";
        parts1_muzzle_default2_text = "AK-74M Default Muzzle";
        parts1_muzzle_default3_text = "AKS-74U Default Muzzle";
        parts1_muzzle_default4_text = "AK-105 Default Muzzle";
        parts1_muzzle_cqb74_text = "PWS CQB 74 Muzzle Brake";
        parts1_muzzle_rrd_text = "JMac RRD-4C Multi-Caliber Muzzle Brake";
        parts1_muzzle_srvv_text = "SRVV Muzzle Brake";
        parts1_muzzle_dtk_text = "Zenit DTK-1 Muzzle Brake";
        parts1_muzzle_reactor_text = "Hexagon Reactor Muzzle Brake";
        parts1_muzzle_dtMount_text = "SilencerCo DT Mount";
        parts1_muzzle_pbs4_text = "AKS-74U PBS-4 Suppressor";
        parts1_muzzle_hexagon_text = "AK-74 Hexagon Suppressor";
        parts1_muzzle_tgpA_text = "TGP-A Suppressor";
        parts1_muzzle_waffle_text = "Hexagon Wafflemaker Suppressor";
        parts1_muzzle_hybrid46_text = "SilencerCo DT Multi-Caliber Suppressor";

        Localization.SendCustomEventDelayedSeconds("localization", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void langKR()
    {
        parts1_hg_default_text = "기본 목재 핸드가드";
        parts1_hg_wooden1_text = "목재 핸드가드 1";
        parts1_hg_wooden2_text = "목재 핸드가드 2";
        parts1_hg_wooden3_text = "목재 핸드가드 3";
        parts1_hg_woodenGrip_text = "목재 그립형 핸드가드";
        parts1_hg_polymer1_text = "폴리머 핸드가드";
        parts1_hg_polymer2_text = "폴리머 핸드가드 Plum";
        parts1_hg_polymerRail_text = "AK 100 폴리머 핸드가드";
        parts1_hg_magpulA1_text = "Magpul MOE AKM 핸드가드 Black";
        parts1_hg_magpulA2_text = "Magpul MOE AKM 핸드가드 FDE";
        parts1_hg_magpulA3_text = "Magpul MOE AKM 핸드가드 OD";
        parts1_hg_magpulA4_text = "Magpul MOE AKM 핸드가드 Plum";
        parts1_hg_magpulA5_text = "Magpul MOE AKM 핸드가드 SG";
        parts1_hg_magpulB1_text = "Magpul Zhukov-U 핸드가드 Black";
        parts1_hg_magpulB2_text = "Magpul Zhukov-U 핸드가드 FDE";
        parts1_hg_magpulB3_text = "Magpul Zhukov-U 핸드가드 Plum";
        parts1_hg_quadRail1_text = "Aggressor 핸드가드";
        parts1_hg_quadRail2_text = "RS47 핸드가드";
        parts1_hg_quadRail3_text = "X47 핸드가드";
        parts1_hg_hexagon1_text = "Hexagon 핸드가드 Black";
        parts1_hg_hexagon2_text = "Hexagon 핸드가드 Red";
        parts1_hg_keymod1_text = "TRAX 1 핸드가드";
        parts1_hg_keymod2_text = "Vltor CMRD 핸드가드";
        parts1_hg_keymod3_text = "OV GP 핸드가드";
        parts1_hg_keymod4_text = "UFM 핸드가드";
        parts1_hg_mlok1_text = "AKM-L 핸드가드 Black";
        parts1_hg_mlok2_text = "AKM-L 핸드가드 Red";
        parts1_hg_mlok3_text = "AKM-L 핸드가드 Bronze";
        parts1_hg_zenit1_text = "Zenit B-10 핸드가드";
        parts1_hg_zenit2_text = "Zenit B-10M 핸드가드";
        parts1_hg_zenit3_text = "Zenit B-30 핸드가드";
        parts1_hg_gasBlock1_text = "Troy 핸드가드";
        parts1_hg_gasBlock2_text = "VS 핸드가드";
        parts1_hg_gasBlock3_text = "VS 핸드가드 White";
        parts1_hg_gasBlock4_text = "M1-B 핸드가드";

        parts1_cover_b33_text = "Zenit B-33 탑커버";
        parts1_cover_bastion_text = "Bastion 탑커버";
        parts1_cover_default_text = "기본 탑커버";
        parts1_cover_dogLeg_text = "Dog Leg 탑커버";
        parts1_cover_pdc_text = "FAB PDC 탑커버";

        parts1_rs_default_text = "AK-74 기본 가늠자";
        parts1_rs_tt01_text = "TT01 레일형 가늠자";

        parts1_muzzle_default1_text = "AK-74 기본 머즐";
        parts1_muzzle_default2_text = "AK-74M 기본 머즐";
        parts1_muzzle_default3_text = "AKS-74U 기본 머즐";
        parts1_muzzle_default4_text = "AK-105 기본 머즐";
        parts1_muzzle_cqb74_text = "PWS CQB 74 머즐 브레이크";
        parts1_muzzle_rrd_text = "JMac RRD-4C 다중 구경 머즐 브레이크";
        parts1_muzzle_srvv_text = "SRVV 머즐 브레이크";
        parts1_muzzle_dtk_text = "Zenit DTK-1 머즐 브레이크";
        parts1_muzzle_reactor_text = "Hexagon Reactor 머즐 브레이크";
        parts1_muzzle_dtMount_text = "SilencerCo 다중 구경 어댑터";
        parts1_muzzle_pbs4_text = "AKS-74U PBS-4 소음기";
        parts1_muzzle_hexagon_text = "Hexagon 소음기";
        parts1_muzzle_tgpA_text = "TGP-A 소음기";
        parts1_muzzle_waffle_text = "Hexagon Wafflemaker 소음기";
        parts1_muzzle_hybrid46_text = "SilencerCo 다중 구경 소음기";

        Localization.SendCustomEventDelayedSeconds("localization", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void reset1_hg()
    {
        parts1_hg_default = false;
        parts1_hg_wooden1 = false;
        parts1_hg_wooden2 = false;
        parts1_hg_wooden3 = false;
        parts1_hg_woodenGrip = false;
        parts1_hg_polymer1 = false;
        parts1_hg_polymer2 = false;
        parts1_hg_polymerRail = false;
        parts1_hg_magpulA1 = false;
        parts1_hg_magpulA2 = false;
        parts1_hg_magpulA3 = false;
        parts1_hg_magpulA4 = false;
        parts1_hg_magpulA5 = false;
        parts1_hg_magpulB1 = false;
        parts1_hg_magpulB2 = false;
        parts1_hg_magpulB3 = false;
        parts1_hg_quadRail1 = false;
        parts1_hg_quadRail2 = false;
        parts1_hg_quadRail3 = false;
        parts1_hg_hexagon1 = false;
        parts1_hg_hexagon2 = false;
        parts1_hg_keymod1 = false;
        parts1_hg_keymod2 = false;
        parts1_hg_keymod3 = false;
        parts1_hg_keymod4 = false;
        parts1_hg_mlok1 = false;
        parts1_hg_mlok2 = false;
        parts1_hg_mlok3 = false;
        parts1_hg_zenit1 = false;
        parts1_hg_zenit2 = false;
        parts1_hg_zenit3 = false;
        parts1_hg_gasBlock1 = false;
        parts1_hg_gasBlock2 = false;
        parts1_hg_gasBlock3 = false;
        parts1_hg_gasBlock4 = false;
        Debug.Log("Weapon 1 Handguards Reset");
    }
    public void reset1_rs()
    {
        parts1_rs_default = false;
        parts1_rs_tt01 = false;
        Debug.Log("Weapon 1 Rear Sight Reset");
    }
    public void reset1_cover()
    {
        parts1_cover_b33 = false;
        parts1_cover_default = false;
        parts1_cover_pdc = false;
        parts1_cover_bastion = false;
        parts1_cover_dogLeg = false;
        Debug.Log("Weapon 1 Cover Reset");
    }
    public void reset1_muzzle()
    {
        parts1_muzzle_default1 = false;
        parts1_muzzle_default2 = false;
        parts1_muzzle_default3 = false;
        parts1_muzzle_default4 = false;
        parts1_muzzle_cqb74 = false;
        parts1_muzzle_rrd = false;
        parts1_muzzle_srvv = false;
        parts1_muzzle_dtk = false;
        parts1_muzzle_reactor = false;
        parts1_muzzle_dtMount = false;
        parts1_muzzle_pbs4 = false;
        parts1_muzzle_hexagon = false;
        parts1_muzzle_tgpA = false;
        parts1_muzzle_waffle = false;
        parts1_muzzle_hybrid46 = false;
        Debug.Log("Weapon 1 Muzzle Reset");
    }



    public void checkParts()
    {
        SendCustomEvent("reset1_rs");
        SendCustomEvent("reset1_hg");
        SendCustomEvent("reset1_cover");
        SendCustomEvent("reset1_muzzle");
        SendCustomEvent("check1Handguards");
        SendCustomEvent("check1RearSights");
        SendCustomEvent("check1Covers");
        SendCustomEvent("check1Muzzles");
    }
    public void check1Handguards()
    {
        if (parts1_hg_default)
        {
            w1hg_default.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_wooden1)
        {
            w1hg_wooden1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_wooden2)
        {
            w1hg_wooden2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_wooden3)
        {
            w1hg_wooden3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_woodenGrip)
        {
            w1hg_woodenGrip.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_polymer1)
        {
            w1hg_polymer1.SetActive(true);
            w1hg_polymerBase.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_polymer2)
        {
            w1hg_polymer2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_polymerRail)
        {
            w1hg_polymerRail.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulA1)
        {
            w1hg_magpulA1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulA2)
        {
            w1hg_magpulA2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulA3)
        {
            w1hg_magpulA3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulA4)
        {
            w1hg_magpulA4.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulA5)
        {
            w1hg_magpulA5.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulB1)
        {
            w1hg_magpulB1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulB2)
        {
            w1hg_magpulB2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_magpulB3)
        {
            w1hg_magpulB3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_quadRail1)
        {
            w1hg_quadRail1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_quadRail2)
        {
            w1hg_quadRail2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_quadRail3)
        {
            w1hg_quadRail3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_hexagon1)
        {
            w1hg_hexagon1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_hexagon2)
        {
            w1hg_hexagon2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_keymod1)
        {
            w1hg_keymod1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if( parts1_hg_keymod2)
        {
            w1hg_keymod2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_keymod3)
        {
            w1hg_keymod3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_keymod4)
        {
            w1hg_keymod4.SetActive(true);
            w1gb_custom.SetActive(true);
        }
        if (parts1_hg_mlok1)
        {
            w1hg_mlok1.SetActive(true);
            w1hg_akmlBase.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_mlok2)
        {
            w1hg_mlok2.SetActive(true);
            w1hg_akmlBase.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_mlok3)
        {
            w1hg_mlok3.SetActive(true);
            w1hg_akmlBase.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_zenit1)
        {
            w1hg_zenit1.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_zenit2)
        {
            w1hg_zenit2.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_zenit3)
        {
            w1hg_zenit3.SetActive(true);
            w1gb_default.SetActive(true);
        }
        if (parts1_hg_gasBlock1)
        {
            w1hg_gasBlock1.SetActive(true);
        }
        if (parts1_hg_gasBlock2)
        {
            w1hg_gasBlock2.SetActive(true);
            w1gb_vs.SetActive(true);
        }
        if (parts1_hg_gasBlock3)
        {
            w1hg_gasBlock4.SetActive(true);
        }
    }
    public void check1Covers()
    {
        if (parts1_cover_default)
        {
            w1cover_default.SetActive(true);
        }
        if (parts1_cover_b33)
        {
            w1cover_b33.SetActive(true);
        }
        if (parts1_cover_bastion)
        {
            w1cover_bastion.SetActive(true);
        }
        if (parts1_cover_dogLeg)
        {
            w1cover_dogLeg.SetActive(true);
        }
        if (parts1_cover_pdc)
        {
            w1cover_pdc.SetActive(true);
        }
    }
    public void check1RearSights()
    {
        if (parts1_rs_default)
        {
            w1rs_default.SetActive(true);
            w1rs_tt01.SetActive(false);
        }
        if (parts1_rs_default)
        {
            w1rs_tt01.SetActive(true);
            w1rs_default.SetActive(false);
        }
    }
    public void check1Muzzles()
    {
        if (parts1_muzzle_default1)
        {
            w1muzzle_default1.SetActive(true);
        }
        if (parts1_muzzle_default2)
        {
            w1muzzle_default2.SetActive(true);
        }
        if (parts1_muzzle_default3)
        {
            w1muzzle_default3.SetActive(true);
        }
        if (parts1_muzzle_default4)
        {
            w1muzzle_default4.SetActive(true);
        }
        if (parts1_muzzle_cqb74)
        {
            w1muzzle_cqb74.SetActive(true);
        }
        if (parts1_muzzle_rrd)
        {
            w1muzzle_rrd.SetActive(true);
        }
        if (parts1_muzzle_srvv)
        {
            w1muzzle_srvv.SetActive(true);
        }
        if (parts1_muzzle_dtk)
        {
            w1muzzle_dtk.SetActive(true);
        }
        if (parts1_muzzle_reactor)
        {
            w1muzzle_reactor.SetActive(true);
        }
        if (parts1_muzzle_dtMount)
        {
            w1muzzle_dtMount.SetActive(true);
        }
        if (parts1_muzzle_pbs4)
        {
            w1muzzle_pbs4.SetActive(true);
        }
        if (parts1_muzzle_hexagon)
        {
            w1muzzle_hexagon.SetActive(true);
        }
        if (parts1_muzzle_tgpA)
        {
            w1muzzle_tgpA.SetActive(true);
        }
        if (parts1_muzzle_waffle)
        {
            w1muzzle_waffle.SetActive(true);
        }
        if (parts1_muzzle_hybrid46)
        {
            w1muzzle_hybrid46.SetActive(true);
        }
    }
}

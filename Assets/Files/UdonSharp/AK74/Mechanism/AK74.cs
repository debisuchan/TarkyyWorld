using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class AK74 : UdonSharpBehaviour
{

    public Settings Settings;
    public Parts Parts;

    public int language = 0;
    public string cantWork = "";
    public string noOneHold = "";
    public string checkSafety = "";
    public string ammoIsLow = "";
    public string stopWorkingLowAmmo = "";
    public string notLoaded = "";

    private VRCPlayerApi api;
    public VRC.SDK3.Components.VRCPickup weapon;
    public bool canFire = false;
    public int AMMO = 0;
    public GameObject SF_SEMI;
    public GameObject SF_AUTO;
    public GameObject SF_SAFE;
    public GameObject AK_CHARGED;
    public GameObject AK_NOTCHARGED;
    public Animator ANIMATOR_AK74;
    public UnityEngine.UI.Text PLAYER;
    public UnityEngine.UI.Text TEXT_AMMO;
    public UnityEngine.UI.Text TEXT_MAXAMMO;
    public UnityEngine.UI.Text ERROR;

    public UnityEngine.UI.Text set_whoIsModder;
    public GameObject modderOnly; //オブジェクトがActiveされてあるかboolの代わりに使う
    public string modder;

    void Start()
    {
        Parts.SendCustomEventDelayedSeconds("checkParts", 1.0f, VRC.Udon.Common.Enums.EventTiming.Update);
    }

    public void langJP()
    {

        notLoaded = "装填されてありません。";
        stopWorkingLowAmmo = "弾薬が足りない為、銃器の作動が止めました。";
        ammoIsLow = "弾薬が足りない為、リロードが必要です。";
        checkSafety = "セーフティをもう一度確認して下さい。";
        noOneHold = "誰も持っていません。";
        cantWork = "作動に問題が発生しました。銃器の状態をもう一度確認して下さい。";

    }
    public void langEN()
    {

        stopWorkingLowAmmo = "Magazine is empty.";
        ammoIsLow = "Magazine is empty, So you need to reload.";
        checkSafety = "Please check the safety.";
        noOneHold = "No one is holding.";
        cantWork = "Weapon can't work. Please check the weapon status.";

    }
    public void langKR()
    {

        stopWorkingLowAmmo = "탄약이 부족하므로 작동을 멈추었습니다.";
        ammoIsLow = "탄약이 없으므로 재장전이 필요합니다.";
        checkSafety = "조정간을 확인해주세요.";
        noOneHold = "아무도 들고있지 않습니다.";
        cantWork = "무기 작동에 실패하였습니다. 무기 상태를 점검해주세요.";

    }

    public UdonBehaviour panel;
    public override void OnPickup()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pickedUp");
    }
    public override void OnDrop()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "dropped");
    }
    public void pickedUp()
    {

        api = weapon.currentPlayer;
        string heldPlayer = api.displayName;
        PLAYER.text = heldPlayer;

        modder = heldPlayer;

    }
    public void dropped()
    {
        PLAYER.text = noOneHold;
    }
    public override void OnPickupUseDown()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "down");
    }
    public override void OnPickupUseUp()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "up");
    }
    public void error()
    {
        ERROR.text = cantWork;
        SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void offError()
    {
        ERROR.text = "";
    }
    public void down()
    {
        if (AK_CHARGED.activeSelf == true)
        {
            if (AMMO >= 1)
            {
                if (SF_AUTO.activeSelf == true)
                {
                    canFire = true;
                    SendCustomEvent("fireA");
                }
                else if (SF_SEMI.activeSelf == true)
                {
                    canFire = true;
                    SendCustomEvent("fireB");
                }
                else if (SF_SAFE.activeSelf == true)
                {
                    canFire = false;
                    ERROR.text = checkSafety;
                    SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
                }
            }
            else if (AMMO == 0)
            {
                canFire = false;
                ERROR.text = ammoIsLow;
                SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
            }
        }
        else if (AK_NOTCHARGED.activeSelf == true)
        {
            canFire = false;
            ERROR.text = notLoaded;
            SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
    }
    public void up()
    {
        canFire = false;
        SendCustomEventDelayedFrames("reset", 6, VRC.Udon.Common.Enums.EventTiming.Update);
    }
    public void fireA()
    {
        if (canFire.Equals(true))
        {
            if (AMMO >= 1)
            {
                ANIMATOR_AK74.SetInteger("bolt", 4);
                AMMO = AMMO - 1;
                SendCustomEventDelayedFrames("fireA", 7, VRC.Udon.Common.Enums.EventTiming.Update);
                TEXT_AMMO.text = AMMO.ToString();
            }
            else
            {
                canFire = false;
                SendCustomEvent("lowAmmo");
                ANIMATOR_AK74.SetInteger("bolt", 0);
                ERROR.text = stopWorkingLowAmmo;
                SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
                TEXT_AMMO.text = AMMO.ToString();
            }
        }
        else if (canFire.Equals(false))
        {
            ANIMATOR_AK74.SetInteger("bolt", 0);
            SendCustomEvent("reset");
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    public void fireB()
    {
        if (AMMO >= 1)
        {
            if (canFire.Equals(true))
            {
                AMMO = AMMO - 1;
                ANIMATOR_AK74.SetInteger("bolt", 5);
                TEXT_AMMO.text = AMMO.ToString();
            }
            else if (canFire.Equals(true))
            {
                ANIMATOR_AK74.SetInteger("bolt", 0);
                canFire = false;
                SendCustomEvent("error");
                SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
                TEXT_AMMO.text = AMMO.ToString();
            }
        }
        else
        {
            ANIMATOR_AK74.SetInteger("bolt", 0);
            canFire = false;
            ERROR.text = stopWorkingLowAmmo;
            SendCustomEvent("lowAmmo");
            SendCustomEventDelayedSeconds("offError", 5.0f, VRC.Udon.Common.Enums.EventTiming.Update);
            TEXT_AMMO.text = AMMO.ToString();
        }
    }

    public void lowAmmo()
    {
        AK_CHARGED.SetActive(false);
        AK_NOTCHARGED.SetActive(true);
        canFire = false;
        SendCustomEventDelayedFrames("reset", 6, VRC.Udon.Common.Enums.EventTiming.Update);
    }

    //弾薬管理の最初の端
    public void RND10()
    {
        if (AMMO <= 1)
        {
            AMMO = AMMO + 10;
            TEXT_MAXAMMO.text = "10";
            TEXT_AMMO.text = AMMO.ToString();
        }
        if (AMMO >= 2)
        {
            AMMO = 10 + 1;
            TEXT_MAXAMMO.text = "10";
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    public void RND30()
    {
        if (AMMO <= 1)
        {
            AMMO = AMMO + 30;
            TEXT_MAXAMMO.text = "30";
            TEXT_AMMO.text = AMMO.ToString();
        }
        else if (AMMO >= 2)
        {
            AMMO = 30 + 1;
            TEXT_MAXAMMO.text = "30";
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    public void RND45()
    {
        if (AMMO <= 1)
        {
            AMMO = AMMO + 45;
            TEXT_MAXAMMO.text = "45";
            TEXT_AMMO.text = AMMO.ToString();
        }
        else if (AMMO >= 2)
        {
            AMMO = 45 + 1;
            TEXT_MAXAMMO.text = "45";
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    public void RND60()
    {
        if (AMMO <= 1)
        {
            AMMO = AMMO + 60;
            TEXT_MAXAMMO.text = "60";
            TEXT_AMMO.text = AMMO.ToString();
        }
        else if (AMMO >= 2)
        {
            AMMO = 60 + 1;
            TEXT_MAXAMMO.text = "60";
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    public void RND95()
    {
        if (AMMO <= 1)
        {
            AMMO = AMMO + 95;
            TEXT_MAXAMMO.text = "95";
            TEXT_AMMO.text = AMMO.ToString();
        }
        else if (AMMO >= 2)
        {
            AMMO = 95 + 1;
            TEXT_MAXAMMO.text = "95";
            TEXT_AMMO.text = AMMO.ToString();
        }
    }
    //弾薬管理の最後の端
    public void canFireTrue()
    {
        canFire = true;
    }
    public void canFireFalse()
    {
        canFire = false;
    }
}
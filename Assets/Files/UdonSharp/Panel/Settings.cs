//This is world setting and other settings handler
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Settings : UdonSharpBehaviour
{
    public AK74 Weapon1;
    public Cover Cover;
    public World World;
    public RearSight RearSight;
    public Handguard Handguard;
    public Panel Panel;
    public Parts Parts;

    public VRCPlayerApi playerApi;

    public UdonBehaviour panel;
    public UdonBehaviour cover;
    public UdonBehaviour world;
    public UdonBehaviour parts;
    public UdonBehaviour weapon1;


    public UnityEngine.UI.Text playerName_text;
    public GameObject LOCKED;


    public Transform tWeapon1;
    [UdonSynced] public int weapon1Size = 10;
    public UnityEngine.UI.Slider weaponSizeSlider;


    [UdonSynced] public bool playerLock;
    [UdonSynced] public string playerName;
    


    public void lockOtherPlayer()
    {

        playerApi = Networking.LocalPlayer; //プレイヤーの名前を呼ぶ

        if (playerName == "" || playerName_text.text == "")
        {

            LOCKED.SetActive(false);

            playerName = playerApi.displayName; //プレイヤーの名前をplayerNameに返還
            playerName_text.text = playerApi.displayName; //プレイヤーの名前をdump用テキストオブジェクトに追加

            panel.SendCustomEvent("lockOtherPlayer");

            Debug.Log(playerName + "is modder now!");

        }

        if (playerApi.displayName == playerName || playerApi.displayName == playerName_text.text)
        {

            LOCKED.SetActive(false);

            playerName = playerApi.displayName;
            playerName_text.text = playerApi.displayName;

            Debug.Log(playerName + "is already modder!");

        }

        else
        {

            LOCKED.SetActive(true);

            Debug.Log(playerApi.displayName + "is not modder!");

        }

    }

    public void setWeaponSizeToAll()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "setWeaponSize");
    }
    //set every weapon size to handle every value of weapon size slider setting.
    public void setWeaponSize()
    {
        //if (Panel.bool_weapon1)
        //{   
            if (weaponSizeSlider.value == 1)
            {
                tWeapon1.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
            if (weaponSizeSlider.value == 2)
            {
                tWeapon1.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            }
            if (weaponSizeSlider.value == 3)
            {
                tWeapon1.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            }
            if (weaponSizeSlider.value == 4)
            {
                tWeapon1.transform.localScale = new Vector3(0.4f, 0.3f, 0.3f);
            }
            if (weaponSizeSlider.value == 5)
            {
                tWeapon1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            if (weaponSizeSlider.value == 6)
            {
                tWeapon1.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            }
            if (weaponSizeSlider.value == 7)
            {
                tWeapon1.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (weaponSizeSlider.value == 8)
            {
                tWeapon1.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            }
            if (weaponSizeSlider.value == 9)
            {
                tWeapon1.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            }
            if (weaponSizeSlider.value == 10)
            {
                tWeapon1.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (weaponSizeSlider.value == 11)
            {
                tWeapon1.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
            }
            if (weaponSizeSlider.value == 12)
            {
                tWeapon1.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            }
            if (weaponSizeSlider.value == 13)
            {
                tWeapon1.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
            }
            if (weaponSizeSlider.value == 14)
            {
                tWeapon1.transform.localScale = new Vector3(1.4f, 1.3f, 1.3f);
            }
            if (weaponSizeSlider.value == 15)
            {
                tWeapon1.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
            if (weaponSizeSlider.value == 16)
            {
                tWeapon1.transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
            }
            if (weaponSizeSlider.value == 17)
            {
                tWeapon1.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
            }
            if (weaponSizeSlider.value == 18)
            {
                tWeapon1.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            }
            if (weaponSizeSlider.value == 19)
            {
                tWeapon1.transform.localScale = new Vector3(1.9f, 1.9f, 1.9f);
            }
            if (weaponSizeSlider.value == 20)
            {
                tWeapon1.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
        //}
    }

    public void langJP()
    {
        Weapon1.language = 0;
        Panel.language = 0;
        Cover.language = 0;
        World.language = 0;
        Parts.language = 0;
        Handguard.language = 0;
        RearSight.language = 0;
        weapon1.SendCustomEventDelayedSeconds("checkLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        parts.SendCustomEventDelayedSeconds("checkLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
    public void langEN()
    {
        Weapon1.language = 1;
        Panel.language = 1;
        Cover.language = 1;
        World.language = 1;
        Parts.language = 1;
        Handguard.language = 1;
        RearSight.language = 1;
        weapon1.SendCustomEventDelayedSeconds("checkLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
    public void langKR()
    {
        Weapon1.language = 2;
        Panel.language = 2;
        Cover.language = 2;
        World.language = 2;
        Parts.language = 2;
        Handguard.language = 2;
        RearSight.language = 2;
        weapon1.SendCustomEventDelayedSeconds("checkLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
}
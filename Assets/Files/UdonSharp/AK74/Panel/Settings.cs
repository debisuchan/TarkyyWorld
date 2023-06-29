//This is world setting and other settings handler
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Settings : UdonSharpBehaviour
{
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


    public UnityEngine.UI.Text playerName_text;
    public GameObject LOCKED;


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

    public void langJP()
    {
        Panel.language = 0;
        Cover.language = 0;
        World.language = 0;
        Parts.language = 0;
        Handguard.language = 0;
        RearSight.language = 0;
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        parts.SendCustomEventDelayedSeconds("checkLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
    public void langEN()
    {
        Panel.language = 1;
        Cover.language = 1;
        World.language = 1;
        Parts.language = 1;
        Handguard.language = 1;
        RearSight.language = 1;
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
    public void langKR()
    {
        Panel.language = 2;
        Cover.language = 2;
        World.language = 2;
        Parts.language = 2;
        Handguard.language = 2;
        RearSight.language = 2;
        panel.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        cover.SendCustomEventDelayedSeconds("setLang", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        //world.SendCustomEventDelayedSeconds("check", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
        Panel.langList.SetActive(!Panel.langList);
    }
}
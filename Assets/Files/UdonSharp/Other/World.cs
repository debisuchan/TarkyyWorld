//This is world status handler
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
public class World : UdonSharpBehaviour
{

    private VRCPlayerApi playerApi;
    public UdonBehaviour panel;
    public UdonBehaviour weapon1;


    public int language = 0;


    //一応はプレイヤーが入ったら実行することは特になし
    void Start()
    {

        SendCustomEvent("checkWorldStatus");

    }

    public void checkWorldStatus()
    {

        playerApi = Networking.LocalPlayer;
        string playerName = playerApi.displayName;

        Debug.Log("World Status is successfully loaded to " + playerName);

    }

}

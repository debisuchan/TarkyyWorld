//This is panel status, information, and etc.. handler
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Panel : UdonSharpBehaviour
{
    public Settings Settings;

    private VRCPlayerApi api;
    public int language = 0;

    public GameObject weaponSelection;
    public GameObject weaponTransition;
    public GameObject weaponPartsW1;
    public GameObject otherSettings;
    public GameObject arAK74;
    public GameObject wsAR;
    public GameObject arList;
    public GameObject langList;
    public GameObject weapon1;
    public GameObject infoPanel;
    public GameObject userPanel;
    public GameObject openObject;
    public GameObject panelDefault;

    public UnityEngine.UI.Text infoOne;
    public UnityEngine.UI.Text infoTwo;
    public UnityEngine.UI.Text okText;
    public UnityEngine.UI.Text panelTitle1;
    public UnityEngine.UI.Text panelTitle2;
    public UnityEngine.UI.Text panelBtn1;
    public UnityEngine.UI.Text panelBtn2;
    public UnityEngine.UI.Text panelBtn3;
    public UnityEngine.UI.Text panelBtn4;
    public UnityEngine.UI.Text panelSet1;
    public UnityEngine.UI.Text panelSet2;
    public UnityEngine.UI.Text panelSet3;
    public UnityEngine.UI.Text panelSet4;
    public UnityEngine.UI.Text panelWS1;
    public UnityEngine.UI.Text weaponName;
    //public UnityEngine.UI.Text panelPartsCoverDefault;
    public UnityEngine.UI.Text panelPartsError1;
    public UnityEngine.UI.Text panelPartsError2;
    public UnityEngine.UI.Text panelPartsError3;
    public UnityEngine.UI.Text panelPartsErrorBTN1;
    public UnityEngine.UI.Text panelPartsErrorBTN2;
    public UnityEngine.UI.Text panelParts1;
    public UnityEngine.UI.Text panelParts2;
    public UnityEngine.UI.Text panelParts3;
    public UnityEngine.UI.Text panelParts4;
    public UnityEngine.UI.Text panelParts5;
    public UnityEngine.UI.Text panelParts6;
    public UnityEngine.UI.Text panelParts7;
    public UnityEngine.UI.Text panelParts8;
    public UnityEngine.UI.Text panelParts9;
    public UnityEngine.UI.Text panelParts10;
    public UnityEngine.UI.Text rearDefault;
    public UnityEngine.UI.Text coverDefault;

    public string topCover;
    public string defaultText;
    public string textRearSight;

    public bool bool_weapon1;

    //設定パネル変数
    public bool modderOnlyMode = true;
    [UdonSynced]
    public string modderName = "";
    public UnityEngine.UI.Text modderName_text;
    public GameObject LOCKED;

    public GameObject pageCover;
    public GameObject pageHandguard;
    public GameObject pageMainParts;
    public GameObject pageDetailButtons;
    public GameObject pageCanvas;
    public UdonBehaviour pageUpdate;
    public UdonBehaviour pagePage;

    public void udstd()
    {

        api = Networking.LocalPlayer;

        if (api.displayName == modderName || api.displayName == modderName_text.text)
        {

            langList.SetActive(false);
            weapon1.SetActive(true);
            infoPanel.SetActive(false);
            pageCanvas.SetActive(true);
            panelDefault.SetActive(true);

        }

        if (modderName_text.text == "" || modderName == "")
        {

            langList.SetActive(false);
            weapon1.SetActive(true);
            infoPanel.SetActive(false);
            pageCanvas.SetActive(true);
            panelDefault.SetActive(true);

            modderName = api.displayName;
            modderName_text.text = api.displayName;

            Debug.Log("The modder is now " + modderName + ".");

        }

        if (api.displayName != modderName || api.displayName != modderName_text.text)
        {
            langList.SetActive(false);
            weapon1.SetActive(true);
            infoPanel.SetActive(false);
            pageCanvas.SetActive(true);
            panelDefault.SetActive(true);

            LOCKED.SetActive(true);
        }

    }

    public void langJP()
    {

        Settings.SendCustomEvent("langJP");

    }
    public void langEN()
    {

        Settings.SendCustomEvent("langEN");

    }
    public void langKR()
    {

        Settings.SendCustomEvent("langKR");

    }
    //言語確認
    //  言語を設定する時と言語をチェックする時も使う
    public void check()
    {
        if (language == 0)
        {
            //初期パネル
            infoOne.text = "銃組み立てワールドへようこそ !";
            infoTwo.text = "このワールドは色んな銃器で打ったり自分だけの銃を組み立てしながらあそべるワールドです。\n\n本ワールドは作者向けで作られたワールドですので下記の注意点を必ず認識してください。\n\n本モデルは問題性が多いですのでインスタンスを必ずFriends Onlyで設定してお楽しみ下さい！\nワールドについて問題が発生したときはPrivateワールドに切り替えしますので\nお楽しみしたい方は作者にご連絡下さい！\n現在、VRだけ対応していただきます。ご了承下さい。\n\n以上です。あとは下の「理解した！」ボタンを押してお楽しみ下さい！";
            okText.text = "理解した ！";
            //メインパネル
            panelTitle1.text = "組み立てパンネル";
            panelTitle2.text = "組み立てパンネル";
            panelBtn1.text = "武器選択";
            panelBtn2.text = "部品";
            panelBtn3.text = "位置";
            panelBtn4.text = "設定";
            //設定
            panelSet1.text = "モバイルモード";
            panelSet2.text = "自動装填";
            panelSet3.text = "銃器の状態や情報";
            panelSet4.text = "組み立て集中モード";
            //武器選択
            panelWS1.text = "アサルトライフル (AR)";
            //部品のリスト
            panelParts1.text = "トップカバー";
            panelParts2.text = "ハンドガード";
            panelParts3.text = "マズル";
            panelParts4.text = "ストック";
            panelParts5.text = "マガジン";
            panelParts6.text = "スコープ";
            panelParts7.text = "レイル";
            panelParts8.text = "リアサイト";
            panelParts9.text = "フォアグリップ";
            panelParts10.text = "グリップ";
            //部品のエラーウィンドウ
            panelPartsError1.text = "通知";
            panelPartsError2.text = "この部品は下記の部品と組み合わせが出来ません。";
            panelPartsError3.text = "この部品を取り出しますか？";
            panelPartsErrorBTN1.text = "いいえ";
            panelPartsErrorBTN2.text = "はい";
            //その外
            coverDefault.text = "基本";
            defaultText = "基本";
            topCover = "トップカバー";
            rearDefault.text = "基本";
            textRearSight = "リアサイト";
        }
        if (language == 1)
        {
            infoOne.text = "Welcome to Gunsmith World!";
            infoTwo.text = "In this world, where you can shoot with some guns or make your own guns.\n\nPlease be aware of the precautions below because this world is designed exclusively for a creator.\n\nThere may be problems with these models in many ways,\nso please make sure to set the instance to Friends Only and enjoy it!\nIf there is a problem with this World, the world creator will set the World to Private,\nso if you want to enjoy it, please contact the creator!\nVR Only support for now!\n\nThat's it. Now, click the 'Understood' button below and enjoy it!";
            okText.text = "Understood!";
            panelTitle1.text = "Gunsmith Panel";
            panelTitle2.text = "Gunsmith Panel";
            panelBtn1.text = "Weapons";
            panelBtn2.text = "Parts";
            panelBtn3.text = "Transform";
            panelBtn4.text = "Settings";
            panelSet1.text = "Mobile Mode";
            panelSet2.text = "Auto Reload";
            panelSet3.text = "Weapon Status";
            panelSet4.text = "Gunsmith Focus Mode";
            panelWS1.text = "Assault Rifle (AR)";
            panelParts1.text = "トップカバー";
            panelParts2.text = "Handguard";
            panelParts3.text = "Muzzle";
            panelParts4.text = "Stock";
            panelParts5.text = "Magazine";
            panelParts6.text = "Scope";
            panelParts7.text = "Rails";
            panelParts8.text = "Rear Sight";
            panelParts9.text = "Foregrip";
            panelParts10.text = "Pistol Grip";
            panelPartsError1.text = "Notify";
            panelPartsError2.text = "This part is incompatible with the following part.";
            panelPartsError3.text = "Remove this part?";
            panelPartsErrorBTN1.text = "No";
            panelPartsErrorBTN2.text = "Yes";
            coverDefault.text = "Default";
            defaultText = "Default";
            topCover = "Dust Cover";
            rearDefault.text = "Default";
        }
        if (language == 2)
        {
            infoOne.text = "총기 조립 월드에 오신것을 환영합니다!";
            infoTwo.text = "이 월드에서는 여러 총기를 가지고 발사하거나 자신만의 총을 조립하며 즐길 수 있는 월드 입니다\n\n해당 월드는 제작자 전용으로 만들어진 월드로서 하단의 주의점을 반드시 숙지하여 주시기 바랍니다.\n\n해당 모델은 문제가 발생할 수 있기에 인스턴스를 반드시 Friends Only으로 설정하여 즐겨주시길 바랍니다!\n월드에 대해 문제가 발생하였을 때에는 Private 월드로 전환할 것 이므로\n즐기고 싶으신분 께서는 제작자에게 연락 부탁 드립니다!\n\n이상입니다. 이제 아래의 '이해했습니다!' 버튼을 눌러 즐겨주시길 바랍니다!";
            okText.text = "이해했습니다!";
            panelTitle1.text = "조립 패널";
            panelTitle2.text = "조립 패널";
            panelBtn1.text = "무기선택";
            panelBtn2.text = "부품";
            panelBtn3.text = "위치";
            panelBtn4.text = "설정";
            panelSet1.text = "모바일 모드";
            panelSet2.text = "자동 장전";
            panelSet3.text = "무기 상태 및 정보";
            panelSet4.text = "조립 집중 모드";
            panelWS1.text = "돌격소총 (AR)";
            panelParts1.text = "탑커버";
            panelParts2.text = "핸드가드";
            panelParts3.text = "머즐";
            panelParts4.text = "스톡";
            panelParts5.text = "탄창";
            panelParts6.text = "스코프";
            panelParts7.text = "레일";
            panelParts8.text = "가늠좌";
            panelParts9.text = "핸드그립";
            panelParts10.text = "피스톨그립";
            panelPartsError1.text = "알림";
            panelPartsError2.text = "이 부품은 아래의 부품과 호환되지 않습니다.";
            panelPartsError3.text = "이 부품을 제거하시겠습니까?";
            panelPartsErrorBTN1.text = "아니오";
            panelPartsErrorBTN2.text = "예";
            coverDefault.text = "기본";
            defaultText = "기본";
            topCover = "탑커버";
            rearDefault.text = "기본";
            textRearSight = "가늠좌";
        }
    }

    public void languageMenu()
    {
        langList.SetActive(true);
    }

    public void selectWeapon()
    {
        pagePage.SendCustomEvent("resetPage");
        weaponSelection.SetActive(true);
        weaponPartsW1.SetActive(false);
        weaponTransition.SetActive(false);
        otherSettings.SetActive(false);
    }

    public void partsLists()
    {
        if (bool_weapon1)
        {
            pagePage.SendCustomEvent("resetPage");
            weaponSelection.SetActive(false);
            weaponPartsW1.SetActive(true);
            weaponTransition.SetActive(false);
            otherSettings.SetActive(false);
        }
        else
        {
            pagePage.SendCustomEvent("resetPage");
            weaponSelection.SetActive(false);
            weaponPartsW1.SetActive(false);
            weaponTransition.SetActive(false);
            otherSettings.SetActive(false);
            Debug.Log("Did not selected any weapon.");
        }
    }

    public void partsTransform()
    {
        pagePage.SendCustomEvent("resetPage");
        weaponSelection.SetActive(false);
        weaponPartsW1.SetActive(false);
        weaponTransition.SetActive(true);
        otherSettings.SetActive(false);
    }

    public void settings()
    {
        pagePage.SendCustomEvent("resetPage");
        weaponSelection.SetActive(false);
        weaponPartsW1.SetActive(false);
        weaponTransition.SetActive(false);
        otherSettings.SetActive(true);
    }

    public void weaponAR()
    {
        wsAR.SetActive(false);
        arList.SetActive(true);
    }

    public void weaponAR_AK74()
    {
        weapon1.SetActive(true);
        bool_weapon1 = true;
        arAK74.SetActive(true);
        weaponName.text = "AR : AK-74";
    }

    public void weaponAR_BACK()
    {
        wsAR.SetActive(true);
        arList.SetActive(false);
    }

    public void closePanel()
    {
        userPanel.SetActive(false);
        openObject.SetActive(true);
    }

    public void toCoverPage()
    {
        pageDetailButtons.SetActive(true);
        pageCover.SetActive(true);
        pageMainParts.SetActive(false);

        pagePage.SendCustomEventDelayedSeconds("update", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }

    public void toHandguardPage()
    {
        pageDetailButtons.SetActive(true);
        pageHandguard.SetActive(true);
        pageMainParts.SetActive(false);

        pagePage.SendCustomEventDelayedSeconds("update", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }
}
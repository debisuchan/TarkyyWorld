
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Page : UdonSharpBehaviour
{
    public GameObject coverW1;
    public GameObject handguardW1;
    //public GameObject handguard1;
    //public GameObject handguard2;
    //public GameObject handguard3;
    //public GameObject handguard4;
    //public GameObject handguard5;
    public GameObject DetailButtonsW1;
    public GameObject MainButtonsW1;

    public UnityEngine.UI.Text maxPage;
    public UnityEngine.UI.Text nowPage;

    /*
    public void uptodate()
    {
        if (DetailButtonsW1.activeSelf)
        {
            maxPage.text = "1";
            nowPage.text = "1";
        }
        if (MainButtonsW1.activeSelf)
        {
            maxPage.text = "1";
            nowPage.text = "1";
        }
        if (cover.activeSelf)
        {
            maxPage.text = "1";
            nowPage.text = "1";
        }
        if (handguardW1.activeSelf)
        {}
        if (handguard1.activeSelf)
        {
            maxPage.text = "5";
            nowPage.text = "1";
        }
        if (handguard2.activeSelf)
        {
            maxPage.text = "5";
            nowPage.text = "2";
        }
        if (handguard3.activeSelf)
        {
            maxPage.text = "5";
            nowPage.text = "3";
        }
        if (handguard4.activeSelf)
        {
            maxPage.text = "5";
            nowPage.text = "4";
        }
        if (handguard5.activeSelf)
        {
            maxPage.text = "5";
            nowPage.text = "5";
        }
    }

    public void next()
    {
        Debug.Log("Executed next button.");
        if (handguard1.activeSelf)
        {
            handguard1.SetActive(false);
            handguard2.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard2.activeSelf)
        {
            handguard2.SetActive(false);
            handguard3.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard3.activeSelf)
        {
            handguard3.SetActive(false);
            handguard4.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard4.activeSelf)
        {
            handguard4.SetActive(false);
            handguard5.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
    }
    */
    public void previous()
    {
        if (coverW1.activeSelf)
        {
            MainButtonsW1.SetActive(true);
            DetailButtonsW1.SetActive(false);
            coverW1.SetActive(false);
            //SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguardW1.activeSelf)
        {
            MainButtonsW1.SetActive(false);
            DetailButtonsW1.SetActive(false);
            handguardW1.SetActive(false);
        }
        /*
        if (handguard1.activeSelf)
        {
            MainButtonsW1.SetActive(true);
            DetailButtonsW1.SetActive(false);
            handguard1.SetActive(false);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard2.activeSelf)
        {
            handguard2.SetActive(false);
            handguard1.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard3.activeSelf)
        {
            handguard3.SetActive(false);
            handguard2.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard4.activeSelf)
        {
            handguard4.SetActive(false);
            handguard3.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        if (handguard5.activeSelf)
        {
            handguard5.SetActive(false);
            handguard4.SetActive(true);
            SendCustomEventDelayedSeconds("uptodate", 0.1f, VRC.Udon.Common.Enums.EventTiming.Update);
        }
        */
    }
    public void resetPage()
    {
        coverW1.SetActive(false);
        handguardW1.SetActive(false);
        //handguard1.SetActive(false);
        //handguard2.SetActive(false);
        //handguard3.SetActive(false);
        //handguard4.SetActive(false);
        //handguard5.SetActive(false);
        DetailButtonsW1.SetActive(false);
        MainButtonsW1.SetActive(false);
    }
}


using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class OpenPanel : UdonSharpBehaviour
{
    public GameObject userPanel;
    public GameObject openPanel;
    public override void Interact()
    {
        userPanel.SetActive(true);
        openPanel.SetActive(false);
    }
}

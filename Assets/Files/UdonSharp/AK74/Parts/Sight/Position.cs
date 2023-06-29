
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Position : UdonSharpBehaviour
{
    public VRC.SDK3.Components.VRCPickup positionObject;
    public Transform getPosition;
    public Transform ScopeEOTechEXPS3;
    public GameObject objScopeEOTechEXPS3;
    public override void OnPickup()
    {
        if (objScopeEOTechEXPS3.activeSelf)
        {
            
        }
    }
}

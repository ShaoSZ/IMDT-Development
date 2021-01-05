using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMode : MonoBehaviour
{
    public bool FirstPersonMode;


    public void setMode()
    {
        ValueManager.getInstance().setMode(FirstPersonMode);
    }
}

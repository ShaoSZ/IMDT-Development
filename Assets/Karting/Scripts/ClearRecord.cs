using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearRecord : MonoBehaviour
{
    public void clear()
    {
        PlayerPrefs.DeleteAll();
    }
}

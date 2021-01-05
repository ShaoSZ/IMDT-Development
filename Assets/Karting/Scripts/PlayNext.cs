using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayNext : MonoBehaviour
{
    public void Next()
    {
        Application.LoadLevel(ValueManager.getInstance().getLevel() + 1);
    } 
}

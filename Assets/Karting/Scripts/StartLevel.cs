using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public int currentLevel = 0;
    public GameObject cinema;
    public GameObject cameraT;
    public GameObject cameraF;


    // Start is called before the first frame update
    void Start()
    {
        ValueManager.getInstance().setLevel(currentLevel);
        ValueManager.getInstance().setCoin(0);

        if (ValueManager.getInstance().getMode())
        {
            cameraT.SetActive(false);
            cinema.SetActive(false);
            cameraF.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

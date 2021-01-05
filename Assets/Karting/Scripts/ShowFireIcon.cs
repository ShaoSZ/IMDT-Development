using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFireIcon : MonoBehaviour
{
   //public GameObject no1;
   //public GameObject no2;
   //public GameObject no3;
   //public GameObject no4;
   //
   //public GameObject no12;
   //public GameObject no22;
   //public GameObject no32;
   //public GameObject no42;
   //
   //public GameObject yes1;
   //public GameObject yes2;
   //public GameObject yes3;
   //public GameObject yes4;
   //
   //public GameObject yes12;
   //public GameObject yes22;
   //public GameObject yes32;
   //public GameObject yes42;

    public GameObject[] no1;
    public GameObject[] no2;
    public GameObject[] yes1;
    public GameObject[] yes2;

    //copied from FinalCalculate.cs!
    private string[] lasts = { "last0", "last1", "last2", "last3", "last4" };
    private string[] lastsF = { "last0f", "last1f", "last2f", "last3f", "last4f" };

    public void refresh()
    {
        for(int i = 0; i < 4; i++)
        {
            if (PlayerPrefs.HasKey(lasts[i + 1]))
            {
                no1[i].SetActive(false);
                yes1[i].SetActive(true);
            }
            else
            {
                no1[i].SetActive(true);
                yes1[i].SetActive(false);
            }

            if (PlayerPrefs.HasKey(lastsF[i + 1]))
            {
                no2[i].SetActive(false);
                yes2[i].SetActive(true);
            }
            else
            {
                no2[i].SetActive(true);
                yes2[i].SetActive(false);
            }
        }
    }
}

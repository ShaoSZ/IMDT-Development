using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalCalculate : MonoBehaviour
{
    public GameObject textCoin;
    public GameObject textTime;
    public GameObject textLast;
    public GameObject buttonNext;

    private string[] lasts ={ "last0", "last1", "last2", "last3", "last4" };
    private string[] lastsF ={ "last0f", "last1f", "last2f", "last3f", "last4f" };

    // Start is called before the first frame update
    void Start()
    {

        textCoin.GetComponent<Text>().text = ValueManager.getInstance().getCoin().ToString();
        textTime.GetComponent<Text>().text = ValueManager.getInstance().getScore().ToString() + "s";

        if (ValueManager.getInstance().getMode())
        {
            if (PlayerPrefs.HasKey(lastsF[ValueManager.getInstance().getLevel()]))
            {
                textLast.GetComponent<Text>().text = PlayerPrefs.GetInt(lastsF[ValueManager.getInstance().getLevel()]).ToString() + "s";
            }
            else
            {
                textLast.GetComponent<Text>().text = "无记录";
            }

            PlayerPrefs.SetInt(lastsF[ValueManager.getInstance().getLevel()], ValueManager.getInstance().getScore());//add the new record
        }
        else
        {
            if (PlayerPrefs.HasKey(lasts[ValueManager.getInstance().getLevel()]))
            {
                textLast.GetComponent<Text>().text = PlayerPrefs.GetInt(lasts[ValueManager.getInstance().getLevel()]).ToString() + "s";
            }
            else
            {
                textLast.GetComponent<Text>().text = "无记录";
            }

            PlayerPrefs.SetInt(lasts[ValueManager.getInstance().getLevel()], ValueManager.getInstance().getScore());//add the new record
        }
    


        if (ValueManager.getInstance().getLevel() == 4)
        {
            buttonNext.GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

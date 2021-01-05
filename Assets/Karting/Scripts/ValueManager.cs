using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueManager : MonoBehaviour
{
    public static ValueManager _instance;

    private int coin;
    private int level;
    private int score;
    private bool mode = false;

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public static ValueManager getInstance()
    {
        return _instance;
    }

    public void setCoin(int coin)
    {
        this.coin = coin;
    }

    public void addCoin()
    {
        this.coin++;
    }

    public int getCoin()
    {
        return this.coin;
    }

    public void setLevel(int level)
    {
        this.level = level;
    }

    public int getLevel()
    {
        return this.level;
    }

    public void setScore(int score)
    {
        this.score = score;
    }

    public int getScore()
    {
        return this.score;
    }

    public void setMode(bool mode)
    {
        this.mode = mode;
    }

    public bool getMode()
    {
        return mode;
    }
}

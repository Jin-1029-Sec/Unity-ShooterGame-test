using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{
    GameObject hp;
    GameObject hptext;
    GameObject score;
    int TheHp = 20;
    static int theScore = 0;

    AudioSource TheAudio;
    public AudioClip moneyEat;
    public AudioClip blood;
    void Start()
    {
        
        this.TheAudio = GetComponent<AudioSource>();
        this.hp = GameObject.Find("hp");
        this.hptext = GameObject.Find("hpText");
        this.score = GameObject.Find("score");
    }

    //¦©¦å¶q(10ºw¦å)
    public void DecreaseHp()
    {
        TheHp -= 1;
        this.hp.GetComponent<Image>().fillAmount -= 0.05f;
        this.hptext.GetComponent<Text>().text = "" + TheHp;
        if (TheHp <= 0)
                SceneManager.LoadScene("StartScene");
    }
    //¸É¦å
    public void addHp()
    {
        if (TheHp <= 19) 
        {
            TheHp += 1;
            this.hp.GetComponent<Image>().fillAmount += 0.05f;
            this.hptext.GetComponent<Text>().text = "" + TheHp;
            TheAudio.PlayOneShot(blood);
        }
            
    }
    public void addpoint()
    {
        theScore += 10;
        this.score.GetComponent<Text>().text = ""+theScore;
        TheAudio.PlayOneShot(moneyEat);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}

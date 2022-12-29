using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�p��
public class diamond : MonoBehaviour
{
    int touch = 0;
    public int speed = -3;
    private Rigidbody2D r2d = null;
    private Animator blueDiamond;
    AudioSource TheAudio;
    public AudioClip borken;
    void Start()
    {
        this.TheAudio = GetComponent<AudioSource>();
        blueDiamond = GetComponent<Animator>();
        r2d = this.gameObject.GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(0, speed);
        r2d.angularVelocity = Random.Range(-200, 200);
    }
    void Update() { }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        //Ĳ�I��l�u
        if (obj.gameObject.name == "bullet(Clone)")
        {
            if (touch == 0)
            {
                TheAudio.PlayOneShot(borken);
                touch += 1;
                blueDiamond.SetInteger("status", 1);
            }
            Destroy(obj.gameObject);
        }
        //Ĳ�I�쭸��
        if (obj.gameObject.name == "spaceship")
        {
            //�I�s�ɺt���榩��&�[��
            GameObject director = GameObject.Find("Director");
            if (touch == 0)
            {
                director.GetComponent<Director>().DecreaseHp();
            }
            else if (touch >= 1)
            {
                director.GetComponent<Director>().addpoint();
                director.GetComponent<Director>().addpoint();
            }
            Destroy(gameObject);
        }
    }
}
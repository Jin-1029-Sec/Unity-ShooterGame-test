using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//火球
public class fireball : MonoBehaviour
{
    int touch = 0;
    public int speed = -5;
    private Rigidbody2D r2d = null;
    private Animator BlueFireball;
    AudioSource TheAudio;
    public AudioClip fireout;
    void Start()
    {
        this.TheAudio = GetComponent<AudioSource>();
        BlueFireball = GetComponent<Animator>();
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
        //觸碰到子彈
        if (obj.gameObject.name == "bullet(Clone)")
        {
            if (touch >= 1)
            {
                Destroy(gameObject);
                Destroy(obj.gameObject);
                touch = 0;
            }
            else
                TheAudio.PlayOneShot(fireout);
                touch += 1;
                BlueFireball.SetInteger("status", 1);
        }
        //觸碰到飛船
        if (obj.gameObject.name == "spaceship")
        {
            //呼叫導演執行扣血
            GameObject director = GameObject.Find("Director");
            if (touch == 0)
            {
                director.GetComponent<Director>().DecreaseHp();
                director.GetComponent<Director>().DecreaseHp();
            }
            else if (touch >= 1)
                director.GetComponent<Director>().DecreaseHp();
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//金幣
public class money : MonoBehaviour
{
    public int speed = -5;
    private Rigidbody2D r2d = null;
    void Start()
    {
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
        //觸碰到飛船
        if (obj.gameObject.name == "spaceship")
        {
            Destroy(gameObject);
            //呼叫導演執行加分
            GameObject director = GameObject.Find("Director");
            director.GetComponent<Director>().addpoint();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int speed = -5;
    private Rigidbody2D r2d = null;
    void Start()
    {
        r2d = this.gameObject.GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(0, speed);
        r2d.angularVelocity = Random.Range(-200, 200);
    }
    void Update(){}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        //觸碰到子彈
        if (obj.gameObject.name == "bullet(Clone)")
        {
            Destroy(gameObject);
            Destroy(obj.gameObject);
        }
        //觸碰到飛船
        if (obj.gameObject.name == "spaceship")
        {
            Destroy(gameObject);
            //呼叫導演執行扣血
            GameObject director = GameObject.Find("Director");
            director.GetComponent<Director>().DecreaseHp();
        }
    }
}

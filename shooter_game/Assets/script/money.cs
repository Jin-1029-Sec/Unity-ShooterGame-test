using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����
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
        //Ĳ�I�쭸��
        if (obj.gameObject.name == "spaceship")
        {
            Destroy(gameObject);
            //�I�s�ɺt����[��
            GameObject director = GameObject.Find("Director");
            director.GetComponent<Director>().addpoint();
        }
    }
}
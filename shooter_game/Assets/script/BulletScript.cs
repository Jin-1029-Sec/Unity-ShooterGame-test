using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//子彈
public class BulletScript : MonoBehaviour
{
    public int speed = 6;
    private Rigidbody2D r2d = null;
    void Start()
    {
        r2d = this.gameObject.GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(0, speed); 
    }
    
    void Update(){}
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

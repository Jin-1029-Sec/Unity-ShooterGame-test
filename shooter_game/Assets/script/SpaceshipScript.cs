using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//飛船
public class SpaceshipScript : MonoBehaviour
{
    private Rigidbody2D r2d = null;
    public GameObject bullet;

    AudioSource biuSound;
    public AudioClip biubiubiu;

    void Start(){
        this.biuSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        //上下左右移動控制
        r2d = this.gameObject.GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.RightArrow)&&transform.position.x<8)
            r2d.velocity = new Vector2(10, 0);
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8)
            r2d.velocity = new Vector2(-10, 0);
        else if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < 1.5)
            r2d.velocity = new Vector2(0, 10);
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.5)
            r2d.velocity = new Vector2(0, -10);
        else
            r2d.velocity = new Vector2(0, 0);

        //空白鍵射出子彈，並發出音效
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            biuSound.PlayOneShot(biubiubiu);
        }
    }
}

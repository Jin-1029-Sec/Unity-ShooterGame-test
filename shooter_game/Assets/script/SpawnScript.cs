using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject enemy;
    public GameObject fireball;
    public GameObject money;
    public GameObject heart;
    public GameObject diamond;

    //spawnTime生成時間
    public float enemyTime = 1.0f;
    public float fireballTime = 1.0f;
    public float moneyTime = 2.5f;
    public float diamondTime = 3.0f;
    public float heartTime = 1.0f;
    void Start()
    {
        InvokeRepeating("addHeart", 0, heartTime);
        InvokeRepeating("addEnemy", 0, enemyTime);
        InvokeRepeating("addFireball",0, fireballTime);
        InvokeRepeating("addDiamond", 0, diamondTime);
        InvokeRepeating("addMoney",0, moneyTime);

    }
    void addEnemy() {
        Renderer rd = this.gameObject.GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x/2;
        float x2 = transform.position.x + rd.bounds.size.x/2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
    void addFireball()
    {
        Renderer rd = this.gameObject.GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(fireball, spawnPoint, Quaternion.identity);
    }
    void addMoney()
    {
        Renderer rd = this.gameObject.GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(money, spawnPoint, Quaternion.identity);
    }
    void addDiamond()
    {
        Renderer rd = this.gameObject.GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(diamond, spawnPoint, Quaternion.identity);
    }
    void addHeart()
    {
        Renderer rd = this.gameObject.GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(heart, spawnPoint, Quaternion.identity);
    }
    void Update()
    {
        
    }
}

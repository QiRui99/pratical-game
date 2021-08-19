using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnerScript : MonoBehaviour
{
    public GameObject[] enemy;
    float randX;
    float randY;

    float xwidth;
    float yheight;

    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    static int maxEnemy = 6;
    static float enemyCount = 0;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCount < maxEnemy)
        {
            if(Time.time > nextSpawn)
            {
                rand = Random.Range(0, enemy.Length);

                nextSpawn = Time.time + spawnRate;
                xwidth = (Screen.width - 32) / 100;
                yheight = (Screen.height - 32) / 100;

                randX = Random.Range(-xwidth, xwidth);
                randY = Random.Range(-yheight, yheight);

                whereToSpawn = new Vector2(randX, randY);
                Instantiate(enemy[rand], whereToSpawn,Quaternion.identity);
                enemyCount++;
            }
        }
    }
}

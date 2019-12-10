using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject knight;
    public GameObject mage;
    public GameObject rogue;
    public GameObject merchant;
    private float randX;
    private float randY;
    Vector3 whereToSpawn;
    public float spawnRate;
    public float spawnNext; 
    float nextSpawn;
    public Vector2 axis;
    public Vector3 myVector; 
    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = Random.Range(1.0f, 5.0f);
        myVector = new Vector3 (0.0f, 0.0f, -5.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            spawnRate = Random.Range(6.0f, 10.0f);
            spawnNext = Random.Range(0.0f, 10.0f);
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-1.4f, 1.4f);
            randY = Random.Range(-1.0f, 1.0f);
            if (randY < 0)
            {
                whereToSpawn = new Vector3((transform.position.x + randX), transform.position.y, myVector.z);
            }
            else
            {
                whereToSpawn = new Vector3((transform.position.x + randX), (transform.position.y + 25.0f), myVector.z); //change value depending on camera size
            }

            if (spawnNext < 3.3f)
            {
                Instantiate(knight, whereToSpawn, Quaternion.identity);
            }
            else if (spawnNext > 6.6f)
            {
                Instantiate(mage, whereToSpawn, Quaternion.identity);
            } 
            else
            {
                Instantiate(rogue, whereToSpawn, Quaternion.identity);
            }
        }
    }
}

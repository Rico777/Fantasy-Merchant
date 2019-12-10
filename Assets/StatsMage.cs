using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsMage : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    public int atk;
    public int def;
    public int charisma;
    void Start()
    {
        HP = (int)Random.Range(10.0f, 15.0f);
        atk = (int)Random.Range(100.0f, 150.0f);
        def = (int)Random.Range(10.0f, 15.0f);
        charisma = (int)Random.Range(10.0f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

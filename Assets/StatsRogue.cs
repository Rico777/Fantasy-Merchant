﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsRogue : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    public int atk;
    public int def;
    public int charisma;
    void Start()
    {
        HP = (int)Random.Range(10.0f, 15.0f);
        atk = (int)Random.Range(10.0f, 15.0f);
        def = (int)Random.Range(15.0f, 20.0f);
        charisma = (int)Random.Range(10.0f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
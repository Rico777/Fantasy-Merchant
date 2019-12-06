using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcVar : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Vector2 axis;
    public bool clicked;
    public GameObject merchant;
    public GameObject spawner;
    void Start()
    {
        merchant = GameObject.Find("Merchant");
        spawner = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLeave : MonoBehaviour
{
    private bool leave;
    public GameObject NPC;
    public NpcVar n;
    public Vector2 myVector;
    public float randy;
    // Start is called before the first frame update
    void Start()
    {
        NPC = this.gameObject;
        n = NPC.GetComponent<NpcVar>();
        n.merchant = GameObject.Find("Merchant"); //IMPORTANT: CHANGE THIS NAME
        randy = Random.Range(0.25f, 1.5f);
        myVector = new Vector3(randy, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") && n.clicked == true)
        {
            leave = true;
            n.clicked = false;
        }
        if (leave)
        {
            n.axis.x = 1;
            if (transform.position.x > (n.spawner.transform.position.x - myVector.x))
            {
                n.axis.x = 0;
                n.axis.y = 1;
                leave = false; 
            }
        }

    }
}


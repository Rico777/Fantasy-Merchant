using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public GameObject NPC;
    public NpcVar n;
    public Vector2 myVector;
    public float randy;
    public static bool otherclick;
    public static bool movingright; 
    // Start is called before the first frame update
    void Start()
    {
        movingright = false;
        otherclick = false; 
        NPC = this.gameObject;
        n = NPC.GetComponent<NpcVar>();
        n.merchant = GameObject.Find("Merchant"); //IMPORTANT: CHANGE THIS NAME
        randy = Random.Range(0.25f, 1.5f);
        myVector = new Vector3(1.0f, randy);
        if (transform.position.y < n.merchant.transform.position.y)
        {
            n.axis.y = 1;
        }
        else
        {
            n.axis.y = -1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(otherclick);
    }
    private void OnMouseDown()
    {
        if (otherclick == false && movingright == false) 
        {
            n.clicked = true;
            otherclick = true;
        }

    }

    void FixedUpdate()
    {
        if (n.axis.x == 1)
        {
            otherclick = false;
            movingright = true;
        }
        if (n.axis.x == 0)
        {
            movingright = false; 
        }
        if (n.clicked)
        {
            otherclick = true; 
            if (transform.position.x < (n.merchant.transform.position.x + myVector.x))
            {
                n.axis.x = 0;
                //scene changes here
            }
            else if (transform.position.x > n.merchant.transform.position.x)
            {
                n.axis.x = -1;
            }


            if (transform.position.y > (n.merchant.transform.position.y + myVector.y))
            {
                n.axis.y = -1;
            }
            else if (transform.position.y < (n.merchant.transform.position.y - myVector.y))
            {
                n.axis.y = 1;
            }
            else
            {
                n.axis.y = 0;
            }

            n.rb.MovePosition(n.rb.position + n.axis * (n.moveSpeed * Time.fixedDeltaTime));

        }
        else
        {
            n.rb.MovePosition(n.rb.position + n.axis * (n.moveSpeed * Time.fixedDeltaTime));
            if (transform.position.y > 100.0f) //despawn point
            {
                Destroy(this.gameObject);
            }
            else if (transform.position.y < -100.0f) //despawn point
            {
                Destroy(this.gameObject);
            }
        }
    }
}

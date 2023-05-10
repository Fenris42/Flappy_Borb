using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Bird : MonoBehaviour
{
    public Rigidbody2D BirdBody;
    public float FlapStrength;
    public LogicScript logic;
    public bool BirdAlive = true;
    private GameObject life1;
    private GameObject life2;
    private GameObject life3;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        life1 = GameObject.FindGameObjectWithTag("Life 1");
        life2 = GameObject.FindGameObjectWithTag("Life 2");
        life3 = GameObject.FindGameObjectWithTag("Life 3");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdAlive == true)
        {
            BirdBody.velocity = Vector2.up * FlapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Pipe")
        {
            if (life1.activeInHierarchy == true)
            {
                life1.SetActive(false);
            }
            else if (life2.activeInHierarchy == true)
            {
                life2.SetActive(false);
            }
            else
            {
                logic.GameOver();
                BirdAlive = false;
            }
            
            
        }
        else if (collision.gameObject.tag == "Dead Zone")
        {
            logic.GameOver();
            BirdAlive = false;
        }
        

    }
}

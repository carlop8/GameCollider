using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bosshealth : MonoBehaviour

{
    public float health;
    public float deathhealth;
    void Update()
    {
        if (health == deathhealth)
        {//on death load next scene
            Destroy(gameObject);
            SceneManager.LoadScene("beach zone");
        }
        if(health == 1)
        {//moves boss depending on health 
            
            transform.position =  Vector3.MoveTowards(transform.position,new Vector3(110,168,209),1);
        }
        if (health == 2)
        {

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(113, 66, 209),1);
        }
        if (health == 3)
        {

            transform.position = Vector3.MoveTowards(transform.position,new Vector3(-123, 160, 209),1);
        }
        if (health == 4)
        {

            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-123, 66, 209),1);
        }
    }
    void OnTriggerEnter(Collider col)
    {//adds incrament depending on colliding object
        if (col.gameObject.tag == "collisionblockon")
            health += 1;
            
    }
}

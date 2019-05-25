using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossfireandmovementscript : MonoBehaviour
{
    public float speed;
    public float stopdist;
    public float retreatdist;
    public Transform player;
    public GameObject projectile;
    private float timebtwshots;
    public float starttimebtwshots;
    public float space;
    void Start()
    {//used to locate player
        player = GameObject.FindGameObjectWithTag("Player").transform;
	//used for fire rate
        timebtwshots = starttimebtwshots;
    }

    void Update()
    {
//enemy will move away if
        if (Vector3.Distance(transform.position, player.position) < retreatdist)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        if (Vector3.Distance(transform.position, player.position) < space)
            if (timebtwshots <= 0)
            {
//projectile is made once in range
                Instantiate(projectile, transform.position, Quaternion.Euler(0, 180, 0));
                timebtwshots = starttimebtwshots;
            }
            else
            {
                timebtwshots -= Time.deltaTime;
            }
    }
}

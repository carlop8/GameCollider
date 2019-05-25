using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchonlocation : MonoBehaviour
{
    public GameObject Top_Camera;
    public GameObject Angeld_Camera;

    public int cammode;

    void OnTriggerEnter(Collider col)
    {//switches camera view on collision
        
        Top_Camera.SetActive(true);
        Angeld_Camera.SetActive(false);
            }

            // Update is called once per frame
            void Update()
    {
        


    }
}

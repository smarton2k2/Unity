using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_pickup : MonoBehaviour
{
    public int ammoAmount = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag =="Player")
        {   
            
            Player_controller.instance.CurrentAmmo += ammoAmount;
            Destroy(gameObject);
            Player_controller.instance.updateAmmoUI();
        }    
        //Debug.Log("Working");
    }
}

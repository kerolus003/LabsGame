using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normalwalking : Enemies
{
    // Start is called before the first frame update
    void Start()
    {
      sr=GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sr.filpX==true){
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed,this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else{
          this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed,this.GetComponent<Rigidbody2D>().velocity.y);

        }
        
    }

    void OnTriggerEnter2D(Coilder2D other){

        if(other.tag == "Player"){

            FindObjectOfType<PlayerStats>.TakeDamage(damage);
            Flip();
        }
    }
}

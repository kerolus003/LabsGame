using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      sr = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(isImmune==true)
        {
            SpriteFilcker();
            isImmunityTime=isImmunityTime+Time.deltaTime;
            if(isImmunityTime>= isImmunityDuration)
            {
                isImmune=false;
                sr.enabled=true;
            }


        }
        
    }
   void SpriteFilcker(){
      if(filckerTime < filckerDuration)
      {
        filckerTime = filckerTime + Time.deltaTime;
      }
      else if (filckerTime >= filckerDuration){
        sr.enabled =!(sr.enabled);
        filckerTime =0;
      }

   }
   public void TakeDamage(int damage){
    if (isImmune == false ){
        health = health - damage;
     if (health < 0)
       health = 0;
       if (lives > 0 && health == 0){
        FindObjectOfType<LevelManager>().RespawnPlayer();
            health = 3;
             lives --;
         }    
         else if (lives == 0 && health == 0)
         {
                 Debug. Log("Gameover");
                 Destroy(this.gameObject);

         } 
          Debug.Log("Player Health:" + health.ToString());
          Debug.Log("Player live:" + lives.ToString());
                   

    }
    isImmune=true;
    isImmunityTime=0f;

   }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCol : MonoBehaviour
{
   
   public static int scoreCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter(Collider other) {
            if (other.tag !="Terrain" && other.tag != "Untagged"){
                             Debug.Log(other.tag);

            }
            
     if (other.tag == "gola"){
       scoreCounter++;
       Destroy(other.gameObject);
       Destroy(gameObject);
       textScreen.text = "Score : " + scoreCounter.ToString();
     }
if (other.tag == "Points"){
       scoreCounter = scoreCounter + 5;
       Destroy(other.gameObject);
       Destroy(gameObject);
       textScreen.text = "Score : " + scoreCounter.ToString();
     }


     
    if (other.tag == "Police"){
            Destroy(other.gameObject);
        print("Hello mate, leave me alone");
     }
    //   if (other.tag == "Player"){
    //               textScreen.text="Game Over";
    //               scoreCounter = 0;
    //               GameOver();

    //  }
      if (other.tag == "Terrain"){
       
     }
     if (other.tag == "End"){
       textScreen.text = "Oho Game Over!";
       Application.LoadLevel(1);
     }
      
        
    }

    void GameOver() {
     Application.LoadLevel(1);
 }
}

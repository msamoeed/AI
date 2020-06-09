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
       textScreen.text = "Score : " + scoreCounter.ToString();
     }
     else if (other.tag == "Police"){

        print("Hello mate, leave me alone");
     }
     else if (other.tag == "Player"){
                  textScreen.text="Game Over";
                  scoreCounter = 0;
                  GameOver();

     }
     else if (other.tag == "Terrain"){
       
     }
      
        
    }

    void GameOver() {
     Application.LoadLevel("Menu");
 }
}

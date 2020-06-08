using UnityEngine; 
 using System.Collections;
 
 public class Shoot : MonoBehaviour 
 {
     public float bulletSpeed = 10;
     public Rigidbody bullet;
     
     
     void Fire()
     {
         Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, gameObject.transform.position,Quaternion.identity);
         bulletClone.velocity = gameObject.transform.forward * bulletSpeed;
         
         Destroy(bulletClone.gameObject, 1f);
     }
 
     void Update () 
     {
         if (Input.GetKeyDown(KeyCode.LeftShift)){
               Fire();
             
         }
           
     }
 }
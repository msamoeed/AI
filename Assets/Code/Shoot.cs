using UnityEngine; 
 using System.Collections;
 using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
 public class Shoot : MonoBehaviour 
 {
     
    

    
     public float bulletSpeed = 10;
     public Rigidbody bullet;
        [SerializeField] private AudioClip m_LandSound;           // the sound played when character touches back on ground.

     
               private AudioSource m_AudioSource;


    bool m_Play;
    bool m_ToggleChange;

     
     void Fire()
     {
         Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, gameObject.transform.position,Quaternion.identity);
         bulletClone.velocity = gameObject.transform.forward * bulletSpeed;
         
         Destroy(bulletClone.gameObject, 1f);
         PlayLandingSound();
     }

       private void PlayLandingSound()
        {
            m_AudioSource.clip = m_LandSound;
            m_AudioSource.Play();
        }
 
     void Update () 
     {
         if (Input.GetKeyDown(KeyCode.LeftShift)){
             
               Fire();
                
           
       
             
         }
           
     }

    
    void Start()
    {
                    m_AudioSource = GetComponent<AudioSource>();

    }

     
 }
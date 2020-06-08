using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScreen : MonoBehaviour
{

        Text textOnScreen;
        public static string text="";


    // Start is called before the first frame update
    void Start()
    {
        textOnScreen = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textOnScreen.text = text;
    }
}

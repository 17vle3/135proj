#if UNITY_EDITOR
 using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    //public float speed = 0.02f;
    //public float jump = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<CharacterController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = transform.position + new Vector3(0, 0, speed * -1);
        //GetComponent<CharacterController>().enabled = true;


        //if (transform.position.y== -0.2f && Input.GetKeyDown(KeyCode.UpArrow)) { 
        //    transform.position = transform.position + new Vector3(0, jump, 0);
        //}
        if (Input.GetKeyDown("escape"))
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                        Application.Quit();
            #endif
        }

    }
}


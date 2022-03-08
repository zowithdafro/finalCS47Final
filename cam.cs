using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;


public class cam : NetworkBehaviour
{
    private float distance = 30.0f;
        private Transform lookAt;
    private Vector3 offset;

    private float yOffset = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        lookAt = this.transform;
        offset = new Vector3(0, yOffset+13, -1f * distance-10);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "film" || SceneManager.GetActiveScene().name == "muse" || SceneManager.GetActiveScene().name == "lobby" || SceneManager.GetActiveScene().name == "writing" || SceneManager.GetActiveScene().name == "music"){
            if (isLocalPlayer)
                {
                    GameObject.Find("Main Camera").gameObject.transform.position = lookAt.position + offset;
                    GameObject.Find("Main Camera").gameObject.transform.LookAt(lookAt);
                    Camera.main.transform.rotation = Quaternion.Euler(10,0,0);
                    //GameObject.Find("Main Camera").gameObject.transform.parent = this.transform;
                }
            }
    }
}

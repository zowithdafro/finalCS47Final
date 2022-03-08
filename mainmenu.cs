using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public GameObject levelButtonPrefab;
    public GameObject head;
    private Material[] mat;


    public GameObject levelButtonContainer;
    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;
    public GameObject hi;

    private  const float CAMERA_TRANSITION_SPEED = 3.0f;
    GameObject customization;
    GameObject movement;
    GameObject Canvas12;

    private void Start(){
        
        cameraTransform = Camera.main.transform;
        customization = GameObject.Find("Canvas1/customization");
        Canvas12 = GameObject.Find("Canvas1");
        movement = GameObject.Find("Canvas1/movement");
        
    }

    private void Update(){
        if(cameraDesiredLookAt != null){
             cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, cameraDesiredLookAt.rotation, CAMERA_TRANSITION_SPEED * Time.deltaTime);
        }
    }

    public void LoadLevel(string sceneName){
        SceneManager.LoadScene(sceneName);
        /*
        if(Canvas12==null)
        {
            
            if(sceneName == "proj"){
            customization = GameObject.Find("Canvas1/customization");
            Canvas12 = GameObject.Find("Canvas1");
            movement = GameObject.Find("Canvas1/movement");
            customization.SetActive(false);
            movement.SetActive(true);
        }
        if(sceneName == "lobby"){
            customization = GameObject.Find("Canvas1/customization");
            Canvas12 = GameObject.Find("Canvas1");
            movement = GameObject.Find("Canvas1/movement");
            customization.SetActive(true);
            movement.SetActive(false);
        }*/

        }
        
        public void LookAtMenu(Transform menuTransform){
        cameraDesiredLookAt = menuTransform;
    }

}
    

    




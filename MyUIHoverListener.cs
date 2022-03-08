using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

 
 public class MyUIHoverListener : MonoBehaviour
 {

    private bool _isTouching;
     public bool isUIOverride { get; private set; }
     private bool i = false;

     private void Awake(){
         #if UNITY_EDITOR
            i = true;
        #endif
     }
     
 
     void Update()
     {
         // It will turn true if hovering any UI Elements
            if(i == true){
                isUIOverride = EventSystem.current.IsPointerOverGameObject();
            }else{
                isUIOverride =EventSystem.current.currentSelectedGameObject;
            }
                


          
        
         

    
     }

     
     
     

     
 }
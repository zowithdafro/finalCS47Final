using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myface : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject g;
    public GameObject head;
    void Start()
    {
        
        if(GameObject.Find("/Switch")!=null){

            g = GameObject.Find("/Switch");
            int index = g.GetComponent<customcolor>().currFace;
            Debug.Log(index);
            if(index == 0){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 1").GetComponent<SkinnedMeshRenderer>().material;
            }else if(index == 1){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 2").GetComponent<SkinnedMeshRenderer>().material;
            }else if(index == 2){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 3").GetComponent<SkinnedMeshRenderer>().material;
            }else if(index == 3){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 4").GetComponent<SkinnedMeshRenderer>().material;
            }else if(index == 4){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 5").GetComponent<SkinnedMeshRenderer>().material;
            }else if(index == 5){
                head.GetComponent<SkinnedMeshRenderer>().materials[2] = 
                GameObject.Find("/fin 2/New Material 6").GetComponent<SkinnedMeshRenderer>().material;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

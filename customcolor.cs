using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class customcolor : MonoBehaviour
{
    public Color[] headColors;
    public Material headColor;

    public Color[] hairColors;
    public Material hairColor;

    public Color[] shirtColors;
    public Material shirtColor;

    public Color[] pantsColors;
    public Material pantsColor;

    public int currShirt;
    public int currPant;
    public int currFace;
    public int currMouth;

    public Material[] materials1;
    //public Material material;
     //in the editor this is what you would set as the object you wan't to change
    public GameObject objects;
     //public Renderer rend;

    public Material[] mmaterials1;
    public GameObject[] mmaterialsobjs = new GameObject[6];
    public Material[] mmaterialsskins;
    public Material[] mats;
    private GameObject person;
    private GameObject face;

    //public Material material;
     //in the editor this is what you would set as the object you wan't to change

    // Start is called before the first frame update
    void Start()
    {
        //person = GameObject.Find("fin 2 1");
        //face=GameObject.Find("fin 2 1/Head");
        //objects = face;
        //mats = objects.GetComponent<SkinnedMeshRenderer>().materials;
    }

    // Update is called once per frame
    void Update()
    {

    }
/*
    public void changeFace(){
        if(currFace == materials1.Length - 1){
            currFace = 0;
        }else{
            currFace++;
        }
        mats[2] = materials1[currFace];
        mats[0] = headColor;
        mats[1] = mmaterials1[currMouth];
        face.GetComponent<SkinnedMeshRenderer>().materials = mats;

    }

    public void changeFaceBack(){
        if(currFace == 0){
            currFace = materials1.Length - 1;
        }else{
            currFace--;
        }
        mats[2] = materials1[currFace];
        mats[0] = headColor;
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;

    }*/
    public void changeHairColor(int colorIndex){
        hairColor.color = hairColors[colorIndex];
    }

/*
    public void changeMouth(){
        if(currMouth == 0){
            currMouth = mmaterials1.Length - 1;
        }else{
            currMouth--;
        }
        mats[1] = mmaterials1[currMouth];
        mats[0] = headColor;
        mats[2] = materials1[currFace];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;

    }

    public void changeMouthBack(){
        Material[] mats = objects.GetComponent<SkinnedMeshRenderer>().materials;
        Debug.Log(mats[2].name);
        if(currMouth == 0){
            currMouth = mmaterials1.Length - 1;
        }else{
            currMouth--;
        }
        mats[1] = mmaterials1[currMouth];
        mats[2] = materials1[currFace];
        mats[0] = headColor;
        face.GetComponent<SkinnedMeshRenderer>().materials = mats;

    }*/



    public void changeHeadColor(int colorIndex){
        headColor.color = headColors[colorIndex];
        mats[0] = headColor;
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
    }

    public void changeShirtColor(int colorIndex){
        shirtColor.color = shirtColors[colorIndex];
    }

    public void changeShirtColor1(){

        if(currShirt == shirtColors.Length - 1){
            currShirt = 0;
        }else{
            currShirt++;
        }
        shirtColor.color = shirtColors[currShirt];
    }

    public void changeShirtColor2(){

        if(currShirt == 0){
            currShirt = shirtColors.Length - 1;
        }else{
            currShirt--;
        }
           shirtColor.color = shirtColors[currShirt];

    }

    public void changePantColor1(){

        if(currPant == pantsColors.Length - 1){
            currPant = 0;
        }else{
            currPant++;
        }
        pantsColor.color = pantsColors[currPant];
    }

    public void changePantColor2(){

        if(currPant == 0){
            currPant = pantsColors.Length - 1;
        }else{
            currPant--;
        }
           pantsColor.color = pantsColors[currPant];

    }

    public void changePantsColor(int colorIndex){
        pantsColor.color = pantsColors[colorIndex];

    }
   
}

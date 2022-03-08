using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using UnityEngine.UI;

public class customize1 : NetworkBehaviour
{

    public GameObject[] hairs;
    public GameObject[] hairss;
    public Material[] mats;
        public Material[] shmats;

    public Material[] materials1;
    public Material[] mmaterials1;
    private GameObject[] childss;
    public Material headColor;
    public GameObject legs;
    public GameObject pants;

    public GameObject ears;
    public GameObject shirthand;





    //public NetworkIdentity item;


    private Button myButton;
    
    private GameObject childs;

    public bool turn;
    public int set;
    public GameObject face1;
    public int open = 0;

    
    public GameObject face;
    [SyncVar]
    public int currHair;
    [SyncVar]
    public int currFace;
    [SyncVar]
    public int currMouth;







    public Material[] headColors;
    //public Material headColor;

    public Material[] hairColors;
    public Material hairColor;

    public Material[] shirtColors;
    public Material shirtColor;

    public Material[] pantsColors;
    public Material pantsColor;

    [SyncVar]
    public int currShirt;
    [SyncVar]
    public int currPant;
    [SyncVar]
    public int currSkin;
    [SyncVar]
    public int currHairColor;



    // Start is called before the first frame update
    void Start()
    {
        //item.AssignClientAuthority(connectionToClient); 

       //mats = face.GetComponent<SkinnedMeshRenderer>().materials;
       // face = this.transform.Find( "Head" ).gameObject;
        legs = this.transform.Find( "Circle.001" ).gameObject;
        shirthand = this.transform.Find( "chest" ).gameObject;
        ears = this.transform.Find( "Circle" ).gameObject;
        pants = this.transform.Find( "pants" ).gameObject;
       mats = face.GetComponent<SkinnedMeshRenderer>().materials;
       //shmats = shirthand.GetComponent<SkinnedMeshRenderer>().materials;


    }

    // Update is called once per frame
    /*
    public override void OnStartServer(){
        Debug.Log("hii");
        
        
        face = this.transform.Find( "Head" ).gameObject;
        Debug.Log(face.name);
        mats = face.GetComponent<SkinnedMeshRenderer>().materials;

    }
    public override void OnStartClient(){
        
        face = this.transform.Find( "Head" ).gameObject;
        mats = face.GetComponent<SkinnedMeshRenderer>().materials;

    }
*/
    public void setMats(){
        legs = this.transform.Find( "Circle.001" ).gameObject;
        shirthand = this.transform.Find( "chest" ).gameObject;
        ears = this.transform.Find( "Circle" ).gameObject;
        mats = face.GetComponent<SkinnedMeshRenderer>().materials;
        shmats = shirthand.GetComponent<SkinnedMeshRenderer>().materials;


    }
    

    void Update()
    {
        setFace();

        
        
        if(SceneManager.GetActiveScene().name == "startinit"){
            

       // face = this.transform.Find( "Head" ).gameObject;
       setMats();
       

       //CmdsetFace();
        
        

        set = 0;
        hairss = new GameObject[11];
        childs = this.transform.Find( "afro" ).gameObject;

        hairss[0]=this.transform.Find( "afro" ).gameObject;
        hairss[1]=this.transform.Find( "boyhair" ).gameObject;
        hairss[2]=this.transform.Find( "boyhair.001" ).gameObject;
        hairss[3]=this.transform.Find( "boyhair.002" ).gameObject;
        hairss[4]=this.transform.Find( "boyhair.003" ).gameObject;
        hairss[5]=this.transform.Find( "boyhair.004" ).gameObject;
        hairss[6]=this.transform.Find( "boyhair.005" ).gameObject;
        hairss[7]=this.transform.Find( "boyhair.006" ).gameObject;
        hairss[8]=this.transform.Find( "boyhair2" ).gameObject;
        hairss[9]=this.transform.Find( "Head.004" ).gameObject;
        hairss[10]=this.transform.Find( "Head.005" ).gameObject;
        hairs = hairss; 
        legs = this.transform.Find( "Circle.001" ).gameObject;
        shirthand = this.transform.Find( "chest" ).gameObject;
        ears = this.transform.Find( "Circle" ).gameObject;




        
        }
        else if(SceneManager.GetActiveScene().name == "proj"){


            
            

            //mats[0] = headColor;
            
             //CmdsetFace();


            
                
            if(open == 0){
                

                Button first = GameObject.Find("Canvas1/customization/hair/Button").GetComponent<Button>();
                Button second = GameObject.Find("Canvas1/customization/hair/Button (1)").GetComponent<Button>();
                Button Face1 = GameObject.Find("Canvas1/customization/face/Button").GetComponent<Button>();
                Button FaceBack1 =  GameObject.Find("Canvas1/customization/face/Button (1)").GetComponent<Button>(); 
                Button Mouth1 = GameObject.Find("Canvas1/customization/mouth/Button").GetComponent<Button>();
                Button MouthBack1 =  GameObject.Find("Canvas1/customization/mouth/Button (1)").GetComponent<Button>();


                Button one = GameObject.Find("Canvas1/customization/skintone/Button").GetComponent<Button>();
                Button two = GameObject.Find("Canvas1/customization/skintone/Button (1)").GetComponent<Button>();
                Button three = GameObject.Find("Canvas1/customization/skintone/Button (2)").GetComponent<Button>();
                Button four =  GameObject.Find("Canvas1/customization/skintone/Button (3)").GetComponent<Button>(); 
                Button five = GameObject.Find("Canvas1/customization/skintone/Button (4)").GetComponent<Button>();
                Button six =  GameObject.Find("Canvas1/customization/skintone/Button (5)").GetComponent<Button>();
                Button seven = GameObject.Find("Canvas1/customization/skintone/Button (6)").GetComponent<Button>();
                Button eight =  GameObject.Find("Canvas1/customization/skintone/Button (7)").GetComponent<Button>();

                one.onClick.AddListener(()=> {
                    Cmdone();

                });

                two.onClick.AddListener(()=> {
                    Cmdtwo();

                });

                three.onClick.AddListener(()=> {
                    Cmdthree();

                });

                four.onClick.AddListener(()=> {
                
                    Cmdfour();
                });

                five.onClick.AddListener(()=> {
                
                    Cmdfive();
                });

                six.onClick.AddListener(()=> {
                    Cmdsix();

                });
                seven.onClick.AddListener(()=> {
                
                    Cmdseven();
                });

                eight.onClick.AddListener(()=> {
                    Cmdeight();

                });



                Button three1= GameObject.Find("Canvas1/customization/hair/Button (2)").GetComponent<Button>();
                Button four1 =  GameObject.Find("Canvas1/customization/hair/Button (3)").GetComponent<Button>(); 
                Button five1 = GameObject.Find("Canvas1/customization/hair/Button (4)").GetComponent<Button>();
                Button six1 =  GameObject.Find("Canvas1/customization/hair/Button (5)").GetComponent<Button>();
                Button seven1 = GameObject.Find("Canvas1/customization/hair/Button (6)").GetComponent<Button>();
                Button eight1 =  GameObject.Find("Canvas1/customization/hair/Button (7)").GetComponent<Button>();

                three1.onClick.AddListener(()=> {
                    Cmdthree1();

                });

                four1.onClick.AddListener(()=> {
                    Cmdfour1();

                });

                five1.onClick.AddListener(()=> {
                    Cmdfive1();

                });

                six1.onClick.AddListener(()=> {
                
                    Cmdsix1();
                });

                seven1.onClick.AddListener(()=> {
                
                    Cmdseven1();
                });

                eight1.onClick.AddListener(()=> {
                    Cmdeight1();

                });
                

                Button shirtl = GameObject.Find("Canvas1/customization/shirt/Button").GetComponent<Button>();
                Button shirtr = GameObject.Find("Canvas1/customization/shirt/Button (1)").GetComponent<Button>();

                Button pantl = GameObject.Find("Canvas1/customization/pant/Button").GetComponent<Button>();
                Button pantr = GameObject.Find("Canvas1/customization/pant/Button (1)").GetComponent<Button>();


                shirtl.onClick.AddListener(()=> {
                Cmdshirtchange();

                });

                shirtr.onClick.AddListener(()=> {
                Cmdshirtchangeback();
                });
                

                pantl.onClick.AddListener(()=> {
                    Cmdpantchange();
                });

                pantr.onClick.AddListener(()=> {
                    Cmdpantchangeback();
                });


                first.onClick.AddListener(()=> {
                Cmdhairchange();

                });

                second.onClick.AddListener(()=> {
                Cmdhairchangeback();
                });
                

                Face1.onClick.AddListener(()=> {
                    Cmdfacechange();
                });

                FaceBack1.onClick.AddListener(()=> {
                    Cmdfacechangeback();
                });

                Mouth1.onClick.AddListener(()=> {
                    Cmdmouthchange();

                });

                MouthBack1.onClick.AddListener(()=> {
                    Cmdmouthchangeback();
                });

                open = 1;

            }
                

                


            geo();



            

            
                
            }else{
                open = 0;
            }

            geo();
                
            
            
            
    }



    public void geo (){
            for(int i = 0; i < hairs.Length; i++){
            if(i == currHair){
                
                hairs[i].SetActive(true);
            }else{
                hairs[i].SetActive(false);
            }
                    
                   


            mats[2] = materials1[currFace];
            mats[0] = headColors[currSkin];
            mats[1] = mmaterials1[currMouth];
            shmats[1] = headColors[currSkin];
            shmats[0] = shirtColors[currShirt];

            //shmats[1] =;

            face.GetComponent<SkinnedMeshRenderer>().materials = mats;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
            legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            pants.GetComponent<SkinnedMeshRenderer>().material = pantsColors[currPant];

           // shirtColor.color = shirtColors[currShirt];
           // pantsColor.color = pantsColors[currPant];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials = shmats;


            //headColor = headColors[currSkin];
            //hairColor = hairColors[currHairColor];

            
          }

    

            
     /*else{
           
               if(!isLocalPlayer)
            {
            for(int i = 0; i < hairs.Length; i++){
                if(i == currHair){
                    hairs[i].SetActive(true);
                }else{
                    hairs[i].SetActive(false);
                }

        // or u can use childB.renderer.enabled=false; if u just want to hide it
            }*/


        }

    public void setFace(){
        
       face.GetComponent<SkinnedMeshRenderer>().materials = mats;

    }



[Command]
public void Cmdshirtchange(){
    if(currShirt == shirtColors.Length - 1){
            currShirt = 0;
        }else{
            currShirt++;
        }
            shmats[0] = shirtColors[currShirt];

        }



[Command]
public void Cmdshirtchangeback(){
    if(currShirt == 0){
            currShirt = shirtColors.Length - 1;
        }else{
            currShirt--;
        }
            shmats[0] = shirtColors[currShirt];
                }
[Command]
public void Cmdpantchange(){
    if(currPant == pantsColors.Length - 1){
            currPant = 0;
        }else{
            currPant++;
        }
        pants.GetComponent<SkinnedMeshRenderer>().material = pantsColors[currPant];
                }

[Command]
public void Cmdpantchangeback(){
    if(currPant == 0){
            currPant = pantsColors.Length - 1;
        }else{
            currPant--;
        }
           pants.GetComponent<SkinnedMeshRenderer>().material  = pantsColors[currPant];

                   //  setFace();
                }




[Command]
public void Cmdhairchange(){
    if(currHair == hairs.Length - 1){
                currHair = 0;
                }else{
                currHair++;
                }

            }



[Command]
public void Cmdhairchangeback(){
    if(currHair == 0){
                    currHair = hairs.Length - 1;
                }else{
                    currHair--;
                }
                }
[Command]
public void Cmdfacechange(){
    if(currFace == materials1.Length - 1){
                        currFace = 0;
                    }else{
                        currFace++;
                    }
                    mats[2] = materials1[currFace];
                    mats[0] = headColors[currSkin];
                    mats[1] = mmaterials1[currMouth];
                   // setFace();
                }
[Command]
public void Cmdfacechangeback(){
   if(currFace == 0){
                        currFace = materials1.Length - 1;
                    }else{
                        currFace--;
                    }
                    mats[2] = materials1[currFace];
                    mats[0] = headColors[currSkin];
                    mats[1] = mmaterials1[currMouth];

                   //  setFace();
                }


     [Command]
public void Cmdmouthchange(){
    if(currMouth == 0){
                        currMouth = mmaterials1.Length - 1;
                    }else{
                        currMouth--;
                    }
                    mats[1] = mmaterials1[currMouth];
                    mats[0] = headColors[currSkin];
                    mats[2] = materials1[currFace];

                  //   setFace();
                }
[Command]
public void Cmdmouthchangeback(){
   if(currMouth == 0){
                        currMouth = mmaterials1.Length - 1;
                    }else{
                        currMouth--;
                    }
                    mats[1] = mmaterials1[currMouth];
                    mats[2] = materials1[currFace];
                    mats[0] = headColors[currSkin];
                  //   setFace();
                }           


                [Command]
                public void Cmdthree1(){
                    currHairColor = 0;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }
                [Command]
                public void Cmdfour1(){
                    currHairColor = 1;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }
                [Command]
                public void Cmdfive1(){
                    currHairColor = 2;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }
                [Command]
                public void Cmdsix1(){
                    currHairColor = 3;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }
                [Command]
                public void Cmdseven1(){
                    currHairColor = 4;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }
                [Command]
                public void Cmdeight1(){
                    currHairColor = 5;
            hairs[currHair].GetComponent<SkinnedMeshRenderer>().material = hairColors[currHairColor];
                }


                [Command]
                public void Cmdone(){
                    currSkin = 0;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;

        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdtwo(){
                    currSkin = 1;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdthree(){
                    currSkin = 2;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdfour(){
                    currSkin = 3;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdfive(){
                    currSkin =4;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdsix(){
                    currSkin = 5;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdseven(){
                    currSkin = 6;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }
                [Command]
                public void Cmdeight(){
                    currSkin = 7;
                    headColor = headColors[currSkin];
                    shmats[1] = headColors[currSkin];
        mats[0] = headColors[currSkin];
        mats[2] = materials1[currFace];
        mats[1] = mmaterials1[currMouth];

        face.GetComponent<SkinnedMeshRenderer>().materials = mats;
        legs.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            ears.GetComponent<SkinnedMeshRenderer>().material = headColors[currSkin];
            shirthand.GetComponent<SkinnedMeshRenderer>().materials[1] = headColors[currSkin];
                }


/*
public void Cmdfacechange1(){
    if(currFace1 == materials1.Length - 1){
                        currFace1 = 0;
                    }else{
                        currFace1++;
                    }
                    mats[2] = materials1[currFace];
                    mats[0] = headColor;
                    mats[1] = mmaterials1[currMouth];
                   // setFace();
                }
public void Cmdfacechangeback1(){
   if(currFace == 0){
                        currFace = materials1.Length - 1;
                    }else{
                        currFace--;
                    }
                    mats[2] = materials1[currFace];
                    mats[0] = headColor;
                    mats[1] = mmaterials1[currMouth];

                   //  setFace();
                }


public void Cmdmouthchange1(){
    if(currMouth == 0){
                        currMouth = mmaterials1.Length - 1;
                    }else{
                        currMouth--;
                    }
                    mats[1] = mmaterials1[currMouth];
                    mats[0] = headColor;
                    mats[2] = materials1[currFace];

                  //   setFace();
                }
public void Cmdmouthchangeback1(){
   if(currMouth == 0){
                        currMouth = mmaterials1.Length - 1;
                    }else{
                        currMouth--;
                    }
                    mats[1] = mmaterials1[currMouth];
                    mats[2] = materials1[currFace];
                    mats[0] = headColor;
                  //   setFace();
                }     
*/
            
}
        
    








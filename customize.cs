using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class customize : MonoBehaviour
{
    public GameObject[] hairs;
    public GameObject[] hairss;

    private int currHair;
    public GameObject char1;
    public GameObject childs;
    public GameObject[] childss;

    public bool turn;





    // Start is called before the first frame update
    void Start()
    {
        char1 = GameObject.Find("fin 2 1");
        hairss = new GameObject[11];
        turn = true;
        childs = char1.transform.Find( "afro" ).gameObject;

        hairss[0]=char1.transform.Find( "afro" ).gameObject;
        hairss[1]=char1.transform.Find( "boyhair" ).gameObject;
        hairss[2]=char1.transform.Find( "boyhair.001" ).gameObject;
        hairss[3]=char1.transform.Find( "boyhair.002" ).gameObject;
        hairss[4]=char1.transform.Find( "boyhair.003" ).gameObject;
        hairss[5]=char1.transform.Find( "boyhair.004" ).gameObject;
        hairss[6]=char1.transform.Find( "boyhair.005" ).gameObject;
        hairss[7]=char1.transform.Find( "boyhair.006" ).gameObject;
        hairss[8]=char1.transform.Find( "boyhair2" ).gameObject;
        hairss[9]=char1.transform.Find( "Head.004" ).gameObject;
        hairss[10]=char1.transform.Find( "Head.005" ).gameObject;
        hairs = hairss; 
        /*
        hairss[0]=GameObject.Find("fin 2 1/afro");
        hairss[1]=GameObject.Find("fin 2 1/boyhair");
        hairss[2]=GameObject.Find("fin 2 1/boyhair.001");
        hairss[3]=GameObject.Find("fin 2 1/boyhair.002");
        hairss[4]=GameObject.Find("fin 2 1/boyhair.003");
        hairss[5]=GameObject.Find("fin 2 1/boyhair.004");
        hairss[6]=GameObject.Find("fin 2 1/boyhair.005");
        hairss[7]=GameObject.Find("fin 2 1/boyhair.006");
        hairss[8]=GameObject.Find("fin 2 1/boyhair2");
        hairss[9]=GameObject.Find("fin 2 1/Head.004");
        hairss[10]=GameObject.Find("fin 2 1/Head.005");
        hairs = hairss;*/
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < hairs.Length; i++){
            if(i == currHair){
                hairs[i].SetActive(true);
            }else{
                hairs[i].SetActive(false);
            }

        }
    }
        public void switchHair(){
        if(currHair == hairs.Length - 1){
            currHair = 0;
        }else{
            currHair++;
        }
    }

    public void switchHairBack(){
        if(currHair == 0){
            currHair = hairs.Length - 1;
        }else{
            currHair--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{

   public GameObject objects;
    public Material blinkFace;
    public Material mee;
    public Material[] mats;
        public Material skincolor;
    public Material mouth;

   public float timeRemaining = 3;
   public float hi = -1;

   void Start(){
      mats = objects.GetComponent<SkinnedMeshRenderer>().materials;
      mee = mats[2];
      skincolor =mats[0];
      mouth = mats[1];
      hi =-1;
      timeRemaining = 5;
   }

    void Update()
    {


        if(hi==-1){
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

            mats = objects.GetComponent<SkinnedMeshRenderer>().materials;

                if(mats[0]!= skincolor){
                skincolor=mats[0];
            }
            if(mats[1]!= mouth){
                mouth=mats[1];
            }
            if(mats[2]!= blinkFace && mats[2] != mee){
                mee=mats[2];
            }
            }else{
                mats[2] = blinkFace;
                objects.GetComponent<SkinnedMeshRenderer>().materials = mats;
                
                timeRemaining=-1;
                hi = .4f;
            }
        }
        if(timeRemaining ==-1){

            if (hi > 0)
            {
                hi -= Time.deltaTime;
            }else{
            
            
                mats[2] = mee;
                mats[0] = skincolor;
                mats[1] = mouth;
                objects.GetComponent<SkinnedMeshRenderer>().materials = mats;
                timeRemaining = 5;
                hi=-1;


            }
    }
        }
        
}

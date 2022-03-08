using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatechar : MonoBehaviour
{
    private GameObject hi;
    public bool rot = false;
    public bool rotl = false;

    public float angle;
    // Start is called before the first frame update

    public void Start()
    {
        
        
    }

    void Update()
    {

        if(rot == true){

            this.transform.Rotate(0, angle + 1, 0);

        }if(rotl == true){
            this.transform.Rotate(0, angle - 1, 0);

        }

    }

    public void down()
    {
        rot=true;
    }
    public void up()
    {
        rot=false;
    }

    public void downl()
    {
        rotl=true;
    }
    public void upl()
    {
        rotl=false;
    }
    
    
}

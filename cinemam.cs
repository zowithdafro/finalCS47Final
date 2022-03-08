using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Cinemachine;

public class cinemam : NetworkBehaviour
{
            [SerializeField] private CinemachineFreeLook freelook;

    // Start is called before the first frame update
    void Start()
    {
        if(isLocalPlayer){
            freelook = CinemachineFreeLook.FindObjectOfType<CinemachineFreeLook>();
            //freelook.lookAt = this.GameObject.transform;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

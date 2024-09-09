using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {
    private Transform playerCamTrans;
    
    // Start is called before the first frame update
    void Start() {
        playerCamTrans = Camera.main.gameObject.transform;
    }

    // Update is called once per frame
    void Update() {
        Vector3 lookDir = transform.position - playerCamTrans.position;
        transform.LookAt( transform.position + lookDir );
    }
}

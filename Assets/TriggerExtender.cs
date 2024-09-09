using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TriggerExtender : MonoBehaviour {
    private UnityEvent onTriggerEnter;

    private void OnTriggerEnter( Collider other ) {
        onTriggerEnter?.Invoke();
    }
}

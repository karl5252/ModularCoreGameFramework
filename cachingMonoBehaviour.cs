using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cachingMonoBehaviour : MonoBehaviour
{
    public Transform myTransform;
    public GameObject myGObject;
    public Rigidbody myRBody;

    public bool didInitialized;
    public bool canControl;

    public int id;

    [System.NonSerialized]
    public Vector3 tempVBC;
    [System.NonSerialized]
    public Transform tempTR;

    public virtual void SetId(int anId)
    {

    }
    
}

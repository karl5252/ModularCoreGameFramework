using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInputController : MonoBehaviour
{
    /// <summary>
    /// user inputs
    /// versatile and universal
    /// </summary>
    /// 
    //Directions
    public bool Up;
    public bool Down;
    public bool Left;
    public bool Right;

    public float horz;
    public float vert;

    //action or fire
    public bool Fire1;

    //weapon or item slots
    public bool Slot1;
    public bool Slot2;
    public bool Slot3;
    public bool Slot4;
    public bool Slot5;
    public bool Slot6;
    public bool Slot7;
    public bool Slot8;
    public bool Slot9;

    public bool shouldRespawn;
    public Vector3 TEMPVec3;
    private Vector3 zeroVector = new Vector3(0, 0, 0);

    public virtual void CheckInput()
    {
        //catch inputs
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Horizontal");
    }
    public virtual float GetHorizontal()
    {
        return horz;
    }
    public virtual float GetVertical()
    {
        return vert;
    }
    public virtual bool GetFire()
    {
        return Fire1;
    }
    public bool GetRespawn()
    {
        return shouldRespawn;
    }

    public virtual Vector3 GetMovementDirection()
    {
        // unused vector always 0,0,0
        TEMPVec3 = zeroVector;

        if (Left || Right)
        {
            TEMPVec3.x = horz;
        }
        if (Up || Down)
        {
            TEMPVec3.y = vert;
        }
        return TEMPVec3;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int speed = 30;
    public int gear = 5;

    public int TotalSpeed
    {
        get { return speed * gear; }
    }
}

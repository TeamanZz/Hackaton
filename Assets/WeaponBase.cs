using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    public Transform muzzleShootPoint;
    public Transform muzzleShootPointSecond; //Необходимо чтобы задавать направление движения пули

    public float bulletStartSpeed;
    public float gravityInfluece;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pistol : WeaponBase
{
    public Transform bulletPreafab;
    public Transform hands;

    public Vector3 startHandsPosition;

    private void Awake()
    {
        startHandsPosition = hands.localPosition;
    }

    private void Update()
    {
        // if (hands.transform.localPosition != startHandsPosition)
        // {
        //     hand
        // }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        var rot = Quaternion.LookRotation(muzzleShootPointSecond.position - muzzleShootPoint.position);
        var newBullet = Instantiate(bulletPreafab, muzzleShootPoint.position, Quaternion.Euler(rot.eulerAngles.x + 90, rot.eulerAngles.y, rot.eulerAngles.z));
        var bulletRigidbody = newBullet.GetComponent<Rigidbody>();
        bulletRigidbody.AddForce((muzzleShootPointSecond.position - muzzleShootPoint.position).normalized * bulletStartSpeed, ForceMode.Impulse);
        bulletRigidbody.AddRelativeForce(Vector3.down * gravityInfluece * 10, ForceMode.Acceleration);
        Camera.main.DOShakePosition(0.3f, 0.03f, 0, 10).SetEase(Ease.InOutBack);
        hands.DOShakePosition(0.2f, 0.05f, 0, 20).SetEase(Ease.InOutBack);
        hands.DOShakeRotation(0.2f, 5, 0, 20).SetEase(Ease.InOutBack);
    }
}
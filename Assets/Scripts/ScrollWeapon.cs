using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWeapon : MonoBehaviour {

    public GameObject Weapon1;
    public GameObject Weapon2;
    public int MaxWeapon = 2;
    private int ScrolInt;
 
    void Update()
    {
        if (ScrolInt == 0)
        {
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
        }
        if (ScrolInt == 1)
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(true);
        }
        if (ScrolInt <= 0)
        {
            ScrolInt = 0;
        }
        if (ScrolInt >= MaxWeapon)
        {
            ScrolInt = MaxWeapon;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            ScrolInt += 1;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            ScrolInt -= 1;
        }
    }
}

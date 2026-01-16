using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] List<Weapon> weapon;
    int count = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
           
        }

        if (Input.GetMouseButtonDown(0))
        {
            weapon[count].Attack();
        }

    }

    void Swap()
    {
        count++;
        if (count > 2)
        {
            count = 0;
        }
        for (int i = 0; i < 3; i++)
        {
            weapon[i].gameObject.SetActive(false);
        }
        weapon[count].gameObject.SetActive(true);
    }
}

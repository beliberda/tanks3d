using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagmentTank : MonoBehaviour
{
    public GeneralVars klass_Obshih_Peremennih;


    private void Update()
    {
        Otslejivanie_Najatiya_Strelok();
    }

    private void Otslejivanie_Najatiya_Strelok()
    {
        if (Input.GetKey(KeyCode.UpArrow) & !Input.GetKey(KeyCode.DownArrow))
        {
            klass_Obshih_Peremennih.Povorot_Verh_Global = true;
        }
        else
        {
            klass_Obshih_Peremennih.Povorot_Verh_Global = false;
        }
        if (Input.GetKey(KeyCode.DownArrow) & !Input.GetKey(KeyCode.UpArrow))
        {
            klass_Obshih_Peremennih.Povorot_Niz_Global = true;
        }
        else
        {
            klass_Obshih_Peremennih.Povorot_Niz_Global = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow) & !Input.GetKey(KeyCode.RightArrow))
        {
            klass_Obshih_Peremennih.Povorot_Levo_Global = true;
        }
        else
        {
            klass_Obshih_Peremennih.Povorot_Levo_Global = false;
        }
        if (Input.GetKey(KeyCode.RightArrow) & !Input.GetKey(KeyCode.LeftArrow))
        {
            klass_Obshih_Peremennih.Povorot_Pravo_Global = true;
        }
        else
        {
            klass_Obshih_Peremennih.Povorot_Pravo_Global = false;
        }
        if (!Input.GetKey(KeyCode.RightArrow) & !Input.GetKey(KeyCode.LeftArrow) & !Input.GetKey(KeyCode.DownArrow) & !Input.GetKey(KeyCode.UpArrow))
        {
            klass_Obshih_Peremennih.Povorot_Pravo_Global = false;
            klass_Obshih_Peremennih.Povorot_Levo_Global = false;
            klass_Obshih_Peremennih.Povorot_Verh_Global = false;
            klass_Obshih_Peremennih.Povorot_Niz_Global = false;

        }
    }
}

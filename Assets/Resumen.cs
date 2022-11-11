using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resumen : MonoBehaviour
{
    public void Click()
    {
        if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
    }
}

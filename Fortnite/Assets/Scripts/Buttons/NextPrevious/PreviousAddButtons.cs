using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousAddButtons : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject previousAddButton;

    void OnMouseDown()
    {
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button3.SetActive(true);
    }

    void OnMouseEnter()
    {
        previousAddButton.transform.localScale = new Vector3(0.275f, 1.1f, 1f);
    }

    void OnMouseExit()
    {
        previousAddButton.transform.localScale = new Vector3(0.25f, 1f, 1f);
    }

}

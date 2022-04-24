using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day0318 : MonoBehaviour
{
    public GameObject cube;
    int a = 100;
    int b = 0;
    int c;
    public Color[] mycolor;
    public List<GameObject> list;
    
    void Start()
    {

        Text();
        StartCoroutine(bases());
    }

    void Text()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject a = Instantiate(cube);
                a.transform.position = new Vector3(i, 0, j);
                Debug.Log(a.transform.childCount);
                a.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material.color = mycolor[i];
                list.Add(a);
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetActive(false);
        }
    }

    public void but()
    {
        StartCoroutine(bases());
       
    }
    IEnumerator bases()
    {
        if (list[99].activeSelf == false)
        {
            Debug.Log("생겨라");

            for (int i = 0; i<list.Count; i++)
            {
                yield return new WaitForSeconds(0.1f);
                list[i].SetActive(!list[i].activeSelf);
            }
        }
        else
            Debug.Log("지워라");
        {
           

            for (int i = list.Count-1; i >= 0; i--)
            {
                Debug.Log("지워라");
                yield return new WaitForSeconds(0.1f);
                list[i].SetActive(!list[i].activeSelf);
            }
        }
    }
}

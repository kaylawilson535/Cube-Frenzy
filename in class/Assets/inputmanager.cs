using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputmanager : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject plane;
    // Start is called before the first frame update
    public void PressButton()
    {
        print("button pressing");

        for (int i =0; i <= 50; i++)
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(0, 50), 30, Random.Range(0, 50)), Quaternion.identity);
        }
    }
    public void PressPlaneButton()
    {
        print("button pressing");

        Instantiate(plane, new Vector3(Random.Range(0, 10), 0, Random.Range(0, 10)), Quaternion.identity);
    }


}

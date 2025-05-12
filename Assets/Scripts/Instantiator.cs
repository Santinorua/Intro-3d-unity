using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    public int randomNumber;
    public int min = 0;
    public int max = 2;

    void Start()
    {
        ClonarCubo();
    }

    void Update()
    {

    }

    public void ClonarCubo()
    {
        randomNumber = Random.Range(min, max+1);
        if(randomNumber == 0)
        {
            Instantiate(cubePrefab);
        }
        else if(randomNumber == 1)
        {
            Instantiate(spherePrefab);
        }
        else
        {
            Instantiate(cylinderPrefab);
        }
    }
}

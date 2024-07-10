using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPyramid : MonoBehaviour
{
    public GameObject cube;
    public int amountLevel = 6;
    private int side = 1;
    private int y;


    public void PyramideWithoutInside()
    {
        y = amountLevel;

        for (int i = 1; i < amountLevel; i++)
        {
            side += 2;
            y--;
            
            for (int z = i, w = 0; w < side; w++, z--)
            {
                Instantiate(cube, new Vector3(i, y, z), Quaternion.identity);
                Instantiate(cube, new Vector3(-i, y, z), Quaternion.identity);
            }
                
            for (int x = i - 1, e = 0; e < side - 2; e++, x--)
            {
                Instantiate(cube, new Vector3(x, y, i), Quaternion.identity);
                Instantiate(cube, new Vector3(x, y, -i), Quaternion.identity);
            }
        }
    }

    public void Pyramide()
    {
        y = amountLevel;
        
        for (int i = 1; i < amountLevel; i++)
        {
            side += 2;
            y--;
            for (int x = i, q = 0; q < side; q++, x--)
            {
                for (int z = i, w = 0; w < side; w++, z--)
                {
                    Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
                }
            }

        }
    }

    public void Start()
    {
        Instantiate(cube, new Vector3(0, amountLevel, 0f), Quaternion.identity);
        Pyramide();
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPyramid : MonoBehaviour
{
    public GameObject cube;
    public int amountLevel = 6;

    public void Pyramide()
    {
        for (int i = 1; i < amountLevel; i++)
        {
            int y = amountLevel - i;
            int len = 2 * (i + 1) - 3;

            for (int x = i - len; x < i; x++)
            {
                for (int z = i - len; z < i; z++)
                {
                    Vector3 pos = new Vector3(x, y, z);
                    Instantiate(cube, pos, Quaternion.identity);
                }
            }
        }
    }

    public void Start()
    {
        Pyramide();
    }
}

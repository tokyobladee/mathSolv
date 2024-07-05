using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPyramid : MonoBehaviour
{
    public GameObject cube;
    public int amountLevel = 6;
    private int side = 3;
    private int prevSide = 1;
    private Vector3 startPosition;
    private Vector3 foo;


    public void Pyramide()
    {
        for (int i = 1; i < amountLevel; i++)
        {
            for (int j = 0; j < side; j++)
            {
                for (int k = 0; k < side; k++)
                {
                    Instantiate(cube, foo, Quaternion.identity);
                    foo.z -= 1;
                }

                foo.x -= 1;
            }

            side += 2;
            startPosition.Set(startPosition.x + 1, startPosition.y - 1, startPosition.z + 1);
            foo = startPosition;
        }
    }

    public void Start()
    {
        foo.Set(1, amountLevel - 1, 1);
        startPosition.Set(cube.transform.position.x + 1, amountLevel - 1, cube.transform.position.z + 1);
        Instantiate(cube, foo, Quaternion.identity);
        Pyramide();
    }
}

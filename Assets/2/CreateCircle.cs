using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateCircle : MonoBehaviour
{
        public GameObject pointGO;
        private float currentRadiant;
        private float Radiant;
        public int countPoints = 4;
        public float radius = 1f;
        private Vector3 point;

        private void Circle()
        {
                if (countPoints < 0)
                        return;

                for (int i = 0; i < countPoints; i++)
                {
                        point.x = radius * Mathf.Cos(currentRadiant);
                        point.y = radius * Mathf.Sin(currentRadiant);
                        point.z = 0;
                        Instantiate(pointGO, point, Quaternion.identity);
                        currentRadiant += Radiant;
                }
        }

        private void Start()
        { 
                Radiant = 2 * Mathf.PI / countPoints;
                currentRadiant = 0;
                Circle();
        }
}

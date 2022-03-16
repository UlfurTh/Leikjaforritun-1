// Þessi skrifta lætur collectibles snúast í hringi
// Sæki allt sem þarf
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ræsi skriftuna
public class Rotator : MonoBehaviour
{

    // Update gerist einu sinni í hverjum ramma.
    void Update()
    {
        // Hérna sný ég peningnum en passa að láta það gerast ekki og hratt með deltaTime
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

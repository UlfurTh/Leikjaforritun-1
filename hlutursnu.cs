// Þessi kóði hefur þann tilgang að snúa hlutum sem hann er tengdur við
// Sæki allt það nauðsynlega
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ræsi forritið
public class hlutursnu : MonoBehaviour
{
    void Update()
    {
        // Hér er "actual" snúningurinn
        transform.Rotate(new Vector3(0,80,0) * Time.deltaTime);
    }
}

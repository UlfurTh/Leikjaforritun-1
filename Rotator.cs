// �essi skrifta l�tur collectibles sn�ast � hringi
// S�ki allt sem �arf
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// R�si skriftuna
public class Rotator : MonoBehaviour
{

    // Update gerist einu sinni � hverjum ramma.
    void Update()
    {
        // H�rna sn� �g peningnum en passa a� l�ta �a� gerast ekki og hratt me� deltaTime
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

// �essi skrifta er til a� sta�setja myndav�lina � r�ttan sta�.
// S�ki allt sem �arf til a� l�ta skriftuna virka.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// H�r hefst skriftan
public class CameraController : MonoBehaviour
{
    // Stofna player game Objecti� fyrir sta�setningu og m�tlykill (offset) Vector3 .
    public GameObject player;
    private Vector3 offset;


    // H�rna koma allar ��r a�ger�ir sem eru ger�ar � byrjun forritsins.
    void Start()
    {
        // H�rna komum vi� myndav�linni fyrir � byrjun leiks me� �v� a� reikna �t sta�setningu "player".
        offset = transform.position - player.transform.position;
    }

    // H�rna koma ��r a�ger�ir sem gerast of � sek�ndu � me�an forriti� er � gangi. Nota "Late" � undan update til a� l�ta forriti� gera �a� s��ast.
    void LateUpdate()
    {
        // R�tt ��ur en a� skj�rinn s�nir hreyfingu player-ins �� endustillir skriftan sta�setningu myndav�larinnar aftur fyrir ofan "player" game object.
        // Svo endurstillir �etta bara sta�setningu, ekki sn�ning, �ar sem �etta er k�la ekki kassi.
        transform.position = player.transform.position + offset;
    }
}

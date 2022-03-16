// Þessi skrifta er til að staðsetja myndavélina á réttan stað.
// Sæki allt sem þarf til að láta skriftuna virka.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hér hefst skriftan
public class CameraController : MonoBehaviour
{
    // Stofna player game Objectið fyrir staðsetningu og mótlykill (offset) Vector3 .
    public GameObject player;
    private Vector3 offset;


    // Hérna koma allar þær aðgerðir sem eru gerðar í byrjun forritsins.
    void Start()
    {
        // Hérna komum við myndavélinni fyrir í byrjun leiks með því að reikna út staðsetningu "player".
        offset = transform.position - player.transform.position;
    }

    // Hérna koma þær aðgerðir sem gerast of á sekúndu á meðan forritið er í gangi. Nota "Late" á undan update til að láta forritið gera það síðast.
    void LateUpdate()
    {
        // Rétt áður en að skjárinn sýnir hreyfingu player-ins þá endustillir skriftan staðsetningu myndavélarinnar aftur fyrir ofan "player" game object.
        // Svo endurstillir þetta bara staðsetningu, ekki snúning, þar sem þetta er kúla ekki kassi.
        transform.position = player.transform.position + offset;
    }
}

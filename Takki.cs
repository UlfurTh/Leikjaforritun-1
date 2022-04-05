// Þessi skrifta gegnir því hlutverki að skipta um senu þegar að réttum kröfum hefur verið uppfyllt
// Sæki allt það nauðsynlega
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Ræsi kóðann
public class Takki : MonoBehaviour
{
    public void Byrja()
    {
        // Hérna load-a ég næstu senu
        SceneManager.LoadScene(1);
    }
    public void Endir()
    {
        SceneManager.LoadScene(0);
        PlayerMovment.count = 0;
    }
    
}

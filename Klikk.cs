// Þessi kóði hefur þann tilgang að skipta um senur
// Sæki allt það nauðsynlega
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Hér hefst kóðinn
public class Klikk : MonoBehaviour
{
    public void Byrja()
    {
        // Hér breyti ég senunni
        SceneManager.LoadScene(1);
    }
}

// Þessi skripta gegnir því hlutverki að sýna 
// Sæki allt það nauðsynlega
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipti : MonoBehaviour
{
    void Start()
    {
        // Sýni textann til að byrja
        Debug.Log("byrja");
    }
    private void OnTriggerEnter(Collider other)
    {
        // Slekk á öllum öðrum game objects
        other.gameObject.SetActive(false);
        StartCoroutine(Bida());    
    }
    IEnumerator Bida()
    {
        // Þetta er til að endurræsa... held ég
        yield return new WaitForSeconds(3);
        Endurræsa();
    }
    public void Endurræsa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//næsta sena
    }

}

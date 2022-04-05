// Þessi kóði hefur þann tilgang að sýna (display-a) stigafjölda
// Sæki allt það nauðsynlega
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Hér hefst kóðinn
public class Lokastig : MonoBehaviour
{
    public Text stig;
    // Start is called before the first frame update
    void Start()
    {
        // Hérna tel ég stigin og sýni þau svo
        stig.text = "Stig: " + PlayerMovment.count.ToString();
    }

    
}

// Þessi skrifta stjórnar "player" eða spilaranum
// Sæki allt nauðsynlegt
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

// Hér hefst skriftan
public class PlayerController : MonoBehaviour
{
    // "Declare-a" eða bý til allar breytur sem verða nauðsynlegar seinna í skriftunni
    // Hér eru allar public breytur
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Og hér eru allar private
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    // Munurinn á public og private er sá að public er breytilegt í Unity UI en private er aðeins breytilegt í gengum skriftuna

    // void Start gerist á undan öllu öðru og áður en fyrsti rammin er sýndur
    void Start()
    {
        // Bý til rb og count breyturnar
        rb = GetComponent<Rigidbody>();
        count = 0;

        // Disable-a tímabundið sigurtextann 
        SetCountText();
        winTextObject.SetActive(false);
    }

    // Hér er fallið sem býr til hreyfingar-breyturnar
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Hér er fallið sem tékkar hvort að stigin séu nógu mörg til að vinna leikinn, eða í þessu tilviki, fá sigurtextann.
    void SetCountText()
    {
        // Hér geri ég countText að "Bruh Coins" og bæti síðan á það stig þegar þau koma
        countText.text = "Bruh Coins: " + count.ToString();
        // Klassískt if fall. Ef að stigin eru jafn mörg eða fleiri en 6900 þá gerir það sigurtextann sem "true".
        if(count >= 6900)
        {
            winTextObject.SetActive(true);
        }
    }

    // Munurinn á Update og FixedUpdate er sá að FixedUpdate gerir aðeins aðgerðirnar 60 sinnum á sekúndu.
    private void FixedUpdate()
    {
        // Hér er hreyfingin gerð. Allt inn í vettvangnum (scene) er staðsett með x,y og z ásum og hér er það notað.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
    
    // Hér er fallið sem tékkar á því ef þú snertir gameobject með ákveðin tags
    private void OnTriggerEnter(Collider other)
    {
        // Annað klassískt if fall sem skoðar (comapres) ef það er með sama PickUp fallið 
        if (other.gameObject.CompareTag("PickUp"))
        {
            // Þegar if fallið er ræst, er losað við gameobject, eða það er falið fyrir notendanum. 
            other.gameObject.SetActive(false);
            // Svo er bætt við stigum þegar hluturinn er farinn.
            count = count + 575;

            SetCountText();
        }
 
    }

}
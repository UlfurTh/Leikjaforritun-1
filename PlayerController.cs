// �essi skrifta stj�rnar "player" e�a spilaranum
// S�ki allt nau�synlegt
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

// H�r hefst skriftan
public class PlayerController : MonoBehaviour
{
    // "Declare-a" e�a b� til allar breytur sem ver�a nau�synlegar seinna � skriftunni
    // H�r eru allar public breytur
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Og h�r eru allar private
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    // Munurinn � public og private er s� a� public er breytilegt � Unity UI en private er a�eins breytilegt � gengum skriftuna

    // void Start gerist � undan �llu ��ru og ��ur en fyrsti rammin er s�ndur
    void Start()
    {
        // B� til rb og count breyturnar
        rb = GetComponent<Rigidbody>();
        count = 0;

        // Disable-a t�mabundi� sigurtextann 
        SetCountText();
        winTextObject.SetActive(false);
    }

    // H�r er falli� sem b�r til hreyfingar-breyturnar
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // H�r er falli� sem t�kkar hvort a� stigin s�u n�gu m�rg til a� vinna leikinn, e�a � �essu tilviki, f� sigurtextann.
    void SetCountText()
    {
        // H�r geri �g countText a� "Bruh Coins" og b�ti s��an � �a� stig �egar �au koma
        countText.text = "Bruh Coins: " + count.ToString();
        // Klass�skt if fall. Ef a� stigin eru jafn m�rg e�a fleiri en 6900 �� gerir �a� sigurtextann sem "true".
        if(count >= 6900)
        {
            winTextObject.SetActive(true);
        }
    }

    // Munurinn � Update og FixedUpdate er s� a� FixedUpdate gerir a�eins a�ger�irnar 60 sinnum � sek�ndu.
    private void FixedUpdate()
    {
        // H�r er hreyfingin ger�. Allt inn � vettvangnum (scene) er sta�sett me� x,y og z �sum og h�r er �a� nota�.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
    
    // H�r er falli� sem t�kkar � �v� ef �� snertir gameobject me� �kve�in tags
    private void OnTriggerEnter(Collider other)
    {
        // Anna� klass�skt if fall sem sko�ar (comapres) ef �a� er me� sama PickUp falli� 
        if (other.gameObject.CompareTag("PickUp"))
        {
            // �egar if falli� er r�st, er losa� vi� gameobject, e�a �a� er fali� fyrir notendanum. 
            other.gameObject.SetActive(false);
            // Svo er b�tt vi� stigum �egar hluturinn er farinn.
            count = count + 575;

            SetCountText();
        }
 
    }

}
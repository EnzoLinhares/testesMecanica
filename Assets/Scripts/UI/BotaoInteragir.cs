using UnityEngine;
using TMPro;

public class BotaoInteragir : MonoBehaviour
{
    public GameObject textoInteragir;
    public string tagAlvo = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag (tagAlvo))
        {
            Debug.Log("Entrou");

                
                textoInteragir.SetActive (true);

            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagAlvo))
        {

                textoInteragir.SetActive(false);

            
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
} 

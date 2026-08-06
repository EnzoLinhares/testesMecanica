using UnityEngine;
using TMPro;

public class BotaoInteragir : MonoBehaviour
{
    public GameObject textoInteragir;
    public string tagAlvo = "Player";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag (tagAlvo))
        {
            if (textoInteragir != null) { 
                
                textoInteragir.SetActive (true);

            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (CompareTag(tagAlvo))
        {
            if (textoInteragir != null)
            {

                textoInteragir.SetActive(false);

            }
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

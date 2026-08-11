
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPlayer : MonoBehaviour
{
    public float velocidadeJogador = 8f;
    public InputAction movimentoJogador;
    private Rigidbody2D fisicaJogador;

    Vector2 direcaoJogador;

    private void OnEnable()
    {
        movimentoJogador.Enable();
    }

    private void OnDisable()
    {

        movimentoJogador.Disable();
    }
    void Start()
    {
        fisicaJogador= GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        direcaoJogador = movimentoJogador.ReadValue<Vector2>();
        fisicaJogador.linearVelocity = new Vector2(direcaoJogador.x * velocidadeJogador, fisicaJogador.linearVelocity.y);
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
{
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");

    Vector3 pos = transform.position;
    pos.x = Mathf.Clamp(pos.x, -2.5f, 2.5f); // ajuste conforme tamanho da tela
    pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f);

    Vector2 move = new Vector2(inputX, inputY);
    transform.position = pos + (Vector3)(move * moveSpeed * Time.deltaTime);
}
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float inputX = 0f;

        // Teclado (funciona no Editor/PC)
        if (Application.isEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            inputX = Input.GetAxis("Horizontal");
        }

        // Toque (funciona em dispositivos mobile)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            inputX = touchPos.x > transform.position.x ? 1f : -1f;
        }

        // Movimento
        Vector3 move = new Vector3(inputX * moveSpeed * Time.deltaTime, 0f, 0f);
        transform.Translate(move);

        // Limitar dentro da tela
        float clampedX = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}

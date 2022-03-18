using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;  // Теперь риджидбоди для игрока называется коротко рб

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // ФиксдАпдейтс используется для физики, так юнити считает точнее
    
    void FixedUpdate()
    {
        // Добавили форвард форс
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Тайм дельтатайм используется для того, чтобы сила воздействия на куб была одинакова на всех устройствах)

    if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

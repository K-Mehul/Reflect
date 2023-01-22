using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void Update()
    {
        if (GameManager.Instance.IsTotalEventsComplete)
        {
            transform.position += transform.right * 2.5f * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IInteract>() != null)
        {
            collision.gameObject.GetComponent<IInteract>().Interactables();
        }
    }
}

using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

    
    }

}

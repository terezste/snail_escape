using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(xInput,1).normalized;

        body.linearVelocity = direction * speed;
    }

}

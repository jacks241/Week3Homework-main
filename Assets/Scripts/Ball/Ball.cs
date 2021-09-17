using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched 
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    [SerializeField]
    private float speed = 1.0f;

    private Vector3 currentDirection = Vector3.zero;

    public bool inPlay;
    public Transform paddle;
    private void Awake()
    {
        //currentDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
        currentDirection = new Vector3(Random(), Random(), 0).normalized;
    }
    

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);

        if(collision.gameObject.name == "OutOfBounds (3)")
        {
            inPlay = false;
        }

        if (collision.transform.CompareTag("Piece"))
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        transform.Translate(currentDirection * Time.deltaTime * speed);

        if (!inPlay)
        {
            transform.position = paddle.position;
        }

        if (Input.GetKey(KeyCode.Space) && !inPlay)
        {
            inPlay = true;
            rigidBody.AddForce(Vector2.up * speed);
        }
    }

    private int Random()
    {
        return UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
    }

}//end of code

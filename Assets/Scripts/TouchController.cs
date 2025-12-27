using UnityEngine;

public class TouchController : MonoBehaviour
{

    public Vector2 pastPosition;
    public float velocity = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            //mousePosition AGORA - mousePosition ANTIGO
            Move(Input.mousePosition.x - pastPosition.x);
        
        }
        pastPosition = Input.mousePosition;
        
    }



    public void Move(float speed)
    {
        transform.position += Vector3.right * Time.deltaTime * speed * velocity;
    }
}

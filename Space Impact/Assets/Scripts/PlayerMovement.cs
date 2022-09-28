using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 8.0f;
    private float cornerBottomY = -3.0f;
    private float cornerTopY = 5.0f;
    private float cornerWidthX = 9.0f;

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //shoot 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        //setup the coreners
        if (transform.position.x > cornerWidthX) 
        {
            transform.position = new Vector3(cornerWidthX, transform.position.y, 0);
        }

        if (transform.position.x < -cornerWidthX)
        {
            transform.position = new Vector3(-cornerWidthX, transform.position.y, 0);
        }

        if (transform.position.y > cornerTopY)
        {
            transform.position = new Vector3(transform.position.x, cornerTopY, 0);
        }

        if (transform.position.y < cornerBottomY)
        {
            transform.position = new Vector3(transform.position.x, cornerBottomY, 0);
        }

        //move the player 
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}

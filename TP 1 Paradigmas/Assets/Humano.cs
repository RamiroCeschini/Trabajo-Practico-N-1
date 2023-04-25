using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public float _moveSpeed;
    public string _name;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Name = "Milanesa";
    }

    void Update()
    {
        _rigidbody.AddForce(new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed, 0f));
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bot"))
        {
            collision.GetComponent<Bot>().Saludar();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    private Collider2D Collider;

    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<BoxCollider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Scene2")
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

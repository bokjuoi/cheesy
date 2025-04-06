using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Cat")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

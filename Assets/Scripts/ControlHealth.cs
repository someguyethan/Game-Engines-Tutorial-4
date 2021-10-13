using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlHealth : MonoBehaviour
{
    public Text health;

    private void Start()
    {
        health.text = "Health " + PersistantManager.Instance.Value.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            PersistantManager.Instance.Value--;
            health.text = "Health " + PersistantManager.Instance.Value.ToString();
        }
    }

    private void Update()
    {
        if (PersistantManager.Instance.Value == 0)
        {
            Destroy(gameObject);
        }
    }
}

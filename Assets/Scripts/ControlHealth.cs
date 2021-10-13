using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControlHealth : MonoBehaviour
{
    public Text health;
    public static event Action col;

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

            #region observer        
            col?.Invoke();
            #endregion
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

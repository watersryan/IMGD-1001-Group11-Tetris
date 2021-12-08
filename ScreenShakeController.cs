using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeController : MonoBehaviour
{
    public static ScreenShakeController instance;
    private float shakeTimeRemaining, shakePower;
   
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartShake(.2f, .25f);
        }
    }

    private void LateUpdate()
    {
        if (shakeTimeRemaining > 0)
        {
            shakeTimeRemaining -= Time.deltaTime;
            float yAmount = Random.Range(0f, 5f) * shakePower;
            transform.position += new Vector3(0f, yAmount, -10f);
        }

        if (shakeTimeRemaining < 0)
        {
            float yAmount = Random.Range(0f, 5f) * shakePower;
            transform.position = new Vector3(0f, 0f, -10f);
        }
    }

    public void StartShake(float length, float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
    }
}

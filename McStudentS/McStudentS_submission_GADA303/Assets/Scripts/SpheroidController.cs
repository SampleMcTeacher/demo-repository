using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpheroidController : MonoBehaviour {

    private Rigidbody rigBod;
    private int numCoins;

    public Text numCoinsText;
    public Text completedText;
    public Text timerText;
    public int totalCoins;
    public float bottom;
    public float speed;

    // Use this for initialization
    void Start () {

        rigBod = GetComponent<Rigidbody>();
        numCoins = 0;
        completedText.text = "";
        CountNumCoinsText();

    }
	
	void FixedUpdate () {

        float rollHorizontal = Input.GetAxis("Horizontal");
        float rollVertical = Input.GetAxis("Vertical");

        Vector3 roll = new Vector3(rollHorizontal, 0.0f, rollVertical);

        timerText.text = Time.time.ToString("0.00");

        rigBod.AddForce(roll * speed);

        if (transform.position.y < bottom)
        {

            transform.position = new Vector3(0, 1f, 0);

            rigBod.velocity = new Vector3(0, 0, 0);

            rigBod.angularVelocity = new Vector3(0, 0, 0);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            numCoins = numCoins + 1;
            CountNumCoinsText();
        }
    }

    void CountNumCoinsText()
    {
        numCoinsText.text = "Coins Collected: " + numCoins.ToString();

        if (numCoins >= totalCoins)
        {
            completedText.text = "Level Completed!  Time: " + Time.time.ToString("0.00");
        }

    }
}

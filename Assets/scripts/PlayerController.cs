using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float velocity = 5;
    public SpriteRenderer spriterendered;
    private float currCountdownValue;
    public int bubbleCount;
    public Text textObj;
    void Start()
    {
        StartCoroutine(BreathingTime());
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    void MovementPlayer() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        this.spriterendered.flipX = horizontal >= 0 ? true : false;
        transform.Translate(new Vector2(horizontal,vertical) * Time.deltaTime * velocity);
    }
    public IEnumerator BreathingTime(float countdownValue = 30)
    {
        this.currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            this.currCountdownValue--;
            this.textObj.text = currCountdownValue.ToString();
        }
        if (currCountdownValue <= 0) {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Bolha"))
        {
            this.bubbleCount++;
            currCountdownValue += 5;
            this.textObj.text = currCountdownValue.ToString();
            Destroy(collision.gameObject);
        }
    }
}

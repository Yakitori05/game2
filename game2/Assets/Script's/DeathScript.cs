using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSpriteColor(Color newColor)
    {        
        spriteRenderer.color = newColor;
    }

    IEnumerator RestoreOriginalColorAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Restore the original color after the delay
        ChangeSpriteColor(originalColor);
        Player.transform.position = startPoint.transform.position;
        Time.timeScale = 1f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChangeSpriteColor(Color.blue);
            Time.timeScale = 0.75f;
            StartCoroutine(RestoreOriginalColorAfterDelay(1f));
            
        }
    }
}

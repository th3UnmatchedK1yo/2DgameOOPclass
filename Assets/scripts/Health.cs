using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("Death Sound")]
    [SerializeField] private AudioClip deathSound;

    

    [Header("Components")]
    [SerializeField] private Behaviour[] components;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        // If already dead, do nothing
        if (dead) return;

        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth <= 0 && !dead)
        {
            // Character dies instantly
            Die();
        }
    }

    private void Die()
    {
        // Trigger death animation if available
        if (anim != null)
            anim.SetTrigger("die");

        // Deactivate all attached components (e.g., enemy behavior, movement, etc.)
        foreach (Behaviour component in components)
            component.enabled = false;

        // Disable player movement (assuming PlayerMovement is the script handling it)
        PlayerMovement movement = GetComponent<PlayerMovement>();
        if (movement != null)
            movement.enabled = false;

        dead = true;
        SoundManager.instance.PlaySound(deathSound);
        // Call Game Over method or transition to the next scene
        
    }
}

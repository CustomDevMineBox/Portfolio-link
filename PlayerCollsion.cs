using UnityEngine;

public class PlayerCollsion : MonoBehaviour {
    private PlayerMovement playerMovement;
    void Start() {
        playerMovement = GetComponent<PlayerMovement>();
    }
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obsticle") {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

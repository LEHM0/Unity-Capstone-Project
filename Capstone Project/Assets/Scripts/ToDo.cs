using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDo : MonoBehaviour
{
    /* Player Controller:
     * ToDo: Increase + Smooth out turn speed
     * ToDo: Smooth jumping physics
     */

    /* Player Stats:
     * ToDo: Smooth out projectile aiming
     */

    /* Enemy Controller:
     * ToDo: Make Enemy follow Player when in range - Working On
     */

    /* Game Controller + UI:
     * ToDo: Add enemy spawning logic - Working On
     * ToDo: Progress wave after short down time once all enemies are defeated
     * ToDo: Vary enemy types as waves progress
     * ToDo: Add Pause Screen that freezes the player and all enemies <---
     * ToDo: Restart starts the game at the begining <---
     * ToDo: Add Main Menu Screen to start the game at the beginning , only spawn Player and Enemies once game starts
     */

    /* Setup:
     * UI: -------------------------
     * ToDo: Add Resume Game button - Working On
     * ToDo: All menus display when called - Working On
     * ToDo: Add High Score counter
     * Player Controls: ------------
     * Fix: Camera is overly sensitive
     * Fix: Camera has no restraints, causing it to be stuck upside down - Working On
     * Fix: Controls can become inverted
     * Fix: Bullet only shoots forward globally, not locally
     */

    /* Benched Features:
     * Fix: Player can fire two shots at once - (Bench?)
     * Fix: Enemy can be pushed around by the player - Bench
     * ToDo: Clean up UI - Bench
     * ToDo: Spawn collectible attack types, unlocking that attack for the player once collected - Bench
     * Start from a certain wave (Bench)
     */

    /* Final Checklist:
     * 1) Refactor GameController into WaveController - Working On
     * 1.1) Set currentWave, wave finish and cooldown and nextEnemy
     * 1.2) Create enemy spawning method at random spawn point GO away from certain distance towards player
     * 2) Add enemy movement and attack logic
     * 3) Adjust player and camera movement
     * 3.1) Fix player aiming
     * 4) Finish UI + logic
     */

    /* Outline:
     * 1. Finish basic Player abilities - Mostly DONE
     * 2. Make basic Enemy Class and behavior - ToDo: Work on enemy movement + attack
     * 3. Basic Wave functionality + gameplay loop - Working On
     * 4. Different Attack + Enemy types - Bench?
     * 5. Enviroment
     * 6. Models, Sounds, and Animations - Bench
     * 7. Polish
     * 8. FINISHED
     */

    // 1. Make if functional
    // 2. Make it play good
    // 3. Make it look good
}

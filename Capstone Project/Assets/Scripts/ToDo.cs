using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDo : MonoBehaviour
{
    /* Player Controller:
     * Fix: Player tilts over - DONE
     * ToDo: Make Camera follow Player's POV - DONE
     * Fix: Player can only move forwards, backwards, and rotate - DONE
     * ToDo: Add Jump ability - DONE
     * Fix: Player Projectiles don't move - DONE
     * Player Projectile needs a script for moving forward - DONE
     * ToDo: Add Player Projectile Trigger Collision - DONE
     * ToDo: Player can fire either a Left Projectile or a Right Projectile - DONE
     * Fix: Turning causes bullet to fire at odd angles - DONE
     * ToDo: Camera + Rotation follow Player Mouse Cursor - DONE
     * BACKLOG: ---------------------------------------------------------------------
     * ToDo: Increase + Smooth out turn speed
     * ToDo: Smooth jumping physics
     * Fix: Player can fire two shots at once - (Doesn't that make sense though?)
     */

    /* Player Stats:
     * ToDo: Player takes damage when colliding w/ enemy or projectile - DONE
     * ToDo: Player Health cannot go below 0 - DONE
     * ToDo: Player is tagged "Dead" when Health reaches 0 - DONE
     * ToDo: Each gun has limited ammo - DONE
     * ToDo: Reloaing can be manually triggered at any time unless ammo is full - DONE
     * ToDo: Each gun has a short reload time after ammo has been depleted - DONE
     * Fix: Reloading happens instantly, not after 2 seconds - DONE
     * ToDo: One reload button, which can reload both guns; If one gun is full, it will only reload the other gun - DONE
     * ToDo: Bullets cannot be fired while reloading - DONE
     * ToDo: Reloading cannot be triggered while that same gun is reloading - DONE
     * Fix: Projectiles only fire forward, not where the camera is facing - DONE
     * ToDo: Player has a Basic Attack, and 6 Elemental Attacks that can be selected with the mouse wheel - DONE
     * ToDo: Implement Elemntal Attack Logic - DONE
     * ToDo: Bullets should despawn after not hitting an enemy - DONE
     * BACKLOG: ---------------------------------------------------------------------
     * ToDo: Different Elemental Attacks affect Elemental Enemies in different ways
     * ToDo: Smooth out projectile aiming
     */

    /* Enemy Controller:
     * ToDo: Enemy can be hit and damaged by Player projectiles - DONE
     * ToDo: Enemy gives Points when dead, adding to player's Total Points score - DONE
     * Fix: Enemy no longer taking damage - DONE
     * Fix: Player is destoryed when in range - DONE
     * ToDo: Add fire rate and attack range variables - DONE
     * ToDo: Enemy has a Ranged attack that damages the player - DONE
     * Fix: Enemy fires an endless stream of bullets - DONE
     * Fix: Make Enemy aim at player - DONE
     * Fix: Enemy looks at player, but projectile still fires in wrong direction - DONE
     * Fix: Trying to fix Enemy aim causes it to fire at itself - DONE
     * Fix: Enemy Bullet is not hitting Player - DONE
     * BACKLOG: ---------------------------------------------------------------------
     * ToDo: Make Enemy follow Player when in range
     * Fix: Enemy can be pushed around by the player
     */

    /* Game Controller + UI:
     * ToDo: Show ammo count + reloading - DONE
     * ToDo: Add Game Over Screen to restart the game or go to the Main menu - DONE
     * ToDo: Game should freeze on Game Over - DONE
     * Fix: Player can shoot on menu screen - DONE
     * BACKLOG: ---------------------------------------------------------------------
     * ToDo: Clean up UI
     * ToDo: Add enemy spawning logic
     * ToDo: Progress wave after short down time once all enemies are defeated
     * ToDo: Vary enemy types as waves progress
     * ToDo: Spawn collectible attack types, unlocking that attack for the player once collected
     * ToDo: Add Pause Screen that freezes the player and all enemies <---
     * ToDo: Restart starts the game at the begining <---
     * ToDo: Add Main Menu Screen to start the game at the beginning or from a certain wave, only spawn Player and Enemies once game starts
     */

    /* Setup:
     * UI: -------------------------
     * Finish Player UI - DONE (Need to clean up)
     * Redo Main Menu - DONE
     * ToDo: Add Wave Select Submenu <---
     * Redo Game Over Menu - DONE
     * ToDo: Add Pause Menu - DONE
     * ToDo: All menus display when called - Working On
     * Player Controls: ------------
     * Test Player Movement - DONE
     * Test Player Attack Selection - DONE
     * Test Player Attacks - DONE
     * Test Player Death - DONE
     * ToDo: Make Camera controlled by Player mouse - DONE
     * ToDo: Let Player move left/right - DONE
     * Fix: Camera is overly sensitive - Working On
     * Fix: Camera Y value is inverted
     * Fix: Camera has no restraints, causing it to be stuck upside down
     * Fix: Controls can become inverted
     * Enemies Behavior: ------------
     * Test Enemy Collision - DONE
     * Test Enemy Death - DONE
     * ToDo: Re-add Player and Enemy Colliders - DONE
     * Test Enemy Attack - DONE
     */

    /* Outline:
     * 1. Finish basic Player abilities - Mostly DONE
     * 2. Make basic Enemy Class and behavior
     * 3. Basic Wave functionality + gameplay loop
     * 4. Different Attack + Enemy types
     * 5. Enviroment
     * 6. Models, Sounds, and Animations
     * 7. Polish
     * 8. FINISHED
     */

    // 1. Make if functional
    // 2. Make it play good
    // 3. Make it look good
}

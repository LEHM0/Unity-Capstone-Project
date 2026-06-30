using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDo : MonoBehaviour
{
    /* Player Stats:
     * ToDo: Smooth out projectile aiming
     */

    /* Game Controller + UI:
     * ToDo: Add Pause Screen that freezes the player and all enemies <---
     */

    /* Setup:
     * UI: -------------------------
     * ToDo: Add Resume Game button - Working On
     * ToDo: All menus display when called - Working On
     * ToDo: Add High Score counter
     * Player Controls: ------------
     * Fix: Bullet only shoots forward globally, not locally
     */

    /* Benched Features:
     * Fix: Player can fire two shots at once - (Bench?)
     * Fix: Enemy can be pushed around by the player - Bench
     * ToDo: Clean up UI - Bench
     * ToDo: Spawn collectible attack types, unlocking that attack for the player once collected - Bench
     * Start from a certain wave (Bench)
     * 4. Different Attack + Enemy types - Bench
     * 5. Enviroment - Bench
     * 6. Models, Sounds, and Animations - Bench
     */

    /* Final Checklist:
     * 1) Refactor GameController into WaveController - DONE
     * 1.1) Set currentWave, wave finish and cooldown and nextEnemy - DONE
     * 1.2) Create enemy spawning method at random spawn point GOs - DONE
     * 1.3) Set enemy spawn points around map - DONE
     * 2) Add enemy movement and attack logic - DONE
     * 3) Adjust player and camera movement - DONE
     * 3.1) Fix player aiming - DONE
     * 4) Fix Spawning issues - DONE
     * 5) Finish UI + logic - Bench
     */

    /* Outline:
     * 1. Finish basic Player abilities
     * 2. Make basic Enemy Class and behavior
     * 3. Basic Wave functionality + gameplay loop
     * 4. Polish
     * 5. FINISHED
     */
}

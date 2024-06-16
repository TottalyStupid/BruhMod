using BruhMod.Items.Weapons;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace BruhMod.Projectiles
{
	// This projectile showcases advanced AI code. Of particular note is a showcase on how projectiles can stick to NPCs in a manner similar to the behavior of vanilla weapons such as Bone Javelin, Daybreak, Blood Butcherer, Stardust Cell Minion, and Tentacle Spike. This code is modeled closely after Bone Javelin.
	public class HammerdomProjectile : ModProjectile
	{
		// These properties wrap the usual ai arrays for cleaner and easier to understand code.
		// Are we sticking to a target?
		public bool IsStickingToTarget {
			get => Projectile.ai[0] == 1f;
			set => Projectile.ai[0] = value ? 1f : 0f;
		}

		// Index of the current target
		public int TargetWhoAmI {
			get => (int)Projectile.ai[1];
			set => Projectile.ai[1] = value;
		}

		public int GravityDelayTimer {
			get => (int)Projectile.ai[2];
			set => Projectile.ai[2] = value;
		}

		public float StickTimer {
			get => Projectile.localAI[0];
			set => Projectile.localAI[0] = value;
		}

		public override void SetDefaults() {
			Projectile.width = 64; // The width of projectile hitbox
			Projectile.height = 64; // The height of projectile hitbox
			Projectile.aiStyle = 3; // The ai style of the projectile (0 means custom AI). For more please reference the source code of Terraria
			Projectile.friendly = true; // Can the projectile deal damage to enemies?
			Projectile.hostile = false; // Can the projectile deal damage to the player?
			Projectile.DamageType = DamageClass.Melee; // Makes the projectile deal ranged damage. You can set in to DamageClass.Throwing, but that is not used by any vanilla items
			Projectile.penetrate = 25647; // How many monsters the projectile can penetrate.
			Projectile.timeLeft = 1800; // The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			Projectile.light = 0.5f; // How much light emit around the projectile
			Projectile.ignoreWater = true; // Does the projectile's speed be influenced by water?
			Projectile.tileCollide = true; // Can the projectile collide with tiles?
		}

		private const int GravityDelay = 45;

		public override void AI() {
			// Run either the Sticky AI or Normal AI
			// Separating into different methods helps keeps your AI clean
			if (IsStickingToTarget) {
				StickyAI();
			}
			else {
				NormalAI();
			}
		}

		private void NormalAI() {
			GravityDelayTimer++; // doesn't make sense.

			// For a little while, the javelin will travel with the same speed, but after this, the javelin drops velocity very quickly.
			if (GravityDelayTimer >= GravityDelay) {
				GravityDelayTimer = GravityDelay;

				// wind resistance
				Projectile.velocity.X *= 0.98f;
				// gravity
				Projectile.velocity.Y += 0.35f;
			}

			// Offset the rotation by 90 degrees because the sprite is oriented vertically.
			Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
		}

		private const int StickTime = 60 * 15; // 15 seconds
		private void StickyAI() {
			Projectile.ignoreWater = true;
			Projectile.tileCollide = false;
			StickTimer += 1f;

			// Every 30 ticks, the javelin will perform a hit effect
			bool hitEffect = StickTimer % 30f == 0f;
			int npcTarget = TargetWhoAmI;
			if (StickTimer >= StickTime || npcTarget < 0 || npcTarget >= 200) { // If the index is past its limits, kill it
				Projectile.Kill();
			}
			else if (Main.npc[npcTarget].active && !Main.npc[npcTarget].dontTakeDamage) {
				// If the target is active and can take damage
				// Set the projectile's position relative to the target's center
				Projectile.Center = Main.npc[npcTarget].Center - Projectile.velocity * 2f;
				Projectile.gfxOffY = Main.npc[npcTarget].gfxOffY;
				if (hitEffect) {
					// Perform a hit effect here, causing the npc to react as if hit.
					// Note that this does NOT damage the NPC, the damage is done through the debuff.
					Main.npc[npcTarget].HitEffect(0, 1.0);
				}
			}
			else { // Otherwise, kill the projectile
				Projectile.Kill();
			}
		}

		public override void OnKill(int timeLeft) {
			SoundEngine.PlaySound(SoundID.Dig, Projectile.position); // Play a death sound
			Vector2 usePos = Projectile.position; // Position to use for dusts

			// Offset the rotation by 90 degrees because the sprite is oriented vertically.
			Vector2 rotationVector = (Projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
			usePos += rotationVector * 16f;
			}
		}
	}
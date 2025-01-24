using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using System;
using Terraria.Audio;

namespace MeleeRemastered.Content.Projectiles
{
    public class CopperBroadswordProj : ModProjectile
    {

        public int i = 0;
        private const float SWINGRANGE = 1.67f * (float)Math.PI; // The angle a swing attack covers (300 deg)
        private const float FIRSTHALFSWING = 0.45f; // How much of the swing happens before it reaches the target angle (in relation to swingRange)
        private const float WINDUP = 0.15f; // How far back the player's hand goes when winding their attack (in relation to swingRange)
        private const float UNWIND = 0.4f; // When should the sword start disappearing
        private Player Owner => Main.player[Projectile.owner];
        public float DamageMultiplyer = 1f;

        // Variables to keep track of during runtime
        private ref float InitialAngle => ref Projectile.ai[1]; // Angle aimed in (with constraints)
        private ref float Timer => ref Projectile.ai[2]; // Timer to keep track of progression of each stage
        private ref float Progress => ref Projectile.localAI[1]; // Position of sword relative to initial angle
        private ref float Size => ref Projectile.localAI[2]; // Size of sword
        private enum AttackStage // What stage of the attack is being executed, see functions found in AI for description
        {
            Prepare,
            Execute
        }
        private AttackStage CurrentStage
        {
            get => (AttackStage)Projectile.localAI[0];
            set
            {
                Projectile.localAI[0] = (float)value;
                Timer = 0; // reset the timer when the projectile switches states
            }
        }
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.HeldProjDoesNotUsePlayerGfxOffY[Type] = true;
        }
        public override void SetDefaults()
        {
            Projectile.width = 36; // Hitbox width of projectile
            Projectile.height = 36; // Hitbox height of projectileS
            Projectile.timeLeft = 10000; // Time it takes for projectile to expire
            Projectile.penetrate = -1; // Projectile pierces infinitely
            Projectile.tileCollide = false; // Projectile does not collide with tiles
            Projectile.usesLocalNPCImmunity = true; // Uses local immunity frames
            Projectile.localNPCHitCooldown = -1; // We set this to -1 to make sure the projectile doesn't hit twice
            Projectile.ownerHitCheck = true; // Make sure the owner of the projectile has line of sight to the target (aka can't hit things through tile).
            Projectile.DamageType = DamageClass.Melee; // Projectile is a melee projectile
        }
       public override void OnSpawn(IEntitySource source)
        {
            CurrentStage = AttackStage.Prepare;
        }
        private void PrepareStrike()
        {
            if (Timer < 180)
            {
                Progress = WINDUP * SWINGRANGE * (1f - Timer / 180); // Calculates rotation from initial angle
                Size = MathHelper.SmoothStep(0.6f, 1.1f, Timer / 180); // Make sword slowly increase in size as we prepare to strike until it reaches max
                DamageMultiplyer = MathHelper.SmoothStep(0.8f, 1.7f, Timer / 180);
            }
            else if (Timer == 180)
            {
                SoundEngine.PlaySound(SoundID.Item4);
            }
        }
        private void ExecuteStrike()
        {
            Projectile.friendly = true;
            SoundEngine.PlaySound(SoundID.Item1);
            i++;
            float damagenum = Projectile.damage * DamageMultiplyer;
            Projectile.damage = (int)damagenum;
            if (i == 1)
                CurrentStage = AttackStage.Execute;
            Progress = MathHelper.SmoothStep(0, SWINGRANGE, (1f - UNWIND) * Timer / 5);
            if (Timer >= 5)
            {
                Progress = MathHelper.SmoothStep(0, SWINGRANGE, (1f - UNWIND) + UNWIND * Timer / 6);
                Size = 1f - MathHelper.SmoothStep(0, 1, Timer / 6); // Make sword slowly decrease in size as we end the swing to make a smooth hiding animation

                if (Timer >= 10)
                {
                    Projectile.Kill();
                }
            }
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            player.itemAnimation += 1;
            player.itemTime += 1;

            // Kill the projectile if the player dies or gets crowd controlled
            if (!player.active || player.dead || player.noItems || player.CCed)
            {
                Projectile.Kill();
                return;
            }
            if (player.channel)
            {
                PrepareStrike();
            }
            else
            {
                ExecuteStrike();
            }
            SetSwordPosition();
            if (player.channel)
                Timer += 1 + (20 / player.itemTime);
            else
                Timer++;
        }
        public void SetSwordPosition()
        {
            Player Owner = Main.player[Projectile.owner];
            Projectile.spriteDirection = Main.MouseWorld.X > Owner.MountedCenter.X ? 1 : -1;
			Owner.ChangeDir(Projectile.spriteDirection); // Change the player's direction based on the projectile's own
            float targetAngle = (Main.MouseWorld - Owner.MountedCenter).ToRotation();
            InitialAngle = targetAngle - FIRSTHALFSWING * SWINGRANGE * Projectile.spriteDirection;
            Projectile.rotation = InitialAngle + Projectile.spriteDirection * Progress; // Set projectile rotation

            // Set composite arm allows you to set the rotation of the arm and stretch of the front and back arms independently
            Owner.SetCompositeArmFront(true, Player.CompositeArmStretchAmount.Full, Projectile.rotation - MathHelper.ToRadians(90f)); // set arm position (90 degree offset since arm starts lowered)
            Vector2 armPosition = Owner.GetFrontHandPosition(Player.CompositeArmStretchAmount.Full, Projectile.rotation - (float)Math.PI / 2); // get position of hand

            armPosition.Y += Owner.gfxOffY;
            Projectile.Center = armPosition; // Set projectile to arm position
            Projectile.scale = Size * 1.2f * Owner.GetAdjustedItemScale(Owner.HeldItem); // Slightly scale up the projectile and also take into account melee size modifiers

            Owner.heldProj = Projectile.whoAmI; // set held projectile to this projectile
        }

        public override bool PreDraw(ref Color lightColor)
        {
            // Calculate origin of sword (hilt) based on orientation and offset sword rotation (as sword is angled in its sprite)
            Vector2 origin;
            float rotationOffset;
            SpriteEffects effects;

            if (Projectile.spriteDirection > 0)
            {
                origin = new Vector2(0, Projectile.height);
                rotationOffset = MathHelper.ToRadians(45f);
                effects = SpriteEffects.None;
            }
            else
            {
                origin = new Vector2(Projectile.width, Projectile.height);
                rotationOffset = MathHelper.ToRadians(135f);
                effects = SpriteEffects.FlipHorizontally;
            }

            Texture2D texture = TextureAssets.Projectile[Type].Value;

            Main.spriteBatch.Draw(texture, Projectile.Center - Main.screenPosition, default, lightColor * Projectile.Opacity, Projectile.rotation + rotationOffset, origin, Projectile.scale, effects, 0);

            // Since we are doing a custom draw, prevent it from normally drawing
            return false;
        }

        // Find the start and end of the sword and use a line collider to check for collision with enemies
        public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
        {
            Vector2 start = Owner.MountedCenter;
            Vector2 end = start + Projectile.rotation.ToRotationVector2() * ((Projectile.Size.Length()) * Projectile.scale);
            float collisionPoint = 0f;
            return Collision.CheckAABBvLineCollision(targetHitbox.TopLeft(), targetHitbox.Size(), start, end, 15f * Projectile.scale, ref collisionPoint);
        }

        // Do a similar collision check for tiles
        public override void CutTiles()
        {
            Vector2 start = Owner.MountedCenter;
            Vector2 end = start + Projectile.rotation.ToRotationVector2() * (Projectile.Size.Length() * Projectile.scale);
            Utils.PlotTileLine(start, end, 15 * Projectile.scale, DelegateMethods.CutTiles);
        }

        // We make it so that the projectile can only do damage in its release and unwind phases
        public override bool? CanDamage()
        {
            if (CurrentStage == AttackStage.Prepare)
                return false;
            return base.CanDamage();
        }

        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            // Make knockback go away from player
            modifiers.HitDirectionOverride = target.position.X > Owner.MountedCenter.X ? 1 : -1;

        }
    }
}
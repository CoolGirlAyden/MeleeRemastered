using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using MeleeRemastered.Content.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections;

namespace MeleeRemastered.Content
{
    public class GlobalProjectiles : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            switch (projectile.type)
            {
                case ProjectileID.ChlorophyteOrb:
                    projectile.penetrate = 5;
                    break;
                case ProjectileID.SporeCloud:
                    projectile.timeLeft = 120;
                    break;
                case ProjectileID.EnchantedBeam:
                    projectile.timeLeft = 120;
                    break;
                case ProjectileID.InfluxWaver:
                    projectile.timeLeft = 120;
                    break;
                case ProjectileID.SeedlerNut:
                    projectile.penetrate = -1;
                    projectile.usesLocalNPCImmunity = true;
                    projectile.localNPCHitCooldown = -1;
                    break;
            }
        }
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
            switch (projectile.type)
            {
                case ProjectileID.ChlorophyteOrb:
                    projectile.penetrate--;
			    if (projectile.penetrate <= 0) 
                {
				    projectile.Kill();
		    	}
			    else 
                {
		    	    Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
				    SoundEngine.PlaySound(SoundID.Item10, projectile.position);
				    if (Math.Abs(projectile.velocity.X - oldVelocity.X) > float.Epsilon) 
                    {
					    projectile.velocity.X = -oldVelocity.X;
				    }
				    if (Math.Abs(projectile.velocity.Y - oldVelocity.Y) > float.Epsilon) 
                    {
					    projectile.velocity.Y = -oldVelocity.Y;
				    }
			    }
                break;
            }
            if (projectile.type == ProjectileID.ChlorophyteOrb)
                return false;
            else
                return base.OnTileCollide(projectile, oldVelocity);
        }
    }
}
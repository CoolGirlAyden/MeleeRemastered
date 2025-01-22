using System.Collections;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MeleeRemastered.Content.Projectiles;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Mono.CompilerServices.SymbolWriter;

namespace MeleeRemastered.Content
{
    public class GlobalItems : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            switch (item.type)
            {
                case ItemID.AdamantiteSword:
                    item.shoot = ModContent.ProjectileType<AdamantiteSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.AshWoodSword:
                    item.shoot = ModContent.ProjectileType<AshWoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BatBat:
                    item.shoot = ModContent.ProjectileType<BatBatProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BeamSword:
                    item.shoot = ModContent.ProjectileType<BeamSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BeeKeeper:
                    item.shoot = ModContent.ProjectileType<BeeKeeperProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BladeofGrass:
                    item.shoot = ModContent.ProjectileType<BladeOfGrassProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Bladetongue:
                    item.shoot = ModContent.ProjectileType<BladetongueProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BloodButcherer:
                    item.shoot = ModContent.ProjectileType<BloodButchererProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BoneSword:
                    item.shoot = ModContent.ProjectileType<BoneSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BorealWoodSword:
                    item.shoot = ModContent.ProjectileType<BorealWoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.DD2SquireDemonSword:
                    item.shoot = ModContent.ProjectileType<BrandOfTheInfernoProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.BreakerBlade:
                    item.shoot = ModContent.ProjectileType<BreakerBladeProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.CandyCaneSword:
                    item.shoot = ModContent.ProjectileType<CandyCaneSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.ChlorophyteClaymore:
                    item.shoot = ModContent.ProjectileType<ChlorophyteClaymoreProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.ChlorophyteSaber:
                    item.shoot = ModContent.ProjectileType<ChlorophyteSaberProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.ChristmasTreeSword:
                    item.shoot = ModContent.ProjectileType<ChristmasTreeSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.TaxCollectorsStickOfDoom:
                    item.shoot = ModContent.ProjectileType<ClassyCaneProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.CobaltSword:
                    item.shoot = ModContent.ProjectileType<CobaltSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.CopperBroadsword:
                    item.shoot = ModContent.ProjectileType<CopperBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Cutlass:
                    item.shoot = ModContent.ProjectileType<CutlassProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.DeathSickle:
                    item.shoot = ModContent.ProjectileType<DeathSickleProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.EbonwoodSword:
                    item.shoot = ModContent.ProjectileType<EbonwoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.EnchantedSword:
                    item.shoot = ModContent.ProjectileType<EnchantedSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.DyeTradersScimitar:
                    item.shoot = ModContent.ProjectileType<ExoticScimitarProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.FalconBlade:
                    item.shoot = ModContent.ProjectileType<FalconBladeProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.DD2SquireBetsySword:
                    item.shoot = ModContent.ProjectileType<FlyingDragonProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Flymeal:
                    item.shoot = ModContent.ProjectileType<FlymealProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Frostbrand:
                    item.shoot = ModContent.ProjectileType<FrostbrandProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.GoldBroadsword:
                    item.shoot = ModContent.ProjectileType<GoldBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.HamBat:
                    item.shoot = ModContent.ProjectileType<HamBatProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.IceBlade:
                    item.shoot = ModContent.ProjectileType<IceBladeProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.IceSickle:
                    item.shoot = ModContent.ProjectileType<IceSickleProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.InfluxWaver:
                    item.shoot = ModContent.ProjectileType<InfluxWaverProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.IronBroadsword:
                    item.shoot = ModContent.ProjectileType<IronBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Katana:
                    item.shoot = ModContent.ProjectileType<KatanaProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Keybrand:
                    item.shoot = ModContent.ProjectileType<KeybrandProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.LeadBroadsword:
                    item.shoot = ModContent.ProjectileType<LeadBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.LightsBane:
                    item.shoot = ModContent.ProjectileType<LightsBaneProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.AntlionMandible:
                    item.shoot = ModContent.ProjectileType<MandibleBladeProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Meowmere:
                    item.shoot = ModContent.ProjectileType<MeowmereProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Muramasa:
                    item.shoot = ModContent.ProjectileType<MuramasaProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.MythrilSword:
                    item.shoot = ModContent.ProjectileType<MythrilSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.OrichalcumSword:
                    item.shoot = ModContent.ProjectileType<OrichalcumSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.PalladiumSword:
                    item.shoot = ModContent.ProjectileType<PalladiumSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.PalmWoodSword:
                    item.shoot = ModContent.ProjectileType<PalmWoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.PearlwoodSword:
                    item.shoot = ModContent.ProjectileType<PearlwoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.PlatinumBroadsword:
                    item.shoot = ModContent.ProjectileType<PlatinumBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.PurpleClubberfish:
                    item.shoot = ModContent.ProjectileType<PurpleClubberfishProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Seedler:
                    item.shoot = ModContent.ProjectileType<SeedlerProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.ShadewoodSword:
                    item.shoot = ModContent.ProjectileType<ShadewoodSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.SilverBroadsword:
                    item.shoot = ModContent.ProjectileType<SilverBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.SlapHand:
                    item.shoot = ModContent.ProjectileType<SlapHandProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.Starfury:
                    item.shoot = ModContent.ProjectileType<StarfuryProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.StarWrath:
                    item.shoot = ModContent.ProjectileType<StarWrathProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.StylistKilLaKillScissorsIWish:
                    item.shoot = ModContent.ProjectileType<StylishScissorsProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.TentacleSpike:
                    item.shoot = ModContent.ProjectileType<TentacleSpikeProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.TitaniumSword:
                    item.shoot = ModContent.ProjectileType<TitaniumSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.TungstenBroadsword:
                    item.shoot = ModContent.ProjectileType<TungstenBroadswordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.FieryGreatsword:
                    item.shoot = ModContent.ProjectileType<VolcanoProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.WoodenSword:
                    item.shoot = ModContent.ProjectileType<WoodenSwordProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
                case ItemID.ZombieArm:
                    item.shoot = ModContent.ProjectileType<ZombieArmProj>();
                    item.noMelee = true;
                    item.noUseGraphic = true;
                    item.channel = true;
                    item.ChangePlayerDirectionOnShoot = false;
                    item.useTurn = false;
                    break;
            }
        }
        public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (item.type == ItemID.StarWrath)
            {
                Projectile.NewProjectile(source, position, velocity, type, damage, knockback);
                return false;
            }
            else
            return base.Shoot(item, player, source, position, velocity, type, damage, knockback);
        }
    }
}

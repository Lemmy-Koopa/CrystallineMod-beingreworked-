using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;


namespace CrystallineMod.Projectiles
{
    class SlimeCloud : ModProjectile
    {
        private bool rotChanged;

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.extraUpdates = -1;
            projectile.tileCollide = false;
            
        }
        public float Timer
        {
            get => projectile.ai[0];
            set => projectile.ai[0] = value;
        }

        int timer;

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            // If the player channels the weapon, do something. This check only works if item.channel is true for the weapon.
            if (player.channel)
            {
                float maxDistance = 18f; // This also sets the maximun speed the projectile can reach while following the cursor.
                Vector2 vectorToCursor = Main.MouseWorld - projectile.Center;
                float distanceToCursor = vectorToCursor.Length();

                // Here we can see that the speed of the projectile depends on the distance to the cursor.
                if (distanceToCursor > maxDistance)
                {
                    distanceToCursor = maxDistance / distanceToCursor;
                    vectorToCursor *= distanceToCursor;
                }

                int velocityXBy1000 = (int)(vectorToCursor.X * 1000f);
                int oldVelocityXBy1000 = (int)(projectile.velocity.X * 1000f);
                int velocityYBy1000 = (int)(vectorToCursor.Y * 1000f);
                int oldVelocityYBy1000 = (int)(projectile.velocity.Y * 1000f);

                // This code checks if the precious velocity of the projectile is different enough from its new velocity, and if it is, syncs it with the server and the other clients in MP.
                // We previously multiplied the speed by 1000, then casted it to int, this is to reduce its precision and prevent the speed from being synced too much.
                if (velocityXBy1000 != oldVelocityXBy1000 || velocityYBy1000 != oldVelocityYBy1000)
                {
                    projectile.netUpdate = true;
                }
                projectile.velocity = vectorToCursor;
            }

            if (!rotChanged)
            {

                projectile.rotation = projectile.DirectionTo(Main.MouseWorld).ToRotation() - MathHelper.PiOver2;
                rotChanged = true;
                Vector2 vectorToCursor = Main.MouseWorld - projectile.Center;
                float distanceToCursor = vectorToCursor.Length();
                Vector2 followMouse = projectile.DirectionTo(Main.MouseWorld);
                projectile.velocity = followMouse;
            }
            {
                timer++;
                if (timer >= 10)
                {
                    timer = 0;
                    if (projectile.owner == Main.myPlayer)
                    {
                        int num421 = (int)(projectile.position.X + 4f + Main.rand.Next(projectile.width - 6));
                        int num422 = (int)(projectile.position.Y + projectile.height + 4f);
                        Projectile.NewProjectile(num421, num422, 0f, 4f, 245, projectile.damage, 0f, projectile.owner);
                    }
                }
            }

        }
       
    }
}

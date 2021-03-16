using System;
using System.Threading.Tasks;
using StardewValley;

namespace Streamvalley.Payloads
{
    public class Payloads
    {
        public void GiveMoney()
        {
            Game1.player.addUnearnedMoney(5000);
        }

        public async Task Freeze()
        {
            Game1.player.CanMove = false;
            await Task.Delay(TimeSpan.FromSeconds(5));
            Game1.player.CanMove = true;
        }

        public void ChangeGender()
        {
            var isMale = Game1.player.isMale;
            Game1.player.changeGender(!isMale);
        }

        public void Divorce()
        {
            if (!Game1.player.isMarried())
            {
                Game1.addHUDMessage(new HUDMessage("No waifu found :(", 2));
                return;
            }
            Game1.player.doDivorce();
        }

        public void Knockout()
        {
            Game1.player.startToPassOut();
        }
    }
}
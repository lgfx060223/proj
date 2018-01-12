using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshp_1
{
    class player
    {
        struct resource
        {
            bool buyonce;
            int race;
            int playerID;
            static int playernum;
            //钱的一套 
            int moneyAdd;
            int moneyProgress;
            int moneyrandProgress;
            int money;
            int moneyTownProgress;//这是因为升本得到的钱，和普通经济不同，两者分开加钱 
            //升本的一套 
            int upgradeAdd;
            int upgradeProgress;
            int upgrade;
            //兵是直接造出来的，再加上生产周期较长，也不必复杂控制，因此不用add，以下是步兵一套骑兵一套
            int footmanProgress;
            int footmanrandProgress;
            int footman;
            int knightProgress;
            int knightrandProgress;
            int knight;
            int hifootmanProgress;
            int hifootmanrandProgress;
            int hifootman;
            int hiknightProgress;
            int killfootmanProgress;
            int hiknightrandProgress;
            int hiknight;
            int defense;
            //敌方带来的减成 
            int attackedfootman;
            int attackedknight;
            int attackedhifootman;
            int attackedhiknight;
            int attackedenemy;
            int attackProgress;
            int showincome;
            //建筑秒建，以后可能会加一套，但建筑有售价...... 
            int farmprice;
            int farm;
            int barrackprice;
            int barrack;
            int bankprice;
            int bank;
            int trainprice;
            int train;
            int stableprice;
            int stable;
            int blacksmithprice;
            int blacksmith;
            int castleprice;
            int castle;
            //controlkeys
            char upkey;
            char downkey;
            char spacekey;
            int maxchoose;
        }
        public void economic_growth(){
            
        }
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
   } 
}

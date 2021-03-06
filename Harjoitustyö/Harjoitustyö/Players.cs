﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyö
{
    public class Players
    {
        private List<Player> playersList = new List<Player>();
        private readonly int MAX_PLAYERS = 8;

        public List<Player> PlayersList
        {
            get { return playersList; }
        }

        public void resetList()
        {
            playersList = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if(playersList.Count() < MAX_PLAYERS)
            {
                playersList.Add(player);
            }
        }

        public void resetStatus()
        {
            resetKysymysmestari();
            resetTauot();
            resetHuora();
        }

        public Player getByName(string name)
        {
            foreach(Player p in playersList)
            {
                if(p.Name == name)
                {
                    return p;
                }
            }
            return null;
        }

        public void resetKysymysmestari()
        {
            foreach (Player p in playersList)
            {
                p.kysymysMestari = false;
            }
        }

        public void resetTauot()
        {
            foreach (Player p in playersList)
            {
                p.Tauot = 0;
                p.tauolla = false;
            }
        }

        public void resetHuora()
        {
            foreach (Player p in playersList)
            {
                p.huorat = new List<Player>();
            }
        }
    }
    
}

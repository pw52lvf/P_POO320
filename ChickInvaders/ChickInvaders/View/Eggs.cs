﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickInvaders
{
    public partial class Eggs
    {
        private int ex;                                 // Position en X depuis la gauche de l'espace aérien
        private int ey;
        private Image eggImage;
        public Rectangle eggHitbox { get; private set; }
        private int eggWidth;
        private int eggHeight;

        // Constructeur
        public Eggs(int x, int y)
        {
            ex = x;
            ey = y;
            //_charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
            eggImage = Image.FromFile("egg.png");
            eggWidth = 16;
            eggHeight = 16;
        }
        public int X { get { return ex; } }
        public int Y { get { return ey; } }

        private void UpdateHitbox()
        {
            eggHitbox = new Rectangle(ex + 2, ey + 2, eggWidth, eggHeight);
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void UpdateE(int interval)
        {
            ey = ey - 8;

            UpdateHitbox();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicForFreedom.Classes
{
    public class Promu
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string  Image;

        public string  image
        {
            get { return Image; }
            set { Image = value; }
        }
        private string description;

        public string desc
        {
            get { return description; }
            set { description = value; }
        }
        private string Link;

        public string link
        {
            get { return Link; }
            set { Link = value; }
        }


        //public Promu(string paramNom, string paramImage, string paramDesc)
        //{
        //    nom = paramNom;
        //    Image  = paramImage;
        //    description = paramDesc;
        //}

    }
}
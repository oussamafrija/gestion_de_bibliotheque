using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_d_une_bibliotheque
{
    class eleve
    {

        private int code_livre;
        private string titre;
        private string auteur;
        private DateTime date_livre;
        private string categorie;
        private string disponible;
        private string text;

        public int Code { get => code_livre; set => code_livre = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public DateTime Date_livre { get => date_livre; set => date_livre = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Disponible { get => disponible; set => disponible = value; }
        public string Text1 { get; }

        public eleve()
        {
           
        }

        public eleve(int CL, string Titre, string Auteur, DateTime DL, string Cate, string Disp)
        {
            this.code_livre = CL;
            this.titre = Titre;
            this.auteur = Auteur;
            this.date_livre = DL;
            this.categorie = Cate;
            this.disponible = Disp;
 }

        public eleve(string text)
        {
            this.text = text;
        }

        public eleve(string text, string text1) : this(text)
        {
            Text1 = text1;
        }
    }
}

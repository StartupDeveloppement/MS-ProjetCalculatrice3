﻿using System;

namespace Projet.Niveau1.MoneyManagementCorrection
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Operation
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        internal DateTime DateOperation;
        internal double Montant;
        internal bool Regulier;
        private string _reguliere;

        public Operation(DateTime date, double montant, bool regulier)
        {
            DateOperation = date;
            Montant = montant;
            Regulier = regulier;
        }

        public override string ToString()
        {
            var dateFormat = DateOperation.ToString("d");
            _reguliere = Regulier ? "operation reguliere" : "non regulier";
            if(Montant.Equals(1.0))
            {
                return dateFormat + " d'un montant de: " + Montant + " euro " + _reguliere;
            }
            return dateFormat + " d'un montant de: " + Montant + " euros " + _reguliere;
        }

        public override bool Equals(object obj)
        {
            var demo = obj as Operation;
            return demo != null && (demo.Montant.Equals(Montant) && demo.DateOperation == DateOperation &&
                                    demo.Regulier == Regulier);
        }
    }
}

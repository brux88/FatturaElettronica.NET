﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FatturaElettronica.Impostazioni
{
    public enum Instance { PubblicaAmministrazione, Privati };
    public class Versione
    {
        public static string Trasmissione { get { return "1.2"; } }
        public static string Controlli { get { return "1.4"; } }
    }
    public class FormatoTrasmissione
    {
        public static string PubblicaAmministrazione { get { return string.Format("FPA{0}", Versione.Trasmissione.Replace(".", "")); } }
        public static string Privati { get { return string.Format("FPR{0}", Versione.Trasmissione.Replace(".", "")); } }

    }
    internal class RootElement
    {
        internal static string Prefix { get { return "p"; } }
        internal static string LocalName { get { return "FatturaElettronica"; } }
        internal static string NameSpace { get { return "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"; } }
    }
}

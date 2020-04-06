﻿using System.Xml.Serialization;

namespace MtWb.Model
{
    [XmlRoot(ElementName = "settings", IsNullable = false)]
    public class Settings
    {
        /// <summary>
        /// Liefert oder setzt den Debug-Modus
        /// </summary>
        [XmlElement(ElementName = "debug", DataType = "boolean")]
        public bool DebugMode { get; set; }

        /// <summary>
        /// Liefert oder setzt die Anzahl der Impulse pro kWh
        /// </summary>
        [XmlElement(ElementName = "ImpulsePerkWh")]
        public int ImpulsePerkWh { get; set; }

        /// <summary>
        /// Liefert oder setzt den Strompreis pro kWh
        /// </summary>
        [XmlElement(ElementName = "ElectricityPricePerkWh")]
        public float ElectricityPricePerkWh { get; set; }

        /// <summary>
        /// Liefert oder setzt die maximale Leistung in kWh
        /// </summary>
        [XmlElement(ElementName = "MaxPower")]
        public float MaxPower { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorPlugin
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://datex2.eu/schema/2/2_0", IsNullable = false)]
    public partial class d2LogicalModel
    {

        private d2LogicalModelExchange exchangeField;

        private d2LogicalModelPayloadPublication payloadPublicationField;

        private byte modelBaseVersionField;

        /// <remarks/>
        public d2LogicalModelExchange exchange
        {
            get
            {
                return this.exchangeField;
            }
            set
            {
                this.exchangeField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublication payloadPublication
        {
            get
            {
                return this.payloadPublicationField;
            }
            set
            {
                this.payloadPublicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte modelBaseVersion
        {
            get
            {
                return this.modelBaseVersionField;
            }
            set
            {
                this.modelBaseVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelExchange
    {

        private d2LogicalModelExchangeSupplierIdentification supplierIdentificationField;

        /// <remarks/>
        public d2LogicalModelExchangeSupplierIdentification supplierIdentification
        {
            get
            {
                return this.supplierIdentificationField;
            }
            set
            {
                this.supplierIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelExchangeSupplierIdentification
    {

        private string countryField;

        private string nationalIdentifierField;

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string nationalIdentifier
        {
            get
            {
                return this.nationalIdentifierField;
            }
            set
            {
                this.nationalIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublication
    {

        private string feedTypeField;

        private System.DateTime publicationTimeField;

        private d2LogicalModelPayloadPublicationPublicationCreator publicationCreatorField;

        private d2LogicalModelPayloadPublicationMeasurementSiteTableReference measurementSiteTableReferenceField;

        private d2LogicalModelPayloadPublicationHeaderInformation headerInformationField;

        private d2LogicalModelPayloadPublicationSiteMeasurements[] siteMeasurementsField;

        private string langField;

        /// <remarks/>
        public string feedType
        {
            get
            {
                return this.feedTypeField;
            }
            set
            {
                this.feedTypeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime publicationTime
        {
            get
            {
                return this.publicationTimeField;
            }
            set
            {
                this.publicationTimeField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationPublicationCreator publicationCreator
        {
            get
            {
                return this.publicationCreatorField;
            }
            set
            {
                this.publicationCreatorField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationMeasurementSiteTableReference measurementSiteTableReference
        {
            get
            {
                return this.measurementSiteTableReferenceField;
            }
            set
            {
                this.measurementSiteTableReferenceField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationHeaderInformation headerInformation
        {
            get
            {
                return this.headerInformationField;
            }
            set
            {
                this.headerInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("siteMeasurements")]
        public d2LogicalModelPayloadPublicationSiteMeasurements[] siteMeasurements
        {
            get
            {
                return this.siteMeasurementsField;
            }
            set
            {
                this.siteMeasurementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationPublicationCreator
    {

        private string countryField;

        private string nationalIdentifierField;

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string nationalIdentifier
        {
            get
            {
                return this.nationalIdentifierField;
            }
            set
            {
                this.nationalIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationMeasurementSiteTableReference
    {

        private string targetClassField;

        private decimal versionField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetClass
        {
            get
            {
                return this.targetClassField;
            }
            set
            {
                this.targetClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationHeaderInformation
    {

        private string confidentialityField;

        private string informationStatusField;

        private string urgencyField;

        /// <remarks/>
        public string confidentiality
        {
            get
            {
                return this.confidentialityField;
            }
            set
            {
                this.confidentialityField = value;
            }
        }

        /// <remarks/>
        public string informationStatus
        {
            get
            {
                return this.informationStatusField;
            }
            set
            {
                this.informationStatusField = value;
            }
        }

        /// <remarks/>
        public string urgency
        {
            get
            {
                return this.urgencyField;
            }
            set
            {
                this.urgencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurements
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasurementSiteReference measurementSiteReferenceField;

        private System.DateTime measurementTimeDefaultField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValue[] measuredValueField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasurementSiteReference measurementSiteReference
        {
            get
            {
                return this.measurementSiteReferenceField;
            }
            set
            {
                this.measurementSiteReferenceField = value;
            }
        }

        /// <remarks/>
        public System.DateTime measurementTimeDefault
        {
            get
            {
                return this.measurementTimeDefaultField;
            }
            set
            {
                this.measurementTimeDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("measuredValue")]
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValue[] measuredValue
        {
            get
            {
                return this.measuredValueField;
            }
            set
            {
                this.measuredValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasurementSiteReference
    {

        private string targetClassField;

        private decimal versionField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetClass
        {
            get
            {
                return this.targetClassField;
            }
            set
            {
                this.targetClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValue
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValue measuredValueField;

        private byte indexField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValue measuredValue
        {
            get
            {
                return this.measuredValueField;
            }
            set
            {
                this.measuredValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValue
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicData basicDataField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicData basicData
        {
            get
            {
                return this.basicDataField;
            }
            set
            {
                this.basicDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicData
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlow vehicleFlowField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataOccupancy occupancyField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageTimeHeadway averageTimeHeadwayField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeed averageVehicleSpeedField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlow vehicleFlow
        {
            get
            {
                return this.vehicleFlowField;
            }
            set
            {
                this.vehicleFlowField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataOccupancy occupancy
        {
            get
            {
                return this.occupancyField;
            }
            set
            {
                this.occupancyField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageTimeHeadway averageTimeHeadway
        {
            get
            {
                return this.averageTimeHeadwayField;
            }
            set
            {
                this.averageTimeHeadwayField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeed averageVehicleSpeed
        {
            get
            {
                return this.averageVehicleSpeedField;
            }
            set
            {
                this.averageVehicleSpeedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlow
    {

        private bool dataErrorField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataError reasonForDataErrorField;

        private ushort vehicleFlowRateField;

        /// <remarks/>
        public bool dataError
        {
            get
            {
                return this.dataErrorField;
            }
            set
            {
                this.dataErrorField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataError reasonForDataError
        {
            get
            {
                return this.reasonForDataErrorField;
            }
            set
            {
                this.reasonForDataErrorField = value;
            }
        }

        /// <remarks/>
        public ushort vehicleFlowRate
        {
            get
            {
                return this.vehicleFlowRateField;
            }
            set
            {
                this.vehicleFlowRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataError
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValues valuesField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValues values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValues
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValuesValue valueField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValuesValue value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataVehicleFlowReasonForDataErrorValuesValue
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataOccupancy
    {

        private bool dataErrorField;

        private decimal percentageField;

        /// <remarks/>
        public bool dataError
        {
            get
            {
                return this.dataErrorField;
            }
            set
            {
                this.dataErrorField = value;
            }
        }

        /// <remarks/>
        public decimal percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageTimeHeadway
    {

        private bool dataErrorField;

        private decimal durationField;

        /// <remarks/>
        public bool dataError
        {
            get
            {
                return this.dataErrorField;
            }
            set
            {
                this.dataErrorField = value;
            }
        }

        /// <remarks/>
        public decimal duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeed
    {

        private bool dataErrorField;

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataError reasonForDataErrorField;

        private decimal speedField;

        /// <remarks/>
        public bool dataError
        {
            get
            {
                return this.dataErrorField;
            }
            set
            {
                this.dataErrorField = value;
            }
        }

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataError reasonForDataError
        {
            get
            {
                return this.reasonForDataErrorField;
            }
            set
            {
                this.reasonForDataErrorField = value;
            }
        }

        /// <remarks/>
        public decimal speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataError
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValues valuesField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValues values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValues
    {

        private d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValuesValue valueField;

        /// <remarks/>
        public d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValuesValue value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://datex2.eu/schema/2/2_0")]
    public partial class d2LogicalModelPayloadPublicationSiteMeasurementsMeasuredValueMeasuredValueBasicDataAverageVehicleSpeedReasonForDataErrorValuesValue
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
